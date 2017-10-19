using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marren1510.SmartMirrorPWS.GUI.Clock
{
    class ClockModel
    {
        DateTime currenTime;
        public DateTime CurrentTime { get; set; }

        public void Update()
        {
            CurrentTime = DateTime.Now;
        }
    }
}
