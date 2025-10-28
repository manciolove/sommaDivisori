namespace sommaDivisori
{
    internal class Program
    {
        static bool Nprimo(int n)
        {
            
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static int Somma(int n)
        {
            int s = 0;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {

                    if (Nprimo(i) == true)
                    {
                        s = s + i;
                    }
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("la somma dei divisori primi: " + Somma(a));
        }
    }
}
