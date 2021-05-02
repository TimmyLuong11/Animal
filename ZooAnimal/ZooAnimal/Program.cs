using System;
using System.Collections.Generic;
using System.IO;

namespace ZooAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading in the file and adding each part to thier respective variable
            string[] lines = File.ReadAllLines("ZooAnimal.csv");
            Zoo z1 = new Zoo();
            List<Animal> animalLists = new List<Animal>();

            //Looping through each line and adding the data to thier respective variable
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');
                Animal a1 = new Animal()
                {
                    Color = pieces[0],
                    Name = pieces[1],
                    Weight = Convert.ToDouble(pieces[2]),
                    Height = Convert.ToDouble(pieces[3]),
                };
                animalLists.Add(a1);
                
                if (z1.ZooInfo.ContainsKey(pieces[4]) == true)
                {
                    z1.ZooInfo[pieces[4]].Add(a1);
                }
                else
                {
                    z1.ZooInfo.Add(pieces[4], new List<Animal>());
                    z1.ZooInfo[pieces[4]].Add(a1);
                }
            }

            //Welcoming the user to the database
            Console.WriteLine("Welcome to the Zoo database!");
            Console.WriteLine("What would you like to see about the Zoo database");
            Console.WriteLine("Type the number to see that information:");
            Console.WriteLine("1. See the list of all the animal\n2. See the animal location\n3. See the average weight at each location\n4. See the average height at each location");
            string answer = Console.ReadLine();
            
            //Looping through until the user wants to quit and showing what the user wants to see
            do
            {
                switch (answer.ToLower()[0])
                {
                    case '1':
                        for (int i = 0; i < animalLists.Count; i++)
                        {
                            Animal a2 = new Animal();
                            a2.DisplayZooInfo(animalLists[i]);
                            Console.WriteLine();
                        }
                        break;
                    case '2':
                        z1.DisplayZooInfo();
                        break;
                    case '3':
                        z1.AverageWeights();
                        break;
                    case '4':
                        z1.AverageHeights();
                        break;
                    default:
                        Console.WriteLine("You did not enter in an valid answer. Please try again!");
                        break;
                }
                if (answer.ToLower()[0] == 'y')
                {
                    Console.WriteLine("1. See the list of all the animal\n2. See the animal location\n3. See the average weight at each location\n4. See the average height at each location");
                    answer = Console.ReadLine();
                    switch (answer.ToLower()[0])
                    {
                        case '1':
                            for (int i = 0; i < animalLists.Count; i++)
                            {
                                Animal a2 = new Animal();
                                a2.DisplayZooInfo(animalLists[i]);
                                Console.WriteLine();
                            }
                            break;
                        case '2':
                            z1.DisplayZooInfo();
                            break;
                        case '3':
                            z1.AverageWeights();
                            break;
                        case '4':
                            z1.AverageHeights();
                            break;
                        default:
                            Console.WriteLine("You did not enter in an valid answer. Please try again!");
                            break;
                    }
                }
                Console.WriteLine("Would you like to see a different information? Type 'yes' or 'no'");
                answer = Console.ReadLine();
            } while (answer.ToLower()[0] != 'n');
            
            //Thanking the user for using the database 
            Console.WriteLine("Thanks for using the Zoo database! Have a great day.");
        }
    }
}
