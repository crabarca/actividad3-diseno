using System;
using System.Collections.Generic;

namespace Problema1
{
    public abstract class Client
    {
        protected RandomPercent Rnd = new RandomPercent();
        protected List<string> ComboTypes = new List<string>() { "A", "B", "C", "D", "E", "F" };
        public double EnlargeComboProb { get; set; }
        public double ExtraCheeseProb { get; set; }
        public double ExtraMeatProb { get; set; }
        public double RemoveVegetablesProb { get; set; }
        public double AddBBQProb { get; set; }
        public double AddDesertProb { get; set; }

        public string selectCombo()
        {
            var Selection = Rnd.Next(0, 6);
            return ComboTypes[Selection];
        }

        public abstract IOrder createOrder();

    
        public bool ApplyDecorator(double Probability)
        {
            var apply = false;
            if (Rnd.getSample() < Probability)
            {
                apply = true;
            }
            return apply;
        }

        public void PrintOrder(IOrder order, string Id)
        {
            Console.WriteLine(order.DisplayOrder(Id, selectCombo()));
        }

    }

    public class YouthClient : Client
    {
        public YouthClient()
        {
            EnlargeComboProb = 0.3;
            ExtraCheeseProb = 0.2;
            ExtraMeatProb = 0.15;
            RemoveVegetablesProb = 0.3;
            AddBBQProb = 0.25;
            AddDesertProb = 0.2;
        }

        public override IOrder createOrder()
        {
            IOrder order = new YouthOrder();
            return order;
        }

    }

    public class AdultClient : Client
    {
        public AdultClient()
        {
            EnlargeComboProb = 0.2;
            ExtraCheeseProb = 0.15;
            ExtraMeatProb = 0.1;
            RemoveVegetablesProb = 0.15;
            AddBBQProb = 0.1;
            AddDesertProb = 0.3;
        }

        public override IOrder createOrder()
        {
            IOrder order = new AdultOrder();
            return order;
        }
    }

    public class ElderAdultClient : Client
    {
        public ElderAdultClient()
        {
            EnlargeComboProb = 0.15;
            ExtraCheeseProb = 0.1;
            ExtraMeatProb = 0.05;
            RemoveVegetablesProb = 0.05;
            AddBBQProb = 0.05;
            AddDesertProb = 0.2;
        }
        
        public override IOrder createOrder()
        {
            IOrder order = new ElderAdultOrder();
            return order;
        }
    }
}
