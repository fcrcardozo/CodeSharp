
using System;

namespace CSharpReference.BitMap
{
    public class BitMap : ICode
    {
        public int Code => 3;
        public void Execute()
        {
            var bm = new BitMapCollection();
            bm.Add(1);
            bm.Add(2);
            bm.Add(4);
            bm.Add(255);
 
            Console.WriteLine(bm.ToString());
            
            Console.WriteLine(bm.Contains(1));
            Console.WriteLine(bm.Contains(2));
            Console.WriteLine(bm.Contains(3));

            Console.WriteLine(bm.Contains(255));
            Console.WriteLine(bm.Contains(256));
            
            
            Console.ReadKey();
        }

        private class BitMapCollection
        {
            private bool[] _indexes = new bool[2];
            private int Capacity => _indexes.Length;

            public void Add(int value) {
                EnsureCapacity(value + 1);
                _indexes[value] = true;
            }

            private void EnsureCapacity(int newCapacity) {
                if (Capacity < newCapacity) {
                    Grow(newCapacity);
                }
            }

            private void Grow(int newSize) {
                Array.Resize(ref _indexes, newSize);
            }

            public bool Contains(int value) {
                return value < Capacity && _indexes[value];
            }
        }
    }
}