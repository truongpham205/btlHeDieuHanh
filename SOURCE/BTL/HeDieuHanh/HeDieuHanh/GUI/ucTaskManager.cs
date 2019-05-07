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
using System.Diagnostics;

namespace HeDieuHanh.GUI
{
    public partial class ucTaskManager : UserControl
    {
        private static int columnclickcount = 0;
        private static int selectedprocess;

        Process[] listProcess = new Process[1000];

        public ucTaskManager()
        {
            InitializeComponent();
        }

        private void ucTaskManager_Load(object sender, EventArgs e)
        {
            setupUC();
            //showProcessList();
        }

        void setupUC()
        {
            lvProcess.Columns.Add("Name");
            lvProcess.Columns.Add("Process ID");
            lvProcess.Columns.Add("Username");
            lvProcess.Columns.Add("Memory usage");

            lvProcess.Columns[0].Width = 127;
            lvProcess.Columns[1].Width = 80;
            lvProcess.Columns[2].Width = 80;
            lvProcess.Columns[3].Width = 127;
            showProcessList();
        }

        void showProcessList()
        {
            Process[] listProcess = Process.GetProcesses();
            foreach (Process process in listProcess)
            {
                ListViewItem item = new ListViewItem();
                double memory = process.WorkingSet64 / 1024.0;

                item.Text = process.ProcessName;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = process.Id.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Environment.MachineName.ToString() });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = memory.ToString() + " KB" });
                lvProcess.Items.Add(item);
            }
        }

        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            Process be_terminated = Process.GetProcessById(selectedprocess);

            string messages = "Do you want to end " + be_terminated.ProcessName + ".exe?";
            string caption = "Alert";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(messages, caption, buttons);
            if (result == DialogResult.Yes)
            {
                TaskManager.getInstant().endProcess(be_terminated);
            }
        }

        private void lvProcess_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            selectedprocess = Int32.Parse(lvProcess.SelectedItems[0].SubItems[1].Text);
        }

        private void lvProcess_Click(object sender, EventArgs e)
        {

        }
    }
}
