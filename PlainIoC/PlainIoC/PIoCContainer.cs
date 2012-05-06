using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace PlainIoC
{
    public class PIoCContainer
    {
        internal IList<string> Assemblies { get; set; }
        internal IList<Type> Types { get; set; }
        internal IDictionary<Type, Delegate> TypesWithDelegate { get; set; }

        public PIoCContainer()
        {
            Assemblies = new List<string>();
            Types = new List<Type>();
            TypesWithDelegate = new Dictionary<Type, Delegate>();
        }

        public void RecordAssembly(Assembly assembly)
        {
            Assemblies.Add(assembly.FullName);
            foreach (Type type in assembly.GetTypes())
            {
                Types.Add(type);
            }
        }

        public void Record<T>(T t, Func<T> f)
        {
            if (Types.Contains(t.GetType()))
            {
                Types.Remove(t.GetType());
                TypesWithDelegate.Add(t.GetType(), f);
            }
        }

        public T Return<T>()
        {
            return Activator.CreateInstance<T>();
        }

        public void Prepare()
        {
            
        }
    }
}
