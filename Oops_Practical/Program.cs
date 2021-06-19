using System;
using BaseClassLibrary;
using static DerivedClassLibrary.DerivedClass;

namespace Oops_Practical
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Creating objects for the mobile Class
            Moblies smartphone = new Moblies();
            smartphone.name = "Nokia";
            //smartphone.model = "3315"; Private perameter
            //smartphone.phonenumber = 9898000000; Protected Parameter



            #region Internal / Protectected Access Modifier Inheritance
            InternalBaseClass Ib = new InternalBaseClass();
            Ib.InternalTest();

            //Protected Internal Access Modifer
            InternalDerivedClass Idc = new InternalDerivedClass();
            Idc.ProtectedDerivedClass();

            //Multilevel Inheritance using user inputs
            Console.WriteLine("\nPlease Enter the Car details: ");
            Car car = new Car();
            car.Drive();
            car.Speed();
            car.SeatingCapacity();
            Console.WriteLine("\nPlease Enter the Bus details: ");
            Bus bus = new Bus();
            bus.Drive();
            bus.Speed();
            bus.SeatingCapacity();

            ////Multilevel Inheritance Simple
            //Console.WriteLine("\n Simple Example");
            //Son son = new Son();
            //son.grandfather();
            //son.father();
            //son.son();
            #endregion

            //caluculation
            SimpleInterest SI = new SimpleInterest();
            Console.WriteLine("\nInterest calculation");
            SI.Inputs();
            SI.Calculation();
        }
    }


    #region Access Modifer
    public class AccessM
    {
        public int a;
        //This is method
        public void Display()
        {
            Console.WriteLine("This is Display Method");
        }
    }
    
    public class Moblies
    {
        public string name;
        private string model;
        protected Int64 phonenumber;
        public void MakeACall()
        {
            Console.WriteLine("Calling to name");
        }
    }
    public class Smartphones : Moblies
    {
        public void TakeAPhoto()
        {
            name = "Nokia";
            //model is not able to acces as it is private method
            phonenumber = 8089808080; 
        }
    }
    #endregion

    #region Multiple Inheritance with User inputs
    public class Vehicle
    {
        public string name;
        public int speed;
        public int capacity;
        public void Drive()
        {
            Console.WriteLine("Enter the Vehile Name: ");
            name = Console.ReadLine();
            Console.WriteLine("This is " + name);
        }
        public void Speed()
        {
            Console.WriteLine("Enter the Speed of Vehile: ");
            speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The speed is " + speed + "Kmph");
        }
        public void SeatingCapacity()
        {
            Console.WriteLine("Enter the capacity: ");
            capacity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seating Capacity is "+ capacity);
        }
    }    
    public class Car : Vehicle
    {    }
    public class Bus : Vehicle
    {    }
    #endregion

    #region Multilevel Inheritance
    //class Grandfather
    //{
    //    public void grandfather()
    //    {
    //        Console.WriteLine("Grandfather...");
    //    }
    //}
    //class Father : Grandfather
    //{
    //    public void father()
    //    {
    //        Console.WriteLine("Father...");
    //    }
    //}
    //class Son : Father
    //{
    //    public void son()
    //    {
    //        Console.WriteLine("Son.. ");
    //    }
    //}
    #endregion
}
