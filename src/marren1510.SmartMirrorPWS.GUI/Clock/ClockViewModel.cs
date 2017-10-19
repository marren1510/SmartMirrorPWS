using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace marren1510.SmartMirrorPWS.GUI.Clock
{
     public class ClockViewModel : INotifyPropertyChanged
    {
        private ClockModel model;
        private string currentTime;
        public string CurrentTime 
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

        internal void Initialize(ClockModel model)
        {
            this.model = model;
            UpdateTime();
        }

        private void UpdateTime()
        {
            CurrentTime = $"{model.CurrentTime.ToString("dd-MM-yy HH:mm")}"; 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void  NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
