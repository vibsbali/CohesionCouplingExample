using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ServiceLocatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Old Way");
            OldWay();

            NewWay.PrepareCoffee();
        }

        public static class NewWay
        {
            public static Coffee PrepareCoffee()
            {
                var coffeeMachine = CoffeeServiceLocator.GetInstance().GetCoffeeMachine();
                Coffee coffee = coffeeMachine.BrewFilterCoffee();
                Console.WriteLine("Coffee is ready!");
                return coffee;
            }
        }

        //The Service Locator is used as a replacement for the new operator. It looks like this:
        public class CoffeeServiceLocator
        {
            private static CoffeeServiceLocator locator;

            private ICoffeeMachine coffeeMachine;

            private CoffeeServiceLocator()
            {
                // configure and instantiate a CoffeeMachine
                var beans = new Dictionary<CoffeeSelection, CoffeeBean>();

                beans.Add(CoffeeSelection.ESPRESSO, new CoffeeBean("My favorite espresso bean", 1000));
                beans.Add(CoffeeSelection.FILTER_COFFEE, new CoffeeBean("My favorite filter coffee bean", 1000));

                coffeeMachine = new PremiumCoffeeMachine(beans);
            }

            public static CoffeeServiceLocator GetInstance()
            {
                if (locator == null)
                {
                    locator = new CoffeeServiceLocator();
                }
                return locator;
            }

            public ICoffeeMachine GetCoffeeMachine()
            {
                return coffeeMachine;
            }
        }


        public static void OldWay()
        {
            // create a Map of available coffee selections
            var coffeeSelections = new Dictionary<CoffeeSelection, CoffeeBean>
            {
                { CoffeeSelection.ESPRESSO, new CoffeeBean("My favorite espresso bean", 1000) },
                { CoffeeSelection.FILTER_COFFEE, new CoffeeBean("My favorite filter coffee bean", 1000) }
            };

            // get a new CoffeeMachine object by instantiating... BAD
            var machine = new PremiumCoffeeMachine(coffeeSelections);

            // Instantiate CoffeeApp 
            CoffeeApp app = new CoffeeApp(machine);

            // brew a fresh coffee
            app.PrepareCoffee(CoffeeSelection.ESPRESSO);
        }
    }

    public class PremiumCoffeeMachine : ICoffeeMachine
    {
        private Dictionary<CoffeeSelection, CoffeeBean> _coffeSelections;

        public PremiumCoffeeMachine(Dictionary<CoffeeSelection, CoffeeBean> coffeeSelections)
        {
            _coffeSelections = coffeeSelections;
        }
        public Coffee BrewFilterCoffee()
        {
            return new Coffee
            {
                SelectedCoffee = CoffeeSelection.FILTER_COFFEE,
                CoffeeBeansUsed = _coffeSelections.GetValueOrDefault(CoffeeSelection.FILTER_COFFEE)
            };
        }
    }

    public class CoffeeApp
    {
        private ICoffeeMachine coffeeMachine;

        public CoffeeApp(ICoffeeMachine coffeeMachine)
        {
            this.coffeeMachine = coffeeMachine;
        }

        public Coffee PrepareCoffee(CoffeeSelection selection)
        {
            var coffee = coffeeMachine.BrewFilterCoffee();
            Console.WriteLine($"Coffee is ready! \n {coffee.CoffeeBeansUsed.Description}");
            return coffee;
        }
    }

    public interface ICoffeeMachine
    {
        Coffee BrewFilterCoffee();
    }

    public class Coffee
    {
        public CoffeeSelection SelectedCoffee { get; set; }
        public CoffeeBean CoffeeBeansUsed { get; set; }
    }

    public class CoffeeBean
    {
        public string Description { get; }
        public int Strength;

        public CoffeeBean(string description, int strength)
        {
            Description = description;
            Strength = strength;
        }
    }

    public enum CoffeeSelection
    {
        ESPRESSO,
        FILTER_COFFEE
    }
}

