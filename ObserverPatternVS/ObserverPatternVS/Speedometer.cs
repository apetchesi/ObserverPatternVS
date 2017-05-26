using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternVS
{
    class Speedometer
    {
        public event EventHandler ValueChanged;
        private int currentSpeed;

        public Speedometer()
        {
            currentSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                currentSpeed = value;

                // Tell all observers so they know value has changed...
                OnValueChanged();
            }
            get
            {
                return currentSpeed;
            }
        }

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, EventArgs.Empty);
            }
        }


    }
}
