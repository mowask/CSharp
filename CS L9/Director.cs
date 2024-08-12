using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Director : Employee, IManager
    {
        public List<Iworker> ListOfWorkers { get; set; }
        public void Control()
        {
            Console.WriteLine("Контролирую работу!");
        }
        public void MakeBudget ()
        {
            Console.WriteLine("Формирую бюджет!");
        }
        public void Organize ()
        {
            Console.WriteLine("Организую работу!");
        }
    }
}
