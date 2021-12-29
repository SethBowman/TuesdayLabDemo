using System;
using System.Collections.Generic;
using System.Linq;

namespace TuesdayLabDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();

            //var numbers = new List<int>();

            //for (int i = 1; i <= 100; i++)
            //{
            //    numbers.Add(r.Next(50));
            //}

            //var otherNums = numbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            //otherNums.ForEach(x => Console.WriteLine(x));


            // dot notation
            var batman = new Movie();

            batman.Title = "Batman";
            batman.Length = 200;
            batman.Rating = "PG13";
            batman.IsGood = true;

            // object initializer syntax

            var returnOfTheKing = new Movie() 
            {
                Title = "Return Of The King",
                Length = 300, 
                Rating = "PG13",
                IsGood = true 
            };

            // using a custom constructor

            var bladeRunner = new Movie("Blade Runner", "R", 220, false);


            var movies = new List<Movie>() 
            { 
                batman, 
                returnOfTheKing, 
                bladeRunner 
            };


            foreach (var item in movies)
            {
                Console.WriteLine($"This movie is called {item.Title}. It's length is {item.Length} minutes long. It is rated {item.Rating}. And it is {item.IsGood} that people like this movie.");
            }


        }
    }
}
