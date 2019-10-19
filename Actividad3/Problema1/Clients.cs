using System;
using System.Collections.Generic;

namespace Problema1
{
    public abstract class Client
    {
        protected RandomPercent Rnd = new RandomPercent();
        protected List<string> ComboTypes = new List<string>() { "A", "B", "C", "D", "E", "F" };

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

    }

    public class YouthClient : Client
    {
        private double EnlargeComboProb = 0.3;
        private double ExtraCheeseProb = 0.2;
        private double ExtraMeatProb = 0.15;
        private double RemoveVegetablesProb = 0.3;
        private double AddBBQProb = 0.25;
        private double AddDesertProb = 0.2;
        public RandomPercent rnd = new RandomPercent();

        public override IOrder createOrder()
        {
            IOrder order = new YouthOrder();
            return order;
        }

    }

    public class AdultClient : Client
    {
        private double EnlargeComboProb = 0.2;
        private double ExtraCheeseProb = 0.15;
        private double ExtraMeatProb = 0.1;
        private double RemoveVegetablesProb = 0.15;
        private double AddBBQProb = 0.1;
        private double AddDesertProb = 0.3;
        public RandomPercent rnd = new RandomPercent();

        public override IOrder createOrder()
        {
            IOrder order = new YouthOrder();
            return order;
        }
    }

    public class ElderAdultClient : Client
    {
        private double EnlargeComboProb = 0.15;
        private double ExtraCheeseProb = 0.1;
        private double ExtraMeatProb = 0.05;
        private double RemoveVegetablesProb = 0.05;
        private double AddBBQProb = 0.05;
        private double AddDesertProb = 0.2;
        public RandomPercent rnd = new RandomPercent();

        public override IOrder createOrder()
        {
            IOrder order = new YouthOrder();
            return order;
        }
    }
}
