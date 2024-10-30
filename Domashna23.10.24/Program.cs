using System.Collections;

namespace Domashna23._10._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList() {"Ivan", "Petq", "Georgi" };
            ArrayList ages = new ArrayList() { 15, 16, 17 };
            ArrayList grades = new ArrayList() { 5.50, 6.00, 3.50 };

            names.Add("Petur");
            ages.Add(14);
            grades.Add(4.00);

            names.Remove("Georgi");
            ages.Remove(17);
            grades.Remove(3.50);

            if (ages.Count == 0) 
            {
                Console.WriteLine("There aren't students in the list");
            }

            int minAge = (int)ages[0];
            int minIndex = 0;

            for (int i = 1; i < ages.Count; i++) 
            {
                if ((int)ages[i] < minAge) 
                { 
                   minAge = (int)ages[i];
                   minIndex = i;
                }

            }

            Console.WriteLine($"The youngest student is {names[minIndex]}. They are {minAge} years old");
        }

  
    }
}
