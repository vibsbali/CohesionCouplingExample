namespace Core
{
    public interface IVehicle
    {
    }

    public abstract class AbstractVehicle : IVehicle
    {
        protected AbstractVehicle()
        {

        }
    }

    public class Car : AbstractVehicle
    {
        public override string ToString()
        {
            return "This is a Car";
        }
    }

    public class Van : AbstractVehicle
    {
        public override string ToString()
        {
            return "This is a Van";
        }
    }
}
