using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ItemsApi.Models
{

    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string location { get; set; }
        public int quantityAvailable { get; set; }

        public Item()
        {
        }

        public Item(int id, string name, int price, string location, int quantityAvailable)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.location = location;
            this.quantityAvailable = quantityAvailable;
        }
    }
}