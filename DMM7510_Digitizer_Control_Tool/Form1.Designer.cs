namespace DMM7510_Digitizer_Control_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nudMinutesToDigitize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSampleRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.grpUnitCtrl = new System.Windows.Forms.GroupBox();
            this.lblUnits1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRange1 = new System.Windows.Forms.ComboBox();
            this.rdoDigiA1 = new System.Windows.Forms.RadioButton();
            this.rdoDigiV1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIpAddress1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUnits2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRange2 = new System.Windows.Forms.ComboBox();
            this.rdoDigiA2 = new System.Windows.Forms.RadioButton();
            this.rdoDigiV2 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIpAddress2 = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIdStr1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRdgsPerSecUnit1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRuntimeUnit1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdStr2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRdgsPerSecUnit2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRuntimeUnit2 = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesToDigitize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).BeginInit();
            this.grpUnitCtrl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 26);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // nudMinutesToDigitize
            // 
            this.nudMinutesToDigitize.Location = new System.Drawing.Point(134, 68);
            this.nudMinutesToDigitize.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.nudMinutesToDigitize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinutesToDigitize.Name = "nudMinutesToDigitize";
            this.nudMinutesToDigitize.Size = new System.Drawing.Size(74, 20);
            this.nudMinutesToDigitize.TabIndex = 2;
            this.nudMinutesToDigitize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinutesToDigitize.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes To Digitize";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nudSampleRate
            // 
            this.nudSampleRate.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSampleRate.Location = new System.Drawing.Point(134, 94);
            this.nudSampleRate.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudSampleRate.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSampleRate.Name = "nudSampleRate";
            this.nudSampleRate.Size = new System.Drawing.Size(74, 20);
            this.nudSampleRate.TabIndex = 4;
            this.nudSampleRate.ThousandsSeparator = true;
            this.nudSampleRate.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sample Rate ";
            // 
            // grpUnitCtrl
            // 
            this.grpUnitCtrl.Controls.Add(this.lblUnits1);
            this.grpUnitCtrl.Controls.Add(this.label4);
            this.grpUnitCtrl.Controls.Add(this.cboRange1);
            this.grpUnitCtrl.Controls.Add(this.rdoDigiA1);
            this.grpUnitCtrl.Controls.Add(this.rdoDigiV1);
            this.grpUnitCtrl.Controls.Add(this.label3);
            this.grpUnitCtrl.Controls.Add(this.txtIpAddress1);
            this.grpUnitCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUnitCtrl.ForeColor = System.Drawing.Color.Chartreuse;
            this.grpUnitCtrl.Location = new System.Drawing.Point(15, 120);
            this.grpUnitCtrl.Name = "grpUnitCtrl";
            this.grpUnitCtrl.Size = new System.Drawing.Size(350, 100);
            this.grpUnitCtrl.TabIndex = 6;
            this.grpUnitCtrl.TabStop = false;
            this.grpUnitCtrl.Text = "DMM7510 1 Settings";
            // 
            // lblUnits1
            // 
            this.lblUnits1.AutoSize = true;
            this.lblUnits1.Location = new System.Drawing.Point(149, 71);
            this.lblUnits1.Name = "lblUnits1";
            this.lblUnits1.Size = new System.Drawing.Size(15, 13);
            this.lblUnits1.TabIndex = 10;
            this.lblUnits1.Text = "V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Range";
            // 
            // cboRange1
            // 
            this.cboRange1.FormattingEnabled = true;
            this.cboRange1.Location = new System.Drawing.Point(72, 68);
            this.cboRange1.Name = "cboRange1";
            this.cboRange1.Size = new System.Drawing.Size(70, 21);
            this.cboRange1.TabIndex = 7;
            // 
            // rdoDigiA1
            // 
            this.rdoDigiA1.AutoSize = true;
            this.rdoDigiA1.Location = new System.Drawing.Point(129, 45);
            this.rdoDigiA1.Name = "rdoDigiA1";
            this.rdoDigiA1.Size = new System.Drawing.Size(112, 17);
            this.rdoDigiA1.TabIndex = 8;
            this.rdoDigiA1.Text = "Digitize Current";
            this.rdoDigiA1.UseVisualStyleBackColor = true;
            this.rdoDigiA1.CheckedChanged += new System.EventHandler(this.rdoDigiA_CheckedChanged);
            // 
            // rdoDigiV1
            // 
            this.rdoDigiV1.AutoSize = true;
            this.rdoDigiV1.Location = new System.Drawing.Point(9, 45);
            this.rdoDigiV1.Name = "rdoDigiV1";
            this.rdoDigiV1.Size = new System.Drawing.Size(114, 17);
            this.rdoDigiV1.TabIndex = 7;
            this.rdoDigiV1.Text = "Digitize Voltage";
            this.rdoDigiV1.UseVisualStyleBackColor = true;
            this.rdoDigiV1.CheckedChanged += new System.EventHandler(this.rdoDigiV_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TCP/IP Address";
            // 
            // txtIpAddress1
            // 
            this.txtIpAddress1.Location = new System.Drawing.Point(129, 19);
            this.txtIpAddress1.Name = "txtIpAddress1";
            this.txtIpAddress1.Size = new System.Drawing.Size(100, 20);
            this.txtIpAddress1.TabIndex = 0;
            this.txtIpAddress1.Text = "192.168.1.78";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUnits2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboRange2);
            this.groupBox1.Controls.Add(this.rdoDigiA2);
            this.groupBox1.Controls.Add(this.rdoDigiV2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIpAddress2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox1.Location = new System.Drawing.Point(384, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DMM7510 2 Settings";
            // 
            // lblUnits2
            // 
            this.lblUnits2.AutoSize = true;
            this.lblUnits2.Location = new System.Drawing.Point(149, 71);
            this.lblUnits2.Name = "lblUnits2";
            this.lblUnits2.Size = new System.Drawing.Size(15, 13);
            this.lblUnits2.TabIndex = 10;
            this.lblUnits2.Text = "V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Range";
            // 
            // cboRange2
            // 
            this.cboRange2.FormattingEnabled = true;
            this.cboRange2.Location = new System.Drawing.Point(72, 68);
            this.cboRange2.Name = "cboRange2";
            this.cboRange2.Size = new System.Drawing.Size(70, 21);
            this.cboRange2.TabIndex = 7;
            // 
            // rdoDigiA2
            // 
            this.rdoDigiA2.AutoSize = true;
            this.rdoDigiA2.Location = new System.Drawing.Point(129, 45);
            this.rdoDigiA2.Name = "rdoDigiA2";
            this.rdoDigiA2.Size = new System.Drawing.Size(112, 17);
            this.rdoDigiA2.TabIndex = 8;
            this.rdoDigiA2.Text = "Digitize Current";
            this.rdoDigiA2.UseVisualStyleBackColor = true;
            this.rdoDigiA2.CheckedChanged += new System.EventHandler(this.rdoDigiA2_CheckedChanged);
            // 
            // rdoDigiV2
            // 
            this.rdoDigiV2.AutoSize = true;
            this.rdoDigiV2.Location = new System.Drawing.Point(9, 45);
            this.rdoDigiV2.Name = "rdoDigiV2";
            this.rdoDigiV2.Size = new System.Drawing.Size(114, 17);
            this.rdoDigiV2.TabIndex = 7;
            this.rdoDigiV2.Text = "Digitize Voltage";
            this.rdoDigiV2.UseVisualStyleBackColor = true;
            this.rdoDigiV2.CheckedChanged += new System.EventHandler(this.rdoDigiV2_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "TCP/IP Address";
            // 
            // txtIpAddress2
            // 
            this.txtIpAddress2.Location = new System.Drawing.Point(129, 19);
            this.txtIpAddress2.Name = "txtIpAddress2";
            this.txtIpAddress2.Size = new System.Drawing.Size(100, 20);
            this.txtIpAddress2.TabIndex = 0;
            this.txtIpAddress2.Text = "192.168.1.79";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(318, 96);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(416, 20);
            this.txtFilePath.TabIndex = 13;
            this.txtFilePath.Text = "C:\\Temp\\Stream_Data";
            // 
            // btnFilePath1
            // 
            this.btnFilePath1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFilePath1.Location = new System.Drawing.Point(237, 94);
            this.btnFilePath1.Name = "btnFilePath1";
            this.btnFilePath1.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath1.TabIndex = 12;
            this.btnFilePath1.Text = "File Path";
            this.btnFilePath1.UseVisualStyleBackColor = true;
            this.btnFilePath1.Click += new System.EventHandler(this.btnFilePath1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(15, 226);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtIdStr1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRdgsPerSecUnit1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRuntimeUnit1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox2.Location = new System.Drawing.Point(15, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 108);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DMM7510 1 Run Info...";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Unit 1 ID String";
            // 
            // txtIdStr1
            // 
            this.txtIdStr1.Location = new System.Drawing.Point(129, 22);
            this.txtIdStr1.Name = "txtIdStr1";
            this.txtIdStr1.Size = new System.Drawing.Size(215, 20);
            this.txtIdStr1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rdgs/sec Unit 1";
            // 
            // txtRdgsPerSecUnit1
            // 
            this.txtRdgsPerSecUnit1.Location = new System.Drawing.Point(129, 74);
            this.txtRdgsPerSecUnit1.Name = "txtRdgsPerSecUnit1";
            this.txtRdgsPerSecUnit1.Size = new System.Drawing.Size(100, 20);
            this.txtRdgsPerSecUnit1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Runtime Unit 1";
            // 
            // txtRuntimeUnit1
            // 
            this.txtRuntimeUnit1.Location = new System.Drawing.Point(129, 48);
            this.txtRuntimeUnit1.Name = "txtRuntimeUnit1";
            this.txtRuntimeUnit1.Size = new System.Drawing.Size(100, 20);
            this.txtRuntimeUnit1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtIdStr2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtRdgsPerSecUnit2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtRuntimeUnit2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Chartreuse;
            this.groupBox3.Location = new System.Drawing.Point(384, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 108);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DMM7510 1 Run Info...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Unit 2 ID String";
            // 
            // txtIdStr2
            // 
            this.txtIdStr2.Location = new System.Drawing.Point(129, 22);
            this.txtIdStr2.Name = "txtIdStr2";
            this.txtIdStr2.Size = new System.Drawing.Size(215, 20);
            this.txtIdStr2.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Rdgs/sec Unit 2";
            // 
            // txtRdgsPerSecUnit2
            // 
            this.txtRdgsPerSecUnit2.Location = new System.Drawing.Point(129, 74);
            this.txtRdgsPerSecUnit2.Name = "txtRdgsPerSecUnit2";
            this.txtRdgsPerSecUnit2.Size = new System.Drawing.Size(100, 20);
            this.txtRdgsPerSecUnit2.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Runtime Unit 2";
            // 
            // txtRuntimeUnit2
            // 
            this.txtRuntimeUnit2.Location = new System.Drawing.Point(129, 48);
            this.txtRuntimeUnit2.Name = "txtRuntimeUnit2";
            this.txtRuntimeUnit2.Size = new System.Drawing.Size(100, 20);
            this.txtRuntimeUnit2.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblState.Location = new System.Drawing.Point(109, 227);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(111, 26);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "Running...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(226, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(508, 23);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(749, 381);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFilePath1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpUnitCtrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSampleRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinutesToDigitize);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DMM7510 Digitizer Control Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesToDigitize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSampleRate)).EndInit();
            this.grpUnitCtrl.ResumeLayout(false);
            this.grpUnitCtrl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NumericUpDown nudMinutesToDigitize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSampleRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpUnitCtrl;
        private System.Windows.Forms.RadioButton rdoDigiA1;
        private System.Windows.Forms.RadioButton rdoDigiV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIpAddress1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRange1;
        private System.Windows.Forms.Label lblUnits1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnits2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRange2;
        private System.Windows.Forms.RadioButton rdoDigiA2;
        private System.Windows.Forms.RadioButton rdoDigiV2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIpAddress2;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRuntimeUnit1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRdgsPerSecUnit1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdStr1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdStr2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRdgsPerSecUnit2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRuntimeUnit2;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

