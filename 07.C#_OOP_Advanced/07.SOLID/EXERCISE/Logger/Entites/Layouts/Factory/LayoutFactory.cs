namespace Logger.Entites.Layouts.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Interfaces;

    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutName)
        {
            Type layoutType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == layoutName);
            return (ILayout) Activator.CreateInstance(layoutType);
        }
    }
}