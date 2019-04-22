using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh.Class
{
    class TaskManager
    {
        public static TaskManager shared;
        public static TaskManager getInstant()
        {
            if (shared == null)
            {
                shared = new TaskManager();
            }
            return shared;
        }

        Process[] listProcess = Process.GetProcesses();

        public Process[] getListProcess()
        {
            return listProcess;
        }

        public void endProcess(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }
    }
}
