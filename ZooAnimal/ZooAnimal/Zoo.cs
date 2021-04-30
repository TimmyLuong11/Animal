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

        public Zoo()
        {
            ZooInfo = new Dictionary<string, List<Animal>>();
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
