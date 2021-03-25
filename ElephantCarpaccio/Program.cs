using System;

namespace ElephantCarpaccio
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();

            CodePays.Display();
            Console.WriteLine("Saisir le code pays");
            string code = "";
            do
            {
                code = Console.ReadLine();
                object recepter = null;
                if(Enum.TryParse(typeof(CodePays.Code), code, out recepter))
                {
                    CodePays.current = (CodePays.Code)recepter;
                }
                else
                {
                    code = "";
                    Console.WriteLine("Saisissez une valeur valide stp.");
                }
            } while (code == "");

            ticket.Add(new Article("sushi", 5.5f), 1);
            ticket.Add(new Article("spaghetti", 1.99f), 3);
            ticket.Add(new Article("stylo", 0.49f), 1500);

            ticket.Display();
            Console.ReadLine();
        }
    }
}
