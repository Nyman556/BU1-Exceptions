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
        } else 
        {
            Console.WriteLine("Fel Input. Skriv ett nummer");
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
                number = 0;
                return false;
            }
        }
    }
}
