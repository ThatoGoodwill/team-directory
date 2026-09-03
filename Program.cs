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

            Console.WriteLine();
            Console.Write("Display members alphabetically? (y/n): ");
            string? sortChoice = Console.ReadLine();

            if (sortChoice?.Trim().Equals("y", StringComparison.OrdinalIgnoreCase) == true)
            {
                teamMembers.Sort(StringComparer.OrdinalIgnoreCase);
            }
            

            foreach (string member in teamMembers)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine();
           Console.Write("Enter a name to search: ");
string? searchName = Console.ReadLine();

if (string.IsNullOrWhiteSpace(searchName))
{
    Console.WriteLine("Search name cannot be empty.");
}
else
{
    bool found = false;

    foreach (string member in teamMembers)
    {
        if (member.Contains(searchName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"Found: {member}");
            found = true;
        }
    }

    if (!found)
    {
        Console.WriteLine($"No team members found matching: {searchName}");
    }
}
             Console.WriteLine("Total team members: " + teamMembers.Count);
        }
    }
}