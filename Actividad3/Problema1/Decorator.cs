using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    abstract class Decorator : IOrder
    {
        protected IOrder _IOrder;

        public Decorator(IOrder iOrder)
        {
            this._IOrder = iOrder;
        }
        
        public void SetAbstractOrder(IOrder iOrder)
        {
            this._IOrder = iOrder;
        }

        public string DisplayOrder(string id, string comboType)
        {
            if (this._IOrder != null)
            {
                return this._IOrder.DisplayOrder(id, comboType);
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
