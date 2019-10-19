using System;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new YouthOrder();
            Console.WriteLine(order.EnlargeCombo());

            Client client = new YouthClient();
            Console.WriteLine(client.createOrder());
        }
    }
}
