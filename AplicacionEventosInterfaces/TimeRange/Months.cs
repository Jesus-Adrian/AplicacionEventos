using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces.TimeRange
{
    public class Months: Management
    {
        protected override string ProcessEvent(IEvent _oEvent)
        {
            TimeSpan _timeRangeDifference = _oEvent.cDate - DateTime.Now;
            double _dTimeRange = Math.Abs(_timeRangeDifference.TotalDays);
            if (_dTimeRange>=30)
            {
               
                if (_oEvent.cDate > DateTime.Today)
                {
                    Console.WriteLine($"{_oEvent.cName} ocurrira dentro de {Math.Round(_dTimeRange / 30)} meses");
                    return "Ok";
                }
                else
                {
                    Console.WriteLine($"{_oEvent.cName} ocurrío hace {Math.Round(_dTimeRange / 30)} meses");
                    return "Ok";
                }
            }
            else
            {
               
                return null;
            }


            
        }
    }
}
