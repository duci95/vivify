using System;
using System.Collections.Generic;
using System.Text;

namespace VivifyIdeasTest
{
    public class Order
    {
        public List<Product> Products { get; set; }
        public Table Table { get; set; }
        public bool Payed { get; set; } = false;

        public Order(List<Product> products, Table table)
        {
            Products = products;
            Table = table;
        }
       

        public override string ToString()
        {
            return  "Order: date " + DateTime.Now +" " + this.Table;
        }

        public string printBill()
        {
            double toPay = 0;
            foreach(var item in Products) 
            {
                toPay += item.Price;
            }
               
            return DateTime.Now + " " + this.Table.TableName + " to pay: " + toPay;
        }

        public void Charge()
        {
            if (Payed)
            {
                printBill();
            }
            else
            {
                throw new Exception("You must pay last order before ordering new one!");
            }
        }
        
        
    }
}
