using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DataForge
{
    public static partial class Forge
    {

        private static Random random = new Random();


        #region Methods

        /// <summary>
        /// Create a single instance of any kind of object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="propertySetter">Property to set</param>
        /// <returns>Instance of specified object</returns>
        public static T CreateInstance<T>(Action<T> propertySetter) where T : class, new()
        {
            T instance = new T();
            propertySetter(instance);
            return instance;
        }

        /// <summary>
        /// Create many instances of any kind of object
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="count">Amount of instances</param>
        /// <param name="propertySetter">Property to set</param>
        /// <returns>List of the specified object</returns>
        public static List<T> CreateInstances<T>(int count, Action<T> propertySetter) where T : class, new()
        {
            List<T> instances = new List<T>();
            for (int i = 0; i < count; i++)
            {
                T instance = new T();
                propertySetter(instance);
                instances.Add(instance);
            }
            return instances;
        }

        #endregion

    }
}
