using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces
{
    class Reader : IReader
    {       
        public List<string> ReadFile(string _cFilePath)
        {
            List<string> _lstEvents = new List<string>(); 
            try
            {
                using (StreamReader sr = new StreamReader(_cFilePath))
                {
                    string line = string.Empty;
                    string[] array = new string[2];
                    while ((line = sr.ReadLine()) != null)
                    {                        
                        _lstEvents.Add(line);
                    }
                    return _lstEvents;
                }             
            }
            catch (IOException e)
            {
                Console.WriteLine("El archivo no se encontro:");
                Console.WriteLine(e.Message);
                return _lstEvents;
            }
           
        }
    }
}
