using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace PizzaCodeExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fileLocation = ConfigurationManager.AppSettings["pizzaFileLocation"] +
                               ConfigurationManager.AppSettings["pizzaFileName"];

            var top20 = GetTop20PizzaCombos(fileLocation);

            OutputToFile(top20);
            OutputToConsole(top20);
            Console.Read();
        }

        private static IEnumerable<KeyValuePair<string, int>> GetTop20PizzaCombos(string fileLocation)
        {
            Console.Title = "Pizza Grouper";
            var pizzas = JsonConvert.DeserializeObject<IEnumerable<Pizza>>(File.ReadAllText(fileLocation)).ToList();

            var stringCollectionComparer = new StringCollectionEqualityComparer();
            var groupsOfPizzas = pizzas.GroupBy(x => x.Toppings, stringCollectionComparer).ToList();

            var pizzaDictionary = new Dictionary<string, int>();
            foreach (var groupOfPizza in groupsOfPizzas.OrderByDescending(group => group.Count()))
            {
                var count = groupOfPizza.Count();
                var groupOfToppingNames = string.Empty;
                foreach (var topping in groupOfPizza.Key)
                {
                    groupOfToppingNames = topping + ", " + groupOfToppingNames;
                }
                //Console.WriteLine(groupOfToppingNames + ": " + count);
                pizzaDictionary.Add(groupOfToppingNames, count);
            }

            return pizzaDictionary.OrderByDescending(x => x.Value).Take(20);
        }

        private static void OutputToConsole(IEnumerable<KeyValuePair<string, int>> top20)
        {
            foreach (var keyValuePair in top20)
                Console.WriteLine(keyValuePair.Key + ": " + keyValuePair.Value);
        }

        private static void OutputToFile(IEnumerable<KeyValuePair<string, int>> top20)
        {
            var outputFileLocation = ConfigurationManager.AppSettings["outputFileLocation"] +"answers.txt";
            using (StreamWriter file = new StreamWriter(outputFileLocation))
                foreach (var entry in top20)
                    file.WriteLine("[{0} {1}]", entry.Key, entry.Value);
        }


    }
}