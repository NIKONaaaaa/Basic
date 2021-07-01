namespace MilitaryElite.Extensions
{
    using Interfaces;
    public static class Stringifier
    {
        public static string Stringify(this ISoldier soldier) => $"Name: {soldier.FirstName} {soldier.LastName} Id: {soldier.Id}";

        public static string Stringify(this IPrivate soldier) => $"{Stringify((ISoldier) soldier)} Salary: {soldier.Salary:f2}";

        public static string Stringify(this ISpy soldier) => $"{Stringify((ISoldier) soldier)}\r\nCode Number: {soldier.CodeNumber}";

        public static string Stringify(this ILieutenantGeneral soldier) => $"{Stringify((IPrivate) soldier)}\r\nPrivates:\r\n  {string.Join("\r\n  ", soldier.Privates)}".TrimEnd();

        public static string Stringify(this ISpecialisedSoldier soldier) => $"{Stringify((IPrivate) soldier)}\r\nCorps: {soldier.Corps}";

        public static string Stringify(this ICommando soldier) => $"{Stringify((ISpecialisedSoldier) soldier)}\r\nMissions:\r\n  {string.Join("\r\n  ", soldier.Missions)}".TrimEnd();

        public static string Stringify(this IEngineer soldier) => $"{Stringify((ISpecialisedSoldier) soldier)}\r\nRepairs:\r\n  {string.Join("\r\n  ", soldier.Repairs)}".TrimEnd();
    }
}