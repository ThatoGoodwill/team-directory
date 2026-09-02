using System;

namespace TeamDirectory
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Team Directory");

            List<string> teamMembers = new List<string>();

            //retrieve names from team.txt file and add them to the list
            string[] names = File.ReadAllLines("team.txt");

            foreach (string name in names)
            {
                teamMembers.Add(name);
            }

            foreach (string member in teamMembers)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine();
            Console.Write("Enter a name to search: ");
            string? searchName = Console.ReadLine();

            foreach (string member in teamMembers)
            {
                if (member == searchName)
                {
                    Console.WriteLine("Found: " + member);
                }              
            }
             Console.WriteLine("Total team members: " + teamMembers.Count);
        }
    }
}