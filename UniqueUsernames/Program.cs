using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> usernames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                if (usernames.Contains(username) == false)
                {
                    usernames.Add(username);
                }
            }

            foreach (var user in usernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
