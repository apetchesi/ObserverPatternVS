using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternVS
{
    class SpeedMonitor
    {
        public const int SPEED_TO_ALERT = 70;

        public SpeedMonitor(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(Object sender, EventArgs e)
        {
            Speedometer speedo = (Speedometer)sender;
            if (speedo.CurrentSpeed > SPEED_TO_ALERT)
            {
                Console.WriteLine("** ALERT ** Driving too fast! ("
                                        + speedo.CurrentSpeed + ")");

            }
            else
            {
                Console.WriteLine("... nice and steady ... ("
                                        + speedo.CurrentSpeed + ")");
            }
        }
    }
}
