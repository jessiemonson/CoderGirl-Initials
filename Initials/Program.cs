using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name.:");
            string name = Console.ReadLine();
            
            Console.WriteLine(Initials(name));
            
                Console.ReadLine();
        }
        public static string Initials(String name1)
        {
            String result = "";
            string[] output = name1.Split(' ');
            foreach (string s in output)
            {
                result += s[0];
            }
            
            return result.ToUpper();

        }
            


        // TODO: Create a method that takes in a full name and return the initials in all capital letters.
    }
}
