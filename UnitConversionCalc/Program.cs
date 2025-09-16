// Week 4 Assignment_UnitConversionCalc -- Alejandra Arauz
using Conversiones;
using MenusForCalculator;
using Reportes;
using static System.Console;

class ApplicationRunning
{
    public static void Main(string[] args)
    {
        Menus.PrincipalMenu(); // The app Runing

    }
}

namespace MenusForCalculator
{
    class Menus() // To create Emnu optiosn for the different choices
    {
        public static void PrincipalMenu()
        {
            List<string> ConversionsOptions = ["1", "2", "3"];
            string userChoice;
            bool startProgram = true;
            while (startProgram)
            { 
                WriteLine("=== CHOICES ===\n1:Farenheit to Celsius\n2:Miles to Kilometer \n3: Liters to Ounce");
                userChoice = ReadLine();
                if (ConversionsOptions.Contains(userChoice) == false)
                {
                    WriteLine("Not Valid Option"); // validating between range of options
                }
                else
                {
                    if (userChoice == "1")
                    {
                        WriteLine("=== FARENHEIT TO CELSIUS ===");
                        Operations.FarenheitToCelsius(); // Caling anotehr Class

                    }
                    else if (userChoice == "2")
                    {
                        WriteLine("=== MILES TO KILOMETERS ===");
                        Operations.MileToKilometer(); // Caling anotehr Class
                    }
                    else
                    {
                        WriteLine("=== LITER TO OUNCES ====");
                        Operations.LiterToOunce(); // Caling anotehr Class
                    }
                }
            }
        }
    }
}

namespace Conversiones
{
    class Operations()
    {
        public static void FarenheitToCelsius() // (((F - 32) * 5) / 9 )
        {
            string num;
            double farenheit;
            WriteLine("Write your Farenheit: ");
            num = ReadLine();
            while (true) // Try and catch Loop to check for numbers only aceptance
            {
                try
                {
                    farenheit = double.Parse(num);
                    break;
                }

                catch (Exception)
                {
                    WriteLine("Num");
                    num = ReadLine();

                }
            }
            double total = (((farenheit - 32) * 5) / 9);
            PrincipalReporte.ReporteInicial();
            WriteLine($"{num} Farenheit converts to {total} Celsius");
        }

        public static void MileToKilometer()
        {
            string num;
            double mile;
            WriteLine("Write your Miles: ");
            num = ReadLine();
            while (true) // Try and catch Loop to check for numbers only aceptance
            {
                try
                {
                    mile = double.Parse(num);
                    break;
                }
                catch (Exception)
                {
                    WriteLine("Write your Miles: ");
                    num = ReadLine();
                }
            }
            double total = (mile * 1.609344);
            PrincipalReporte.ReporteInicial();
            WriteLine($"{num} Mile(s) converts to {total} Kilometer(s)");
        }
        public static void LiterToOunce()
        {
            string num;
            double liter;
            WriteLine("Write your Liters: ");
            num = ReadLine();
            while (true) // Try and catch Loop to check for numbers only aceptance
            {
                try
                {
                    liter = double.Parse(num);
                    break;
                }
                catch (Exception)
                {
                    WriteLine("Write your Liters: ");
                    num = ReadLine();
                }
            }
            double total = (liter * 33.8140227);
            PrincipalReporte.ReporteInicial();
            WriteLine($"{num} Liters converts to {total} Ounces");
        }
    }
}

    namespace Reportes
    {
        class PrincipalReporte
        {
            public static void ReporteInicial() // Creates a report at the end of every conversion created
            {
                DateTime currentTime = DateTime.Now;
                string Name;
                WriteLine("Whats your Name? ");
                Name = ReadLine();
                WriteLine("=== Report === ");
                WriteLine(currentTime);
                WriteLine($"Welcome {Name}");
            }
        }
    }
