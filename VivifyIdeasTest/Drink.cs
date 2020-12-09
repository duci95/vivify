using System;
using System.Collections.Generic;
using System.Text;

namespace VivifyIdeasTest
{
    public class Drink : Product
    {
        public double Volume { get; set; }
        public Drink(string name, double price, double volume) : base(name, price)
        {
            this.Volume = volume;
        }

       
    }
}
