namespace Threeuple
{
    public class Threeuple<TFirst, TSecond, TThird>
    {
        public TFirst FirstEntry { get; set; }
        public TSecond SecondEntry { get; set; }
        public TThird ThirdEntry { get; set; }
        public Threeuple(TFirst firstValue, TSecond secondValue, TThird thirdValue)
        {
            FirstEntry = firstValue;
            SecondEntry = secondValue;
            ThirdEntry = thirdValue;
        }
    }
}