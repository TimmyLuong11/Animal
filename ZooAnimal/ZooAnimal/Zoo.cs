using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooAnimal
{
    /// <summary>
    /// This class will display a zoo in a given location while calcuating the average weight and height at given location
    /// </summary>
    class Zoo
    {
        //Declaring public variables
        public Dictionary<string, List<Animal>> ZooInfo { get; set; }
        public double AverageWeight { get; set; }
        public double AverageHeight { get; set; }

        /// <summary>
        /// Default constructor setting each value to 0 or new
        /// </summary>
        public Zoo()
        {
            ZooInfo = new Dictionary<string, List<Animal>>();
            AverageWeight = 0;
            AverageHeight = 0;
        }

        /// <summary>
        /// Calculate the average height of the zoo location 
        /// </summary>
        public void AverageWeights()
        {
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
                double avg = 0;
                int count = 0;
                AverageWeight = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    avg = a.CalculateAverageWeight(item.Value[i]);
                    AverageWeight += avg;
                    count++;
                }
                AverageWeight = AverageWeight / count;
                Console.WriteLine($"{item.Key} Zoo has an average weight of {AverageWeight.ToString("N2")} pounds.");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calculate the average weight of the zoo location
        /// </summary>
        public void AverageHeights()
        {
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
                double avg = 0;
                int count = 0;
                AverageHeight = 0;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    avg = a.CalculateAverageHeight(item.Value[i]);
                    AverageHeight += avg;
                    count++;
                }
                AverageHeight = AverageHeight / count;
                Console.WriteLine($"{item.Key} Zoo has an average height of {AverageHeight.ToString("N2")} inches.");
                Console.WriteLine();
                count = 0;
            }
        }

        /// <summary>
        /// Dispaly the animals at each zoo location
        /// </summary>
        public void DisplayZooInfo()
        {
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
                Console.WriteLine($"{item.Key} Zoo has the following animal:");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    a.DisplayZooInfo(item.Value[i]);
                }
                Console.WriteLine();
            }
        }
    }
}
