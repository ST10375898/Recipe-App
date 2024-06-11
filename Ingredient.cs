using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design
{
    public class Ingredient
    {
        // declaration of Ingredient object properties
        private string name;
        private double quantity;
        private string unit;
        private string group;
        private double calory;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public double Calory
        {
            get { return calory; }
            set { calory = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
