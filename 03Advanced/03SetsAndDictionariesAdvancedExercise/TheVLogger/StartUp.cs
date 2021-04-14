namespace TheVLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, Vlogger> vloggers = new Dictionary<string, Vlogger>();
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] tokens = input.Split();
                string vloggerName = tokens[0];
                string command = tokens[1];
                if (command == "joined")
                {
                    if (!vloggers.ContainsKey(vloggerName))
                    {
                        Vlogger vlogger = new Vlogger(vloggerName);
                        vloggers.Add(vloggerName, vlogger);
                    }
                }
                else
                {
                    string vloggerFollowerName = tokens[2];
                    if (vloggers.ContainsKey(vloggerName) && vloggers.ContainsKey(vloggerFollowerName) && vloggerName != vloggerFollowerName)
                    {
                        vloggers[vloggerName].Following.Add(vloggerFollowerName);
                        vloggers[vloggerFollowerName].Followers.Add(vloggerName);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;
            foreach (var item in vloggers.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count))
            {
                Console.WriteLine($"{count}. {item.Key} : {item.Value.Followers.Count} followers, {item.Value.Following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in item.Value.Followers.OrderBy(n => n))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
    class Vlogger
    {
        public string Name { get; set; }
        public HashSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
        public Vlogger(string name)
        {
            Name = name;
            Followers = new HashSet<string>();
            Following = new HashSet<string>();
        }
    }
}