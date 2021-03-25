using System;
using System.Collections.Generic;
using System.Text;

namespace ElephantCarpaccio
{
    public class Article
    {
        public string name;
        public float unitPrice;

        public Article(string _name, float _unitPrice)
        {
            name = _name;
            unitPrice = _unitPrice;
        }

        public string Name
        {
            get
            {
                return Formatter.FormatString(name);
            }
        }

        public string Price
        {
            get { return Formatter.FormatPrice(unitPrice); }
        }
    }
}
