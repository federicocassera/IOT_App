using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Sensor
    {
        private Dictionary<string, int> _results;
        public Dictionary<string, int> Result { get { return _results; } }

        private List<string> _Types;

        public Sensor(List<string> input)
        {
            _Types = new List<string>(input);
            _results = new Dictionary<string, int>();
            Misure();
        }
        public void Misure()
        {
            foreach (string type in _Types)
            {
                var rand = new Random();
                int number = rand.Next(1, 50);
                _results.Add(type, number);
            }
        }        
    }
}
