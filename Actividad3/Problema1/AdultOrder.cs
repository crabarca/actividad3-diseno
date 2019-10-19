using System;
namespace Problema1
{
    public class AdultOrder : IOrder
    {
        public string DisplayOrder(string id, string comboType)
        {
            return "Cliente 'adulto' " + id + " ordena combo " + comboType + ". ";
        }
    }
}
