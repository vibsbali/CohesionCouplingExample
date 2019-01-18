namespace AbstractFactoryPattern
{
    public class Client
    {
        public void Run(string vehicleType)
        {
            AbstractVehicleFactory vehicleFactory;
            if (vehicleType.ToLower() == "car")
            {
                vehicleFactory = new CarFactory();
            }
            else
            {
                vehicleFactory = new VanFactory();
            }

           var parts = vehicleFactory.GetParts;
           var body = vehicleFactory.GetBody;
        }
    }
}
