using System;

namespace CSharpReference.References.Events
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