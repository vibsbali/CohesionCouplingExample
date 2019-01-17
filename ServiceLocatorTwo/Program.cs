using System;
using System.Collections.Generic;

namespace ServiceLocatorTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://blog.ploeh.dk/2010/02/03/ServiceLocatorisanAnti-Pattern/
            //http://blog.ploeh.dk/2014/05/15/service-locator-violates-solid/

            Locator.Register<IOrderValidator>(() => new OrderValidator());
            Locator.Register<IOrderProcessor>(() => new OrderProcessor());

            var processor = Locator.Resolve<IOrderProcessor>();
            processor.Process(new Order());
        }
    }

    public class OrderValidator : IOrderValidator
    {
        public bool Validate(Order order)
        {
            return !order.IsEmpty;
        }
    }

    public class OrderProcessor : IOrderProcessor
    {
        public void Process(Order order)
        {
            //code smell hidden dependency
            var validator = Locator.Resolve<IOrderValidator>();
            if (validator.Validate(order))
            {
                var shipper = Locator.Resolve<IOrderShipper>();
                shipper.Ship(order);
            }
        }
    }

    public interface IOrderShipper
    {
        void Ship(Order order);
    }

    public interface IOrderValidator
    {
        bool Validate(Order order);
    }



    public class Locator
    {
        private static readonly Dictionary<Type, Func<object>> Services = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> resolver)
        {
            Locator.Services[typeof(T)] = () => resolver();
        }

        public static T Resolve<T>()
        {
            return (T)Locator.Services[typeof(T)]();
        }

        public static void Reset()
        {
            Locator.Services.Clear();
        }
    }

    public class Order
    {
        public bool IsEmpty { get; set; }
    }

    public interface IOrderProcessor
    {
        void Process(Order order);
    }
}
