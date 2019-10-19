using System;

namespace Problema1
{
    class Program
    {  
    public class Client
        {
            // The client code works with all objects using the Component interface.
            // This way it can stay independent of the concrete classes of
            // components it works with.
            public void ClientCode(AbstractOrder order)
            {
                Console.WriteLine("RESULT: " + order.DisplayOrder("joven", "1", "F"));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Client client = new Client();
            var simple = new Order();

            client.ClientCode(simple);

            Console.WriteLine();

            // ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            EnlargeComboDecorator decorator1 = new EnlargeComboDecorator(simple);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator1);
        }


    }
}


public string showOrder()
{
    var orderString = createOrder().DisplayOrder(Id, selectCombo());

    if (ApplyDecorator(EnlargeComboProb))
    {

    }

    if (ApplyDecorator(ExtraCheeseProb))
    {

    }

    if (ApplyDecorator(ExtraMeatProb))
    {

    }

    if (ApplyDecorator(RemoveVegetablesProb))
    {

    }

    if (ApplyDecorator(AddBBQProb))
    {

    }

    if (ApplyDecorator(AddDesertProb))
    {

    }
}