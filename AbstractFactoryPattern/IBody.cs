using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public interface IBody
    {
        
    }

    public class ClassBody : IBody
    {
        public override string ToString()
        {
            return $"This is a car body";
        }
    }

    public class VanBody : IBody
    {
        public override string ToString()
        {
            return $"This is a van body";
        }
    }
}
