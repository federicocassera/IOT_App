using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class ReadConfig
    {
        public int Nsensor { get; set; }
        public string TypeSensor { get; set; }
        public List<string> Function { get; set; }
        
        private static ReadConfig _config;

        public ReadConfig()
        {
            Function = new List<string>();  
        }

        public static ReadConfig DoConfiguration
        {
            get
            {
                if (_config == null)
                {
                    _config = new ReadConfig();
                }
                return _config;
            }
        }

        public ReadConfig ReadConfiguration(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                DoConfiguration.TypeSensor = sr.ReadLine();
                DoConfiguration.Nsensor = int.Parse(sr.ReadLine());
                DoConfiguration.Function = sr.ReadToEnd().Split(Environment.NewLine).ToList();
            }
            return _config;
        }
    }
}
