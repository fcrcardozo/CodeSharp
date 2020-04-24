using System;

namespace CSharpReference.References.Events
{
    public class Events : ICode

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