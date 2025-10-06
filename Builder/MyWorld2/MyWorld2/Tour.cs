using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld2
{
    class Tour
    {
        private string _tourType;
        private Dictionary<string, string> _parts =
            new Dictionary<string, string>();

        public Tour(string tourType)
        {
            _tourType = tourType;
        }

        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("Tour Type: {0}", _tourType);
            Console.WriteLine(" Flight    : {0}", _parts["flight"]);
            Console.WriteLine(" Hotel     : {0}", _parts["hotel"]);
            Console.WriteLine(" Meals     : {0}", _parts["meals"]);
            Console.WriteLine(" Activities: {0}", _parts["activities"]);
        }
    }
}
