using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        
        static bool cont = true;
        static List<string> activities = new List<string>()
        {
            "Movies",
            "Paintball",
            "Bowling",
            "Lazer Tag",
            "LAN Party",
            "Hiking",
            "Axe Throwing",
            "Wine Tasting"
        };
        static void Main(string[] args)
        {

            Console.Write("Hello, welcome to the random activity generator! \n" +
                          "Would you like to generate a random activity? yes/no: ");
            string cont = Console.ReadLine();
            if (cont.ToLower() == "yes")
            {


                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                int userAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                string seeList = Console.ReadLine();
                if (seeList.ToLower() == "sure")
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");

                    do
                    {

                        string addToList = Console.ReadLine();
                        
                        if (addToList.ToLower() == "yes")
                        {
                            Console.WriteLine();
                        }
                        else if (addToList.ToLower() == "no")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Ok");
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Hmm... not really an option but lets keep going");
                            break;
                        }

                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");

                    } while (true);
                }
                Console.WriteLine("Ok, data saved!");
                Console.WriteLine("Choose again...");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to generate a random activity? yes/no: ");

                var rng = new Random();
                do
                {
                    string userActivityAnswer = Console.ReadLine();
                    if (userActivityAnswer.ToLower() == "redo")
                    {

                    }
                    else if (userActivityAnswer.ToLower() == "yes")
                    {

                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Thread.Sleep(500);
                        }
                        Console.WriteLine("Umm... Ok... have fun!");
                        break;
                    }

                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();

                    var randomNumber = rng.Next(activities.Count);
                    string randomActivity = activities[randomNumber];
                    Console.WriteLine();
                    if (userAge < 21 && randomActivity == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity);
                        randomNumber = rng.Next(activities.Count);
                        randomActivity = activities[randomNumber];
                    }

                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();

                } while (true);


            


            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }
                Console.WriteLine();
                Console.WriteLine("Ok");
            }
        }
    }
}