using System;

namespace CSharpReference.Events
{
    public class Bell
    {
        public event EventHandler Ring;


        protected virtual void OnRing()
        {
            Ring?.Invoke(this, EventArgs.Empty);
        }


        public void Play()
        {
            OnRing();
        }
    }
}