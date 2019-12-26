using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            LecturaArchivo.LeerArchivo();

        }
    }

    static class LecturaArchivo
    {
        public static string archivoTexto = @"C:\AplicacionEventos\AplicacionEventos\AplicacionEventos\Archivo\Eventos.txt";

        /// <summary>
        /// Lee el archivo de texto con los datos capturados
        /// </summary>
        public static void LeerArchivo()
        {
            try
            {
                using (StreamReader sr = new StreamReader(archivoTexto))
                {
                    string line = string.Empty;
                    string[] array = new string[2];
                    while ((line = sr.ReadLine()) != null)
                    {

                        array = line.Split(',');

                        DateTime today = DateTime.Now;

                        TimeSpan diferencia = (ConvertirFecha(array[1]).Subtract(today));

                        CalcularFecha(diferencia, array,today);

                    }


                }
            }
            catch (IOException e)
            {
                Console.WriteLine("El archivo no se encontro:");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Convierte la cadena de fecha del evento  a tipo datetime.
        /// </summary>
        /// <param name="_cFecha"></param>
        /// <returns></returns>
        public static DateTime ConvertirFecha(string _cFecha)
        {
            return Convert.ToDateTime(_cFecha);
        }

        public static void CalcularFecha(TimeSpan _dtDiferencia, string[] array,DateTime today)
        {
            TimeSpan todayDate = today.TimeOfDay;
            if (_dtDiferencia.TotalDays < todayDate.TotalDays)
            {
                Console.WriteLine($"{array[0]} ocurrió hace {Math.Abs(_dtDiferencia.Days / 30)} mes(es), {Math.Abs(_dtDiferencia.Days - (_dtDiferencia.Days / 30)*30)} dia(s) {Math.Abs(_dtDiferencia.Hours)} hora(s) y {Math.Abs(_dtDiferencia.Minutes)} minutos(s)");
            }
          

            else
            {
                Console.WriteLine($"{array[0]} ocurrirá dentro de {_dtDiferencia.Days / 30} mes(es), {Math.Abs(_dtDiferencia.Days - (_dtDiferencia.Days / 30) * 30)} dia(s) {Math.Abs(_dtDiferencia.Hours)} hora(s) y {Math.Abs(_dtDiferencia.Minutes)} minutos(s)");
            }


        }
    }
}
