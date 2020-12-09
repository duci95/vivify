using System;
using System.Collections.Generic;
using System.Text;

namespace VivifyIdeasTest
{
    public class Meal : Product
    {
        public Dictionary<string, double> Insets { get; set; }
        public Meal(string name, double price) : base(name,price)
        {
           
        }

        public double CalcualteMealPrice(Dictionary<string, double> insets)
        {
            double result = 0;
            foreach(var item in insets.Values)
            {
                result += item;
            }
            this.Price += result;
            return this.Price;
        }
    }
}
