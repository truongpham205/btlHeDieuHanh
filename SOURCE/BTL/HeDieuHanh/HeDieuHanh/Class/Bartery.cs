using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeDieuHanh.Class
{
    class Bartery
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageBox(int hwnd, string lpText, string lpCaption, int wType);
        PowerStatus powerStatus = SystemInformation.PowerStatus;

        public static Bartery shared;
        public static Bartery getInstant()
        {
            if (shared == null)
            {
                shared = new Bartery();
            }
            return shared;
        }

        public int getBatteryLifePercent()
        {
            int capacityBatery = (int)(powerStatus.BatteryLifePercent * 100);
            return capacityBatery;
        }

        public string getBateryStatus()
        {
            string barteryStatus = "";
            switch (powerStatus.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    barteryStatus = "Dùng pin";
                    break;
                case PowerLineStatus.Online:
                    barteryStatus = "Đang sạc";
                    break;
                default:
                    barteryStatus = "Tình trạng không rõ";
                    break;
            }
            return barteryStatus;
        }

        public string getPercentBartery()
        {
            return ((int)(powerStatus.BatteryLifePercent * 100)).ToString() + "%";
        }
    }
}
