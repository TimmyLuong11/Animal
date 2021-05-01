using System;
using System.Collections.Generic;
using System.Text;

namespace ZooAnimal
{
    /// <summary>
    /// This animal class will represent an animal zoo with the animal color, name, weight, height, and location.
    /// </summary>
    class Animal
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Animal()
        {
            Color = string.Empty;
            Name = string.Empty;
            Weight = 0;
            Height = 0;
        }

        public void DisplayZooInfo(Animal animal)
        {
            Console.WriteLine($"{animal.Name} is a {animal.Color}-colored animal, that weights {animal.Weight.ToString("N2")} pounds, with a height of {animal.Height} inches.");
        }

        public double CalculateAverageWeight(Animal animal)
        {
            return animal.Weight;
            
        }

        public double CalculateAverageHeight(Animal animal)
        {
            return animal.Height;
        }
    }
}
