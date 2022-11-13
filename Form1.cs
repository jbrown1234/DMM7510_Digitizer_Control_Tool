using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace DMM7510_Digitizer_Control_Tool
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(nudMinutesToDigitize.Value < 1)
            {
                MessageBox.Show("INVALID SELECTION: The minimum number of minutes to digitize is 1.", "Value Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (nudMinutesToDigitize.Value >= 1440)
            {
                MessageBox.Show("INVALID SELECTION: The maximum number of minutes to digitize is 1440 (1 day).", "Value Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(nudMinutesToDigitize.Value > 1440)
                {
                    nudMinutesToDigitize.Value = 1440;
                }
            }
        }

        private void rdoDigiV_CheckedChanged(object sender, EventArgs e)
        {
            string[] rangeItems = { "0.1", "1", "10", "100", "1000" };
            cboRange1.Items.Clear();
            cboRange1.Items.AddRange(rangeItems);
            cboRange1.SelectedIndex = 2;
            lblUnits1.Text = "V";
        }

        private void rdoDigiA_CheckedChanged(object sender, EventArgs e)
        {
            string[] rangeItems = { "10e-6", "100e-6", "1e-3", "10e-3", "100e-3", "1"};
            cboRange1.Items.Clear();
            cboRange1.Items.AddRange(rangeItems);
            cboRange1.SelectedIndex = 4;
            lblUnits1.Text = "A";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoDigiV1.Checked = true;
            rdoDigiV2.Checked = true;

            lblState.Text = "";

            //backgroundWorker1.WorkerReportsProgress = true;
            //backgroundWorker1.RunWorkerAsync();
        }

        private void rdoDigiV2_CheckedChanged(object sender, EventArgs e)
        {
            string[] rangeItems = { "0.1", "1", "10", "100", "1000" };
            cboRange2.Items.Clear();
            cboRange2.Items.AddRange(rangeItems);
            cboRange2.SelectedIndex = 2;
            lblUnits2.Text = "V";
        }

        private void rdoDigiA2_CheckedChanged(object sender, EventArgs e)
        {
            string[] rangeItems = { "10e-6", "100e-6", "1e-3", "10e-3", "100e-3", "1" };
            cboRange2.Items.Clear();
            cboRange2.Items.AddRange(rangeItems);
            cboRange2.SelectedIndex = 4;
            lblUnits2.Text = "A";
        }

        private void btnFilePath1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtFilePath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bufferSize = 30 * Convert.ToInt32(nudSampleRate.Value);
            int unitFunc1, unitFunc2;
            Stopwatch myStpWtch1 = new Stopwatch();
            Stopwatch myStpWtch2 = new Stopwatch();
            int bytesRcvCnt = 8192;            // Size the receive buffer so that data is not lost/clipped
            int chunkSize = 249;                // presently the value for max allowable packet size - do we bother making this scalable?
            int totalWrittenRdgs1 = 0;
            int totalWrittenRdgs2 = 0;

            
            txtIdStr1.Text = "";
            txtRuntimeUnit1.Text = "";
            txtRdgsPerSecUnit1.Text = "";

            txtIdStr2.Text = "";
            txtRuntimeUnit2.Text = "";
            txtRdgsPerSecUnit2.Text = "";

            lblState.Text = "Running...";

            btnStart.Enabled = false;
            btnStart.Text = "-----";
            Application.DoEvents();

            if (lblUnits1.Text.Contains("V"))
                unitFunc1 = 0;
            else
                unitFunc1 = 1;

            if (lblUnits2.Text.Contains("V"))
                unitFunc2 = 0;
            else
                unitFunc2 = 1;

            // Instantiate the DMM7510 objects...
            DMM7510 unit1 = new DMM7510(txtIpAddress1.Text, Convert.ToInt32(nudSampleRate.Value), unitFunc1, Convert.ToSingle(cboRange1.Text), bufferSize);
            DMM7510 unit2 = new DMM7510(txtIpAddress2.Text, Convert.ToInt32(nudSampleRate.Value), unitFunc2, Convert.ToSingle(cboRange2.Text), bufferSize);

            // Establish network connection to the instruments...
            string rcvBuffer = "";
            unit1.instConnect(true, ref rcvBuffer);
            txtIdStr1.Text = rcvBuffer;

            unit2.instConnect(true, ref rcvBuffer);
            txtIdStr2.Text = rcvBuffer;

            unit1.Setup_Buffers();
            unit2.Setup_Buffers();

            unit1.Setup_DMM();
            unit2.Setup_DMM();

            unit1.Setup_Digitizing(Convert.ToInt32(nudMinutesToDigitize.Value));
            unit2.Setup_Digitizing(Convert.ToInt32(nudMinutesToDigitize.Value));

            unit1.Trigger_DMM();
            unit2.Trigger_DMM();


            myStpWtch1.Start();          // Start the timers here and stop them inside the thread(s)
            myStpWtch2.Start();

            /*Thread t3 = new Thread(() =>
            {
                // Start the BackgroundWorker.
                backgroundWorker1.RunWorkerAsync();
                //backgroundWorker1.CancelAsync();
            });*/

            Thread t1 = new Thread(() =>
            {
                unit1.Extract_Buffer_Data(txtFilePath.Text, "UNIT1", "defbuffer1", bufferSize, bytesRcvCnt, chunkSize, ref myStpWtch1, Convert.ToInt32(nudMinutesToDigitize.Value), ref totalWrittenRdgs1);
            });

            Thread t2 = new Thread(() =>
            {
                unit2.Extract_Buffer_Data(txtFilePath.Text, "UNIT2", "defbuffer1", bufferSize, bytesRcvCnt, chunkSize, ref myStpWtch2, Convert.ToInt32(nudMinutesToDigitize.Value), ref totalWrittenRdgs2);
                //t3.Abort();
            });

            t1.Start();
            t2.Start();
            //t3.Start();
            Application.DoEvents();
            t1.Join();
            t2.Join();
            //t3.Join();

            System.Media.SystemSounds.Beep.Play();

            lblState.Text = "Stopped...";
            btnStart.Enabled = true;
            btnStart.Text = "START";

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts1 = myStpWtch1.Elapsed;
            TimeSpan ts2 = myStpWtch2.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts1.Hours, ts1.Minutes, ts1.Seconds,
                ts1.Milliseconds / 10);
            txtRuntimeUnit1.Text = elapsedTime;

            txtRdgsPerSecUnit1.Text = string.Format("{0:0.00}", totalWrittenRdgs1 / ts1.TotalSeconds);

            string elapsedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts2.Hours, ts2.Minutes, ts2.Seconds,
                ts2.Milliseconds / 10);

            txtRuntimeUnit2.Text = elapsedTime;

            txtRdgsPerSecUnit2.Text = string.Format("{0:0.00}", totalWrittenRdgs2 / ts2.TotalSeconds);

            // Disconnect from the instruments...
            unit1.instDisconnect();
            unit2.instDisconnect();
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                // Wait 100 milliseconds.
                Thread.Sleep(1000);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;
            int j = e.ProgressPercentage;
            //progressBar1.
            // Set the text.
            
        }

    }
}
