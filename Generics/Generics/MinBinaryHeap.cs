using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MinBinaryHeap<T> : BinaryHeap<T>
        where T : IComparable
    {

        /*public MinBinaryHeap(params T[] ValuesForHeap) :
            base()
        {}*/

        public MinBinaryHeap() :
            base()
        {}


        public override void Insert(T value)
        {
            ValuesOfBinaryHeap.Add(value);
            int i = HeapSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && ValuesOfBinaryHeap[i].CompareTo(ValuesOfBinaryHeap[parent]) < 0)
            {
                T tempValue = ValuesOfBinaryHeap[i];
                ValuesOfBinaryHeap[i] = ValuesOfBinaryHeap[parent];
                ValuesOfBinaryHeap[parent] = tempValue;

                i = parent;
                parent = (i - 1) / 2;
            }
        }


        public T Extract()
        {
            T ExtractedValue = ValuesOfBinaryHeap[0];
            ValuesOfBinaryHeap[0] = ValuesOfBinaryHeap[HeapSize - 1];
            ValuesOfBinaryHeap.RemoveAt(HeapSize - 1);
            Streamline(0);
            return ExtractedValue;

        }


        private void Streamline(int indexOfParent)
        {
            int IndexOfLeftChild;
            int IndexOfRightChild;
            int IndexOfParent;

            while (true)
            {
                IndexOfLeftChild = 2 * indexOfParent + 1;
                IndexOfRightChild = 2 * indexOfParent + 2;
                IndexOfParent = indexOfParent;

                if (IndexOfLeftChild < HeapSize && ValuesOfBinaryHeap[IndexOfLeftChild].CompareTo(ValuesOfBinaryHeap[IndexOfParent]) < 0)
                {
                    IndexOfParent = IndexOfLeftChild;
                }

                if (IndexOfRightChild < HeapSize && ValuesOfBinaryHeap[IndexOfRightChild].CompareTo(ValuesOfBinaryHeap[IndexOfParent]) < 0)
                {
                    IndexOfParent = IndexOfRightChild;
                }

                if (IndexOfParent == indexOfParent)
                {
                    break;
                }

                T ValueToSwap = ValuesOfBinaryHeap[indexOfParent];
                ValuesOfBinaryHeap[indexOfParent] = ValuesOfBinaryHeap[IndexOfParent];
                ValuesOfBinaryHeap[IndexOfParent] = ValueToSwap;
                indexOfParent = IndexOfParent;
            }

        }

    }
}