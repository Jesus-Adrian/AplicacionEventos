using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    interface IProcessor
    {
        List<IEvent> GetListEvent(List<string> lstEventos);
    }
}
