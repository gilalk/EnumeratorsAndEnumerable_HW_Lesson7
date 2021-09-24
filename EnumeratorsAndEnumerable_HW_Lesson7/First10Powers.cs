using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerable_HW_Lesson7
{
    class First10Powers : IEnumerable<Double>
    {
        public int num { get; set; }

        public First10Powers(int num)
        {
            this.num = num;
        }

        public IEnumerator<Double> GetEnumerator()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return Math.Pow(this.num, i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
