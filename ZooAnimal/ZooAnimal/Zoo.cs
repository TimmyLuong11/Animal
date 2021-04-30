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

        public double AverageWeights()
        {
            double avg = 0;
         /*   foreach (var item in ZooInfo)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    double w = a.CalculateAverageWeight(item.Value[i]);
                    w += w;
                    avg = w / item.Value.Count;
                }
            }*/
            return avg;
        }

        public void DisplayZooInfo()
        {
            foreach (var item in ZooInfo.OrderBy(i => i.Key))
            {
                double avg = 0;
                double w = 0;
                int count = 1;
                Console.WriteLine($"{item.Key} Zoo has the following animal:");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Animal a = new Animal();
                    a.DisplayZooInfo(item.Value[i]);
                    w = a.CalculateAverageWeight(item.Value[i]);
                    w += w;
                    ++count;
                }
                avg = w / count;
                Console.WriteLine($"The average weight for this zoo is {avg}");
                //Console.WriteLine($"The average height for this zoo is {AverageWeights()}");
                Console.WriteLine();
            }
        }
    }
}
