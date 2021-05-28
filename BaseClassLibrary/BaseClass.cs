using System;

namespace BaseClassLibrary
{
    public class BaseClass
    {
        internal string Intenalmodifer = "Internal";
        protected internal string ProtectedInternalModifer = "Protected Internal";
    }
    public class InternalBaseClass
    {
        public void InternalTest()
        {
            BaseClass instance = new BaseClass();          
            Console.WriteLine("Base Class is called. \nThis is " + instance.Intenalmodifer + " Access modifier");

            //Console.WriteLine("This is " + instance.PIModifer + " Access modifier");
        }
    }
}
