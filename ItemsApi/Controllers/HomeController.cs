using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItemsApi.Models;

namespace ItemsApi.Controllers
{
    public class HomeController : Controller
    {
        List<Item> items = new List<Item>()
        {
            new Item(1, "Phone", 2, "Budapest", 2),
            new Item(2, "Laptop", 3, "Nigeria", 3),
            new Item(3, "Headphones", 4, "Lagos", 4),
            new Item(4, "Drink Bottle", 5, "Asaba", 5),
            new Item(5, "Peanut Butter", 6, "Oko", 6)
        };


        //GET api/item/5
        [HttpGet("{id}", Name = "Get")]
        public Item Get(int id)
        {
            Item item = items.Find(f => f.id == id);
            return item;
        }



        [HttpPost]
        public List<Item> Post([FromBody] Item item)
        {
            items.Add(item);
            return items;
        }



        [HttpPut("{id}")]
        public List<Item> Put(int id, [FromBody] Item item)
        {
            Item ItemToUpdate = items.Find(f => f.id == id);
            int index = items.IndexOf(ItemToUpdate);

            items[index].name = item.name;
            items[index].price = item.price;
            items[index].location = item.location;
            items[index].quantityAvailable = item.quantityAvailable;

            return items;
        }


        [HttpDelete("{id}")]
        public List<Item> Delete(int id)
        {
            Item item = items.Find(f => f.id == id);
            items.Remove(item);
            return items;
        }
    }


}
