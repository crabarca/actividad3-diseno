using System;
namespace Problema1
{
    public interface IOrder
    {
        Boolean EnlargeCombo();
        Boolean AddExtraCheese();
        Boolean AddExtraMeat();
        Boolean RemoveVegetables();
        Boolean AddBBQSauce();
        Boolean AddDesert();
    }
}
