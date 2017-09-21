namespace movietheaterzach
{
    //Implement the interface with lightbulb
    public class Ticket : IPurchasable
    {
        //Movie and Time are not necessary but I might want them in the future
        Movie Movie;
        string Time;
        public float Cost { get; set; }
        public int Inventory { get; set; }

        public bool Purchase(int quantity)
        {
            //make sure I have the inventory first
            if(Inventory-quantity>=0)
            {
                Inventory-=quantity;
                System.Console.WriteLine($"Here is your ticket(s)");
                //because it is a bool, return type is true
                return true;
            }
            //If you do not have enough
            //Sorry but we have either none or say 6 left when they are asking for 10.  
            //() is a turnary statement
            System.Console.WriteLine($"Sorry, but we have {(Inventory == 0 ? "none" : Inventory.ToString())} left");
            return false;            
        }
        public Ticket(Movie movie, string time, float cost, int inventory)
        {
            Cost = cost;
            Inventory = inventory;
            Movie = movie;
            Time = time;
        }
    }
}