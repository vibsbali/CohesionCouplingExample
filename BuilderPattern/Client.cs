using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Client
    {
        public static void Run()
        {
            //make determination of which type of builder and director to instantiate
            var builder = new CarBuilder();
            var director = new CarDirector(builder);
            var vehicle = director.Build();

            Console.WriteLine(vehicle);
        }

    }
}
