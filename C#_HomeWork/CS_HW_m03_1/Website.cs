using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m03_1
{
    internal class Website
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Ip { get; set; }

        public void changeTheme(string newDescription) { Description = newDescription; }
        public void Print()
        {
            Console.WriteLine($"Title: {Name} \nurl: {Url} \ntheme: {Description} \nip {Ip}");
        }
    }
}
