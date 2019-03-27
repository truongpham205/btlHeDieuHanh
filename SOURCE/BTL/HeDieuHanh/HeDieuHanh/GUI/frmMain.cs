using HeDieuHanh.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setupForm();
            displayStatusBatery();
        }

        void setupForm()
        {
            progressBarBartery.Maximum = 100;
            progressBarBartery.Minimum = 0;

            trackBarVolume.Maximum = 100;
            trackBarVolume.Minimum = 0;
        }

        void displayStatusBatery()
        {  
            progressBarBartery.Value = Bartery.getInstant().getBatteryLifePercent();
            //progressBarBartery.ResetTe
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {

        }

        private void btnMusic_Click(object sender, EventArgs e)
        {

        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }
    }
}
