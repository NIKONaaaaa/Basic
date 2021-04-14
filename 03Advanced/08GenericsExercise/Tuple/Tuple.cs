namespace Tuple
{
    public class Tuple<TFirst, TSecond>
    {
        public TFirst FirstEntry { get; set; }
        public TSecond SecondEntry { get; set; }
        public Tuple(TFirst firstValue, TSecond secondValue)
        {
            FirstEntry = firstValue;
            SecondEntry = secondValue;
        }
    }
}