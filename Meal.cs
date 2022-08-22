using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFood
{
    internal class Meal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Nums { get; set; }
        public int Total { get; set; }
        public Meal(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
