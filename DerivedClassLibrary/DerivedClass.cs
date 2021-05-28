using System;
using BaseClassLibrary;

namespace DerivedClassLibrary
{
    public class DerivedClass
    {
        public class InternalDerivedClass : BaseClass
        {
            public void ProtectedDerivedClass()
            {
                BaseClass instance = new BaseClass();
                Console.WriteLine("Derived Class is called. \nThis is " + base.ProtectedInternalModifer + " access modifier");
            }
        }
    }
}
