using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElephantCarpaccio
{
    public class Ticket
    {
        private List<GroupOfArticle> articles = new List<GroupOfArticle>();

        public GroupOfArticle Add(Article article, int quantity)
        {
            GroupOfArticle group = new GroupOfArticle(article, quantity);
            articles.Add(group);
            return group;
        }

        public float TotalUnitPrice
        {
            get
            {
                return articles.Sum(group => group.article.unitPrice * group.quantity);
            }
        }

        public float PercentValue(float value)
        {
            return (TotalUnitPrice / 100) * value;
        }

        public void Display()
        {
            string colName = Formatter.FormatString("name");
            string colQuantity = Formatter.FormatString("quantity");
            string colPrice = Formatter.FormatString("price");
            string colTotal = Formatter.FormatString("total");
            string inter = " --- ";

            Console.WriteLine(colName + inter + colQuantity + inter + colPrice + inter + colTotal);

            articles.ForEach(article =>
            {
                article.Display();
            });

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 55)));

            Console.WriteLine("Total without taxes".PadRight(45) + Formatter.FormatPrice(TotalUnitPrice));

            Console.WriteLine($"Taxe {CodePays.GetCurrentTVA}%".PadRight(44) + "+" + Formatter.FormatPrice(PercentValue(CodePays.GetCurrentTVA)));

            Console.WriteLine(String.Concat(Enumerable.Repeat("-", 55)));

            Console.WriteLine("Total price".PadRight(45) + Formatter.FormatPrice(TotalUnitPrice + PercentValue(CodePays.GetCurrentTVA)));
        }
    }
}
