using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class BinaryHeap<T>
        where T : IComparable
    {
        public readonly List<T> ValuesOfBinaryHeap = new List<T>();

        /*public BinaryHeap(params T[] ValueForHeap)
        {
            for (int i = 0; i < ValueForHeap.Length; i++)
            {
                ValuesOfBinaryHeap.Add(ValueForHeap[i]);
            }
        }*/

        
        public BinaryHeap() { }


        public int HeapSize
        {
            get
            {
                return ValuesOfBinaryHeap.Count();
            }
        }


        public virtual void Insert(T Value)
        {
            ValuesOfBinaryHeap.Add(Value);
        }


    }
}
