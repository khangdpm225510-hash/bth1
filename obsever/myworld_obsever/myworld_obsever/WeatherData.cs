using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myworld_obsever
{
    public abstract class WeatherData
    {
        private double _temperature;
        private List<IDisplay> _displays = new List<IDisplay>();

        public WeatherData(double temp)
        {
            _temperature = temp;
        }

        public void Attach(IDisplay display)
        {
            _displays.Add(display);
        }

        public void Detach(IDisplay display)
        {
            _displays.Remove(display);
        }

        public void Notify()
        {
            foreach (IDisplay display in _displays)
            {
                display.Update(this);
            }
            Console.WriteLine();
        }

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                if (_temperature != value)
                {
                    _temperature = value;
                    Notify();
                }
            }
        }
    }
}
