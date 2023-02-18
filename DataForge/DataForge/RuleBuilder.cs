using System;
using System.Collections.Generic;
using System.Text;

namespace DataForge
{
    public class RuleBuilder<T>
    {
        private readonly T _instance;

        public RuleBuilder(T instance)
        {
            _instance = instance;
        }

        public RuleBuilder<T> SetProperty(Action<T> action)
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
        public static RuleBuilder<T> CreateBuilder<T>(this T instance)
        {
            return new RuleBuilder<T>(instance);
        }
    }

}
