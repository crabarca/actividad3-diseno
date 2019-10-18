using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    class EnlargeComboDecorator : Decorator
    {
        public EnlargeComboDecorator(AbstractOrder order) : base(order)
        {

        }

        public override string DisplayOrder(string name, string id, string type)
        {
            return base.DisplayOrder(name, id, type) + "Agrandar combo. ";
        }
    }
}
