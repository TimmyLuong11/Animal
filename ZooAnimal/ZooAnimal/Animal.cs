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
        //Declaring public variables
        public string Color { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        /// <summary>
        /// Default constructor and setting each value to empty or 0
        /// </summary>
        public Animal()
        {
            Color = string.Empty;
            Name = string.Empty;
            Weight = 0;
            Height = 0;
        }

        /// <summary>
        /// Display all the animals our
        /// </summary>
        /// <param name="animal"></param>
        public void DisplayZooInfo(Animal animal)
        {
            Console.WriteLine($"{animal.Name} is a {animal.Color}-colored animal, that weights {animal.Weight.ToString("N2")} pounds, with a height of {animal.Height} inches.");
        }

        /// <summary>
        /// Getting the animals weight
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>The animal weight</returns>
        public double CalculateAverageWeight(Animal animal)
        {
            return animal.Weight;
            
        }

        /// <summary>
        /// Getting the animals height
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>The animal height</returns>
        public double CalculateAverageHeight(Animal animal)
        {
            return animal.Height;
        }
    }
}
