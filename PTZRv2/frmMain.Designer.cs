namespace PTZRv2 {
  partial class frmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.groupBox16 = new System.Windows.Forms.GroupBox();
      this.btnStopPeriodicRead = new System.Windows.Forms.Button();
      this.btnStartPeriodicRead = new System.Windows.Forms.Button();
      this.btnReadAll = new System.Windows.Forms.Button();
      this.groupBox30 = new System.Windows.Forms.GroupBox();
      this.btnResetFlow = new System.Windows.Forms.Button();
      this.lblResetFlow = new System.Windows.Forms.Label();
      this.groupBox35 = new System.Windows.Forms.GroupBox();
      this.lblDTHighLimit = new System.Windows.Forms.Label();
      this.btnResetHighLimit = new System.Windows.Forms.Button();
      this.btnReadHighLimit = new System.Windows.Forms.Button();
      this.lblHighLimit = new System.Windows.Forms.Label();
      this.btnResetLowLimit = new System.Windows.Forms.Button();
      this.btnReadLowLimit = new System.Windows.Forms.Button();
      this.lblLowLimit = new System.Windows.Forms.Label();
      this.lblDTLowLimit = new System.Windows.Forms.Label();
      this.groupBox31 = new System.Windows.Forms.GroupBox();
      this.btnTemperatureInKelvin = new System.Windows.Forms.Button();
      this.lblTemperatureInKelvin = new System.Windows.Forms.Label();
      this.groupxxx = new System.Windows.Forms.GroupBox();
      this.btnCorrectionCoefitient = new System.Windows.Forms.Button();
      this.lblCorrectionCoefitient = new System.Windows.Forms.Label();
      this.groupBox24 = new System.Windows.Forms.GroupBox();
      this.btnResetCover = new System.Windows.Forms.Button();
      this.btnReadCover = new System.Windows.Forms.Button();
      this.lblCover = new System.Windows.Forms.Label();
      this.groupBox20 = new System.Windows.Forms.GroupBox();
      this.btnResetCorrectedFlowDp = new System.Windows.Forms.Button();
      this.btnReadCorrectedFlowDp = new System.Windows.Forms.Button();
      this.lblCorrectedFlowDp = new System.Windows.Forms.Label();
      this.groupBox19 = new System.Windows.Forms.GroupBox();
      this.btnResetCorrectedFlow = new System.Windows.Forms.Button();
      this.btnReadCorrectedFlow = new System.Windows.Forms.Button();
      this.lblCorrectedFlow = new System.Windows.Forms.Label();
      this.groupBox18 = new System.Windows.Forms.GroupBox();
      this.btnEsimateCompres = new System.Windows.Forms.Button();
      this.lblEstimateCompres = new System.Windows.Forms.Label();
      this.groupBox17 = new System.Windows.Forms.GroupBox();
      this.btnReadNotCorrectedFlow = new System.Windows.Forms.Button();
      this.lblNotCorrectedFlow = new System.Windows.Forms.Label();
      this.groupBox15 = new System.Windows.Forms.GroupBox();
      this.btnResetMeasureImpuls = new System.Windows.Forms.Button();
      this.btnReadMeasureImpuls = new System.Windows.Forms.Button();
      this.lblMeasureImpuls = new System.Windows.Forms.Label();
      this.groupBox14 = new System.Windows.Forms.GroupBox();
      this.btnReadMeasurePressure = new System.Windows.Forms.Button();
      this.lblMeasurePressure = new System.Windows.Forms.Label();
      this.groupBox13 = new System.Windows.Forms.GroupBox();
      this.btnReadMeasureTemp = new System.Windows.Forms.Button();
      this.lblMeasureTemp = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.btnSetBaseTemperature = new System.Windows.Forms.Button();
      this.btnReadBaseTemperature = new System.Windows.Forms.Button();
      this.txtBaseTemperature = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.groupBox16.SuspendLayout();
      this.groupBox30.SuspendLayout();
      this.groupBox35.SuspendLayout();
      this.groupBox31.SuspendLayout();
      this.groupxxx.SuspendLayout();
      this.groupBox24.SuspendLayout();
      this.groupBox20.SuspendLayout();
      this.groupBox19.SuspendLayout();
      this.groupBox18.SuspendLayout();
      this.groupBox17.SuspendLayout();
      this.groupBox15.SuspendLayout();
      this.groupBox14.SuspendLayout();
      this.groupBox13.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.SuspendLayout();
      // 
      // pictureBox2
      // 
      this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pictureBox2.Image = global::PTZRv2.Properties.Resources.Wrench;
      this.pictureBox2.Location = new System.Drawing.Point(17, 672);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(61, 59);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 42;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(96, 8);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(980, 670);
      this.tabControl1.TabIndex = 46;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.groupBox16);
      this.tabPage1.Controls.Add(this.btnReadAll);
      this.tabPage1.Controls.Add(this.groupBox30);
      this.tabPage1.Controls.Add(this.groupBox35);
      this.tabPage1.Controls.Add(this.groupBox31);
      this.tabPage1.Controls.Add(this.groupxxx);
      this.tabPage1.Controls.Add(this.groupBox24);
      this.tabPage1.Controls.Add(this.groupBox20);
      this.tabPage1.Controls.Add(this.groupBox19);
      this.tabPage1.Controls.Add(this.groupBox18);
      this.tabPage1.Controls.Add(this.groupBox17);
      this.tabPage1.Controls.Add(this.groupBox15);
      this.tabPage1.Controls.Add(this.groupBox14);
      this.tabPage1.Controls.Add(this.groupBox13);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(972, 644);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Measured Malues";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // groupBox16
      // 
      this.groupBox16.Controls.Add(this.btnStopPeriodicRead);
      this.groupBox16.Controls.Add(this.btnStartPeriodicRead);
      this.groupBox16.Location = new System.Drawing.Point(36, 16);
      this.groupBox16.Name = "groupBox16";
      this.groupBox16.Size = new System.Drawing.Size(200, 48);
      this.groupBox16.TabIndex = 59;
      this.groupBox16.TabStop = false;
      this.groupBox16.Text = "Periodic Read within 3 seconds";
      // 
      // btnStopPeriodicRead
      // 
      this.btnStopPeriodicRead.Location = new System.Drawing.Point(96, 16);
      this.btnStopPeriodicRead.Name = "btnStopPeriodicRead";
      this.btnStopPeriodicRead.Size = new System.Drawing.Size(64, 24);
      this.btnStopPeriodicRead.TabIndex = 1;
      this.btnStopPeriodicRead.Text = "Stop";
      this.btnStopPeriodicRead.Click += new System.EventHandler(this.btnStopPeriodicRead_Click);
      // 
      // btnStartPeriodicRead
      // 
      this.btnStartPeriodicRead.Location = new System.Drawing.Point(16, 16);
      this.btnStartPeriodicRead.Name = "btnStartPeriodicRead";
      this.btnStartPeriodicRead.Size = new System.Drawing.Size(64, 24);
      this.btnStartPeriodicRead.TabIndex = 0;
      this.btnStartPeriodicRead.Text = "Start";
      this.btnStartPeriodicRead.Click += new System.EventHandler(this.btnStartPeriodicRead_Click);
      // 
      // btnReadAll
      // 
      this.btnReadAll.Location = new System.Drawing.Point(244, 33);
      this.btnReadAll.Name = "btnReadAll";
      this.btnReadAll.Size = new System.Drawing.Size(91, 32);
      this.btnReadAll.TabIndex = 58;
      this.btnReadAll.Text = "Read All";
      this.btnReadAll.UseVisualStyleBackColor = true;
      this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
      // 
      // groupBox30
      // 
      this.groupBox30.Controls.Add(this.btnResetFlow);
      this.groupBox30.Controls.Add(this.lblResetFlow);
      this.groupBox30.Location = new System.Drawing.Point(455, 87);
      this.groupBox30.Name = "groupBox30";
      this.groupBox30.Size = new System.Drawing.Size(200, 51);
      this.groupBox30.TabIndex = 57;
      this.groupBox30.TabStop = false;
      this.groupBox30.Text = "Reset Flow Counters";
      // 
      // btnResetFlow
      // 
      this.btnResetFlow.Location = new System.Drawing.Point(8, 16);
      this.btnResetFlow.Name = "btnResetFlow";
      this.btnResetFlow.Size = new System.Drawing.Size(64, 24);
      this.btnResetFlow.TabIndex = 1;
      this.btnResetFlow.Text = "Reset";
      this.btnResetFlow.Click += new System.EventHandler(this.btnResetFlow_Click);
      // 
      // lblResetFlow
      // 
      this.lblResetFlow.AutoSize = true;
      this.lblResetFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblResetFlow.Location = new System.Drawing.Point(80, 24);
      this.lblResetFlow.Name = "lblResetFlow";
      this.lblResetFlow.Size = new System.Drawing.Size(44, 16);
      this.lblResetFlow.TabIndex = 0;
      this.lblResetFlow.Text = "---------";
      // 
      // groupBox35
      // 
      this.groupBox35.Controls.Add(this.lblDTHighLimit);
      this.groupBox35.Controls.Add(this.btnResetHighLimit);
      this.groupBox35.Controls.Add(this.btnReadHighLimit);
      this.groupBox35.Controls.Add(this.lblHighLimit);
      this.groupBox35.Controls.Add(this.btnResetLowLimit);
      this.groupBox35.Controls.Add(this.btnReadLowLimit);
      this.groupBox35.Controls.Add(this.lblLowLimit);
      this.groupBox35.Controls.Add(this.lblDTLowLimit);
      this.groupBox35.Location = new System.Drawing.Point(39, 393);
      this.groupBox35.Name = "groupBox35";
      this.groupBox35.Size = new System.Drawing.Size(448, 112);
      this.groupBox35.TabIndex = 56;
      this.groupBox35.TabStop = false;
      this.groupBox35.Text = "Read High Limit Event";
      // 
      // lblDTHighLimit
      // 
      this.lblDTHighLimit.Location = new System.Drawing.Point(8, 80);
      this.lblDTHighLimit.Name = "lblDTHighLimit";
      this.lblDTHighLimit.Size = new System.Drawing.Size(136, 24);
      this.lblDTHighLimit.TabIndex = 18;
      this.lblDTHighLimit.Text = "RTC";
      // 
      // btnResetHighLimit
      // 
      this.btnResetHighLimit.Location = new System.Drawing.Point(8, 48);
      this.btnResetHighLimit.Name = "btnResetHighLimit";
      this.btnResetHighLimit.Size = new System.Drawing.Size(64, 24);
      this.btnResetHighLimit.TabIndex = 2;
      this.btnResetHighLimit.Text = "Reset";
      this.btnResetHighLimit.Click += new System.EventHandler(this.btnResetHighLimit_Click);
      // 
      // btnReadHighLimit
      // 
      this.btnReadHighLimit.Location = new System.Drawing.Point(8, 16);
      this.btnReadHighLimit.Name = "btnReadHighLimit";
      this.btnReadHighLimit.Size = new System.Drawing.Size(64, 24);
      this.btnReadHighLimit.TabIndex = 1;
      this.btnReadHighLimit.Text = "Read";
      this.btnReadHighLimit.Click += new System.EventHandler(this.btnReadHighLimit_Click);
      // 
      // lblHighLimit
      // 
      this.lblHighLimit.AutoSize = true;
      this.lblHighLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblHighLimit.Location = new System.Drawing.Point(80, 24);
      this.lblHighLimit.Name = "lblHighLimit";
      this.lblHighLimit.Size = new System.Drawing.Size(44, 16);
      this.lblHighLimit.TabIndex = 0;
      this.lblHighLimit.Text = "---------";
      // 
      // btnResetLowLimit
      // 
      this.btnResetLowLimit.Location = new System.Drawing.Point(184, 48);
      this.btnResetLowLimit.Name = "btnResetLowLimit";
      this.btnResetLowLimit.Size = new System.Drawing.Size(64, 24);
      this.btnResetLowLimit.TabIndex = 2;
      this.btnResetLowLimit.Text = "Reset";
      this.btnResetLowLimit.Click += new System.EventHandler(this.btnResetLowLimit_Click);
      // 
      // btnReadLowLimit
      // 
      this.btnReadLowLimit.Location = new System.Drawing.Point(184, 16);
      this.btnReadLowLimit.Name = "btnReadLowLimit";
      this.btnReadLowLimit.Size = new System.Drawing.Size(64, 24);
      this.btnReadLowLimit.TabIndex = 1;
      this.btnReadLowLimit.Text = "Read";
      this.btnReadLowLimit.Click += new System.EventHandler(this.btnReadLowLimit_Click);
      // 
      // lblLowLimit
      // 
      this.lblLowLimit.AutoSize = true;
      this.lblLowLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblLowLimit.Location = new System.Drawing.Point(256, 24);
      this.lblLowLimit.Name = "lblLowLimit";
      this.lblLowLimit.Size = new System.Drawing.Size(44, 16);
      this.lblLowLimit.TabIndex = 0;
      this.lblLowLimit.Text = "---------";
      // 
      // lblDTLowLimit
      // 
      this.lblDTLowLimit.Location = new System.Drawing.Point(184, 80);
      this.lblDTLowLimit.Name = "lblDTLowLimit";
      this.lblDTLowLimit.Size = new System.Drawing.Size(136, 24);
      this.lblDTLowLimit.TabIndex = 18;
      this.lblDTLowLimit.Text = "RTC";
      // 
      // groupBox31
      // 
      this.groupBox31.Controls.Add(this.btnTemperatureInKelvin);
      this.groupBox31.Controls.Add(this.lblTemperatureInKelvin);
      this.groupBox31.Location = new System.Drawing.Point(455, 144);
      this.groupBox31.Name = "groupBox31";
      this.groupBox31.Size = new System.Drawing.Size(200, 48);
      this.groupBox31.TabIndex = 55;
      this.groupBox31.TabStop = false;
      this.groupBox31.Text = "Temperature In Kelvin";
      // 
      // btnTemperatureInKelvin
      // 
      this.btnTemperatureInKelvin.Location = new System.Drawing.Point(8, 16);
      this.btnTemperatureInKelvin.Name = "btnTemperatureInKelvin";
      this.btnTemperatureInKelvin.Size = new System.Drawing.Size(64, 24);
      this.btnTemperatureInKelvin.TabIndex = 1;
      this.btnTemperatureInKelvin.Text = "Read";
      this.btnTemperatureInKelvin.Click += new System.EventHandler(this.btnTemperatureInKelvin_Click);
      // 
      // lblTemperatureInKelvin
      // 
      this.lblTemperatureInKelvin.AutoSize = true;
      this.lblTemperatureInKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblTemperatureInKelvin.Location = new System.Drawing.Point(80, 24);
      this.lblTemperatureInKelvin.Name = "lblTemperatureInKelvin";
      this.lblTemperatureInKelvin.Size = new System.Drawing.Size(44, 16);
      this.lblTemperatureInKelvin.TabIndex = 0;
      this.lblTemperatureInKelvin.Text = "---------";
      // 
      // groupxxx
      // 
      this.groupxxx.Controls.Add(this.btnCorrectionCoefitient);
      this.groupxxx.Controls.Add(this.lblCorrectionCoefitient);
      this.groupxxx.Location = new System.Drawing.Point(455, 198);
      this.groupxxx.Name = "groupxxx";
      this.groupxxx.Size = new System.Drawing.Size(200, 48);
      this.groupxxx.TabIndex = 54;
      this.groupxxx.TabStop = false;
      this.groupxxx.Text = "Correction Coefitient";
      // 
      // btnCorrectionCoefitient
      // 
      this.btnCorrectionCoefitient.Location = new System.Drawing.Point(8, 16);
      this.btnCorrectionCoefitient.Name = "btnCorrectionCoefitient";
      this.btnCorrectionCoefitient.Size = new System.Drawing.Size(64, 24);
      this.btnCorrectionCoefitient.TabIndex = 1;
      this.btnCorrectionCoefitient.Text = "Read";
      this.btnCorrectionCoefitient.Click += new System.EventHandler(this.btnCorrectionCoefitient_Click);
      // 
      // lblCorrectionCoefitient
      // 
      this.lblCorrectionCoefitient.AutoSize = true;
      this.lblCorrectionCoefitient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblCorrectionCoefitient.Location = new System.Drawing.Point(80, 24);
      this.lblCorrectionCoefitient.Name = "lblCorrectionCoefitient";
      this.lblCorrectionCoefitient.Size = new System.Drawing.Size(44, 16);
      this.lblCorrectionCoefitient.TabIndex = 0;
      this.lblCorrectionCoefitient.Text = "---------";
      // 
      // groupBox24
      // 
      this.groupBox24.Controls.Add(this.btnResetCover);
      this.groupBox24.Controls.Add(this.btnReadCover);
      this.groupBox24.Controls.Add(this.lblCover);
      this.groupBox24.Location = new System.Drawing.Point(42, 293);
      this.groupBox24.Name = "groupBox24";
      this.groupBox24.Size = new System.Drawing.Size(200, 88);
      this.groupBox24.TabIndex = 53;
      this.groupBox24.TabStop = false;
      this.groupBox24.Text = "Read Flag For Opening Cover";
      // 
      // btnResetCover
      // 
      this.btnResetCover.Location = new System.Drawing.Point(8, 48);
      this.btnResetCover.Name = "btnResetCover";
      this.btnResetCover.Size = new System.Drawing.Size(64, 24);
      this.btnResetCover.TabIndex = 2;
      this.btnResetCover.Text = "Reset";
      this.btnResetCover.Click += new System.EventHandler(this.btnResetCover_Click);
      // 
      // btnReadCover
      // 
      this.btnReadCover.Location = new System.Drawing.Point(8, 16);
      this.btnReadCover.Name = "btnReadCover";
      this.btnReadCover.Size = new System.Drawing.Size(64, 24);
      this.btnReadCover.TabIndex = 1;
      this.btnReadCover.Text = "Read";
      this.btnReadCover.Click += new System.EventHandler(this.btnReadCover_Click);
      // 
      // lblCover
      // 
      this.lblCover.AutoSize = true;
      this.lblCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblCover.Location = new System.Drawing.Point(80, 24);
      this.lblCover.Name = "lblCover";
      this.lblCover.Size = new System.Drawing.Size(44, 16);
      this.lblCover.TabIndex = 0;
      this.lblCover.Text = "---------";
      // 
      // groupBox20
      // 
      this.groupBox20.Controls.Add(this.btnResetCorrectedFlowDp);
      this.groupBox20.Controls.Add(this.btnReadCorrectedFlowDp);
      this.groupBox20.Controls.Add(this.lblCorrectedFlowDp);
      this.groupBox20.Location = new System.Drawing.Point(254, 292);
      this.groupBox20.Name = "groupBox20";
      this.groupBox20.Size = new System.Drawing.Size(200, 88);
      this.groupBox20.TabIndex = 52;
      this.groupBox20.TabStop = false;
      this.groupBox20.Text = "Corrected Flow After Decimal Point";
      // 
      // btnResetCorrectedFlowDp
      // 
      this.btnResetCorrectedFlowDp.Location = new System.Drawing.Point(8, 48);
      this.btnResetCorrectedFlowDp.Name = "btnResetCorrectedFlowDp";
      this.btnResetCorrectedFlowDp.Size = new System.Drawing.Size(64, 24);
      this.btnResetCorrectedFlowDp.TabIndex = 2;
      this.btnResetCorrectedFlowDp.Text = "Reset";
      this.btnResetCorrectedFlowDp.Click += new System.EventHandler(this.btnResetCorrectedFlow_Click);
      // 
      // btnReadCorrectedFlowDp
      // 
      this.btnReadCorrectedFlowDp.Location = new System.Drawing.Point(8, 16);
      this.btnReadCorrectedFlowDp.Name = "btnReadCorrectedFlowDp";
      this.btnReadCorrectedFlowDp.Size = new System.Drawing.Size(64, 24);
      this.btnReadCorrectedFlowDp.TabIndex = 1;
      this.btnReadCorrectedFlowDp.Text = "Read";
      this.btnReadCorrectedFlowDp.Click += new System.EventHandler(this.btnReadCorrectedFlowDp_Click);
      // 
      // lblCorrectedFlowDp
      // 
      this.lblCorrectedFlowDp.AutoSize = true;
      this.lblCorrectedFlowDp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblCorrectedFlowDp.Location = new System.Drawing.Point(80, 24);
      this.lblCorrectedFlowDp.Name = "lblCorrectedFlowDp";
      this.lblCorrectedFlowDp.Size = new System.Drawing.Size(44, 16);
      this.lblCorrectedFlowDp.TabIndex = 0;
      this.lblCorrectedFlowDp.Text = "---------";
      // 
      // groupBox19
      // 
      this.groupBox19.Controls.Add(this.btnResetCorrectedFlow);
      this.groupBox19.Controls.Add(this.btnReadCorrectedFlow);
      this.groupBox19.Controls.Add(this.lblCorrectedFlow);
      this.groupBox19.Location = new System.Drawing.Point(244, 198);
      this.groupBox19.Name = "groupBox19";
      this.groupBox19.Size = new System.Drawing.Size(200, 88);
      this.groupBox19.TabIndex = 51;
      this.groupBox19.TabStop = false;
      this.groupBox19.Text = "Corrected Flow (m3)";
      // 
      // btnResetCorrectedFlow
      // 
      this.btnResetCorrectedFlow.Location = new System.Drawing.Point(8, 48);
      this.btnResetCorrectedFlow.Name = "btnResetCorrectedFlow";
      this.btnResetCorrectedFlow.Size = new System.Drawing.Size(64, 24);
      this.btnResetCorrectedFlow.TabIndex = 2;
      this.btnResetCorrectedFlow.Text = "Reset";
      this.btnResetCorrectedFlow.Click += new System.EventHandler(this.btnResetCorrectedFlow_Click);
      // 
      // btnReadCorrectedFlow
      // 
      this.btnReadCorrectedFlow.Location = new System.Drawing.Point(8, 16);
      this.btnReadCorrectedFlow.Name = "btnReadCorrectedFlow";
      this.btnReadCorrectedFlow.Size = new System.Drawing.Size(64, 24);
      this.btnReadCorrectedFlow.TabIndex = 1;
      this.btnReadCorrectedFlow.Text = "Read";
      this.btnReadCorrectedFlow.Click += new System.EventHandler(this.btnReadCorrectedFlow_Click);
      // 
      // lblCorrectedFlow
      // 
      this.lblCorrectedFlow.AutoSize = true;
      this.lblCorrectedFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblCorrectedFlow.Location = new System.Drawing.Point(80, 24);
      this.lblCorrectedFlow.Name = "lblCorrectedFlow";
      this.lblCorrectedFlow.Size = new System.Drawing.Size(44, 16);
      this.lblCorrectedFlow.TabIndex = 0;
      this.lblCorrectedFlow.Text = "---------";
      // 
      // groupBox18
      // 
      this.groupBox18.Controls.Add(this.btnEsimateCompres);
      this.groupBox18.Controls.Add(this.lblEstimateCompres);
      this.groupBox18.Location = new System.Drawing.Point(249, 143);
      this.groupBox18.Name = "groupBox18";
      this.groupBox18.Size = new System.Drawing.Size(200, 48);
      this.groupBox18.TabIndex = 50;
      this.groupBox18.TabStop = false;
      this.groupBox18.Text = "Estimate SuperCompressability";
      // 
      // btnEsimateCompres
      // 
      this.btnEsimateCompres.Location = new System.Drawing.Point(8, 16);
      this.btnEsimateCompres.Name = "btnEsimateCompres";
      this.btnEsimateCompres.Size = new System.Drawing.Size(64, 24);
      this.btnEsimateCompres.TabIndex = 1;
      this.btnEsimateCompres.Text = "Read";
      this.btnEsimateCompres.Click += new System.EventHandler(this.btnEsimateCompres_Click);
      // 
      // lblEstimateCompres
      // 
      this.lblEstimateCompres.AutoSize = true;
      this.lblEstimateCompres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblEstimateCompres.Location = new System.Drawing.Point(80, 24);
      this.lblEstimateCompres.Name = "lblEstimateCompres";
      this.lblEstimateCompres.Size = new System.Drawing.Size(44, 16);
      this.lblEstimateCompres.TabIndex = 0;
      this.lblEstimateCompres.Text = "---------";
      // 
      // groupBox17
      // 
      this.groupBox17.Controls.Add(this.btnReadNotCorrectedFlow);
      this.groupBox17.Controls.Add(this.lblNotCorrectedFlow);
      this.groupBox17.Location = new System.Drawing.Point(40, 143);
      this.groupBox17.Name = "groupBox17";
      this.groupBox17.Size = new System.Drawing.Size(200, 48);
      this.groupBox17.TabIndex = 49;
      this.groupBox17.TabStop = false;
      this.groupBox17.Text = "Not Corrected Flow (m3)";
      // 
      // btnReadNotCorrectedFlow
      // 
      this.btnReadNotCorrectedFlow.Location = new System.Drawing.Point(8, 18);
      this.btnReadNotCorrectedFlow.Name = "btnReadNotCorrectedFlow";
      this.btnReadNotCorrectedFlow.Size = new System.Drawing.Size(64, 24);
      this.btnReadNotCorrectedFlow.TabIndex = 1;
      this.btnReadNotCorrectedFlow.Text = "Read";
      this.btnReadNotCorrectedFlow.Click += new System.EventHandler(this.btnReadNotCorrectedFlow_Click);
      // 
      // lblNotCorrectedFlow
      // 
      this.lblNotCorrectedFlow.AutoSize = true;
      this.lblNotCorrectedFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblNotCorrectedFlow.Location = new System.Drawing.Point(80, 24);
      this.lblNotCorrectedFlow.Name = "lblNotCorrectedFlow";
      this.lblNotCorrectedFlow.Size = new System.Drawing.Size(44, 16);
      this.lblNotCorrectedFlow.TabIndex = 0;
      this.lblNotCorrectedFlow.Text = "---------";
      // 
      // groupBox15
      // 
      this.groupBox15.Controls.Add(this.btnResetMeasureImpuls);
      this.groupBox15.Controls.Add(this.btnReadMeasureImpuls);
      this.groupBox15.Controls.Add(this.lblMeasureImpuls);
      this.groupBox15.Location = new System.Drawing.Point(40, 198);
      this.groupBox15.Name = "groupBox15";
      this.groupBox15.Size = new System.Drawing.Size(200, 88);
      this.groupBox15.TabIndex = 48;
      this.groupBox15.TabStop = false;
      this.groupBox15.Text = "Counted Impulses (broi)";
      // 
      // btnResetMeasureImpuls
      // 
      this.btnResetMeasureImpuls.Location = new System.Drawing.Point(8, 48);
      this.btnResetMeasureImpuls.Name = "btnResetMeasureImpuls";
      this.btnResetMeasureImpuls.Size = new System.Drawing.Size(64, 24);
      this.btnResetMeasureImpuls.TabIndex = 2;
      this.btnResetMeasureImpuls.Text = "Reset";
      this.btnResetMeasureImpuls.Click += new System.EventHandler(this.btnResetMeasureImpuls_Click);
      // 
      // btnReadMeasureImpuls
      // 
      this.btnReadMeasureImpuls.Location = new System.Drawing.Point(8, 16);
      this.btnReadMeasureImpuls.Name = "btnReadMeasureImpuls";
      this.btnReadMeasureImpuls.Size = new System.Drawing.Size(64, 24);
      this.btnReadMeasureImpuls.TabIndex = 1;
      this.btnReadMeasureImpuls.Text = "Read";
      this.btnReadMeasureImpuls.Click += new System.EventHandler(this.btnReadMeasureImpuls_Click);
      // 
      // lblMeasureImpuls
      // 
      this.lblMeasureImpuls.AutoSize = true;
      this.lblMeasureImpuls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblMeasureImpuls.Location = new System.Drawing.Point(80, 24);
      this.lblMeasureImpuls.Name = "lblMeasureImpuls";
      this.lblMeasureImpuls.Size = new System.Drawing.Size(44, 16);
      this.lblMeasureImpuls.TabIndex = 0;
      this.lblMeasureImpuls.Text = "---------";
      // 
      // groupBox14
      // 
      this.groupBox14.Controls.Add(this.btnReadMeasurePressure);
      this.groupBox14.Controls.Add(this.lblMeasurePressure);
      this.groupBox14.Location = new System.Drawing.Point(243, 87);
      this.groupBox14.Name = "groupBox14";
      this.groupBox14.Size = new System.Drawing.Size(200, 48);
      this.groupBox14.TabIndex = 47;
      this.groupBox14.TabStop = false;
      this.groupBox14.Text = "Pressure (bar)";
      // 
      // btnReadMeasurePressure
      // 
      this.btnReadMeasurePressure.Location = new System.Drawing.Point(8, 16);
      this.btnReadMeasurePressure.Name = "btnReadMeasurePressure";
      this.btnReadMeasurePressure.Size = new System.Drawing.Size(64, 24);
      this.btnReadMeasurePressure.TabIndex = 1;
      this.btnReadMeasurePressure.Text = "Read";
      this.btnReadMeasurePressure.Click += new System.EventHandler(this.btnReadMeasurePressure_Click);
      // 
      // lblMeasurePressure
      // 
      this.lblMeasurePressure.AutoSize = true;
      this.lblMeasurePressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblMeasurePressure.Location = new System.Drawing.Point(80, 24);
      this.lblMeasurePressure.Name = "lblMeasurePressure";
      this.lblMeasurePressure.Size = new System.Drawing.Size(44, 16);
      this.lblMeasurePressure.TabIndex = 0;
      this.lblMeasurePressure.Text = "---------";
      // 
      // groupBox13
      // 
      this.groupBox13.Controls.Add(this.btnReadMeasureTemp);
      this.groupBox13.Controls.Add(this.lblMeasureTemp);
      this.groupBox13.Location = new System.Drawing.Point(39, 86);
      this.groupBox13.Name = "groupBox13";
      this.groupBox13.Size = new System.Drawing.Size(200, 48);
      this.groupBox13.TabIndex = 46;
      this.groupBox13.TabStop = false;
      this.groupBox13.Text = "Temperature (Gradussi Celzii)";
      // 
      // btnReadMeasureTemp
      // 
      this.btnReadMeasureTemp.Location = new System.Drawing.Point(8, 16);
      this.btnReadMeasureTemp.Name = "btnReadMeasureTemp";
      this.btnReadMeasureTemp.Size = new System.Drawing.Size(64, 24);
      this.btnReadMeasureTemp.TabIndex = 1;
      this.btnReadMeasureTemp.Text = "Read";
      this.btnReadMeasureTemp.Click += new System.EventHandler(this.btnReadMeasureTemp_Click);
      // 
      // lblMeasureTemp
      // 
      this.lblMeasureTemp.AutoSize = true;
      this.lblMeasureTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblMeasureTemp.Location = new System.Drawing.Point(80, 24);
      this.lblMeasureTemp.Name = "lblMeasureTemp";
      this.lblMeasureTemp.Size = new System.Drawing.Size(44, 16);
      this.lblMeasureTemp.TabIndex = 0;
      this.lblMeasureTemp.Text = "---------";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.groupBox7);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(972, 644);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.btnSetBaseTemperature);
      this.groupBox7.Controls.Add(this.btnReadBaseTemperature);
      this.groupBox7.Controls.Add(this.txtBaseTemperature);
      this.groupBox7.Location = new System.Drawing.Point(10, 16);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(192, 112);
      this.groupBox7.TabIndex = 2;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "Base Temperature for Bulgaria 293.15 K";
      // 
      // btnSetBaseTemperature
      // 
      this.btnSetBaseTemperature.Location = new System.Drawing.Point(96, 72);
      this.btnSetBaseTemperature.Name = "btnSetBaseTemperature";
      this.btnSetBaseTemperature.Size = new System.Drawing.Size(80, 24);
      this.btnSetBaseTemperature.TabIndex = 2;
      this.btnSetBaseTemperature.Text = "Set";
      this.btnSetBaseTemperature.Click += new System.EventHandler(this.btnSetBaseTemperature_Click);
      // 
      // btnReadBaseTemperature
      // 
      this.btnReadBaseTemperature.Location = new System.Drawing.Point(8, 72);
      this.btnReadBaseTemperature.Name = "btnReadBaseTemperature";
      this.btnReadBaseTemperature.Size = new System.Drawing.Size(80, 24);
      this.btnReadBaseTemperature.TabIndex = 1;
      this.btnReadBaseTemperature.Text = "Read";
      this.btnReadBaseTemperature.Click += new System.EventHandler(this.btnReadBaseTemperature_Click);
      // 
      // txtBaseTemperature
      // 
      this.txtBaseTemperature.Location = new System.Drawing.Point(8, 40);
      this.txtBaseTemperature.Name = "txtBaseTemperature";
      this.txtBaseTemperature.Size = new System.Drawing.Size(168, 20);
      this.txtBaseTemperature.TabIndex = 0;
      this.txtBaseTemperature.Text = "293.15";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1097, 763);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.pictureBox2);
      this.Name = "frmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.frmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.groupBox16.ResumeLayout(false);
      this.groupBox30.ResumeLayout(false);
      this.groupBox30.PerformLayout();
      this.groupBox35.ResumeLayout(false);
      this.groupBox35.PerformLayout();
      this.groupBox31.ResumeLayout(false);
      this.groupBox31.PerformLayout();
      this.groupxxx.ResumeLayout(false);
      this.groupxxx.PerformLayout();
      this.groupBox24.ResumeLayout(false);
      this.groupBox24.PerformLayout();
      this.groupBox20.ResumeLayout(false);
      this.groupBox20.PerformLayout();
      this.groupBox19.ResumeLayout(false);
      this.groupBox19.PerformLayout();
      this.groupBox18.ResumeLayout(false);
      this.groupBox18.PerformLayout();
      this.groupBox17.ResumeLayout(false);
      this.groupBox17.PerformLayout();
      this.groupBox15.ResumeLayout(false);
      this.groupBox15.PerformLayout();
      this.groupBox14.ResumeLayout(false);
      this.groupBox14.PerformLayout();
      this.groupBox13.ResumeLayout(false);
      this.groupBox13.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.groupBox7.ResumeLayout(false);
      this.groupBox7.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.GroupBox groupBox16;
    private System.Windows.Forms.Button btnStopPeriodicRead;
    private System.Windows.Forms.Button btnStartPeriodicRead;
    private System.Windows.Forms.Button btnReadAll;
    private System.Windows.Forms.GroupBox groupBox30;
    private System.Windows.Forms.Button btnResetFlow;
    public System.Windows.Forms.Label lblResetFlow;
    private System.Windows.Forms.GroupBox groupBox35;
    public System.Windows.Forms.Label lblDTHighLimit;
    private System.Windows.Forms.Button btnResetHighLimit;
    private System.Windows.Forms.Button btnReadHighLimit;
    public System.Windows.Forms.Label lblHighLimit;
    private System.Windows.Forms.Button btnResetLowLimit;
    private System.Windows.Forms.Button btnReadLowLimit;
    public System.Windows.Forms.Label lblLowLimit;
    public System.Windows.Forms.Label lblDTLowLimit;
    private System.Windows.Forms.GroupBox groupBox31;
    private System.Windows.Forms.Button btnTemperatureInKelvin;
    public System.Windows.Forms.Label lblTemperatureInKelvin;
    private System.Windows.Forms.GroupBox groupxxx;
    private System.Windows.Forms.Button btnCorrectionCoefitient;
    public System.Windows.Forms.Label lblCorrectionCoefitient;
    private System.Windows.Forms.GroupBox groupBox24;
    private System.Windows.Forms.Button btnResetCover;
    private System.Windows.Forms.Button btnReadCover;
    public System.Windows.Forms.Label lblCover;
    private System.Windows.Forms.GroupBox groupBox20;
    private System.Windows.Forms.Button btnResetCorrectedFlowDp;
    private System.Windows.Forms.Button btnReadCorrectedFlowDp;
    public System.Windows.Forms.Label lblCorrectedFlowDp;
    private System.Windows.Forms.GroupBox groupBox19;
    private System.Windows.Forms.Button btnResetCorrectedFlow;
    private System.Windows.Forms.Button btnReadCorrectedFlow;
    public System.Windows.Forms.Label lblCorrectedFlow;
    private System.Windows.Forms.GroupBox groupBox18;
    private System.Windows.Forms.Button btnEsimateCompres;
    public System.Windows.Forms.Label lblEstimateCompres;
    private System.Windows.Forms.GroupBox groupBox17;
    private System.Windows.Forms.Button btnReadNotCorrectedFlow;
    public System.Windows.Forms.Label lblNotCorrectedFlow;
    private System.Windows.Forms.GroupBox groupBox15;
    private System.Windows.Forms.Button btnResetMeasureImpuls;
    private System.Windows.Forms.Button btnReadMeasureImpuls;
    public System.Windows.Forms.Label lblMeasureImpuls;
    private System.Windows.Forms.GroupBox groupBox14;
    private System.Windows.Forms.Button btnReadMeasurePressure;
    public System.Windows.Forms.Label lblMeasurePressure;
    private System.Windows.Forms.GroupBox groupBox13;
    private System.Windows.Forms.Button btnReadMeasureTemp;
    public System.Windows.Forms.Label lblMeasureTemp;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.Button btnSetBaseTemperature;
    private System.Windows.Forms.Button btnReadBaseTemperature;
    public System.Windows.Forms.TextBox txtBaseTemperature;
  }
}

