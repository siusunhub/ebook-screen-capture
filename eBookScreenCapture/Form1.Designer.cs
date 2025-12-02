namespace eBookScreenCapture
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxSaveFolder = new System.Windows.Forms.TextBox();
            this.textBoxFileNamePrefix = new System.Windows.Forms.TextBox();
            this.numericStartPage = new System.Windows.Forms.NumericUpDown();
            this.numericTotalPage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCapturePos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelClickPos = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numericWaitSecond = new System.Windows.Forms.NumericUpDown();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxCutLeftRight = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWaitSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSaveFolder
            // 
            this.textBoxSaveFolder.Location = new System.Drawing.Point(82, 7);
            this.textBoxSaveFolder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSaveFolder.Name = "textBoxSaveFolder";
            this.textBoxSaveFolder.Size = new System.Drawing.Size(122, 20);
            this.textBoxSaveFolder.TabIndex = 21;
            // 
            // textBoxFileNamePrefix
            // 
            this.textBoxFileNamePrefix.Location = new System.Drawing.Point(321, 7);
            this.textBoxFileNamePrefix.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFileNamePrefix.Name = "textBoxFileNamePrefix";
            this.textBoxFileNamePrefix.Size = new System.Drawing.Size(110, 20);
            this.textBoxFileNamePrefix.TabIndex = 23;
            // 
            // numericStartPage
            // 
            this.numericStartPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericStartPage.Location = new System.Drawing.Point(476, 7);
            this.numericStartPage.Margin = new System.Windows.Forms.Padding(2);
            this.numericStartPage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericStartPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStartPage.Name = "numericStartPage";
            this.numericStartPage.Size = new System.Drawing.Size(53, 20);
            this.numericStartPage.TabIndex = 24;
            this.numericStartPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericTotalPage
            // 
            this.numericTotalPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericTotalPage.Location = new System.Drawing.Point(575, 7);
            this.numericTotalPage.Margin = new System.Windows.Forms.Padding(2);
            this.numericTotalPage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericTotalPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTotalPage.Name = "numericTotalPage";
            this.numericTotalPage.Size = new System.Drawing.Size(52, 20);
            this.numericTotalPage.TabIndex = 26;
            this.numericTotalPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Capture Pos:";
            // 
            // labelCapturePos
            // 
            this.labelCapturePos.AutoSize = true;
            this.labelCapturePos.Location = new System.Drawing.Point(738, 9);
            this.labelCapturePos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCapturePos.Name = "labelCapturePos";
            this.labelCapturePos.Size = new System.Drawing.Size(120, 13);
            this.labelCapturePos.TabIndex = 28;
            this.labelCapturePos.Text = "1024,1024 / 1024,1024";
            this.labelCapturePos.Click += new System.EventHandler(this.labelCapturePos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(911, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Click Pos:";
            // 
            // labelClickPos
            // 
            this.labelClickPos.AutoSize = true;
            this.labelClickPos.Location = new System.Drawing.Point(997, 9);
            this.labelClickPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClickPos.Name = "labelClickPos";
            this.labelClickPos.Size = new System.Drawing.Size(58, 13);
            this.labelClickPos.TabIndex = 28;
            this.labelClickPos.Text = "1024,1024";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(1447, 4);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(37, 21);
            this.buttonStart.TabIndex = 32;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1059, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Wait Sec:";
            // 
            // numericWaitSecond
            // 
            this.numericWaitSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericWaitSecond.Location = new System.Drawing.Point(1119, 7);
            this.numericWaitSecond.Margin = new System.Windows.Forms.Padding(2);
            this.numericWaitSecond.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericWaitSecond.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericWaitSecond.Name = "numericWaitSecond";
            this.numericWaitSecond.Size = new System.Drawing.Size(49, 20);
            this.numericWaitSecond.TabIndex = 34;
            this.numericWaitSecond.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(1486, 3);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(37, 21);
            this.buttonStop.TabIndex = 35;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelStatus.Location = new System.Drawing.Point(1271, 9);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 36;
            this.labelStatus.Text = "Status";
            this.labelStatus.Click += new System.EventHandler(this.labelStatus_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1525, 3);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(37, 21);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxCutLeftRight
            // 
            this.checkBoxCutLeftRight.AutoSize = true;
            this.checkBoxCutLeftRight.Location = new System.Drawing.Point(1175, 8);
            this.checkBoxCutLeftRight.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCutLeftRight.Name = "checkBoxCutLeftRight";
            this.checkBoxCutLeftRight.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCutLeftRight.TabIndex = 38;
            this.checkBoxCutLeftRight.Text = "Cut Left/Right";
            this.checkBoxCutLeftRight.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(883, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(859, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(976, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(714, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PNG Image (*.png)|*.png";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Save Image to";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMain.Image")));
            this.pictureBoxMain.Location = new System.Drawing.Point(206, 6);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 19;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Save Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filename Prefix:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 32);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBoxCutLeftRight);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.numericWaitSecond);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelClickPos);
            this.Controls.Add(this.labelCapturePos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericTotalPage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericStartPage);
            this.Controls.Add(this.textBoxFileNamePrefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSaveFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "eBook Screen Capture";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.numericStartPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTotalPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWaitSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxSaveFolder;
        private System.Windows.Forms.TextBox textBoxFileNamePrefix;
        private System.Windows.Forms.NumericUpDown numericStartPage;
        private System.Windows.Forms.NumericUpDown numericTotalPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCapturePos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelClickPos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericWaitSecond;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxCutLeftRight;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

