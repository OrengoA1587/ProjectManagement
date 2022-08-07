using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public  class TimerWatch
    {
        private bool _timerEnd;

        public TimerWatch()
        {
            TimerEnd = false;
        }
        public TimerWatch(bool timerEnd)
        {
            TimerEnd = timerEnd;
        }

        public bool TimerEnd
        {
            get
            {
                return _timerEnd;
            }
            set
            {
                _timerEnd = value;
            }
        }
    }
}
