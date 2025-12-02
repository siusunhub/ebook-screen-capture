namespace eBookScreenCapture
{
    partial class GetPositionFullScreen
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
            this.labelPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(114, 107);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(51, 20);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "label1";
            // 
            // GetPositionFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetPositionFullScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GetPositionFullScreen";
            this.TopMost = true;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GetPositionFullScreen_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GetPositionFullScreen_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPosition;
    }
}