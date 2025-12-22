using System;
using AverageCalculator;

namespace Program00 
{
    public class Program
    {
        public static int Main() {
            double[] list_element = {0, 1, 2};
            double[] list_element_two = {1, 2, 3};
            Average list = new(list_element);
            double[] new_list = list.GetElements();
            int count = 0; 

            Console.WriteLine("___Average Calcutlator!___");
            Console.WriteLine("");

            // First list_element:
            Console.WriteLine("First:");
            list.Add(list_element);
            foreach(double value in new_list) {
                Console.WriteLine($"Value ({count}): {value}");
                count++;
            }
            Console.WriteLine($"Average: {list.GetAverage()}");
            Console.WriteLine($"Änderungen: {list.Count()}");
            Console.WriteLine("");

            //Second list_element:
            Console.WriteLine("Second:");
            list.Add(list_element_two);
            foreach(double value in new_list) {
                Console.WriteLine($"Value ({count}): {value}");
                count++;
            }
            Console.WriteLine($"Average: {list.GetAverage()}");
            Console.WriteLine($"Änderungen: {list.Count()}");

            return 0;
        }
    }
}
