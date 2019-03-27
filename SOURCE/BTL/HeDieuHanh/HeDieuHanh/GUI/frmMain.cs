using HeDieuHanh.Class;
using HeDieuHanh.GUI;
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
            //pnDisplay.Controls.Clear();
            //pnDisplay.Refresh();

            ucTaskManager ucTaskManager = new ucTaskManager();
            //pnDisplay.Controls.Add(ucTaskManager);
            //ucTaskManager.Dock = DockStyle.Fill;
            displayUcOnPanel(ucTaskManager);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            ucMusic ucMusic = new ucMusic();
            displayUcOnPanel(ucMusic);
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            Volume.getInstant().volumeUp();
        }

        void displayUcOnPanel(UserControl userControl)
        {
            pnDisplay.Controls.Clear();
            pnDisplay.Refresh();
            pnDisplay.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }
    }
}
