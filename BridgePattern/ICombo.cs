namespace BridgePattern
{
    public interface ICombo
    {
        dynamic GetCombo();
    }


    public class CokeAndChips : ICombo
    {
        public dynamic GetCombo()
        {
            return "Coke and Chips Comming Up!";
        }
    }

    public class MilkAndCookies : ICombo
    {
        public dynamic GetCombo()
        {
            return "Milk and Cookies Coming up!";
        }
    }

}