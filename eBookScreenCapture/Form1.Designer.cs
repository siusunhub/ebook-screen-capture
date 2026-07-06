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
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            textBoxSaveFolder = new System.Windows.Forms.TextBox();
            textBoxFileNamePrefix = new System.Windows.Forms.TextBox();
            numericStartPage = new System.Windows.Forms.NumericUpDown();
            numericTotalPage = new System.Windows.Forms.NumericUpDown();
            label5 = new System.Windows.Forms.Label();
            labelCapturePos = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            labelClickPos = new System.Windows.Forms.Label();
            buttonStart = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            numericWaitSecond = new System.Windows.Forms.NumericUpDown();
            buttonStop = new System.Windows.Forms.Button();
            labelStatus = new System.Windows.Forms.Label();
            buttonExit = new System.Windows.Forms.Button();
            checkBoxCutLeftRight = new System.Windows.Forms.CheckBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            pictureBoxMain = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericStartPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTotalPage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericWaitSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // textBoxSaveFolder
            // 
            textBoxSaveFolder.Location = new System.Drawing.Point(82, 7);
            textBoxSaveFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            textBoxSaveFolder.Name = "textBoxSaveFolder";
            textBoxSaveFolder.Size = new System.Drawing.Size(94, 20);
            textBoxSaveFolder.TabIndex = 21;
            // 
            // textBoxFileNamePrefix
            // 
            textBoxFileNamePrefix.Location = new System.Drawing.Point(296, 7);
            textBoxFileNamePrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            textBoxFileNamePrefix.Name = "textBoxFileNamePrefix";
            textBoxFileNamePrefix.Size = new System.Drawing.Size(110, 20);
            textBoxFileNamePrefix.TabIndex = 23;
            // 
            // numericStartPage
            // 
            numericStartPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numericStartPage.Location = new System.Drawing.Point(451, 7);
            numericStartPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            numericStartPage.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericStartPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericStartPage.Name = "numericStartPage";
            numericStartPage.Size = new System.Drawing.Size(52, 20);
            numericStartPage.TabIndex = 24;
            numericStartPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericTotalPage
            // 
            numericTotalPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numericTotalPage.Location = new System.Drawing.Point(574, 7);
            numericTotalPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            numericTotalPage.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericTotalPage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericTotalPage.Name = "numericTotalPage";
            numericTotalPage.Size = new System.Drawing.Size(52, 20);
            numericTotalPage.TabIndex = 26;
            numericTotalPage.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(609, 9);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 13);
            label5.TabIndex = 27;
            label5.Text = "Capture Pos:";
            // 
            // labelCapturePos
            // 
            labelCapturePos.AutoSize = true;
            labelCapturePos.Location = new System.Drawing.Point(713, 9);
            labelCapturePos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelCapturePos.Name = "labelCapturePos";
            labelCapturePos.Size = new System.Drawing.Size(120, 13);
            labelCapturePos.TabIndex = 28;
            labelCapturePos.Text = "1024,1024 / 1024,1024";
            labelCapturePos.Click += labelCapturePos_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(885, 9);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(64, 13);
            label7.TabIndex = 30;
            label7.Text = "Click Pos:";
            // 
            // labelClickPos
            // 
            labelClickPos.AutoSize = true;
            labelClickPos.Location = new System.Drawing.Point(973, 9);
            labelClickPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelClickPos.Name = "labelClickPos";
            labelClickPos.Size = new System.Drawing.Size(58, 13);
            labelClickPos.TabIndex = 28;
            labelClickPos.Text = "1024,1024";
            // 
            // buttonStart
            // 
            buttonStart.Location = new System.Drawing.Point(1413, 4);
            buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(38, 21);
            buttonStart.TabIndex = 32;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(1034, 9);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(63, 13);
            label9.TabIndex = 33;
            label9.Text = "Wait Sec:";
            // 
            // numericWaitSecond
            // 
            numericWaitSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numericWaitSecond.Location = new System.Drawing.Point(1094, 7);
            numericWaitSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            numericWaitSecond.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericWaitSecond.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericWaitSecond.Name = "numericWaitSecond";
            numericWaitSecond.Size = new System.Drawing.Size(38, 20);
            numericWaitSecond.TabIndex = 34;
            numericWaitSecond.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // buttonStop
            // 
            buttonStop.Location = new System.Drawing.Point(1451, 3);
            buttonStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new System.Drawing.Size(38, 21);
            buttonStop.TabIndex = 35;
            buttonStop.Text = "Stop";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            labelStatus.Location = new System.Drawing.Point(1235, 10);
            labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(37, 13);
            labelStatus.TabIndex = 36;
            labelStatus.Text = "Status";
            labelStatus.Click += labelStatus_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new System.Drawing.Point(1491, 3);
            buttonExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(38, 21);
            buttonExit.TabIndex = 37;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button3_Click;
            // 
            // checkBoxCutLeftRight
            // 
            checkBoxCutLeftRight.AutoSize = true;
            checkBoxCutLeftRight.Location = new System.Drawing.Point(1139, 8);
            checkBoxCutLeftRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            checkBoxCutLeftRight.Name = "checkBoxCutLeftRight";
            checkBoxCutLeftRight.Size = new System.Drawing.Size(93, 17);
            checkBoxCutLeftRight.TabIndex = 38;
            checkBoxCutLeftRight.Text = "Cut Left/Right";
            checkBoxCutLeftRight.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(859, 6);
            pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(20, 20);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(835, 6);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(20, 20);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(951, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(20, 20);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(689, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(20, 20);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "PNG Image (*.png)|*.png";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save Image to";
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.Image = (System.Drawing.Image)resources.GetObject("pictureBoxMain.Image");
            pictureBoxMain.Location = new System.Drawing.Point(181, 6);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new System.Drawing.Size(20, 20);
            pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxMain.TabIndex = 19;
            pictureBoxMain.TabStop = false;
            pictureBoxMain.Click += pictureBoxMain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Location = new System.Drawing.Point(4, 9);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 13);
            label1.TabIndex = 20;
            label1.Text = "Save Folder:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(201, 9);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 13);
            label2.TabIndex = 22;
            label2.Text = "Filename Prefix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(409, 9);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(38, 13);
            label3.TabIndex = 22;
            label3.Text = "Start:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(511, 9);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 25;
            label4.Text = "Total:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1539, 32);
            ControlBox = false;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(checkBoxCutLeftRight);
            Controls.Add(buttonExit);
            Controls.Add(labelStatus);
            Controls.Add(buttonStop);
            Controls.Add(numericWaitSecond);
            Controls.Add(label9);
            Controls.Add(buttonStart);
            Controls.Add(pictureBox2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(labelClickPos);
            Controls.Add(labelCapturePos);
            Controls.Add(label5);
            Controls.Add(numericTotalPage);
            Controls.Add(label4);
            Controls.Add(numericStartPage);
            Controls.Add(textBoxFileNamePrefix);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxSaveFolder);
            Controls.Add(label1);
            Controls.Add(pictureBoxMain);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "eBook Screen Capture";
            TopMost = true;
            Load += Form1_Load;
            Move += Form1_Move;
            ((System.ComponentModel.ISupportInitialize)numericStartPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTotalPage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericWaitSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

