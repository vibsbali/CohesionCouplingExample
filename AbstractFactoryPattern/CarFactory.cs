namespace AbstractFactoryPattern
{
    public class CarFactory : AbstractVehicleFactory
    {
        public CarFactory()
        {
            GetParts = new CarParts();
            GetBody = new ClassBody();
        }

        public override IParts GetParts { get; }
        public override IBody GetBody { get; }
    }

    public class VanFactory : AbstractVehicleFactory
    {
        public VanFactory()
        {
            GetParts = new VanParts();
            GetBody = new VanBody();
        }
        public override IParts GetParts { get; }
        public override IBody GetBody { get; }
    }

    public abstract class AbstractVehicleFactory
    {
        protected AbstractVehicleFactory() {}

        public abstract IParts GetParts { get; }
        public abstract IBody GetBody { get; }
    }
}
