using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantCarpaccio
{
    public class GroupOfArticle
    {
        public Article article;
        public int quantity;

        public GroupOfArticle(Article _article, int _quantity)
        {
            article = _article;
            quantity = _quantity;
        }

        public string Quantity
        {
            get { return Formatter.FormatInt(quantity); }
        }

        public float TotalPrice
        {
            get { return article.unitPrice * quantity; }
        }

        public string TotalPriceFormat
        {
            get { return Formatter.FormatPrice(article.unitPrice * quantity); }
        }

        public void Display()
        {
            if (quantity > 0)
            {
                Console.WriteLine($"{article.Name} --- {Quantity} --- {article.Price} --- {TotalPriceFormat}");
            }
        }
    }
}
