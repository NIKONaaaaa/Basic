namespace Telephony
{
    using System.Linq;
    public class Smartphone : ICallable, IBrowsable
    {
        public string Number { get; set; }
        public string Address { get; set; }

        public Smartphone()
        {
            Number = null;
            Address = null;
        }

        public string CallNumber()
        {
            if (Number.All(char.IsDigit))
            {
                return $"Calling... {Number}";
            }

            return "Invalid number!";
        }

        public string BrowseAddress()
        {
            if (Address.Any(char.IsDigit))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {Address}!";
        }
    }
}