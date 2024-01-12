using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace exceptions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if(Övning1(input, out int result))
        {
            Console.WriteLine($"Parsed: {result}");
        }

        bool Övning1(string input, out int number) 
        {
            try
            {
                number = Int32.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Fel Input. Skriv ett nummer");
            }
            catch (OverflowException)
            {
                Console.WriteLine("För stort eller för litet tal. Ange ett tal inom det tillåtna intervallet för Int32.");
            }
            number = 0;
            return false;
        }
    }
}
