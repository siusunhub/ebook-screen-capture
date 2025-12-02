using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eBookScreenCapture
{
    public partial class GetPositionFullScreen : Form
    {
        int capturePointLeftX = 0;
        int capturePointLeftY = 0;

        bool viewOnly = false;

        int captureMode = 0;
        int step = 0;

        Form1 sourceForm;

        int currentMousePositionX = 0;
        int currentMousePositionY = 0;

        int screenBoundX = 0;
        int screenBoundY = 0;

        Graphics g;

        Color FormBGColour = Color.White;

        private System.Timers.Timer gcTimer;

        int forceUpdateScreenCount = 0;

        public GetPositionFullScreen(Form1 sform ,bool viewO)
        {
            InitializeComponent();
            
            DoubleBuffered = true;

            sourceForm = sform;

            viewOnly = viewO;

            this.Top = 0;
            this.Left = 0;
            int x = Screen.FromControl(this).Bounds.Width;
            int y = Screen.FromControl(this).Bounds.Height;
            this.Size = new Size(x, y);
            this.BackColor = FormBGColour;
            this.Opacity = 0.2;
//            this.TransparencyKey = Color.White;

            g = this.CreateGraphics();

            screenBoundX = x;
            screenBoundY = y;

            
                sourceForm.isPreviewing = true;

                gcTimer = new System.Timers.Timer();
                gcTimer.AutoReset = false;
                gcTimer.Interval = 100;
                gcTimer.Elapsed += new System.Timers.ElapsedEventHandler(gcTimer_Elapsed);
                gcTimer.Enabled = true;
            

        }

        private void gcTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            showMousePositionText();
            forceUpdateScreenCount++;
            if (forceUpdateScreenCount < 5)
            {
                gcTimer.Start();
            } else
            {
                forceUpdateScreenCount = 0;
            }
        }


        public void forceUpdaetScreen()
        {
            gcTimer.Start();

        }

        public void setCaptureMode(int m)
        {
            if (!viewOnly)
            {
                captureMode = m;
            }
        }

        private void updateNowMousePos()
        {
            if (!viewOnly)
            {
                currentMousePositionX = MousePosition.X;
                currentMousePositionY = MousePosition.Y;
            }
        }

        public void closePreview()
        {
            sourceForm.isPreviewing = false;
            this.Close();
        }


      
        public void updateViewPosition(int x1 , int y1, int x2, int y2 )
        {
            capturePointLeftX = x1;
            capturePointLeftY = y1;
            currentMousePositionX = x2;
            currentMousePositionY = y2;
            showMousePositionText();
        }

        public void initUpdateScreen()
        {
            gcTimer.Start();
            
        }

        private void GetPositionFullScreen_MouseClick(object sender, MouseEventArgs e)
        {
            if (!viewOnly)
            {
                updateNowMousePos();

                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if ((captureMode == 0 || captureMode == 1) && step == 1)
                    {
                        step = 0;
                    }
                    else if (((captureMode == 0 || captureMode == 1) && step == 0) || captureMode == 2)
                    {
                        sourceForm.isPreviewing = false;
                        this.Close();
                    }
                }
                else
                {
                    if (captureMode == 0 || captureMode == 1)
                    {
                        if (step == 0)
                        {
                            capturePointLeftX = currentMousePositionX;
                            capturePointLeftY = currentMousePositionY;
                            step = 1;
                        }
                        else
                        {

                            if (currentMousePositionX < capturePointLeftX || currentMousePositionY < capturePointLeftY)
                            {
                            }
                            else
                            {
                                sourceForm.setCpautrePosition(capturePointLeftX, capturePointLeftY, currentMousePositionX, currentMousePositionY);
                                this.Close();
                            }


                        }

                    }
                    if (captureMode == 2)
                    {
                        sourceForm.setClickPosition(currentMousePositionX, currentMousePositionY);
                        sourceForm.isPreviewing = false;
                        this.Close();
                    }
                }
            } else
            {
                sourceForm.isPreviewing = false;
                this.Close();
            }
        }

        private void GetPositionFullScreen_MouseMove(object sender, MouseEventArgs e)
        {

            if (!viewOnly) showMousePositionText();
            
        }


        private void showMousePositionText()
        {
            if (!viewOnly)
            {
                updateNowMousePos();
                bool showtext = false;

                try
                {
                    if (captureMode == 0 || captureMode == 1)
                    {

                        if (step == 1)
                        {
                            if (currentMousePositionX < capturePointLeftX || currentMousePositionY < capturePointLeftY)
                            {

                            }
                            else
                            {
                                showtext = true;
                            }
                        }
                        else
                        {
                            showtext = true;
                        }

                    }
                    else
                    {
                        showtext = true;
                    }

                    if (showtext)
                    {
                        labelPosition.Text = "(" + currentMousePositionX + "," + currentMousePositionY + ")";
                        labelPosition.Location = new Point(currentMousePositionX + 15, currentMousePositionY + 5);

                        if (captureMode == 0 || captureMode == 1)
                        {


                            g.Clear(FormBGColour);

                            Color black = Color.FromArgb(255, 0, 0, 0);
                            Pen blackPen = new Pen(black, 2);

                            if (step == 0)
                            {

                                g.DrawLine(blackPen, 0, currentMousePositionY, screenBoundX, currentMousePositionY);
                                g.DrawLine(blackPen, currentMousePositionX, 0, currentMousePositionX, screenBoundY);
                            }

                            if (step == 1)
                            {


                                g.DrawRectangle(blackPen, capturePointLeftX, capturePointLeftY, currentMousePositionX - capturePointLeftX, currentMousePositionY - capturePointLeftY);

                                int halfPosX = (int)(currentMousePositionX - capturePointLeftX) / 2 + capturePointLeftX;


                                g.DrawLine(blackPen, halfPosX, capturePointLeftY, halfPosX, currentMousePositionY);


                            }

                            g.Flush();

                        }

                    }
                    else
                    {
                        labelPosition.Text = "";

                    }
                } catch (Exception e)
                {

                }
            } else
            {
                try
                {

                    g.Clear(FormBGColour);

                    Color black = Color.FromArgb(255, 0, 0, 0);
                    Pen blackPen = new Pen(black, 2);

                    g.DrawRectangle(blackPen, capturePointLeftX, capturePointLeftY, currentMousePositionX - capturePointLeftX, currentMousePositionY - capturePointLeftY);

                    int halfPosX = (int)(currentMousePositionX - capturePointLeftX) / 2 + capturePointLeftX;

                    g.DrawLine(blackPen, halfPosX, capturePointLeftY, halfPosX, currentMousePositionY);
                    g.Flush();
                } catch (Exception e) 
                {

                }

            }
        }
    }
}
