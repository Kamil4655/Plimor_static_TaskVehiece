using polimorphizm.Interfaces;
using polimorphizm.Models;

namespace polimorphizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAdd a = new Calculate();

            Console.WriteLine(a.Add(82, 523));

            IDivide c = new Calculate();

            Console.WriteLine(c.Divide(80,2));
        }
    }
}
