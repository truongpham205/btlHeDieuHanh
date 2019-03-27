using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeDieuHanh.Class
{
    class Network
    {
        public static Network shared;
        public static Network getInstant()
        {
            if (shared == null)
            {
                shared = new Network();
            }
            return shared;
        }
    }
}
