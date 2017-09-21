using System;
using System.Collections.Generic;

namespace movietheaterzach
{
    //Can't by the movie so do not bring in IPurchasable.  Can only buy the food and ticket.
    public class Movie
    {
        public string Title;
        public string Description;

        //Showtimes will be part of tickets
        //New thing called a dictionary
        //Dictionary takes in a <key, data>
        //Have to add using systems generic with lightbulb
        public Dictionary<string, Ticket> Showtimes = new Dictionary <string, Ticket>();

        //Needs to take in time and create a ticket
        
        public void PurchaseTicket()
        {
            //For time in the specific movie.  Brings this key value pair in from program
            foreach(var time in this.Showtimes)
            {
                // time.Key;
                // time.Value.Cost;
                // time.Value.Inventory;
                System.Console.WriteLine($"At {time.Key}, we have {time.Value.Inventory} tickets available at {time.Value.Cost}");
            }
        }
        
        
        public void addShowtime(string time, float cost, int inventory)
        {
            //Need to add a showtime
            //(key, value)
            Showtimes.Add(time, new Ticket(this, time, cost, inventory));
        }


        //Constructor
        public Movie(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}