namespace eBookScreenCapture
{
    partial class CustomCapturePosWin
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
            label2 = new System.Windows.Forms.Label();
            numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            labelOrgSize = new System.Windows.Forms.Label();
            labelSaveSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(11, 9);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 13);
            label2.TabIndex = 21;
            label2.Text = "New Size:";
            // 
            // numericUpDownX1
            // 
            numericUpDownX1.Location = new System.Drawing.Point(80, 7);
            numericUpDownX1.Name = "numericUpDownX1";
            numericUpDownX1.Size = new System.Drawing.Size(63, 20);
            numericUpDownX1.TabIndex = 22;
            numericUpDownX1.ValueChanged += numericUpDownX1_ValueChanged;
            // 
            // numericUpDownY1
            // 
            numericUpDownY1.Location = new System.Drawing.Point(155, 7);
            numericUpDownY1.Name = "numericUpDownY1";
            numericUpDownY1.Size = new System.Drawing.Size(63, 20);
            numericUpDownY1.TabIndex = 23;
            numericUpDownY1.ValueChanged += numericUpDownY1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(230, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 13);
            label1.TabIndex = 24;
            label1.Text = "X";
            // 
            // numericUpDownY2
            // 
            numericUpDownY2.Location = new System.Drawing.Point(331, 7);
            numericUpDownY2.Name = "numericUpDownY2";
            numericUpDownY2.Size = new System.Drawing.Size(63, 20);
            numericUpDownY2.TabIndex = 26;
            numericUpDownY2.ValueChanged += numericUpDownY2_ValueChanged;
            // 
            // numericUpDownX2
            // 
            numericUpDownX2.Location = new System.Drawing.Point(256, 7);
            numericUpDownX2.Name = "numericUpDownX2";
            numericUpDownX2.Size = new System.Drawing.Size(63, 20);
            numericUpDownX2.TabIndex = 25;
            numericUpDownX2.ValueChanged += numericUpDownX2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(403, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(64, 23);
            button1.TabIndex = 27;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(585, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 13);
            label3.TabIndex = 28;
            label3.Text = "Original Size:";
            // 
            // labelOrgSize
            // 
            labelOrgSize.AutoSize = true;
            labelOrgSize.Location = new System.Drawing.Point(671, 10);
            labelOrgSize.Name = "labelOrgSize";
            labelOrgSize.Size = new System.Drawing.Size(35, 13);
            labelOrgSize.TabIndex = 29;
            labelOrgSize.Text = "label4";
            // 
            // labelSaveSize
            // 
            labelSaveSize.AutoSize = true;
            labelSaveSize.Location = new System.Drawing.Point(475, 10);
            labelSaveSize.Name = "labelSaveSize";
            labelSaveSize.Size = new System.Drawing.Size(35, 13);
            labelSaveSize.TabIndex = 30;
            labelSaveSize.Text = "label4";
            // 
            // CustomCapturePosWin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(811, 33);
            ControlBox = false;
            Controls.Add(labelSaveSize);
            Controls.Add(labelOrgSize);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(numericUpDownY2);
            Controls.Add(numericUpDownX2);
            Controls.Add(label1);
            Controls.Add(numericUpDownY1);
            Controls.Add(numericUpDownX1);
            Controls.Add(label2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomCapturePosWin";
            Text = "Custom Capture Size";
            TopMost = true;
            Load += CustomCapturePosWin_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOrgSize;
        private System.Windows.Forms.Label labelSaveSize;
    }
}