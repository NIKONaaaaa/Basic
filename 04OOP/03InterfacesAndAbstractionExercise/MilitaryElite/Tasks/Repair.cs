namespace MilitaryElite.Tasks
{
    using Interfaces;
    public class Repair : IRepair
    {
        public string Part { get; set; }
        public int Hours { get; set; }

        public Repair(string part, int hours)
        {
            Part = part;
            Hours = hours;
        }

        public override string ToString() => $"Part Name: {Part} Hours Worked: {Hours}";
    }
}