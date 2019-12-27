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
            Reader reader = new Reader();
            lstEventos= reader.ReadFile(@"C:\AplicacionEventos\AplicacionEventos\AplicacionEventosInterfaces\Archivo\Eventos.txt");
            ProcessorEvents oProcessorEvents = new ProcessorEvents();
            oProcessorEvents.GetListEvent(lstEventos);
        }
    }
    
}


