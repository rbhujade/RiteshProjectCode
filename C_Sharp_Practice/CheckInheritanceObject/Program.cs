using System.ComponentModel;

class Program
{
    public static void Main(string[] args)
    {
        A a= new A();
        A b= new B();
        //B c= new A();
        B d= new B();
    }


    class A
    {

    }

    class B : A 
    { 
    
    }
}
