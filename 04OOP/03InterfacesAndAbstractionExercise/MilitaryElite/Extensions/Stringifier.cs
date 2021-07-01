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

        public static string Stringify(this ILieutenantGeneral soldier)
        {
            var entry = new Private(soldier.Id, soldier.FirstName, soldier.LastName, soldier.Salary);
            return $"{entry.Stringify()}\r\nPrivates:";
        }

        public static string Stringify(this ISpecialisedSoldier soldier)
        {
            var entry = new Private(soldier.Id, soldier.FirstName, soldier.LastName, soldier.Salary);
            return $"{entry.Stringify()}\r\nCorps: {soldier.Corps}";
        }

        public static string Stringify(this ICommando soldier)
        {
            var entry = new SpecialisedSoldier(soldier.Id, soldier.FirstName, soldier.LastName, soldier.Salary, soldier.Corps);
            return $"{entry.Stringify()}\r\nMissions:";
        }

        public static string Stringify(this IEngineer soldier)
        {
            var entry = new SpecialisedSoldier(soldier.Id, soldier.FirstName, soldier.LastName, soldier.Salary, soldier.Corps);
            return $"{entry.Stringify()}\r\nRepairs:";
        }
    }
}