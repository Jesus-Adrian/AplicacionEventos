using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEventosInterfaces.TimeRange
{
    public interface IManagement
    {
        void NextChainLink(IManagement _oManagement);
        void EvaluateEvent(IEvent _oEvent);

    }
}
