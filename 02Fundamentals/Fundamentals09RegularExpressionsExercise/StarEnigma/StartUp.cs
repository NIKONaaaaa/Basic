namespace StarEnigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            List<Planet> planets = new List<Planet>();
            const string pattern = @"@(?<planetName>[A-Za-z]+)[^@:!>-]*:(?<population>\d+)[^@:!>-]*!(?<attackType>[AD])[^@:!>-]*![^@:!>-]*->(?<soldiers>\d+)";
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = MessageDecoder(Console.ReadLine());
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    planets.Add(new Planet(match.Groups["planetName"].Value, char.Parse(match.Groups["attackType"].Value)));
                }
            }
            Console.WriteLine($"Attacked planets: {Planet.PlanetCount(planets, 'A')}");
            foreach (Planet planet in planets.Where(typeOf => typeOf.AttackType == 'A').OrderBy(planet => planet.PlanetName))
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }
            Console.WriteLine($"Destroyed planets: {Planet.PlanetCount(planets, 'D')}");
            foreach (Planet planet in planets.Where(typeOf => typeOf.AttackType == 'D').OrderBy(planet => planet.PlanetName))
            {
                Console.WriteLine($"-> {planet.PlanetName}");
            }
        }
        private static string MessageDecoder(string messageInput)
        {
            int key = messageInput.ToLower().Count(letter => letter == 's' || letter == 't' || letter == 'a' || letter == 'r');
            StringBuilder messageOutput = new StringBuilder();
            messageInput.ToList().ForEach(letter => messageOutput.Append((char)(letter - key)));
            return messageOutput.ToString();
        }
        private class Planet
        {
            public string PlanetName { get; }
            public char AttackType { get; }
            public Planet(string planetName, char attackType)
            {
                PlanetName = planetName;
                AttackType = attackType;
            }
            internal static int PlanetCount(List<Planet> planets, char attackType)
            {
                return planets.Count(typeOf => typeOf.AttackType == attackType);
            }
        }
    }
}