namespace Telephony
{
    using System.Linq;
    public class StationaryPhone : ICallable
    {
        public string Number { get; set; }

        public StationaryPhone(string number)
        {
            Number = number;
        }

        public string CallNumber()
        {
            if (Number.All(char.IsDigit))
            {
                return $"Dialing... {this.Number}";
            }

            return "Invalid number!";
        }
    }
}