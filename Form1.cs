using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerStatus
{
    public partial class Form1 : Form
    {
        Point mouseDownPoint = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrPower_Tick(object sender, EventArgs e)
        {
            label1.Text = Math.Round(SystemInformation.PowerStatus.BatteryLifePercent * 100, MidpointRounding.AwayFromZero).ToString() + "%";
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDownPoint = Point.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownPoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mouseDownPoint.X), f.Location.Y + (e.Y - mouseDownPoint.Y));
        }
    }
}
