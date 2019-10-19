﻿using System;
namespace Problema1
{
    public class ElderAdultOrder : IOrder
    {
        private double EnlargeComboProb;
        private double ExtraCheeseProb;
        private double ExtraMeatProb;
        private double RemoveVegetablesProb;
        private double AddBBQProb;
        private double AddDesertProb;
        public RandomPercent rnd;

        public ElderAdultOrder()
        {
            EnlargeComboProb = 0.15;
            ExtraCheeseProb = 0.1;
            ExtraMeatProb = 0.05;
            RemoveVegetablesProb = 0.05;
            AddBBQProb = 0.05;
            AddDesertProb = 0.2;
            rnd = new RandomPercent();
        }

        public bool EnlargeCombo()
        {
            var apply = false;
            if (rnd.getSample() < EnlargeComboProb)
            {
                apply = true;
            }
            return apply;
        }

        public bool AddExtraCheese()
        {
            var apply = false;
            if (rnd.getSample() < ExtraCheeseProb)
            {
                apply = true;
            }
            return apply;
        }

        public bool AddExtraMeat()
        {
            var apply = false;
            if (rnd.getSample() < ExtraMeatProb)
            {
                apply = true;
            }
            return apply;
        }

        public bool RemoveVegetables()
        {
            var apply = false;
            if (rnd.getSample() < RemoveVegetablesProb)
            {
                apply = true;
            }
            return apply;
        }

        public bool AddBBQSauce()
        {
            var apply = false;
            if (rnd.getSample() < AddBBQProb)
            {
                apply = true;
            }
            return apply;
        }

        public bool AddDesert()
        {
            var apply = false;
            if (rnd.getSample() < AddDesertProb)
            {
                apply = true;
            }
            return apply;
        }
    }
}