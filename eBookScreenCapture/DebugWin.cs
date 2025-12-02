using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace eBookScreenCapture
{
    public partial class DebugWin : Form
    {
        public DebugWin()
        {
            InitializeComponent();

            callData();
        }

        public static int returnScrenDPI()
        {
            return (int)(100 * Screen.PrimaryScreen.Bounds.Width / SystemParameters.PrimaryScreenWidth); ;
        }

        private void callData()
        {
            int ScreenDPI = returnScrenDPI();

            int screenbx = Screen.FromControl(this).Bounds.Width;
            int screenby = Screen.FromControl(this).Bounds.Height;

            string outputdate = "Screen DPI:" + ScreenDPI + "\r\n" +
                "Screen Resulation:" + screenbx + " x " + screenby;
                


            textBox1.Text = outputdate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            callData();
        }
    }
}
