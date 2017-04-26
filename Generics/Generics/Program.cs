using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] ValuesForHeap = new double[]{ 1.5, 2.7, 1, 8.4, 1.1 };
            //MaxBinaryHeap<double> MaxBinaryHeap = new MaxBinaryHeap<double>();
            MinBinaryHeap<double> MinBinaryHeap = new MinBinaryHeap<double>();
            MinBinaryHeap.Insert(15);
            MinBinaryHeap.Insert(11);
            MinBinaryHeap.Insert(6);
            MinBinaryHeap.Insert(9);
            MinBinaryHeap.Insert(7);
            MinBinaryHeap.Insert(8);
            MinBinaryHeap.Insert(1);
            MinBinaryHeap.Insert(3);
            MinBinaryHeap.Insert(5);
            MinBinaryHeap.Insert(17);

            /*for (int i = 0; i < MaxBinaryHeap.HeapSize; i++)
            {
                Console.WriteLine(MaxBinaryHeap.ValuesOfBinaryHeap[i]);
            }*/

            for (int i = 0; i < MinBinaryHeap.HeapSize; i++)
            {
                Console.WriteLine(MinBinaryHeap.ValuesOfBinaryHeap[i]);
            }

        }

    }
}
