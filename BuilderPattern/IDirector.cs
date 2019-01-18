using System;
using Core;

namespace BuilderPattern
{
    public interface IDirector
    {
        IVehicle Build();
    }

    public class CarDirector : IDirector
    {
        private readonly IBuilder _builder;

        public CarDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public IVehicle Build()
        {
            _builder.BuildBody();
            _builder.BuildChassis();
            _builder.BuildGlassWare();
            _builder.AddReinforcements();

            return _builder.GetBuiltVehicle();
        }
    }

    public class VanDirector : IDirector
    {
        private IBuilder _builder;

        public VanDirector(IBuilder builder)
        {
            _builder = builder;
        }
        public IVehicle Build()
        {
            _builder.BuildBody();
            _builder.BuildChassis();
            _builder.BuildGlassWare();
            _builder.AddReinforcements();

            return _builder.GetBuiltVehicle();
        }
    }


}
