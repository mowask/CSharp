using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nДолжность: {Position}" + 
                $"\nЗаработная плата: {Salary} руб.";
        }
    }
}
