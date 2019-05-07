using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeDieuHanh.Class;

namespace HeDieuHanh.GUI
{
    public partial class ucUtilities : UserControl
    {
        public ucUtilities()
        {
            InitializeComponent();
        }

        public bool _runThread = true;

        private void ucUtilities_Load(object sender, EventArgs e)
        {
            setupForm();
            
        }

        void setupForm()
        {
            progressBarBartery.Maximum = 100;
            progressBarBartery.Minimum = 0;

            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 0;

            progressBarBartery.Value = Bartery.getInstant().getBatteryLifePercent();
            lblStatePin.Text = Bartery.getInstant().getBateryStatus();
            lblBatery.Text = Bartery.getInstant().getPercentBartery();
            lblInternet.Text = Network.getInstant().getStateInternet();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            Volume.getInstant().mute();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            setupForm();
        }
    }
}
