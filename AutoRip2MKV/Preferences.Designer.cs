﻿namespace AutoRip2MKV
{
    partial class Preferences
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
            this.Save = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.TextBox();
            this.textBoxCurrentTitle = new System.Windows.Forms.TextBox();
            this.AutoConvert = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dvdDriveID = new System.Windows.Forms.TextBox();
            this.makeMKVPath = new System.Windows.Forms.TextBox();
            this.handbrakeParams = new System.Windows.Forms.TextBox();
            this.tempPath = new System.Windows.Forms.TextBox();
            this.finalPath = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.timeOutValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(58, 354);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.AutoSizeChanged += new System.EventHandler(this.Save_Click);
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(333, 354);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 2;
            this.Close.Text = "&Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.FormMain_FormClosing);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Handbrake Parameters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temp Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Final Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "MakeMKV Path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "DVD Drive";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Minimum Title Length";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(197, 359);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(64, 13);
            this.timeLabel.TabIndex = 27;
            this.timeLabel.Text = "30 Seconds";
            this.timeLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Current Title";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // statusText
            // 
            this.statusText.AcceptsReturn = true;
            this.statusText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "StatusText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusText.Location = new System.Drawing.Point(472, 2);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(389, 375);
            this.statusText.TabIndex = 30;
            this.statusText.Text = global::AutoRip2MKV.Properties.Settings.Default.StatusText;
            // 
            // textBoxCurrentTitle
            // 
            this.textBoxCurrentTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "CurrentTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCurrentTitle.Location = new System.Drawing.Point(130, 2);
            this.textBoxCurrentTitle.Name = "textBoxCurrentTitle";
            this.textBoxCurrentTitle.Size = new System.Drawing.Size(333, 20);
            this.textBoxCurrentTitle.TabIndex = 29;
            this.textBoxCurrentTitle.Text = global::AutoRip2MKV.Properties.Settings.Default.CurrentTitle;
            this.textBoxCurrentTitle.TextChanged += new System.EventHandler(this.textBoxCurrentTitle_TextChanged);
            // 
            // AutoConvert
            // 
            this.AutoConvert.AutoSize = true;
            this.AutoConvert.Checked = global::AutoRip2MKV.Properties.Settings.Default.Timout;
            this.AutoConvert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoConvert.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoRip2MKV.Properties.Settings.Default, "Timout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AutoConvert.Location = new System.Drawing.Point(158, 318);
            this.AutoConvert.Name = "AutoConvert";
            this.AutoConvert.Size = new System.Drawing.Size(113, 17);
            this.AutoConvert.TabIndex = 25;
            this.AutoConvert.Text = "Auto Convert After";
            this.AutoConvert.UseVisualStyleBackColor = true;
            this.AutoConvert.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::AutoRip2MKV.Properties.Settings.Default.KeepAfterConv;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoRip2MKV.Properties.Settings.Default, "KeepAfterConv", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(133, 160);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Keep MKV After Convert";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::AutoRip2MKV.Properties.Settings.Default.ConvWithHandbrake;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AutoRip2MKV.Properties.Settings.Default, "ConvWithHandbrake", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(133, 137);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Convert with Handbrake";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dvdDriveID
            // 
            this.dvdDriveID.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "DVDDrive", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dvdDriveID.Location = new System.Drawing.Point(133, 192);
            this.dvdDriveID.Name = "dvdDriveID";
            this.dvdDriveID.Size = new System.Drawing.Size(333, 20);
            this.dvdDriveID.TabIndex = 12;
            this.dvdDriveID.Text = global::AutoRip2MKV.Properties.Settings.Default.DVDDrive;
            // 
            // makeMKVPath
            // 
            this.makeMKVPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "MakeMKVPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.makeMKVPath.Location = new System.Drawing.Point(133, 218);
            this.makeMKVPath.Name = "makeMKVPath";
            this.makeMKVPath.Size = new System.Drawing.Size(333, 20);
            this.makeMKVPath.TabIndex = 11;
            this.makeMKVPath.Text = global::AutoRip2MKV.Properties.Settings.Default.MakeMKVPath;
            // 
            // handbrakeParams
            // 
            this.handbrakeParams.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "HandBrakeParameters", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.handbrakeParams.Location = new System.Drawing.Point(130, 32);
            this.handbrakeParams.Name = "handbrakeParams";
            this.handbrakeParams.Size = new System.Drawing.Size(333, 20);
            this.handbrakeParams.TabIndex = 6;
            this.handbrakeParams.Text = global::AutoRip2MKV.Properties.Settings.Default.HandBrakeParameters;
            // 
            // tempPath
            // 
            this.tempPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "TempPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tempPath.Location = new System.Drawing.Point(130, 58);
            this.tempPath.Name = "tempPath";
            this.tempPath.Size = new System.Drawing.Size(263, 20);
            this.tempPath.TabIndex = 5;
            this.tempPath.Text = global::AutoRip2MKV.Properties.Settings.Default.TempPath;
            // 
            // finalPath
            // 
            this.finalPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "FinalPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.finalPath.Location = new System.Drawing.Point(130, 84);
            this.finalPath.Name = "finalPath";
            this.finalPath.Size = new System.Drawing.Size(263, 20);
            this.finalPath.TabIndex = 4;
            this.finalPath.Text = global::AutoRip2MKV.Properties.Settings.Default.FinalPath;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "MinTitleLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(130, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = global::AutoRip2MKV.Properties.Settings.Default.MinTitleLength;
            // 
            // timeOutValue
            // 
            this.timeOutValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AutoRip2MKV.Properties.Settings.Default, "TimeoutValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.timeOutValue.Location = new System.Drawing.Point(266, 315);
            this.timeOutValue.Name = "timeOutValue";
            this.timeOutValue.Size = new System.Drawing.Size(46, 20);
            this.timeOutValue.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "seconds";
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeOutValue);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.textBoxCurrentTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.AutoConvert);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvdDriveID);
            this.Controls.Add(this.makeMKVPath);
            this.Controls.Add(this.handbrakeParams);
            this.Controls.Add(this.tempPath);
            this.Controls.Add(this.finalPath);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Save);
            this.Name = "Preferences";
            this.Text = "AutoRip2MKV Preferences";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox finalPath;
        private System.Windows.Forms.TextBox tempPath;
        private System.Windows.Forms.TextBox handbrakeParams;
        private System.Windows.Forms.TextBox makeMKVPath;
        private System.Windows.Forms.TextBox dvdDriveID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox AutoConvert;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCurrentTitle;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.TextBox timeOutValue;
        private System.Windows.Forms.Label label5;
    }
}