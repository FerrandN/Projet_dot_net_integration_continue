using Domain;

namespace MyCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new Voiture(50000, "Lamborguini", "L2");
            Console.WriteLine(v.Prix);
        }
    }
}