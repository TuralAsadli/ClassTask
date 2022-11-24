using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Model
{
    internal class Product
    {
        string _name;
        int _price;

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => _name; set => _name = value; }
        public int Price { get { return _price; } set { _price = value; } }


        
    }
}
