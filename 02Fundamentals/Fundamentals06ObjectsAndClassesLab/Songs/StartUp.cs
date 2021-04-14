namespace Songs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class StartUp
    {
        static void Main()
        {
            int songCounter = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < songCounter; i++)
            {
                string[] input = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                Song currentSong = new Song
                {
                    TypeList = input[0],
                    Name = input[1],
                    Time = input[2]
                };
                songs.Add(currentSong);
            }
            string typeList = Console.ReadLine();
            List<Song> songsOutput = new List<Song>();
            if (typeList == "all")
            {
                songsOutput = songs.ToList();
            }
            else
            {
                songsOutput = songs.Where(song => song.TypeList == typeList).ToList();

            }
            foreach (Song song in songsOutput)
            {
                Console.WriteLine(song.Name);
            }
        }
    }
}