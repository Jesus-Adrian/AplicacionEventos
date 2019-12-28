using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    class ProcessorEvents : IProcessor
    {
        public List<IEvent> GetListEvent(List<string> lstEvents)
        {
            

            List<IEvent> lstEventsFormated = new List<IEvent>();

            foreach (var evento in lstEvents)
            {
                string[] ArrayFormat = evento.Split(',');
                IEvent _oEvento = new Evento()
                {
                    cName = ArrayFormat[0],
                    cDate = Convert.ToDateTime(ArrayFormat[1])
                };

                lstEventsFormated.Add(_oEvento);

            }
            return lstEventsFormated;
        }
    }
}
