using System;
using Utilities;

namespace IOT_App
{
    /*enum non utilizza siccome era una bozza
    enum SelectPath
    {
        path1 = 1, //select path1 entry sensor
        path2 = 2, //select path2 pro1 sensor
        path3 = 3, //select path3 pro2 sensor
        path4 = 4  //select path4 super sensor
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SelectPath path = SelectPath.path1;

            switch (path)
            {
                case SelectPath.path1:
                    ReadConfig c1 = new ReadConfig();
                    c1 = c1.ReadConfiguration(path1);
                    break;
                case SelectPath.path2:
                    break;
                case SelectPath.path3:
                    break;
                case SelectPath.path4:
                    break;
                default:
                    break;
            }*/

            //i file contengono la seguente sintassi:
            //nome device
            //numero sensori
            //funzioni da calcolare 1
            //funzione da calcolare 2
            //funzione da calcolare 3

            string path1 = @"C:\Users\federico.cassera\Desktop\.net example\IOT_App\Config\Config_entry.txt";
            string path2 = @"C:\Users\federico.cassera\Desktop\.net example\IOT_App\Config\Config_pro1.txt";
            string path3 = @"C:\Users\federico.cassera\Desktop\.net example\IOT_App\Config\Config_pro2.txt";
            string path4 = @"C:\Users\federico.cassera\Desktop\.net example\IOT_App\Config\Config_super.txt";

            //creo opggetto ReadConfig
            //per selezionare un determinato tipo di sensore bisogna cambiare il path
            //passato come parametro nell'oggetto c1
            ReadConfig c1 = new ReadConfig();
            c1 = c1.ReadConfiguration(path1);

            DeviceType d1 = new DeviceType(c1);
            
            d1.Start();
            d1.Print();

        }
    }
}
