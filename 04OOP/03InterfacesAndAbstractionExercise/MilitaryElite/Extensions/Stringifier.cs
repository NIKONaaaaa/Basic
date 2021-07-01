namespace MilitaryElite.Extensions
{
    using Interfaces;
    using Soldiers;
    public static class Stringifier
    {
        public static string Stringify(this ISoldier soldier)
        {
            return $"Name: {soldier.FirstName} {soldier.LastName} Id: {soldier.Id}";
        }

        public static string Stringify(this IPrivate soldier)
        {
            var entry = new Soldier(soldier.Id, soldier.FirstName, soldier.LastName);
            return $"{entry.Stringify()} Salary: {soldier.Salary:f2}";
        }

        public static string Stringify(this ISpy soldier)
        {
            var entry = new Soldier(soldier.Id, soldier.FirstName, soldier.LastName);
            return $"{entry.Stringify()}\r\nCode Number: {soldier.CodeNumber}";
        }
    }
}