using System;
using System.Collections.Generic;
using System.Text;

namespace LowCohesionLowCoupling
{
    public class ControllerAlternative
    {
        private string _resolution;

        //constructor injection
        public ControllerAlternative(string resolution)
        {
            _resolution = resolution;
        }

        
        public void Draw()
        {
            // ... Does something here .....
            // ... Prework

            switch (_resolution)
            {
                case "LOW":
                    // use low resolution 
                    break;
                case "HIGH":
                    //use high resolution
                    break;
            }
        }
        
        public void Print()
        {
            // ... Does something here .....
            // ... Prework


            switch (_resolution)
            {
                case "LOW":
                    // use low resolution 
                    break;
                case "HIGH":
                    //use high resolution
                    break;
            }
        }
    }
}
