using System;
using System.Collections.Generic;
using System.Linq;

namespace CivRpgCharacterExample_20210617.models
{
    public class Inventory
    {

        public int WeightCapacity { get; set; }
        public List<Item> Items { get; set; }

        public Inventory(int weightCapacity)
        {
            this.WeightCapacity = weightCapacity;
            this.Items = new List<Item>();
        }

        public Inventory()
        {
            this.WeightCapacity = 50;
            this.Items = new List<Item>();

            this.Items.Add(new Item("Health Potion", 1, 10));
            this.Items.Add(new Item("Stick", 1, 1));
            this.Items.Add(new Weapon("Big Wacking Stick", 5, 5, 1, 5));
        }

        public void SortByName()
        {
            this.Items = this.Items.OrderBy(i => i.Name).ToList();
        }
        public void SortByWeight()
        {
            //TODO: complete this by using the above method as a base 
            this.Items = this.Items.OrderBy(i => i.Weight).ToList();
        }
        public int GetCurrentCapacity()
        {
            //TODO: return the total weight of items in the Items list
            int totalWeight = 0;
            foreach (Item item in Items)
            {
                totalWeight += item.Weight;
            }
            return totalWeight;
        }
        public void AddNewItem(Item item)
        {
            //TODO: Add the item to the backpack, if it doesn't make the backpack exceed WeightCapacity

            if (item.Weight <= this.WeightCapacity - GetCurrentCapacity())
            {
                this.Items.Add(item);
            }
            else
            {
                Console.WriteLine($"Could not add item: {item} to backpack, too heavy");
            }
        }

        /// <summary>
        /// Tries to find itemName in list and removes the first instance of it
        /// </summary>
        /// <param name="itemName"></param>
        public void RemoveItem(string itemName)
        {
            // Iterate through the list -> foreach
            // compare item's name to search term (itemName) -> if
            // if match - Remove from list, stop looking
            // if no match - keep going through the list

            foreach (Item item in this.Items)
            {
                if (item.Name == itemName)
                {
                    this.Items.Remove(item);
                    break;
                }
            }
        }

        public int GetQuantity(string itemName)
        {
            //TODO: Get an item name and check how many of that item is in the list
            int quantity = 0;

            foreach (Item item in Items)
            {
                if (item.Name == itemName)
                {
                    quantity++;
                }
            }
            return quantity;
        }
        public string ListItems()
        {
            string resultString = "Name\t\t\tWeight\t\tValue\n";
            resultString += "----------------------------------------\n";

            // go through the list of Items -> while, for, foreach
            // from each item in the list append Name, Weight and Value
            foreach (Item item in this.Items)
            {
                resultString += $"{item.Name}\t\t\t{item.Weight}\t\t{item.Value}\n";
            }
            return resultString;
        }
    }
}