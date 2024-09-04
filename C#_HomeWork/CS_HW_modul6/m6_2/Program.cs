using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Car car = new Car("Ferrari", "sportcar");
            car.Sound();
            car.Show();
            car.Description();                        
            Console.WriteLine();

            Kettle kettle = new Kettle("", "Not electric");
            kettle.Sound();            
            kettle.Description();
            Console.WriteLine();

            Microwave microwave = new Microwave("LG");
            microwave.Sound();
            microwave.Show();
            Console.WriteLine();

            SteamShip steamship = new SteamShip();
            steamship.Sound();
            
            

            


            Console.ReadKey();
        }
    }
}
