using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    interface IEvent
    {
        string cName { get; set; }
        DateTime cDate{ get; set; }

    }
}
