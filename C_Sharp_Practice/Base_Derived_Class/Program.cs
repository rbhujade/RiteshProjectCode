namespace Base_Derived_Class
{
    class Program
    {
        public static void Main(string[] args) 
        {
            A a = new A();
            B b1 = new B();
            A c = new B();
            //B d= new A();

            BaseClass baseClass = new BaseClass();
            baseClass.Print();
            //Init base class
            //Print Base

            Console.WriteLine("");
            BaseClass b = new DerivedClass();
            b.Print();
            //Init base class
            //Init Derived
            //Print Base

            Console.WriteLine("");

            DerivedClass b2 = new DerivedClass();
            b2.Print();
            b2.Print2();
            //Init base class
            //Init Derived
            //Derived print
            //Print 2


            //DerivedClass d = new BaseClass(); //incorrect


            Console.ReadLine();
        }
    }


    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Init base class");
        }
        public virtual void Print()
        {
            Console.WriteLine("Print Base");
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("Init Derived");
        }
        public override void Print()
        {
            Console.WriteLine("Derived print");
        }
        public void Print2()
        {
            Console.WriteLine("Print 2");
        }
    }

    class A
    {

    }
    class B : A
    {

    }

}