using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
