namespace movietheaterzach
{
    public class Food : IPurchasable
    //Need to implement interface with lightbulb; see next comment
    //Get rid of the throw comments
    {
        public string Name;
        public float Cost { get; set; }
        public int Inventory { get; set; }

        public bool Purchase(int quantity)
        {
            //make sure I have the inventory first
            if(Inventory-quantity>=0)
            {
                Inventory-=quantity;
                System.Console.WriteLine($"We now have {Inventory} left of {Name}");
                System.Console.WriteLine($"Here is your {quantity}, {Name}");
                //because it is a bool, return type is true
                return true;
            }
            //If you do not have enough
            //Sorry but we have either none or say 6 left when they are asking for 10.  
            //() is a turnary statement
            System.Console.WriteLine($"Sorry, but we have {(Inventory == 0 ? "none" : Inventory.ToString())} left");
            return false;            
        }

        //type ctor
        public Food(string name, float cost, int inventory)
        {
            Name = name;
            Cost = cost;
            Inventory = inventory;
        }
    }
}