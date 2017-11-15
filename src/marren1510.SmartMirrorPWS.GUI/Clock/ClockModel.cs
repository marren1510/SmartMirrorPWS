using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marren1510.SmartMirrorPWS.GUI.Clock
{
    class ClockModel : BaseModel
    {
        DateTime currentTime;
        public DateTime CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged("CurrentTime");
                }

            }
        }


        public override TimeSpan Interval => TimeSpan.FromSeconds(1) ;

        public override void Update()
        {
            CurrentTime = DateTime.Now;
        }
    }
}
