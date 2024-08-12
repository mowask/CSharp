using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal interface Iworker
    {
        bool IsWorking { get; }
        string Work();
    }
}
