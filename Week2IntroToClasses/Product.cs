using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2IntroToClasses
{
    public class Product
    {
        // fields
        private int id;
        private string _name;
        private double _price;

        //properties
        private int _quantity;

        //propfull
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        // prop
        public int MyProperty { get; set; }

        // propg
        public int MyProperty1 { get; private set; }


        // constructors
        public Product()
        {
            id = 0;
            _name = "";
            _price = 0;
        }

        public Product(int id, string name, double price)
        {
            this.id = id;
            _name = name;
            _price = price;
        }
    }
}
