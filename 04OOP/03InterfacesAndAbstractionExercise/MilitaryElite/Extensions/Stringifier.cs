namespace MilitaryElite.Extensions
{
    using Interfaces;
    public static class Stringifier
    {
        public static string SoldierToString(this ISoldier soldier)
        {
            return $"Name: {soldier.FirstName} {soldier.LastName} Id: {soldier.Id}";
        }

        public static string PrivateToString(this IPrivate soldier)
        {
            return $"{SoldierToString(soldier)} Salary: {soldier.Salary:f2}";
        }

        public static string SpyToString(this ISpy soldier)
        {
            return $"{SoldierToString(soldier)}\r\nCode Number: {soldier.CodeNumber}";
        }

        public static string LtGeneralToString(this ILieutenantGeneral soldier)
        {
            return $"{PrivateToString(soldier)}\r\nPrivates:";
        }

        public static string SpecialistToString(this ISpecialisedSoldier soldier)
        {
            return $"{PrivateToString(soldier)}\r\nCorps: {soldier.Corps}";
        }

        public static string CommandoToString(this ICommando soldier)
        {
            return $"{SpecialistToString(soldier)}\r\nMissions:";
        }

        public static string EngineerToString(this IEngineer soldier)
        {
            return $"{SpecialistToString(soldier)}\r\nRepairs:";
        }
    }
}