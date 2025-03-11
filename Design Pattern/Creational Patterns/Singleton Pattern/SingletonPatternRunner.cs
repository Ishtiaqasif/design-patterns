using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Creational_Patterns.Singleton_Pattern
{
    public static class SingletonPatternRunner
    {
        public static void Run()
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();
            Console.WriteLine(object.ReferenceEquals(instance1, instance2));
        }
    }
}
