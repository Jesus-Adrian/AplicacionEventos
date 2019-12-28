using System;
using System.Collections.Generic;
using System.IO;

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
                   
                    while ((line = sr.ReadLine()) != null)
                    {                        
                        _lstEvents.Add(line);
                    }
                
                }             
            }
            catch (IOException e)
            {
                Console.WriteLine("El archivo no se encontro:");
                Console.WriteLine(e.Message);
               
            }
            return _lstEvents;
        }
    }
}
