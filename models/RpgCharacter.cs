namespace CivRpgCharacterExample_20210617.models
{
    public class RpgCharacter
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHp { get; set; }
        public int Mp { get; set; }
        public int MaxMp { get; set; }
        public Inventory BackPack { get; set; }

        public RpgCharacter(string name, int maxHp, int maxMp)
        {
            this.Name = name;
            this.MaxHp = maxHp;
            // set mp to maxmp
            this.Hp = this.MaxHp;
            this.MaxMp = maxMp;
            // set mp to maxmp
            this.Mp = this.MaxMp;
            this.BackPack = new Inventory(100);
        }

        // Default constructor
        public RpgCharacter() {
            this.Name = "Dephoult";
            this.MaxHp = 100;
            this.Hp = this.MaxHp;
            this.MaxMp = 50;
            // set mp to maxmp
            this.Mp = this.MaxMp;
            this.BackPack = new Inventory();

            
        }

        public int Attack(string weaponName) { return 0; }
        public void AddToBackPack(Item item) { 
            this.BackPack.AddNewItem(item);
        }
        public void RemoveFromBackPack(string itemName) { 
            //TODO: call the method from Inventory that removes an item by name
            this.BackPack.RemoveItem(itemName);
        }
        public string LookInBackPack() { 
            return this.BackPack.ListItems(); 
        }
    }
}