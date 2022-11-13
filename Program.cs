using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace DMM7510_Digitizer_Control_Tool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class DMM7510
    {
        public  string ipAddress;
        public  int sampleRate;
        public  string measFunction;
        public  Single range;
        public  int bufferSize;

        private  int portNum = 5025;
        private  TcpClient myClient = null;
        private  NetworkStream netStream = null;
        private  String rcvBuffer = "";
        private  String sndBuffer = "";
        private  int startIndex;
        private  int endIndex;
        private  int totalRdgs;
        private  float[] fltData;
        private  String timeStamp;
        private  string fileName;
        private  string filePathAndName;
        private  int fileCounter;
        private  int writeCounter;
        private  int lastCount;
        private  int loopBrkr;
        private  int accumVal;
        private  int lastVal;
        private  int thisVal;
        private  int k;
        private  bool isEndBuff;
        private  bool doPoll;
        private  int huh;
        private  int jj;
        private  byte[] rcvBytes;
        private  byte[] byteBuffer;

        // Define constructor(s)...
        public DMM7510()
        {

        }

        public DMM7510(string addr, int sRate, int measFunc, Single myRange, int bufSz)
        {
            ipAddress = addr;
            sampleRate = sRate;
            if (measFunc == 0)
                measFunction = "VOLT";
            else
                measFunction = "CURR";
            range = myRange;
            bufferSize = bufSz;
        }

        public int instConnect(bool echoIdString)
        {
            int status = 0;
            try
            {
                myClient = new TcpClient(ipAddress, portNum);
                Console.WriteLine("Connected to instrument......");
                myClient.ReceiveTimeout = 20000;
                myClient.ReceiveBufferSize = 35565;
                myClient.NoDelay = true;  // added 2022-11-13
                netStream = myClient.GetStream();
                if(echoIdString)
                {
                    rcvBuffer = "";
                    instQuery("*IDN?", 128, ref rcvBuffer);
                }
            }
            catch (Exception e)
            {
                status = -1;
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Nothing to close
            }
            return status;
        }

        public int instConnect(bool echoIdString, ref string strId)
        {
            int status = 0;
            try
            {
                myClient = new TcpClient(ipAddress, portNum);
                Console.WriteLine("Connected to instrument......");
                myClient.ReceiveTimeout = 20000;
                myClient.ReceiveBufferSize = 35565;
                netStream = myClient.GetStream();
                if (echoIdString)
                {
                    instQuery("*IDN?", 128, ref strId);
                }
            }
            catch (Exception e)
            {
                status = -1;
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Nothing to close
            }
            return status;
        }

        public void instDisconnect()
        {
            netStream.Close();
            myClient.Close();
        }

        public int instSend(string cmdStr)
        {
            byteBuffer = Encoding.ASCII.GetBytes(cmdStr + "\r\n;");
            netStream.Write(byteBuffer, 0, byteBuffer.Length);
            Array.Clear(byteBuffer, 0, byteBuffer.Length);
            return 0;
        }

        public int instRcv(int byteCount, ref string rcvStr)
        {
            rcvBytes = new byte[byteCount];
            int bytesRcvd = netStream.Read(rcvBytes, 0, byteCount);
            rcvStr = Encoding.ASCII.GetString(rcvBytes, 0, bytesRcvd);
            Array.Clear(rcvBytes, 0, byteCount);
            return 0;
        }

        public int instRcv_FloatData(int chunkSize, ref float[] fltData)
        {
            rcvBytes = new byte[chunkSize * 4 + 3];
            int bytesRcvd = netStream.Read(rcvBytes, 0, rcvBytes.Length);
            // Need to convert to the byte array into single or do
            Buffer.BlockCopy(rcvBytes, 2, fltData, 0, fltData.Length * 4);
            Array.Clear(rcvBytes, 0, rcvBytes.Length);
            return 0;
        }

        public int instQuery(string cmdStr, int byteCount, ref string rcvStr)
        {
            int status = 0;
            status = instSend(cmdStr);
            status = instRcv(byteCount, ref rcvStr);
            return 0;
        }
    
        public int instQuery_FloatData(string cmdStr, int byteCount, ref float[] fltData)
        {
            int status = 0;
            status = instSend(cmdStr);
            status = instRcv_FloatData(byteCount, ref fltData);
            return 0;
        }

        public void Setup_Buffers()
        {
            instSend("*RST");
            instSend("TRAC:CLE \"defbuffer1\"");
            instSend("TRAC:POIN " + Convert.ToString(bufferSize) + ", \"defbuffer1\"");
            instSend("TRAC:FILL:MODE CONT, \"defbuffer1\"");
            instSend("*WAI");
            Thread.Sleep(100);
        }

        public void Setup_DMM()
        {
            // Do setup...
            instSend(":SENS:DIG:FUNC \"" + measFunction + "\"");
            instSend(":DIG:" + measFunction + ":RANG " + Convert.ToString(range));
            instSend(":SENS:DIG:" + measFunction + ":SRAT " + Convert.ToString(sampleRate));
            instSend(":SENS:DIG:COUNt " + Convert.ToString(bufferSize));
            instSend(":SENS:DIG:" + measFunction + ":APER 5e-6");        // was 1e-6
            instSend(":FORM:DATA SRE");                                 // for single precision
        }

        public void Setup_Digitizing(int captureMinutes)
        {
            instSend(":TRIGger:LOAD \"EMPTY\"");
            instSend(":TRIGger:BLOCk:DIGitize 1, \"defbuffer1\", " + Convert.ToString(bufferSize));
            instSend(":TRIGger:BLOCk:BRANch:COUNter 2, " + Convert.ToString(captureMinutes * 2) + ", 1");
        }

        public void Trigger_DMM()
        {
            // Do Trigger...
            instSend("INIT");
        }

        public void Extract_Buffer_Data(string filePath, string unitId, String bufferName, int bufferSize, int bytesRcvCnt, int chunkSize, ref Stopwatch myStpWtch, int minCapt, ref int rdgsOut)
        {
            startIndex = 1;
            endIndex = chunkSize;
            totalRdgs = 0;
            fltData = new float[chunkSize];
            timeStamp = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");
            fileName = "DMM7510_StreamDigitized_" + unitId + "_" + timeStamp + ".csv";
            filePathAndName = filePath + "\\" + fileName;
            fileCounter = 0;
            writeCounter = 0;
            lastCount = 0;
            loopBrkr = bufferSize / chunkSize;
            accumVal = 0;
            lastVal = 0;
            thisVal = 0;
            k = 0;
            isEndBuff = false;
            doPoll = true;
            huh = 0;
            jj = 0;

            do
            {
                if (doPoll)
                {
                    do
                    {
                        rcvBuffer = "";
                        sndBuffer = ":TRACe:ACTual:END? \"" + bufferName + "\"";        // use END becaus plain old ACT? tops off at bufferSize when full
                        instQuery(sndBuffer, 256, ref rcvBuffer);
                        netStream.Flush();

                        thisVal = Convert.ToInt32(rcvBuffer);
                        if (thisVal < lastVal)
                        {
                            k++;                    // this indicates a buffer roll-over condition
                            isEndBuff = true;
                        }
                        accumVal = k * bufferSize + thisVal;
                        lastVal = thisVal;

                    } while ((accumVal - totalRdgs) < chunkSize);
                }
                
                // Pulling the data back from the instrument means there's a bottleneck with the network...
                if (endIndex > bufferSize)
                    endIndex = bufferSize;

                rcvBuffer = "";
                sndBuffer = ":TRAC:DATA? " + Convert.ToString(startIndex) + ", " + Convert.ToString(endIndex) + ", \"" + bufferName + "\"";
                instQuery_FloatData(sndBuffer, bytesRcvCnt, ref fltData);
                netStream.Flush();

                // Generate the file name based on the system timestamp...
                writeCounter = totalRdgs / bufferSize;
                if (writeCounter > lastCount)
                {
                    // create a new file name...
                    timeStamp = DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss");

                    fileName = "DMM7510_StreamDigitized_" + unitId + "_" + timeStamp + ".csv";
                    filePathAndName = filePath + "\\" + fileName;

                    lastCount++;
                }
                
                Write_Data_To_CSV(filePathAndName, fltData);
                
                totalRdgs += chunkSize;
                startIndex = (totalRdgs % bufferSize) + 1;
                endIndex = startIndex + (chunkSize - 1);

                // Write to file in 30s intervals
                fileCounter = totalRdgs / bufferSize; 

                huh = bufferSize * (minCapt * 2) - chunkSize;
            } while (totalRdgs < huh); // (!(rcvBuffer.Contains("IDLE")));

            rdgsOut = totalRdgs;

            myStpWtch.Stop();
        }

        public static void Write_Data_To_CSV(String fileName, float[] fltData)
        {
            bool doAppend = true;
            using (StreamWriter writer = new StreamWriter(fileName, doAppend)) 
            {
                foreach (var value in fltData)
                {
                    writer.WriteLine(value);
                }
            }

        }
    }

}

    
