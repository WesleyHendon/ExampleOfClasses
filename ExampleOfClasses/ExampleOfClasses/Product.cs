using System;
namespace ExampleOfClasses
{
    public class Product
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Product()
        {
            Name = "";
            Price = 0.00;
        }

        public override string ToString()
        {
            return Name + " $" + Price;
        }
    }
}
