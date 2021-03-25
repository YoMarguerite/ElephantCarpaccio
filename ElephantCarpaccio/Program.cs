using System;

namespace ElephantCarpaccio
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();

            ticket.Add(new Article("sushi", 5.5f), 1);
            ticket.Add(new Article("spaghetti", 1.99f), 3);
            ticket.Add(new Article("stylo", 0.49f), 1500);

            Console.WriteLine("Saisir le taux de la TVA");
            int taux = -1;
            do
            {
                string read = Console.ReadLine();
                if(!Int32.TryParse(read, out taux))
                {
                    Console.WriteLine("Saisissez une valeur valide stp.");
                }
            } while (taux < 0);

            ticket.tauxTVA = taux;

            ticket.Display();
            Console.ReadLine();
        }
    }
}
