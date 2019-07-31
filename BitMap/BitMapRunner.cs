using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace CSharpReference.BitMap
{
    public class BitMapRunner : IReference
    {
        public int Code => 3;
        public string Name => "BitMap";

        public void Execute()
        {
            var bm = new BitMap();
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

        private class BitMap
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