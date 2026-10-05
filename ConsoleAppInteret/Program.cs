namespace ConsoleAppInteret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal argent = 1200;
            const decimal taux = 0.013m;

            while (true)
            {
                Console.WriteLine("Quelle est la somme d'argent que vous aimeriez atteindre ?");
                decimal sommeCible = Convert.ToDecimal(Console.ReadLine());
                int i = 0;
                while (argent < sommeCible)
                {
                    i++;
                    argent += argent * taux;
                    
                }
                Console.WriteLine($"Il vous faudra {i} ans pour atteindre cette somme.");
                break;
            }

        }
    }
}
