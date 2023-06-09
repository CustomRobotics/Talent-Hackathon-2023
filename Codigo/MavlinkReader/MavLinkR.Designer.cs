﻿namespace MavLinkReader
{
    partial class MavLinkReader
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
            this.components = new System.ComponentModel.Container();
            this.LCom = new System.Windows.Forms.Label();
            this.LBaud = new System.Windows.Forms.Label();
            this.Comm = new System.Windows.Forms.TextBox();
            this.Baud = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.Serial = new System.IO.Ports.SerialPort(this.components);
            this.LStatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.LMode = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.Label();
            this.LBattery = new System.Windows.Forms.Label();
            this.BVolts = new System.Windows.Forms.Label();
            this.LBPercent = new System.Windows.Forms.Label();
            this.BPercent = new System.Windows.Forms.Label();
            this.LCurrent = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Label();
            this.LRoll = new System.Windows.Forms.Label();
            this.Roll = new System.Windows.Forms.Label();
            this.LPitch = new System.Windows.Forms.Label();
            this.Pitch = new System.Windows.Forms.Label();
            this.LYaw = new System.Windows.Forms.Label();
            this.Yaw = new System.Windows.Forms.Label();
            this.LGpsf = new System.Windows.Forms.Label();
            this.GpsFix = new System.Windows.Forms.Label();
            this.LLatitude = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.Label();
            this.LLongitude = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.Label();
            this.LSatellites = new System.Windows.Forms.Label();
            this.Satellites = new System.Windows.Forms.Label();
            this.LAltitude = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.LHeading = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seq = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Results = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Request = new System.Windows.Forms.Button();
            this.HeartBeat = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.FlightModes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MissionItems = new System.Windows.Forms.Label();
            this.GetMissionValues = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCom
            // 
            this.LCom.AutoSize = true;
            this.LCom.ForeColor = System.Drawing.Color.Lime;
            this.LCom.Location = new System.Drawing.Point(21, 33);
            this.LCom.Name = "LCom";
            this.LCom.Size = new System.Drawing.Size(51, 19);
            this.LCom.TabIndex = 0;
            this.LCom.Text = "COM:";
            // 
            // LBaud
            // 
            this.LBaud.AutoSize = true;
            this.LBaud.ForeColor = System.Drawing.Color.Lime;
            this.LBaud.Location = new System.Drawing.Point(21, 62);
            this.LBaud.Name = "LBaud";
            this.LBaud.Size = new System.Drawing.Size(59, 19);
            this.LBaud.TabIndex = 0;
            this.LBaud.Text = "BAUD:";
            // 
            // Comm
            // 
            this.Comm.Location = new System.Drawing.Point(86, 33);
            this.Comm.Name = "Comm";
            this.Comm.Size = new System.Drawing.Size(100, 26);
            this.Comm.TabIndex = 1;
            // 
            // Baud
            // 
            this.Baud.FormattingEnabled = true;
            this.Baud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.Baud.Location = new System.Drawing.Point(86, 62);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(121, 26);
            this.Baud.TabIndex = 2;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(260, 62);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(114, 26);
            this.Start.TabIndex = 3;
            this.Start.Text = "Connect";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.ReadData);
            // 
            // Serial
            // 
            this.Serial.BaudRate = 57600;
            this.Serial.PortName = "COM15";
            this.Serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Data);
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.ForeColor = System.Drawing.Color.Lime;
            this.LStatus.Location = new System.Drawing.Point(18, 233);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(59, 19);
            this.LStatus.TabIndex = 0;
            this.LStatus.Text = "Status:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(86, 233);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(36, 19);
            this.Status.TabIndex = 4;
            this.Status.Text = "N/A";
            // 
            // LMode
            // 
            this.LMode.AutoSize = true;
            this.LMode.ForeColor = System.Drawing.Color.Lime;
            this.LMode.Location = new System.Drawing.Point(163, 233);
            this.LMode.Name = "LMode";
            this.LMode.Size = new System.Drawing.Size(54, 19);
            this.LMode.TabIndex = 0;
            this.LMode.Text = "Mode:";
            // 
            // Mode
            // 
            this.Mode.AutoSize = true;
            this.Mode.Location = new System.Drawing.Point(226, 233);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(36, 19);
            this.Mode.TabIndex = 4;
            this.Mode.Text = "N/A";
            // 
            // LBattery
            // 
            this.LBattery.AutoSize = true;
            this.LBattery.ForeColor = System.Drawing.Color.Lime;
            this.LBattery.Location = new System.Drawing.Point(18, 249);
            this.LBattery.Name = "LBattery";
            this.LBattery.Size = new System.Drawing.Size(66, 19);
            this.LBattery.TabIndex = 0;
            this.LBattery.Text = "Battery:";
            // 
            // BVolts
            // 
            this.BVolts.AutoSize = true;
            this.BVolts.Location = new System.Drawing.Point(86, 249);
            this.BVolts.Name = "BVolts";
            this.BVolts.Size = new System.Drawing.Size(36, 19);
            this.BVolts.TabIndex = 4;
            this.BVolts.Text = "N/A";
            // 
            // LBPercent
            // 
            this.LBPercent.AutoSize = true;
            this.LBPercent.ForeColor = System.Drawing.Color.Lime;
            this.LBPercent.Location = new System.Drawing.Point(163, 249);
            this.LBPercent.Name = "LBPercent";
            this.LBPercent.Size = new System.Drawing.Size(71, 19);
            this.LBPercent.TabIndex = 0;
            this.LBPercent.Text = "Percent:";
            // 
            // BPercent
            // 
            this.BPercent.AutoSize = true;
            this.BPercent.Location = new System.Drawing.Point(226, 249);
            this.BPercent.Name = "BPercent";
            this.BPercent.Size = new System.Drawing.Size(36, 19);
            this.BPercent.TabIndex = 4;
            this.BPercent.Text = "N/A";
            // 
            // LCurrent
            // 
            this.LCurrent.AutoSize = true;
            this.LCurrent.ForeColor = System.Drawing.Color.Lime;
            this.LCurrent.Location = new System.Drawing.Point(305, 249);
            this.LCurrent.Name = "LCurrent";
            this.LCurrent.Size = new System.Drawing.Size(69, 19);
            this.LCurrent.TabIndex = 0;
            this.LCurrent.Text = "Current:";
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.Location = new System.Drawing.Point(379, 249);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(36, 19);
            this.Current.TabIndex = 4;
            this.Current.Text = "N/A";
            // 
            // LRoll
            // 
            this.LRoll.AutoSize = true;
            this.LRoll.ForeColor = System.Drawing.Color.Lime;
            this.LRoll.Location = new System.Drawing.Point(18, 265);
            this.LRoll.Name = "LRoll";
            this.LRoll.Size = new System.Drawing.Size(40, 19);
            this.LRoll.TabIndex = 0;
            this.LRoll.Text = "Roll:";
            // 
            // Roll
            // 
            this.Roll.AutoSize = true;
            this.Roll.Location = new System.Drawing.Point(86, 265);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(36, 19);
            this.Roll.TabIndex = 4;
            this.Roll.Text = "N/A";
            // 
            // LPitch
            // 
            this.LPitch.AutoSize = true;
            this.LPitch.ForeColor = System.Drawing.Color.Lime;
            this.LPitch.Location = new System.Drawing.Point(163, 265);
            this.LPitch.Name = "LPitch";
            this.LPitch.Size = new System.Drawing.Size(51, 19);
            this.LPitch.TabIndex = 0;
            this.LPitch.Text = "Pitch:";
            // 
            // Pitch
            // 
            this.Pitch.AutoSize = true;
            this.Pitch.Location = new System.Drawing.Point(226, 265);
            this.Pitch.Name = "Pitch";
            this.Pitch.Size = new System.Drawing.Size(36, 19);
            this.Pitch.TabIndex = 4;
            this.Pitch.Text = "N/A";
            // 
            // LYaw
            // 
            this.LYaw.AutoSize = true;
            this.LYaw.ForeColor = System.Drawing.Color.Lime;
            this.LYaw.Location = new System.Drawing.Point(305, 265);
            this.LYaw.Name = "LYaw";
            this.LYaw.Size = new System.Drawing.Size(44, 19);
            this.LYaw.TabIndex = 0;
            this.LYaw.Text = "Yaw:";
            // 
            // Yaw
            // 
            this.Yaw.AutoSize = true;
            this.Yaw.Location = new System.Drawing.Point(379, 265);
            this.Yaw.Name = "Yaw";
            this.Yaw.Size = new System.Drawing.Size(36, 19);
            this.Yaw.TabIndex = 4;
            this.Yaw.Text = "N/A";
            // 
            // LGpsf
            // 
            this.LGpsf.AutoSize = true;
            this.LGpsf.ForeColor = System.Drawing.Color.Lime;
            this.LGpsf.Location = new System.Drawing.Point(18, 281);
            this.LGpsf.Name = "LGpsf";
            this.LGpsf.Size = new System.Drawing.Size(74, 19);
            this.LGpsf.TabIndex = 0;
            this.LGpsf.Text = "GPS Fix:";
            // 
            // GpsFix
            // 
            this.GpsFix.AutoSize = true;
            this.GpsFix.Location = new System.Drawing.Point(86, 281);
            this.GpsFix.Name = "GpsFix";
            this.GpsFix.Size = new System.Drawing.Size(36, 19);
            this.GpsFix.TabIndex = 4;
            this.GpsFix.Text = "N/A";
            // 
            // LLatitude
            // 
            this.LLatitude.AutoSize = true;
            this.LLatitude.ForeColor = System.Drawing.Color.Lime;
            this.LLatitude.Location = new System.Drawing.Point(163, 281);
            this.LLatitude.Name = "LLatitude";
            this.LLatitude.Size = new System.Drawing.Size(71, 19);
            this.LLatitude.TabIndex = 0;
            this.LLatitude.Text = "Latitude:";
            // 
            // Latitude
            // 
            this.Latitude.AutoSize = true;
            this.Latitude.Location = new System.Drawing.Point(227, 281);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(36, 19);
            this.Latitude.TabIndex = 4;
            this.Latitude.Text = "N/A";
            // 
            // LLongitude
            // 
            this.LLongitude.AutoSize = true;
            this.LLongitude.ForeColor = System.Drawing.Color.Lime;
            this.LLongitude.Location = new System.Drawing.Point(305, 281);
            this.LLongitude.Name = "LLongitude";
            this.LLongitude.Size = new System.Drawing.Size(85, 19);
            this.LLongitude.TabIndex = 0;
            this.LLongitude.Text = "Longitude:";
            // 
            // Longitude
            // 
            this.Longitude.AutoSize = true;
            this.Longitude.Location = new System.Drawing.Point(379, 281);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(36, 19);
            this.Longitude.TabIndex = 4;
            this.Longitude.Text = "N/A";
            // 
            // LSatellites
            // 
            this.LSatellites.AutoSize = true;
            this.LSatellites.ForeColor = System.Drawing.Color.Lime;
            this.LSatellites.Location = new System.Drawing.Point(18, 297);
            this.LSatellites.Name = "LSatellites";
            this.LSatellites.Size = new System.Drawing.Size(78, 19);
            this.LSatellites.TabIndex = 0;
            this.LSatellites.Text = "Satellites:";
            // 
            // Satellites
            // 
            this.Satellites.AutoSize = true;
            this.Satellites.Location = new System.Drawing.Point(86, 297);
            this.Satellites.Name = "Satellites";
            this.Satellites.Size = new System.Drawing.Size(36, 19);
            this.Satellites.TabIndex = 4;
            this.Satellites.Text = "N/A";
            // 
            // LAltitude
            // 
            this.LAltitude.AutoSize = true;
            this.LAltitude.ForeColor = System.Drawing.Color.Lime;
            this.LAltitude.Location = new System.Drawing.Point(18, 313);
            this.LAltitude.Name = "LAltitude";
            this.LAltitude.Size = new System.Drawing.Size(67, 19);
            this.LAltitude.TabIndex = 0;
            this.LAltitude.Text = "Altitude:";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Location = new System.Drawing.Point(86, 313);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(36, 19);
            this.Altitude.TabIndex = 4;
            this.Altitude.Text = "N/A";
            // 
            // LHeading
            // 
            this.LHeading.AutoSize = true;
            this.LHeading.ForeColor = System.Drawing.Color.Lime;
            this.LHeading.Location = new System.Drawing.Point(163, 313);
            this.LHeading.Name = "LHeading";
            this.LHeading.Size = new System.Drawing.Size(74, 19);
            this.LHeading.TabIndex = 0;
            this.LHeading.Text = "Heading:";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Location = new System.Drawing.Point(226, 313);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(36, 19);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(305, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sequence:";
            // 
            // Seq
            // 
            this.Seq.AutoSize = true;
            this.Seq.Location = new System.Drawing.Point(379, 233);
            this.Seq.Name = "Seq";
            this.Seq.Size = new System.Drawing.Size(36, 19);
            this.Seq.TabIndex = 6;
            this.Seq.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(18, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Command Results:";
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Location = new System.Drawing.Point(163, 352);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(36, 19);
            this.Results.TabIndex = 8;
            this.Results.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(18, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status Message:";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(163, 368);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(36, 19);
            this.Message.TabIndex = 10;
            this.Message.Text = "N/A";
            // 
            // Request
            // 
            this.Request.Location = new System.Drawing.Point(343, 134);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(75, 23);
            this.Request.TabIndex = 11;
            this.Request.Text = "Request";
            this.Request.UseVisualStyleBackColor = true;
            this.Request.Click += new System.EventHandler(this.DoCmd);
            // 
            // HeartBeat
            // 
            this.HeartBeat.DoWork += new System.ComponentModel.DoWorkEventHandler(this.HeartB);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Stop Heartbeat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StopHeartBeat);
            // 
            // FlightModes
            // 
            this.FlightModes.FormattingEnabled = true;
            this.FlightModes.Location = new System.Drawing.Point(112, 131);
            this.FlightModes.Name = "FlightModes";
            this.FlightModes.Size = new System.Drawing.Size(121, 26);
            this.FlightModes.TabIndex = 13;
            this.FlightModes.SelectedIndexChanged += new System.EventHandler(this.ChgFlight);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Flight Mode:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Send Mission";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SendMission);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Get Mission";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.GetMission);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(18, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mission:";
            // 
            // MissionItems
            // 
            this.MissionItems.AutoSize = true;
            this.MissionItems.Location = new System.Drawing.Point(86, 329);
            this.MissionItems.Name = "MissionItems";
            this.MissionItems.Size = new System.Drawing.Size(36, 19);
            this.MissionItems.TabIndex = 18;
            this.MissionItems.Text = "N/A";
            // 
            // GetMissionValues
            // 
            this.GetMissionValues.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RecvMission);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(491, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 376);
            this.textBox1.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1018, 394);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 26);
            this.button4.TabIndex = 20;
            this.button4.Text = "clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(491, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Arm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(572, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "TakeOff";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MavLinkReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 436);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MissionItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FlightModes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Longitude);
            this.Controls.Add(this.Yaw);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.Latitude);
            this.Controls.Add(this.Pitch);
            this.Controls.Add(this.BPercent);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.Altitude);
            this.Controls.Add(this.Satellites);
            this.Controls.Add(this.GpsFix);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.BVolts);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Baud);
            this.Controls.Add(this.Comm);
            this.Controls.Add(this.LLongitude);
            this.Controls.Add(this.LYaw);
            this.Controls.Add(this.LCurrent);
            this.Controls.Add(this.LHeading);
            this.Controls.Add(this.LLatitude);
            this.Controls.Add(this.LPitch);
            this.Controls.Add(this.LBPercent);
            this.Controls.Add(this.LMode);
            this.Controls.Add(this.LAltitude);
            this.Controls.Add(this.LSatellites);
            this.Controls.Add(this.LGpsf);
            this.Controls.Add(this.LRoll);
            this.Controls.Add(this.LBattery);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LBaud);
            this.Controls.Add(this.LCom);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MavLinkReader";
            this.Text = "MavLink";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dismiss);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Update);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCom;
        private System.Windows.Forms.Label LBaud;
        private System.Windows.Forms.TextBox Comm;
        private System.Windows.Forms.ComboBox Baud;
        private System.Windows.Forms.Button Start;
        private System.IO.Ports.SerialPort Serial;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label LMode;
        private System.Windows.Forms.Label Mode;
        private System.Windows.Forms.Label LBattery;
        private System.Windows.Forms.Label BVolts;
        private System.Windows.Forms.Label LBPercent;
        private System.Windows.Forms.Label BPercent;
        private System.Windows.Forms.Label LCurrent;
        private System.Windows.Forms.Label Current;
        private System.Windows.Forms.Label LRoll;
        private System.Windows.Forms.Label Roll;
        private System.Windows.Forms.Label LPitch;
        private System.Windows.Forms.Label Pitch;
        private System.Windows.Forms.Label LYaw;
        private System.Windows.Forms.Label Yaw;
        private System.Windows.Forms.Label LGpsf;
        private System.Windows.Forms.Label GpsFix;
        private System.Windows.Forms.Label LLatitude;
        private System.Windows.Forms.Label Latitude;
        private System.Windows.Forms.Label LLongitude;
        private System.Windows.Forms.Label Longitude;
        private System.Windows.Forms.Label LSatellites;
        private System.Windows.Forms.Label Satellites;
        private System.Windows.Forms.Label LAltitude;
        private System.Windows.Forms.Label Altitude;
        private System.Windows.Forms.Label LHeading;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Seq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button Request;
        private System.ComponentModel.BackgroundWorker HeartBeat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox FlightModes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MissionItems;
        private System.ComponentModel.BackgroundWorker GetMissionValues;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

