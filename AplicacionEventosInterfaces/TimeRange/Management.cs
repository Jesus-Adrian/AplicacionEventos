using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AplicacionEventosInterfaces.TimeRange
{
    public abstract class Management : IManagement
    {
        private IManagement oManagement;
        public void EvaluateEvent(IEvent _oEvent)
        {
            if (ProcessEvent(_oEvent)!= "Ok")
            {
                this.oManagement?.EvaluateEvent(_oEvent);
            }
        }

        public void NextChainLink(IManagement _oManagement)
        {
            this.oManagement = _oManagement;
        }

        protected abstract string ProcessEvent(IEvent _oEvent);
    }
}
