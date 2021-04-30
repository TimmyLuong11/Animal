using System;
using System.Collections.Generic;
using System.IO;

namespace ZooAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("ZooAnimal.csv");
            Zoo z1 = new Zoo();
            List<Animal> animalLists = new List<Animal>();

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
            Console.WriteLine("Welcome to the Zoo database!");
            Console.WriteLine("Would you like a list of all the animals or would you like to see where the animals are located?");
            Console.WriteLine("Type 'list' for list of animals or 'state' for location of the animals");
            string answer = Console.ReadLine();
            if (answer.ToLower()[0] == 'l')
            {
                for (int i = 0; i < animalLists.Count; i++)
                {
                    Animal a2 = new Animal();
                    a2.DisplayZooInfo(animalLists[i]);
                }

            }
            else
            {
                z1.DisplayZooInfo();
            }
        }
    }
}
