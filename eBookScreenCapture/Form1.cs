using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBookScreenCapture
{
    public partial class Form1 : Form
    {
        [DllImport("psapi.dll")]
        static extern int EmptyWorkingSet(IntPtr hProcess);

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                        int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }


        string ImageSaveFolder = "";
        string ImageSaveFilenamePrefix = "";
        int filenameStartDigit = 1;
        int filenameTotalClick = 1;
        int nextWaitSecond = 1;

        public int capturePointX1 = 0;
        public int capturePointY1 = 0;
        public int capturePointX2 = 0;
        public int capturePointY2 = 0;

        int captureClickPointX = 0;
        int captureClickPointY = 0;

        int lockThisX = 0;
        int lockThisY = 0;

        bool cutLeftRightPage = false;

        bool isProcessing = false;

        public bool isPreviewing = false;

        delegate void SetTextDelegate(Label l, string text);
        delegate void SetNumericUpDownDelegate(NumericUpDown l, int i);
        delegate void RefreshUIDelegate(Form l);

        delegate void SetButtonEnableCallback(Button x, bool enable);
        delegate void SetTextBoxEnableCallback(TextBox x, bool enable);
        delegate void SetCheckBoxEnableCallback(CheckBox x, bool enable);
        delegate void SetNumericUpDownEnableCallback(NumericUpDown x, bool enable);
        

        private System.Timers.Timer gcTimer;
        private System.Timers.Timer saveImageTimer;

        public Form1()
        {
            InitializeComponent();
            updatePositionText();

            SetLabel(labelStatus, "Ready to capture");

            gcTimer = new System.Timers.Timer();
            gcTimer.AutoReset = true;
            gcTimer.Interval = 60000;
            gcTimer.Elapsed += new System.Timers.ElapsedEventHandler(gcTimer_Elapsed);
            gcTimer.Enabled = true;
            gcTimer.Start();


            saveImageTimer = new System.Timers.Timer();
            saveImageTimer.AutoReset = false;
            saveImageTimer.Interval = 1000;
            saveImageTimer.Elapsed += new System.Timers.ElapsedEventHandler(saveImageTimer_Elapsed);
            saveImageTimer.Enabled = false;
            saveImageTimer.Stop();


        }

        private void SetLabel(Label l, string s)
        {

            if (l.InvokeRequired)
            {

                SetTextDelegate d = new SetTextDelegate(SetLabel);
                l.Invoke(d, new object[] { l, s });
            }
            else
            {

                l.Text = s;
            }
        }

        private void SetNumberic(NumericUpDown l, int s)
        {

            if (l.InvokeRequired)
            {

                SetNumericUpDownDelegate d = new SetNumericUpDownDelegate(SetNumberic);
                l.Invoke(d, new object[] { l, s });
            }
            else
            {

                l.Value = s;
            }
        }

        void setButtonEnable(Button x, bool enable)
        {


            if (x.InvokeRequired)
            {
                SetButtonEnableCallback d = new SetButtonEnableCallback(setButtonEnable);
                this.Invoke(d, new object[] { x, enable });
            }
            else
            {
                x.Enabled = enable;
            }
        }


        void setTextboxEnable(TextBox x, bool enable)
        {


            if (x.InvokeRequired)
            {
                SetTextBoxEnableCallback d = new SetTextBoxEnableCallback(setTextboxEnable);
                this.Invoke(d, new object[] { x, enable });
            }
            else
            {
                x.Enabled = enable;
            }
        }
        void setCheckboxEnable(CheckBox x, bool enable)
        {


            if (x.InvokeRequired)
            {
                SetCheckBoxEnableCallback d = new SetCheckBoxEnableCallback(setCheckboxEnable);
                this.Invoke(d, new object[] { x, enable });
            }
            else
            {
                x.Enabled = enable;
            }
        }
        void setNumericUpDownEnable(NumericUpDown x, bool enable)
        {


            if (x.InvokeRequired)
            {
                SetNumericUpDownEnableCallback d = new SetNumericUpDownEnableCallback(setNumericUpDownEnable);
                this.Invoke(d, new object[] { x, enable });
            }
            else
            {
                x.Enabled = enable;
            }
        }



        private void RefreshForm(Form l)
        {
            if (l.InvokeRequired)
            {

                RefreshUIDelegate d = new RefreshUIDelegate(RefreshForm);
                l.Invoke(d, new object[] { l });
            }
            else
            {

                l.Update();
            }
        }


        private void updatePositionText()
        {
            labelCapturePos.Text = capturePointX1 + "," + capturePointY1 + " / " + capturePointX2 + "," + capturePointY2;
            labelClickPos.Text = captureClickPointX + "," + captureClickPointY;
            this.Refresh();
        }
        public void setCpautrePosition(int x1, int y1, int x2, int y2)
        {
            capturePointX1 = x1;
            capturePointY1 = y1;
            capturePointX2 = x2;
            capturePointY2 = y2;
        }

        public void setClickPosition(int x1, int y1)
        {
            captureClickPointX = x1;
            captureClickPointY = y1;
        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            selectDirectoryBox(textBoxSaveFolder);
        }

        private void selectDirectoryBox(TextBox _textbox)
        {
            if (_textbox.Text != "")
            {
                folderBrowserDialog1.SelectedPath = _textbox.Text;
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                _textbox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                GetPositionFullScreen fscreen = new GetPositionFullScreen(this,false);
                fscreen.setCaptureMode(1);
                fscreen.ShowDialog();
                updatePositionText();
                isPreviewing = false;
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                GetPositionFullScreen fscreen = new GetPositionFullScreen(this,false);
                fscreen.setCaptureMode(2);
                fscreen.ShowDialog();
                updatePositionText();
                isPreviewing = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = Screen.FromControl(this).Bounds.Width - this.Width;
            this.Left = (int)Math.Round((double) x / 2);
            this.Top = 0;
            buttonStop.Enabled = false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (textBoxSaveFolder.Text == "")
            {
                MessageBox.Show("Please set Folder.");
            }
            else if (!Directory.Exists(textBoxSaveFolder.Text))
            {
                MessageBox.Show("Folder not exist.");
            }
            else if (textBoxFileNamePrefix.Text == "")
            {
                MessageBox.Show("Please set filename.");
            }
            else if (numericStartPage.Value <= 0)
            {
                MessageBox.Show("Please set start number.");
            }
            else if (numericTotalPage.Value <= 0)
            {
                MessageBox.Show("Please set end number.");
            }
            else if (numericTotalPage.Value < numericStartPage.Value)
            {
                MessageBox.Show("Please set end number.");
            }
            else if (numericWaitSecond.Value <= 0)
            {
                MessageBox.Show("Please set wait time.");
            }
            else if (capturePointX1 == 0 && capturePointY1 == 0)
            {
                MessageBox.Show("Please set capture position.");
            }
            else if (capturePointX2 == 0 && capturePointY2 == 0)
            {
                MessageBox.Show("Please set capture position.");
            }
            else if (captureClickPointX == 0 && captureClickPointY == 0)
            {
                MessageBox.Show("Please set click position.");
            }
            else
            {

                isProcessing = true;

                ImageSaveFolder = textBoxSaveFolder.Text;
                ImageSaveFilenamePrefix = textBoxFileNamePrefix.Text;
                filenameStartDigit = (int)numericStartPage.Value;
                filenameTotalClick = (int)numericTotalPage.Value;
                nextWaitSecond = (int)numericWaitSecond.Value;
                cutLeftRightPage = checkBoxCutLeftRight.Checked;


                lockThisX = Left;
                lockThisY = Top;
                
                textBoxSaveFolder.Enabled = false;
                textBoxFileNamePrefix.Enabled = false;
                numericStartPage.Enabled = false;
                numericTotalPage.Enabled = false;
                numericWaitSecond.Enabled = false;

                buttonStop.Enabled = true;
                buttonStart.Enabled = false;
                buttonExit.Enabled = false;
                checkBoxCutLeftRight.Enabled = false;
               

                SetLabel(labelStatus, "Start Processing..");


                saveImageTimer.Interval = 1000;
                saveImageTimer.Enabled = true;
                saveImageTimer.Start();

            }
          }

            private void Form1_Move(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                this.Left = lockThisX;
                this.Top = lockThisY;
            }
        }
        


        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (isProcessing)
            {
                isProcessing = false;
                saveImageTimer.Stop();
            }
            isProcessing = false;
            textBoxSaveFolder.Enabled = true;
            textBoxFileNamePrefix.Enabled = true;
            numericStartPage.Enabled = true;
            numericTotalPage.Enabled = true;
            numericWaitSecond.Enabled = true;

            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            buttonExit.Enabled = true;
            checkBoxCutLeftRight.Enabled = true;

            SetLabel(labelStatus, "Process stopped by user.");
        }

        private void ClearMemory()
        {
            GC.Collect(GC.MaxGeneration);
            IntPtr hThisProcess = Process.GetCurrentProcess().Handle;
            EmptyWorkingSet(hThisProcess);
        }


        private void gcTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ClearMemory();
        }

        private void leftClick(Point p)
        {
            Cursor.Position = p;
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
        }

        private void saveImageTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (isProcessing)
            {
                SetLabel(labelStatus, "Capturing (" + filenameStartDigit + "/" + filenameTotalClick + ") .. ");
                

                string positionfilenametext = "[" + capturePointX1 + "," + capturePointY1 + "x" + capturePointX2 + "," + capturePointY2 + "]";

                if (cutLeftRightPage)
                {

                    // not done

                    Bitmap captureBitmap = new Bitmap(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1, PixelFormat.Format32bppArgb);
                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                    Size capSize = new Size(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1);
                    captureGraphics.CopyFromScreen(capturePointX1, capturePointY1, 0, 0, capSize);

                    string savingpath = ImageSaveFolder + "\\" + ImageSaveFilenamePrefix + positionfilenametext + filenameStartDigit.ToString("D4") + ".png";

                    SetLabel(labelStatus, "Saving (" + filenameStartDigit + "/" + filenameTotalClick + ") .. ");

                    captureBitmap.Save(savingpath, ImageFormat.Png);

                } else
                {
                    Bitmap captureBitmap = new Bitmap(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1, PixelFormat.Format32bppArgb);
                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                    Size capSize = new Size(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1);
                    captureGraphics.CopyFromScreen(capturePointX1, capturePointY1, 0, 0, capSize);

                    string savingpath = ImageSaveFolder + "\\" + ImageSaveFilenamePrefix + positionfilenametext + filenameStartDigit.ToString("D4") + ".png";

                    SetLabel(labelStatus, "Saving (" + filenameStartDigit + "/" + filenameTotalClick + ") .. ");

                    captureBitmap.Save(savingpath, ImageFormat.Png);

                }


                if (filenameStartDigit >= filenameTotalClick)
                {
                    isProcessing = false;

                    // change button status

                    setTextboxEnable(textBoxSaveFolder, true);
                    setTextboxEnable(textBoxFileNamePrefix, true);
                    setNumericUpDownEnable(numericStartPage, true);
                    setNumericUpDownEnable(numericTotalPage, true);
                    setNumericUpDownEnable(numericWaitSecond, true);
                    setButtonEnable(buttonStop, false);
                    setButtonEnable(buttonStart, true);
                    setButtonEnable(buttonExit, true);
                    setCheckboxEnable(checkBoxCutLeftRight, true);

                    SetLabel(labelStatus, "Finish..");
                    saveImageTimer.Enabled = false;
                    saveImageTimer.Stop();
                } else
                {
                    filenameStartDigit++;
                    SetNumberic(numericStartPage, filenameStartDigit);

                    SetLabel(labelStatus, "Click to next page..");

                    Point nowpos = Cursor.Position;

                    Point p = new Point(captureClickPointX, captureClickPointY);
                    leftClick( p);

                    Cursor.Position = nowpos;


                    saveImageTimer.Interval = nextWaitSecond * 1000;

                    SetLabel(labelStatus, "Wait "+ nextWaitSecond + " seconds..  (" + filenameStartDigit + "/" + filenameTotalClick + ")");

                    saveImageTimer.Start();

                }

                
            }

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
            DebugWin d = new DebugWin();
            d.ShowDialog();
        }

        private void labelCapturePos_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                if (!isPreviewing)
                {
                    GetPositionFullScreen fscreen = new GetPositionFullScreen(this, true);
                    fscreen.updateViewPosition(capturePointX1, capturePointY1, capturePointX2, capturePointY2);
                    fscreen.TopMost = false;
                    fscreen.Show();
                    fscreen.initUpdateScreen();

                    CustomCapturePosWin custScreen = new CustomCapturePosWin(this, fscreen);
                    custScreen.ShowDialog();
                    fscreen.Close();
                    updatePositionText();
                    isPreviewing = false;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                if (capturePointX1 == 0 && capturePointY1 == 0)
                {
                    SetLabel(labelStatus, "Please set capture position.");
                }
                else if (capturePointX2 == 0 && capturePointY2 == 0)
                {
                    SetLabel(labelStatus, "Please set capture position.");
                }
                else
                {
                    SetLabel(labelStatus, "Capturing.. ");




                    Bitmap captureBitmap = new Bitmap(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1, PixelFormat.Format32bppArgb);
                    Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
                    Graphics captureGraphics = Graphics.FromImage(captureBitmap);
                    Size capSize = new Size(capturePointX2 - capturePointX1, capturePointY2 - capturePointY1);
                    captureGraphics.CopyFromScreen(capturePointX1, capturePointY1, 0, 0, capSize);


                    ImageSaveFolder = textBoxSaveFolder.Text;
                    ImageSaveFilenamePrefix = textBoxFileNamePrefix.Text;

                    saveFileDialog1.InitialDirectory = ImageSaveFolder;
                    saveFileDialog1.FileName = ImageSaveFilenamePrefix;


                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {


                        string savingpath = saveFileDialog1.FileName;
                        SetLabel(labelStatus, "Saving .. ");

                        captureBitmap.Save(savingpath, ImageFormat.Png);

                        SetLabel(labelStatus, "Saving Done.. ");
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!isProcessing)
            {
                if (!isPreviewing)
                {
                    GetPositionFullScreen fscreen = new GetPositionFullScreen(this, true);
                    fscreen.updateViewPosition(capturePointX1, capturePointY1, capturePointX2, capturePointY2);
//                    fscreen.TopMost = false;
                    fscreen.ShowDialog();
                    fscreen.initUpdateScreen();
                    isPreviewing = false;
                }
            }
        }
    }
}
