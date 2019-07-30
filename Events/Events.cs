using System;

namespace CSharpReference.Events
{
    public class Events : IReference

    {
        public int Code => 2;
        public string Name => "Events";

        public void Execute()
        {
            var bell = new Bell();
            bell.Ring += Click;
            bell.Ring += Click;
            bell.Ring += Click;

            bell.Play();
        }

        private static void Click(object sender, EventArgs args)
        {
            Console.WriteLine("TUM ");
        }
    }
}