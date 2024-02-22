namespace AS2324._3G.SignorettiGiulio.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AS2324.Giulio.Signoretti.3G.Esercizio sugli array");
            Console.WriteLine("Inserire il numero di persone delle quali vuoi raccogliere i dati.");
            int dim = Convert.ToInt32(Console.ReadLine());
            int[] età = new int[dim];
            double[] peso = new double[dim];
            CaricaVettori(ref peso, ref età);
            double max = peso[0];
            double min = peso[0];
            double media = 0;
            Statistiche(ref peso, ref media, ref min, ref max);
        }
        static void CaricaVettori(ref double[] peso, ref int[] età)
        {
            Random random = new Random();
            for (int i = 0; i < età.Length; i++)
            {
                peso[i] = random.Next(18, 100);
                età[i] = random.Next(50, 101);
                Console.WriteLine($"Il peso e l'età della persona in posizione {i + 1} sono {peso}kg e {età} anni");
            }
        }
        static void Statistiche(ref double[] peso, ref double media, ref double min, ref double max)
        {
            for (int i = 0; i < peso.Length; i++)
            {
                if (max < peso[i])
                {
                    max = peso[i];
                }
                if (min > peso[i])
                {
                    min = peso[i];
                }
                media += peso[0];
            }
            media = media / peso.Length;
        }

    }
}