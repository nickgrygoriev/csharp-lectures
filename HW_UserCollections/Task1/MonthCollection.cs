using System.Collections;

namespace Task1
{
    class MonthCollection : IEnumerable
    {
        private Month[] monthes;

        public MonthCollection(Month[] monthes)
        {
            this.monthes = monthes;
        }

        public Month this[int number]
        {
            get { return monthes[number - 1]; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i <monthes.Length; i++)
            {
                yield return monthes[i];
            }
        }

        public IEnumerable GetByDays(int days)
        {
            for (int i = 0; i < monthes.Length; i++)
            {
                if (monthes[i].DaysQuantity == days) { 
                    yield return monthes[i];
                }
            }
        }
    }
}
