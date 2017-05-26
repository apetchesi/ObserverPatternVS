using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternVS
{
    class AutomaticGearbox
    {
        public AutomaticGearbox(Speedometer speedo)
        {
            speedo.ValueChanged += ValueHasChanged;
        }

        private void ValueHasChanged(Object sender, EventArgs e)
        {
            Speedometer speedo = (Speedometer)sender;

         

            if (speedo.CurrentSpeed <= 10)
            {
                Console.WriteLine("Now in first gear");

            }
            else if (speedo.CurrentSpeed <= 20)
            {
                Console.WriteLine("Now in second gear");

            }
            else if (speedo.CurrentSpeed <= 30)
            {
                Console.WriteLine("Now in third gear");

            }
            else
            {
                Console.WriteLine("Now in fourth gear");
            }
        }
    }
}
