using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePicker
{
     public class Start : Names   // Need to add a way to make the names not repeat, and then give an option to start over.
    {

        public Start()
        {

            var cohort3ClassList = cohort3ClassRoster.ToList();

            while (cohort3ClassList.Count > 0)
            {
                Console.Clear();
                string x = "Random Name Picker! *Making Rudy's life easier*";
                Console.SetCursorPosition((Console.WindowWidth - x.Length) / 2, Console.CursorTop); // Centering message and keeping a consistent layout.
                Console.WriteLine(x);
                Console.WriteLine("\n\n\n Press Enter to Pick a name\n\n");
                Pick(cohort3ClassList);
                
            }

            Console.WriteLine("You have gone through all 24 students now.\n\nEnter [1] To start over or press anything else to exit the application");//switch statement
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    new Start();
                    break;
                default:
                    break;
                    
            }
        }
        

        public void Pick(List<string> cohort3ClassList) // This takes the list that was converted from the array of names, and randomizes and removes so repeats do not happen.
        {

            Random rnd = new Random();
            var rndnames = cohort3ClassList.OrderBy(a => rnd.NextDouble()).First();
            cohort3ClassList.Remove(rndnames);
            Console.WriteLine(rndnames);
            Console.ReadLine();
        }   
    }
}
