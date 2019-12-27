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
            string[] ArrayFormat = new string[2];

            List<IEvent> lstEventsFormated = new List<IEvent>();

            foreach (var evento in lstEvents)
            {
               ArrayFormat = evento.Split(',');
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
