using Exercices;

namespace exercices
{
    public class Program
    {
        public static void Main()
        {
            Pareja<string, int> parStr = new Pareja<string, int>("AAAAA", 1234);
            Pareja<double, bool> parBool = new Pareja<double, bool>(2.5, true);

            Console.WriteLine(parStr.ToString(), parStr.Valor1, parStr.Valor2);
            Console.WriteLine(parBool.ToString(), parBool.Valor1, parBool.Valor2);
        }
    }
}