using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    class EnlargeComboDecorator : Decorator
    {
        public EnlargeComboDecorator(IOrder order) : base(order) { }

        public new string DisplayOrder(string id, string type)
        {
            return base.DisplayOrder(id, type) + "Agrandar combo. ";
        }
    }
}
