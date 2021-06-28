namespace Telephony
{
    public interface IBrowsable
    {
        public string Address { get; set; }

        public string BrowseAddress();
    }
}