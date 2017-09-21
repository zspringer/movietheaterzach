using System;

namespace movietheaterzach
{
    class Program
    {
        static void Main(string[] args)
        {
            bool selecting = true;
            Console.Clear();
            while (selecting)
            {
                Console.WriteLine("Hello Movies!");
                //Start of asking questions to make menus
                System.Console.WriteLine("What do you want to do?");
                System.Console.WriteLine("1. Go to a movie\n2. Purchase Food\n3. Quit");
                string UserChoice = Console.ReadLine();
                //Declare a num and then Int32 line says that if it successfully takes in the user choice, it will set the value to num
                int num;
                Int32.TryParse(UserChoice, out num);

                //See the bottom of this file for the if statements pertaining to the user response to the questions
                

                //Need to start by creating a theatre
                //Could add multiple theaters by doing the same thing
                Theater Majestic = new Theater("Majestic");

                //Need to make movies before we add them
                Movie IT = new Movie("IT", "Clowns are scary");
                Movie WeddingSinger = new Movie("The Wedding Singer", "Adam Sandler");
                Movie JurasicPark = new Movie("Jurasic Park", "Dinsosaurs Are Awesome!");

                //Make showtimes.  <key, value>
                IT.addShowtime("10:00", 5.99f, 100);
                IT.addShowtime("11:00", 5.99f, 100);
                IT.addShowtime("12:00", 5.99f, 100);

                WeddingSinger.addShowtime("10:00", 5.99f, 100);
                WeddingSinger.addShowtime("11:00", 5.99f, 100);
                WeddingSinger.addShowtime("12:00", 5.99f, 100);

                JurasicPark.addShowtime("10:00", 5.99f, 100);
                JurasicPark.addShowtime("11:00", 5.99f, 100);
                JurasicPark.addShowtime("12:00", 5.99f, 100);

                //Make Food
                //f is for float
                Food Nachos = new Food("Nachos", 5.99f, 25);
                Food Popcorn = new Food("Popcorn", 8.50f, 120);
                Food Drink = new Food("Drink", 4.99f, 200);

                //Add all items to Theater
                //Comes from the method on theater and you have to use the list title from Theater
                Majestic.Menu.Add(Nachos);
                Majestic.Menu.Add(Popcorn);
                Majestic.Menu.Add(Drink);
                Majestic.Movies.Add(IT);
                Majestic.Movies.Add(WeddingSinger);
                Majestic.Movies.Add(JurasicPark);

                // System.Console.WriteLine(Majestic.Movies[0].Title);
                // System.Console.WriteLine(Majestic.Menu[0]);

                //Start of If statements
                //if statements corresponding to user choice from the menu item question
                //Going to a movie section
                if (num == 1)
                {
                    selecting = false;
                    Movie selectedMovie = Majestic.SelectMovie(Majestic.Movies);
                    if (selectedMovie != null)
                    {
                        //Whatever movie was selected and then run the PurchaseTicket method for that movie with its showtimes
                    // System.Console.WriteLine("What time do you want to go to?");
                    System.Console.WriteLine("How many tickets do you want");
                    string UserTicket = Console.ReadLine();
                    int tic;
                    Int32.TryParse(UserTicket, out tic);
                    selectedMovie.PurchaseTicket();
                    }


                }
                
                if (num ==2)
                {
                    selecting = false;
                    Food selectedFood = Majestic.SelectFood(Majestic.Menu);
                    if (selectedFood != null)
                    {
                        System.Console.WriteLine("How many do you want to purchase?");
                        string UserFood = Console.ReadLine();
                        int treat;
                        Int32.TryParse(UserFood, out treat);
                        selectedFood.Purchase(treat);
                    }
                }

                if (num ==3)
                {
                    selecting = false;
                }
                selecting = true;

                //End of If statements
            }
        }
    }
}
