using System;
using System.Collections.Generic;

namespace VivifyIdeasTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random drinkPrice = new Random();
            double d1 = drinkPrice.Next(150, 500);

            Random mealPrice = new Random();
            double m1 = mealPrice.Next(300, 600);

            Random insetPrice = new Random();

            double i1 = insetPrice.Next(1, 10);
            Meal meal = new Meal("Pizza Capricciosa", m1);
            Meal meal1 = new Meal("Pasta Italiana", m1);

            Dictionary<string, double> insets = new Dictionary<string, double>();
            insets.Add("kecap", i1);
            insets.Add("origano", i1);
            insets.Add("extra cheese", i1);
            meal.CalcualteMealPrice(insets);

            List<Product> products = new List<Product>();
            products.Add(meal);

            Table t1 = new Table(1);
            Table t2 = new Table(2);
            Table t3 = new Table(3);
            Table t4 = new Table(4);

            Order o1 = new Order(products, t1);

        }
    }
}
