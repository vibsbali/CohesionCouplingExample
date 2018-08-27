using System;

namespace HighCohesionHighCoupling
{
    interface IDisplay
    {
        void GenerateImage();
    }

    interface IPrinter
    {
        void PrintImage();
    }

    //constructs HighResImage
    public class HighResDisplay : IDisplay
    {
        public void GenerateImage()
        {
            Console.WriteLine("High Res");
        }
    }

    //constructs LowResImage
    class LowResDisplay : IDisplay
    {  
        public void GenerateImage()
        {
            Console.WriteLine("Low Res");
        }
    }

    //constructs HighResPrinter
    class HighResPrint : IPrinter
    {
        public void PrintImage()
        {
            Console.WriteLine("High Res");
        }
    }

    //constructs LowResPrinter
    class LowResPrint : IPrinter
    {
        public void PrintImage()
        {
            Console.WriteLine("Low Res");
        }
    }

    static class DisplayFactory
    {
        public static IDisplay GetDisplayDriver()
        {

            //Switch here is OK because we are encapsulating all the logic in one place and
            //only this class is responsible for all the processing related to instantiation of 
            //a particular type of Display Object
            switch ("Reflection-based or Resolution")
            {
                default:
                    return new HighResDisplay();
            }
        }
    }

    static class PrinterFactory
    {
        public static IPrinter GetPrinterDriver()
        {
            switch ("Reflection-based or Resolution")
            {
                default:
                    return new HighResPrint();
            }
        }
    }


    class Program
    {
        public static void Main()
        {
            //We could use Containers to instantiate or Factory like so

            IDisplay display = DisplayFactory.GetDisplayDriver();
            IPrinter printer = PrinterFactory.GetPrinterDriver();

            display.GenerateImage();
            printer.PrintImage();
        }
    }
}


