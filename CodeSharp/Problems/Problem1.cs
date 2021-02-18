
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReference.Problems
{
    public class Problem1: ICode
    {
        public void Execute()
        {
            const string? input = "aaaabbbcca";
            // var result = Transform(input);
            // Console.WriteLine(result);
        }

        // private static (string, int) Transform(string input)
        // {
        //     var arr = input.ToCharArray();
        //
        //     var result = new List<Tuple<char, int>>();
        //
        //     var count = 0;
        //     
        //     foreach (var c in arr)
        //     {
        //         var a = result.FirstOrDefault(x => x.Item1 == c);
        //         if (a != null)
        //         {
        //             a.Item2 = a.Item2 + 1;
        //         }
        //     }
        //
        //     var r = arr.Aggregate((acc, nextChar, arr) => acc == nextChar ? nextChar : acc);
        //     return r;
        // }
    }
}