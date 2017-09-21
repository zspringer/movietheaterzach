using System.Collections.Generic;

namespace movietheaterzach
{
    public class Theater
    {
        public string Name;
        public List<Movie> Movies = new List<Movie>();
        //add the user system generic
        public List<Food> Menu = new List<Food>();

        //Constructor
        //Need an addMovie()
        //Need an addFood()
        //Need to add a selectMovie method

        public Movie SelectMovie(List<Movie> list)
        {
            Movie selectedmovie = null;
            System.Console.WriteLine("Please choose a movie by title to go to");
            foreach (Movie movie in list)
            {
                //get the movies from the list
                System.Console.WriteLine(movie.Title, movie.Description);
            }
            string UserChoice = System.Console.ReadLine();
            System.Console.WriteLine(UserChoice);
            foreach (Movie movie in list)
            {
                if (UserChoice == movie.Title)
                {
                    selectedmovie = movie;
                }
            }
            return selectedmovie;
        }

        public Food SelectFood(List<Food> list)
        {
            Food selectedfood = null;
            System.Console.WriteLine("Please choose a treat by title");
            foreach (Food food in list)
            {
                //get the food from the list
                System.Console.WriteLine(food.Name, food.Cost, food.Inventory);
            }
            string UserChoice = System.Console.ReadLine();
            System.Console.WriteLine(UserChoice);
            foreach (Food food in list)
            {
                if (UserChoice == food.Name)
                {
                    selectedfood = food;
                }
            }
            return selectedfood;
        }
        
        //Not being used
        // public void addMovie(Movie movie)
        // {
        //     Movies.Add(movie);
        // }

        public void addFood(Food food)
        {
            Menu.Add(food);
        }

        public Theater(string name)
        {
            Name=name;

        }
    }
}