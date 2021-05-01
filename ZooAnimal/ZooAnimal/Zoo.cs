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
        public Dictionary<string, List<Animal>> ZooInfo { get; set; }
        public double AverageWeight { get; set; }
        public double AverageHeight { get; set; }

        public Zoo()
        {
            ZooInfo = new Dictionary<string, List<Animal>>();
            AverageWeight = 0;
            AverageHeight = 0;
        }

        public void AverageWeights()
        {
            double avg = 0;
            int count = 0;
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
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
        public void AverageHeights()
        {
            double avg = 0;
            int count = 0;
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    avg = a.CalculateAverageHeight(item.Value[i]);
                    AverageHeight += avg;
                    count++;
                }
                AverageHeight = AverageHeight / count;
                Console.WriteLine($"{item.Key} Zoo has an average weight of {AverageHeight.ToString("N2")} inches.");
                Console.WriteLine();
            }
        }

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
