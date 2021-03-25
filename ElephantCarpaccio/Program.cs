﻿using System;

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

            do
            {
                Console.WriteLine("Ajouter un article :");

                Console.Write("Nom : ");
                string name = Console.ReadLine();

                Console.Write("Prix : ");
                float price = -1;
                do
                {
                    string str = Console.ReadLine();
                    if(!float.TryParse(str, out price))
                    {
                        price = -1;
                        Console.WriteLine("Saisissez une valeur valide stp.");
                    }
                } while (price == -1);

                Console.Write("Quantité : ");
                int quantity = -1;
                do
                {
                    string str = Console.ReadLine();
                    if (!Int32.TryParse(str, out quantity))
                    {
                        quantity = -1;
                        Console.WriteLine("Saisissez une valeur valide stp.");
                    }
                } while (quantity < 0);

                ticket.Add(new Article(name, price), quantity);
                Console.WriteLine("Article ajouté.");

                Console.WriteLine("Pour arrêter d'ajouter des articles appuyez sur ESC.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine();

            ticket.Display();
            Console.ReadLine();
        }
    }
}
