namespace MilitaryElite.Tasks
{
    using Interfaces;
    public class Mission : IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public void CompleteMission()
        {
            State = "Finished";
        }

        public override string ToString() => $"Code Name: {CodeName} State: {State}";
    }
}