namespace Telephony
{
    public interface ICallable
    {
        public string Number { get; set; }

        public string CallNumber();
    }
}