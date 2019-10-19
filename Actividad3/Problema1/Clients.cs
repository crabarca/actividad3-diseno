using System;
using System.Collections.Generic;

namespace Problema1
{
    public abstract class Client
    {
        protected Random Rnd = new Random();
        protected List<string> ComboTypes = new List<string>() { "A", "B", "C", "D", "E", "F" };

        public virtual string createOrder()
        {
            var Selection = Rnd.Next(0, 6);
            return ComboTypes[Selection];
        }
    }

    public class YouthClient : Client
    {
        public override string createOrder()
        {
            var Combo = base.createOrder();
            return $"Cliente 'joven' ordena combo {Combo}";
        }
    }

    public class AdultClient : Client
    {
        public override string createOrder()
        {
            var Combo = base.createOrder();
            return $"Cliente 'adulto' ordena combo {Combo}";
        }
    }

    public class ElderAdultClient : Client
    {
        public override string createOrder()
        {
            var Combo = base.createOrder();
            return $"Cliente 'adulto mayor' ordena combo {Combo}";
        }
    }
}
