using System;
namespace Problema1
{
    public class ElderAdultOrder : IOrder
    {
        public string DisplayOrder(string id, string comboType)
        {
            return "Cliente 'adulto mayor' " + id + " ordena combo " + comboType + ". ";
        }
    }
}
