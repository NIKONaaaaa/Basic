namespace Froggy
{
    using System.Collections.Generic;
    using System.Collections;
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return this.stones[i];
            }
            int lastOddIndex = this.stones.Count % 2 == 0 ? this.stones.Count - 1 : this.stones.Count - 2;
            for (int i = lastOddIndex; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}