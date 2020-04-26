using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace CSharpReference.LeetCode._2_AddTwoNumbers
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var a = Inverse(GetAllNumbersListNode(l1,  new List<int>()));
            var b = Inverse(GetAllNumbersListNode(l2,  new List<int>()));

            var c = a + b;

            var cArr = c.ToString().Select(x => int.Parse(x.ToString())).ToArray();

            var cArrInverse = new List<int>();
            for (int i = cArr.Count() - 1; i >= 0; i--)
            {
                cArrInverse.Add(cArr[i]);
            }

            return CreateListNodes(cArrInverse.ToArray());
        }

        private BigInteger Inverse(string num)
        {
            var numArr = num.Select(x => int.Parse(x.ToString())).ToArray();
            
            var numArrInverse = new List<int>();
            for (int i = numArr.Count() - 1; i >= 0; i--)
            {
                numArrInverse.Add(numArr[i]);
            }

            return BigInteger.Parse(string.Join(string.Empty, numArrInverse));
        }


        public string GetAllNumbersListNode(ListNode l, List<int> acumulator)
        {
            acumulator.Add(l.val);
            if (l.next != null)
            {
                return GetAllNumbersListNode(l.next, acumulator);
            }

            return string.Join(string.Empty, acumulator);
        }

        public ListNode CreateListNodes(int[] x)
        {
            var l = new ListNode(x[0]);
            
            if (x.Length > 1)
            {
                l.next = CreateListNodes(x.Skip(1).ToArray());
            };

            return l;
        }
    }

    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int x)
        {
            val = x;
        }
    }
}