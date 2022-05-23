using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] people = { "Sam", "Dio", "Nathan", "Nicko" };

            var selectedPeople = people.Select(s => s.First()).Reverse();


            foreach (var item in selectedPeople)
            {
                Console.WriteLine(item);
            }

        }
	
    }
}
