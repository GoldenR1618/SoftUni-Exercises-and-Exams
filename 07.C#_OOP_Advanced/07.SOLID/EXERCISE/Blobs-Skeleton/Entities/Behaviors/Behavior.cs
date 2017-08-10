namespace _02.Blobs.Entities.Behaviors
{
    using Interfaces;

    public abstract class Behavior : IBehavior
    {
        protected Behavior()
        {
            this.IsTriggered = false;
        }

        protected abstract void ApplyTriggerEffect(Blob source);

        public bool IsTriggered { get; protected set; }

        public abstract void Trigger(Blob source);

        public abstract void ApplyPostTriggerEffect(Blob source);
    }
}