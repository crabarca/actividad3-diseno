using System;

namespace Problema1
{
    class Program
    {  
    public class Simulation
        {
            // The client code works with all objects using the Component interface.
            // This way it can stay independent of the concrete classes of
            // components it works with.
            Random Rnd = new Random();

            public void run(int numberIterations)
            {
                for (int i = 0; i <= numberIterations; i++)
                {
                    var amountClients = Rnd.Next(0, 11);

                    for (int j = 0; j <= amountClients; j++)
                    {
                        var clientType = Rnd.Next(0, 3);
                        Client client;
                        if (clientType == 0)
                        {
                            client = new YouthClient();
                        }

                        else if (clientType == 1)
                        {
                            client = new AdultClient();
                        }

                        else
                        {
                            client = new ElderAdultClient();
                        }

                        IOrder order = client.createOrder();

                        Decorator decorator;
                        if (client.ApplyDecorator(client.EnlargeComboProb))
                        {
                            decorator = new EnlargeComboDecorator();
                        }

                        EnlargeComboDecorator order2;
                        if (client.ApplyDecorator(client.ExtraCheeseProb))
                        {
                            decorator = new EnlargeComboDecorator(decorator);
                        }
                        else
                        {
                            order2 = (Problema1.EnlargeComboDecorator)order1;
                        }

                        EnlargeComboDecorator order3;
                        if (client.ApplyDecorator(client.ExtraMeatProb))
                        {
                            order3 = new EnlargeComboDecorator(order2);
                        }
                        else
                        {
                            order3 = (Problema1.EnlargeComboDecorator)order2;
                        }

                        EnlargeComboDecorator order4;
                        if (client.ApplyDecorator(client.RemoveVegetablesProb))
                        {
                            order4 = new EnlargeComboDecorator(order3);
                        }
                        else
                        {
                            order4 = (Problema1.EnlargeComboDecorator)order3;
                        }

                        EnlargeComboDecorator order5;
                        if (client.ApplyDecorator(client.AddBBQProb))
                        {
                            order5 = new EnlargeComboDecorator(order4);
                        }
                        else
                        {
                            order5 = (Problema1.EnlargeComboDecorator)order4;
                        }

                        EnlargeComboDecorator order6;
                        if (client.ApplyDecorator(client.AddDesertProb))
                        {
                            order6 = new EnlargeComboDecorator(order5);
                        }
                        else
                        {
                            order6 = (Problema1.EnlargeComboDecorator)order5;
                        }

                        Console.WriteLine(order6.DisplayOrder("1", client.selectCombo()));
                    }
                }
                
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Simulation simulation = new Simulation();
            int numberIterations = 5;
            simulation.run(numberIterations);
        }


    }
}
