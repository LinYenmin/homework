using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllyControl
{
    interface IObserver
    {
        string Name { get; set; }
        string Help();
        string BeAttacked(AllyControlCenter acc);
    }
}
