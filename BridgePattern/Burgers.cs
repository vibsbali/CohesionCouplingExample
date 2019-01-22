using System;

namespace BridgePattern
{
    public abstract class Burgers
    {
        protected ICombo Combo;

        protected Burgers(ICombo combo)
        {
            Combo = combo;
        }

        public abstract void GetCompleteOrder();
    }

    public class ChickenBurger : Burgers
    {
        public ChickenBurger(ICombo combo) : base(combo)
        {
        }

        public override void GetCompleteOrder()
        {
            Console.WriteLine($"This is a Chicken burger with {Combo.GetCombo()}");
        }
    }

    public class BeefBurger : Burgers
    {
        public BeefBurger(ICombo combo) : base(combo)
        {
        }

        public override void GetCompleteOrder()
        {
            Console.WriteLine($"This is an Angus beef burger with {Combo.GetCombo()}");
        }
    }
}
