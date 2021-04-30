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
            Console.WriteLine($"{animal.Name}, a {animal.Color}-colored animal. {animal.Weight} pounds, {animal.Height} inches.");
        }

    }
}
