namespace RecyclingStation.WasteDisposal.Attributes
{
    using System;

    /// <summary>
    /// An abstract attribute class, that represents the base of all Disposable Attribute classes.
    /// </summary>
    
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class DisposableAttribute : Attribute
    {
    }
}
