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
    public partial class frmPowerStatus : Form
    {
        Point mouseDownPoint = Point.Empty;

        public frmPowerStatus()
        {
            InitializeComponent();
        }

        private void tmrPower_Tick(object sender, EventArgs e)
        {
            string powerPercent = Math.Round(SystemInformation.PowerStatus.BatteryLifePercent * 100, MidpointRounding.AwayFromZero).ToString() + "%";
        }
    }
}
