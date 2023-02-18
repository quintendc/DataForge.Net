using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public class ForgeBuilder<T>
    {
        private readonly T _instance;

        public ForgeBuilder(T instance)
        {
            _instance = instance;
        }

        public ForgeBuilder<T> RuleFor(Action<T> action)
        {
            action(_instance);
            return this;
        }

        public T Build()
        {
            return _instance;
        }
    }

    public static class RuleBuilderExtensions
    {
        public static ForgeBuilder<T> Forge<T>(this T instance)
        {
            return new ForgeBuilder<T>(instance);
        }
    }

}
