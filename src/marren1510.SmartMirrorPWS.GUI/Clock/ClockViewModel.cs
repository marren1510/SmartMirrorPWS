using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marren1510.SmartMirrorPWS.GUI.Clock
{
     public class ClockViewModel : PropertyChangedBase
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
            CurrentTime = $"{model.CurrentTime.ToString("HH:mm:ss" + Environment.NewLine + "dd-MM-yyyy") }"; 
        } 

     
    }
}
