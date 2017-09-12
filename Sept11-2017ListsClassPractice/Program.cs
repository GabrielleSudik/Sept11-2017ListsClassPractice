using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept11_2017ListsClassPractice
{
    class Program
    {
        //LISTS
        //similar to arrays
        //but number of elements can change, more or fewer
        //it's a "linear" type of data structure -- all in a row

        static void Main(string[] args)
        {
            List<string> faveFoods = new List<string>() { "sushi", "ice cream", "bananas", "pizza"};
                //one way to populate list -- add on the curly brackets and fill 'em, like above

                //another way: 
            List<int> luckyNumbers = new List<int>(); //and more comes later.
            luckyNumbers.Add(2);
            luckyNumbers.Add(25);
            luckyNumbers.Add(30);
            luckyNumbers.Add(42);
            luckyNumbers.Add(43);
            luckyNumbers.Add(8); //sorry, can't do them all on one line.
                //but later, you can Add on more any time!

            //how to print out one element:

            Console.WriteLine(faveFoods[2]); //will print bananas. see how each element is syntax kind of like array. [ ]

            List<string> leastFavorites = new List<string>();
            leastFavorites.Add("onions");
            leastFavorites.Add("watermelon");
            leastFavorites.Add("black licorice");
            leastFavorites.Add("peppers");

            //to put items in a specific spot:

            leastFavorites[0] = "tomatoes"; //will put this in first spot
            leastFavorites[3] = "vegemite"; //CAREFUL! doing this will REPLACE whatever was in that index place before.
                                            //to "bump" existing items, you need to loop all the rest up one place, 
                                            //and then add the new item

            Console.WriteLine(leastFavorites[0]);
            Console.WriteLine(leastFavorites[3]);

            leastFavorites.Insert(1, "stewed rat"); //so... teachers got something wrong earlier...
                                                    //use INSERT if you want to insert, not replace.
                                                    //this will also bump the rest of the list (not delete)

            foreach (string food in leastFavorites)
            {
                Console.WriteLine(food);
            }

            Console.WriteLine();

            //how to do stuff with the list:

            List<string> faveMovies = new List<string>() { "Raiders", "Working Girl", "The Decoy Bride", "Nosferatu" };

            //printing the list:

            for (int i= 0; i < faveMovies.Count; i++) //note .COUNT (similar to Length method)
            {
                Console.WriteLine(faveMovies[i]);
            }

            //or:

            foreach (string movie in faveMovies)
            {
                Console.WriteLine(movie);
            }

            //to remove something from the list: REMOVE method

            faveMovies.Remove("Raiders");
            faveMovies.Remove("The Decoy Bride"); 

            foreach (string movie in faveMovies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();   //WHEEE! this method clears the console. Great for making little programs.


            //class practice:

            List<string> animals = new List<string>() { "man", "bear", "pig", "dodo", "hippo" };

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();

            List<bool> rainyDays = new List<bool>() { true, false, false, true, false };

            foreach (bool day in rainyDays)
            {
                if (day == true)
                {
                    Console.WriteLine("Bring an umbrella");
                }

                else
                {
                    Console.WriteLine("No rain today");
                }
            }

            Console.WriteLine();

            List<int> miscNumbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };

            foreach (int number in miscNumbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("You're looking for 23, 77, 15.");
            if (miscNumbers.Contains(23))
            {
                Console.WriteLine("Found it!");
            }
            if (miscNumbers.Contains(77))
            {
                Console.WriteLine("Found it!");
            }
            if (miscNumbers.Contains(15))
            {
                Console.WriteLine("Found it!"); //won't print because no 15.
            }

            Console.WriteLine("Is 8 on the list?");
            Console.WriteLine(miscNumbers.Contains(8));  //should print false

            Console.WriteLine("How about 922?");
            Console.WriteLine(miscNumbers.Contains(922));  //should print true

            Console.WriteLine();

            miscNumbers.Remove(27);
            miscNumbers.Remove(77);
            miscNumbers.Remove(32);
            miscNumbers.Remove(6);

            foreach (int number in miscNumbers)
            {
                Console.Write(number + " ");
            }

            //research Add, Remove, Sort

            Console.WriteLine();
            Console.WriteLine();

            List<string> books = new List<string>() { "Dune", "Rebecca", "I, Robot", "V", "Animal Farm" };

            books.Sort();

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            books.Add("The Count of Monte Cristo");
            books.Add("A Tale of Two Cities");
            books.Add("It");

            books.Remove("Animal Farm");

            books.Sort();

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();

            //so why use arrays instead of lists?
            //sometimes you don't want to change number of items in the list
            //like number of days in week
            //or empty seats in a theater
        }
    }
}
