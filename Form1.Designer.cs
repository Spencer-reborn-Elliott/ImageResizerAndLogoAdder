namespace ImageResizerAndLogoAdder
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
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.WarningMessage = new System.Windows.Forms.Label();
            this.IncludeSubDirsCheck = new System.Windows.Forms.CheckBox();
            this.Xaxis = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Yaxis = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WaterMarkChooser = new System.Windows.Forms.OpenFileDialog();
            this.ChooseLogoBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.logoxaxis = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.logoyaxis = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.LogoSettings = new System.Windows.Forms.GroupBox();
            this.IncludeLogoChk = new System.Windows.Forms.CheckBox();
            this.QualityBar = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoxaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoyaxis)).BeginInit();
            this.LogoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.Location = new System.Drawing.Point(478, 479);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(115, 42);
            this.ConvertBtn.TabIndex = 0;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "This utility will allow you to choose a folder of images and convert them all to " +
    "the specified size.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converting the files will save a copy of the files in the application directory. " +
    "It will not affect the original files.";
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Location = new System.Drawing.Point(13, 85);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(155, 54);
            this.ChooseBtn.TabIndex = 3;
            this.ChooseBtn.Text = "Choose Input Image Folder";
            this.ChooseBtn.UseVisualStyleBackColor = true;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // WarningMessage
            // 
            this.WarningMessage.AutoSize = true;
            this.WarningMessage.Location = new System.Drawing.Point(287, 212);
            this.WarningMessage.Name = "WarningMessage";
            this.WarningMessage.Size = new System.Drawing.Size(0, 13);
            this.WarningMessage.TabIndex = 4;
            // 
            // IncludeSubDirsCheck
            // 
            this.IncludeSubDirsCheck.AutoSize = true;
            this.IncludeSubDirsCheck.Location = new System.Drawing.Point(174, 122);
            this.IncludeSubDirsCheck.Name = "IncludeSubDirsCheck";
            this.IncludeSubDirsCheck.Size = new System.Drawing.Size(140, 17);
            this.IncludeSubDirsCheck.TabIndex = 6;
            this.IncludeSubDirsCheck.Text = "Include Sub-directories?";
            this.IncludeSubDirsCheck.UseVisualStyleBackColor = true;
            // 
            // Xaxis
            // 
            this.Xaxis.Location = new System.Drawing.Point(19, 43);
            this.Xaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Xaxis.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Xaxis.Name = "Xaxis";
            this.Xaxis.Size = new System.Drawing.Size(68, 20);
            this.Xaxis.TabIndex = 7;
            this.Xaxis.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X-axis size in pixels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y-axis size in pixels";
            // 
            // Yaxis
            // 
            this.Yaxis.Location = new System.Drawing.Point(133, 43);
            this.Yaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.Yaxis.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.Yaxis.Name = "Yaxis";
            this.Yaxis.Size = new System.Drawing.Size(68, 20);
            this.Yaxis.TabIndex = 9;
            this.Yaxis.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Xaxis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Yaxis);
            this.groupBox1.Location = new System.Drawing.Point(15, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 80);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Size of Images";
            // 
            // WaterMarkChooser
            // 
            this.WaterMarkChooser.FileName = "openFileDialog1";
            // 
            // ChooseLogoBtn
            // 
            this.ChooseLogoBtn.Location = new System.Drawing.Point(6, 19);
            this.ChooseLogoBtn.Name = "ChooseLogoBtn";
            this.ChooseLogoBtn.Size = new System.Drawing.Size(155, 54);
            this.ChooseLogoBtn.TabIndex = 13;
            this.ChooseLogoBtn.Text = "Choose Logo / Watermark";
            this.ChooseLogoBtn.UseVisualStyleBackColor = true;
            this.ChooseLogoBtn.Click += new System.EventHandler(this.ChooseLogoBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "You can also choose to over-lay a watermark or a logo. ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.logoxaxis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.logoyaxis);
            this.groupBox2.Location = new System.Drawing.Point(6, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 80);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position of Watermark/Logo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "0 x 0 would be top left";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "X-axis ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "X";
            // 
            // logoxaxis
            // 
            this.logoxaxis.Location = new System.Drawing.Point(19, 43);
            this.logoxaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.logoxaxis.Name = "logoxaxis";
            this.logoxaxis.Size = new System.Drawing.Size(68, 20);
            this.logoxaxis.TabIndex = 7;
            this.logoxaxis.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(130, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Y-axis";
            // 
            // logoyaxis
            // 
            this.logoyaxis.Location = new System.Drawing.Point(133, 43);
            this.logoyaxis.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.logoyaxis.Name = "logoyaxis";
            this.logoyaxis.Size = new System.Drawing.Size(68, 20);
            this.logoyaxis.TabIndex = 9;
            this.logoyaxis.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 13;
            // 
            // LogoSettings
            // 
            this.LogoSettings.Controls.Add(this.ChooseLogoBtn);
            this.LogoSettings.Controls.Add(this.groupBox2);
            this.LogoSettings.Enabled = false;
            this.LogoSettings.Location = new System.Drawing.Point(13, 254);
            this.LogoSettings.Name = "LogoSettings";
            this.LogoSettings.Size = new System.Drawing.Size(377, 172);
            this.LogoSettings.TabIndex = 16;
            this.LogoSettings.TabStop = false;
            this.LogoSettings.Text = "Watermark / Logo Settings";
            // 
            // IncludeLogoChk
            // 
            this.IncludeLogoChk.AutoSize = true;
            this.IncludeLogoChk.Location = new System.Drawing.Point(15, 231);
            this.IncludeLogoChk.Name = "IncludeLogoChk";
            this.IncludeLogoChk.Size = new System.Drawing.Size(153, 17);
            this.IncludeLogoChk.TabIndex = 17;
            this.IncludeLogoChk.Text = "Include logo / Watermark?";
            this.IncludeLogoChk.UseVisualStyleBackColor = true;
            this.IncludeLogoChk.CheckedChanged += new System.EventHandler(this.IncludeLogoChk_CheckedChanged);
            // 
            // QualityBar
            // 
            this.QualityBar.Location = new System.Drawing.Point(22, 31);
            this.QualityBar.Maximum = 4;
            this.QualityBar.Name = "QualityBar";
            this.QualityBar.Size = new System.Drawing.Size(399, 45);
            this.QualityBar.TabIndex = 5;
            this.QualityBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.QualityBar.Value = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.QualityBar);
            this.groupBox3.Location = new System.Drawing.Point(13, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 89);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Output Quality";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(130, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "The higher the quality, the higher the file size.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Low";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(392, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "High";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.IncludeLogoChk);
            this.Controls.Add(this.LogoSettings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IncludeSubDirsCheck);
            this.Controls.Add(this.WarningMessage);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConvertBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Image Resizer and Logo Adder";
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoxaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoyaxis)).EndInit();
            this.LogoSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QualityBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog InputFolder;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.Label WarningMessage;
        private System.Windows.Forms.CheckBox IncludeSubDirsCheck;
        private System.Windows.Forms.NumericUpDown Xaxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Yaxis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog WaterMarkChooser;
        private System.Windows.Forms.Button ChooseLogoBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog OutputFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown logoxaxis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown logoyaxis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox LogoSettings;
        private System.Windows.Forms.CheckBox IncludeLogoChk;
        private System.Windows.Forms.TrackBar QualityBar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
    }
}

