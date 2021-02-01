using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _04.Froggy
{
    class Lake : IEnumerable<int>
    {
        private List<int> Stones;

        public Lake(List<int> stones)
        {
            this.Stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < this.Stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(this.Stones[i]);
                }
                else
                {
                    odds.Add(this.Stones[i]);
                }
            }

            foreach (var item in evens)
            {
                yield return item;
            }

            odds.Reverse();

            foreach (var item in odds)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
