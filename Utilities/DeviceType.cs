using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace Utilities
{
    public class DeviceType
    {
        public int Nsensor { get; set; }
        public string TypeSensor { get; set; }
        //private attribute
        List<string> _contents = null;
        //private attribute
        List<Sensor> _sensors;

        public DeviceType (ReadConfig c)
        {
            Nsensor = c.Nsensor;
            TypeSensor = c.TypeSensor;
            _sensors = new List<Sensor>();
            _contents = new List<string>();
            _contents = c.Function;
        }

        public void Print()
        {
            Console.WriteLine($"The type is a : {TypeSensor} and it has : {Nsensor} sensors");
            
            foreach (Sensor sensor in _sensors)
            {
                foreach (var result in sensor.Result)
                {
                    Console.WriteLine($"{result.Key} : {result.Value}");
                }
            }
        }

        public void Start()
        {
            for (int i = 0; i < Nsensor; i += 1)
            {
                _sensors.Add(new Sensor(_contents));
            }
        }
    }
}
