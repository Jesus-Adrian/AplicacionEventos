using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces.TimeRange
{
    public class Hours : Management
    {
        protected override string ProcessEvent(IEvent _oEvent)
        {
            TimeSpan _timeRangeDifference = _oEvent.cDate - DateTime.Now;
            double _dTimeRange = Math.Abs(_timeRangeDifference.TotalHours);
            if (_dTimeRange>=24)
            {
                return null;
            }
            else if (_oEvent.cDate > DateTime.Today)
            {
                Console.WriteLine($"{_oEvent.cName} ocurrira dentro de {Math.Round(_dTimeRange)} horas");
                return "Ok";
            }
            else
            {
                Console.WriteLine($"{_oEvent.cName} ocurrío hace {Math.Round(_dTimeRange)} horas");
                return "Ok";
            }
        }
    }
}
