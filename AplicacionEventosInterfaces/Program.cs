using AplicacionEventosInterfaces.TimeRange;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lstEventos = new List<string>();
            List<IEvent> lstEventosFormated = new List<IEvent>();
            Reader reader = new Reader();
            lstEventos= reader.ReadFile(@"C:\AplicacionEventos\AplicacionEventos\AplicacionEventosInterfaces\Archivo\Eventos.txt");
            ProcessorEvents oProcessorEvents = new ProcessorEvents();
            lstEventosFormated =  oProcessorEvents.GetListEvent(lstEventos);
            IManagement _oMinute = new Minutes();
            IManagement _oHour = new Hours();
            IManagement _oDay = new Days();
            IManagement _oMonth = new Months();


            _oMinute.NextChainLink(_oHour);
            _oHour.NextChainLink(_oDay);
            _oDay.NextChainLink(_oMonth);

            foreach (var evento in lstEventosFormated)
            {
                _oMinute.EvaluateEvent(evento);
            }
            Console.ReadKey();
        }
    }
    
}


