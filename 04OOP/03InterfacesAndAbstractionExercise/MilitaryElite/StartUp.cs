namespace MilitaryElite
{
    using Interfaces;
    using Soldiers;
    using Tasks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string command;
            var privates = new List<IPrivate>();
            var soldiers = new List<ISoldier>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] entry = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (entry[0] == "Private")
                {
                    var newPrivate = new Private(entry[1], entry[2], entry[3], decimal.Parse(entry[4]));
                    privates.Add(newPrivate);
                    soldiers.Add(newPrivate);
                }
                else if (entry[0] == "LieutenantGeneral")
                {
                    var newLtGen = new LieutenantGeneral(entry[1], entry[2], entry[3], decimal.Parse(entry[4]));
                    for (int i = 5; i < entry.Length; i++)
                    {
                        newLtGen.Privates.Add(privates.FirstOrDefault(x => x.Id == entry[i]));
                    }

                    soldiers.Add(newLtGen);
                }
                else if (entry[0] == "Engineer")
                {
                    if (entry[5] == "Marines" || entry[5] == "Airforces")
                    {
                        var newEngineer = new Engineer(entry[1], entry[2], entry[3], decimal.Parse(entry[4]), entry[5]);

                        for (int i = 6; i < entry.Length - 1; i += 2)
                        {
                            var newRepair = new Repair(entry[i], int.Parse(entry[i + 1]));
                            newEngineer.Repairs.Add(newRepair);
                        }

                        soldiers.Add(newEngineer);
                    }
                }
                else if (entry[0] == "Commando")
                {
                    var newCommando = new Commando(entry[1], entry[2], entry[3], decimal.Parse(entry[4]), entry[5]);

                    for (int i = 6; i < entry.Length - 1; i += 2)
                    {
                        if (entry[i + 1] == "inProgress" || entry[i + 1] == "Finished")
                        {
                            var newMission = new Mission(entry[i], entry[i + 1]);
                            newCommando.Missions.Add(newMission);
                        }
                    }

                    soldiers.Add(newCommando);
                }
                else if (entry[0] == "Spy")
                {
                    var newSpy = new Spy(entry[1], entry[2], entry[3], int.Parse(entry[4]));
                    soldiers.Add(newSpy);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, soldiers));
        }
    }
}