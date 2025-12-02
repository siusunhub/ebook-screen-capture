using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBookScreenCapture
{
    public partial class CustomCapturePosWin : Form
    {
        Form1 sourceForm;
        GetPositionFullScreen fullScreenForm;

        bool isInit = false;

       
        public CustomCapturePosWin(Form1 sform, GetPositionFullScreen fForm)
        {
            InitializeComponent();
            this.sourceForm = sform;
            this.fullScreenForm = fForm;

            isInit = true;

            labelOrgSize.Text = sform.capturePointX1 + "," + sform.capturePointY1 + " / " + sform.capturePointX2 + "," + sform.capturePointY2;

            numericUpDownX1.Minimum = 0;
            numericUpDownX1.Maximum = Screen.FromControl(this).Bounds.Width;
            numericUpDownX2.Minimum = 0;
            numericUpDownX2.Maximum = Screen.FromControl(this).Bounds.Width;


            numericUpDownY1.Minimum = 0;
            numericUpDownY1.Maximum = Screen.FromControl(this).Bounds.Height;
            numericUpDownY2.Minimum = 0;
            numericUpDownY2.Maximum = Screen.FromControl(this).Bounds.Height;


            numericUpDownX1.Value = sform.capturePointX1;
            numericUpDownY1.Value = sform.capturePointY1;
            numericUpDownX2.Value = sform.capturePointX2;
            numericUpDownY2.Value = sform.capturePointY2;

            updateUpDownMaxValue();

            isInit = false;
        }

        private void updateUpDownMaxValue()
        {

            //reset to init
            numericUpDownX1.Minimum = 0;
            numericUpDownX1.Maximum = Screen.FromControl(this).Bounds.Width;
            numericUpDownX2.Minimum = 0;
            numericUpDownX2.Maximum = Screen.FromControl(this).Bounds.Width;


            numericUpDownY1.Minimum = 0;
            numericUpDownY1.Maximum = Screen.FromControl(this).Bounds.Height;
            numericUpDownY2.Minimum = 0;
            numericUpDownY2.Maximum = Screen.FromControl(this).Bounds.Height;

        }

        private void CustomCapturePosWin_Load(object sender, EventArgs e)
        {
            int x = Screen.FromControl(this).Bounds.Width - this.Width;
            this.Left = (int)Math.Round((double)x / 2);
            this.Top = sourceForm.Top + sourceForm.Height + 5;

            fullScreenForm.updateViewPosition((int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
            fullScreenForm.forceUpdaetScreen();
            updateSavedSize();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (numericUpDownY2.Value <= numericUpDownY1.Value || numericUpDownX2.Value <= numericUpDownX1.Value)
            {
                MessageBox.Show("Size Incorrect");
            } else
            {
                sourceForm.setCpautrePosition((int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
                this.Close();
            }

            
        }

        private void updateSavedSize()
        {
            
                  if (numericUpDownY2.Value > numericUpDownY1.Value && numericUpDownX2.Value > numericUpDownX1.Value)
            
            {
                int _width = (int)numericUpDownX2.Value - (int)numericUpDownX1.Value;
                int _height = (int)numericUpDownY2.Value - (int)numericUpDownY1.Value;
                labelSaveSize.Text = _width + " x " + _height;
            }
            
        }

        private void valueChangedAction()
        {
            if (!isInit)
            {
                updateUpDownMaxValue();
                fullScreenForm.updateViewPosition((int)numericUpDownX1.Value, (int)numericUpDownY1.Value, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value);
                updateSavedSize();
            }
        }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            valueChangedAction();
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            valueChangedAction();
        }

        private void numericUpDownX2_ValueChanged(object sender, EventArgs e)
        {
            valueChangedAction();
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            valueChangedAction();

        }
    }
}
