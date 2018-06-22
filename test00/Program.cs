using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test00.testservice;
using TestWeather;

namespace test00
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceClient cl = new ServiceClient();

            // string name = cl.Get("Weather", "Name").Message.ToString();
            GenericObject fc = cl.Get("Weather", "OneDay");




            // Console.WriteLine(name + "\n-------------------\n");
            //Console.WriteLine(fc);
            //Console.WriteLine(fc.Date);
            //Console.WriteLine(fc.Wind);
            //Console.WriteLine(fc.Temperature);
            Console.ReadLine();

        }
    }
}
