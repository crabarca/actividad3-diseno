using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    abstract class Decorator : AbstractOrder
    {
        protected AbstractOrder _abstractOrder;

        public Decorator(AbstractOrder abstractOrder)
        {
            this._abstractOrder = abstractOrder;
        }
        
        public void SetAbstractOrder(AbstractOrder abstractOrder)
        {
            this._abstractOrder = abstractOrder;
        }
        public override string DisplayOrder(string name, string id, string comboType)
        {
            if (this._abstractOrder != null)
            {
                return this._abstractOrder.DisplayOrder(name, id, comboType);
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
