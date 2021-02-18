using System;
using System.Collections.Generic;

namespace CSharpReference.Problems
{
    public class Problem2: ICode
    {
        public void Execute()
        {

            object obj = new {Key = 1, Value = "abc"};

            var a = (KeyValuePair<int, string>) obj;
            
            Console.WriteLine("");
        }
    }
}