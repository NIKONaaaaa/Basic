namespace MilitaryElite.Extensions
{
    using Interfaces;
    public static class Stringifier
    {
        public static string SoldierToString(this ISoldier soldier) => $"Name: {soldier.FirstName} {soldier.LastName} Id: {soldier.Id}";

        public static string PrivateToString(this IPrivate soldier) => $"{SoldierToString(soldier)} Salary: {soldier.Salary:f2}";

        public static string SpyToString(this ISpy soldier) => $"{SoldierToString(soldier)}\r\nCode Number: {soldier.CodeNumber}";

        public static string LtGeneralToString(this ILieutenantGeneral soldier) => $"{PrivateToString(soldier)}\r\nPrivates:\r\n  {string.Join("\r\n  ", soldier.Privates)}".TrimEnd();

        public static string SpecialistToString(this ISpecialisedSoldier soldier) => $"{PrivateToString(soldier)}\r\nCorps: {soldier.Corps}";

        public static string CommandoToString(this ICommando soldier) => $"{SpecialistToString(soldier)}\r\nMissions:\r\n  {string.Join("\r\n  ", soldier.Missions)}".TrimEnd();

        public static string EngineerToString(this IEngineer soldier) => $"{SpecialistToString(soldier)}\r\nRepairs:\r\n  {string.Join("\r\n  ", soldier.Repairs)}".TrimEnd();
    }
}