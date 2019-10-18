using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1
{
    class Order : AbstractOrder
    {
        public override string DisplayOrder(string type, string id, string comboType)
        {
            return "Cliente " + type + " " + id + " ordena combo " + comboType + ". ";
        }
    }
}
