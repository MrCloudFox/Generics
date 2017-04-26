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

        /*public readonly T[] ValuesOfBinaryHeap; // На базе простого массива
        public readonly int  SizeOfHeap = 0;*/

        /*public BinaryHeap(int SizeOfHeap) // На базе простого массива (при инизализации задаётся размер кучи)
        {
            ValuesOfBinaryHeap = new T[SizeOfHeap];
        }*/

        /*public BinaryHeap(params T[] ValueForHeap)
        {
            for (int i = 0; i < ValueForHeap.Length; i++)
            {
                ValuesOfBinaryHeap.Add(ValueForHeap[i]);
            }
        }*/


        public BinaryHeap() { }

        /*public int HeapSize           // На базе простого массива
        {
            get
            {
                return ValuesOfBinaryHeap.Length;
            }
        }*/

        public int HeapSize
        {
            get
            {
                return ValuesOfBinaryHeap.Count();
            }
        }

        /*public virtual void Insert(T value) // На базе простого массива
        {
            ValuesOfBinaryHeap[SizeOfHeap] = value;
            SizeOfHeap++;
        }*/

        public virtual void Insert(T Value)
        {
            if(ValuesOfBinaryHeap.Contains(Value))
            {
                throw new ArgumentException("Элемент кучи уже имеется");
            }
            else
            ValuesOfBinaryHeap.Add(Value);
        }


    }
}
