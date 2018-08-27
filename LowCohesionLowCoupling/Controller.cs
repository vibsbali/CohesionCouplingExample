using System;

namespace LowCohesionLowCoupling
{
    /// <summary>
    /// Responsible for Displaying and Printing something
    /// </summary>
    public class Controller
    {
        //method injection
        public void Draw(string resolution)
        {
            // ... Does something here .....
            // ... Prework
            switch (resolution)
            {
                case "LOW":
                    // use low resolution 
                    break;
                case "HIGH":
                    //use high resolution
                    break;
            }
        }

        //method injection
        public void Print(string resolution)
        {
            // ... Does something here .....
            // ... Prework
            switch (resolution)
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
