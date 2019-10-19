using System;
namespace Problema1
{
    public class YouthOrder : IOrder
    {

        public string DisplayOrder(string id, string comboType)
        {
            return "Cliente 'joven' " + id + " ordena combo " + comboType + ". ";
        }


    }
}
