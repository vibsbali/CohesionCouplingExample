using System;
using Core;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void BuildChassis();
        void BuildBody();
        void BuildGlassWare();
        void AddReinforcements();
        IVehicle GetBuiltVehicle();
    }

    public class CarBuilder : IBuilder
    {
        private readonly IVehicle _car;
        public CarBuilder()
        {
            _car = new Car();
        }
        public void BuildChassis()
        {
            Console.WriteLine($"Building car Chassis");
        }

        public void BuildBody()
        {
            Console.WriteLine($"Building car Body");
        }

        public void BuildGlassWare()
        {
            Console.WriteLine($"Building car Glassware");
        }

        public void AddReinforcements()
        {
            Console.WriteLine($"Car doesn't need reinforcements");
        }

        public IVehicle GetBuiltVehicle()
        {
            return _car;
        }
    }

    public class VanBuilder : IBuilder
    {
        private readonly IVehicle _van;
        public VanBuilder()
        {
            _van = new Van();
        }
        public void BuildChassis()
        {
            Console.WriteLine($"Building Van Chassis");
        }

        public void BuildBody()
        {
            Console.WriteLine($"Building Van Body");
        }

        public void BuildGlassWare()
        {
            Console.WriteLine($"Building Van Glassware");
        }

        public void AddReinforcements()
        {
            Console.WriteLine($"Adding reinforcements to Van");
        }

        public IVehicle GetBuiltVehicle()
        {
            return _van;
        }
    }
}