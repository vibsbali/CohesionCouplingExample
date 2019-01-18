using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IParts
    {
        
    }

    public class CarParts : IParts
    {
        public override string ToString()
        {
            return $"These are van parts";
        }
    }

    public class VanParts : IParts
    {
        public override string ToString()
        {
            return $"These are van parts";
        }
    }


}
