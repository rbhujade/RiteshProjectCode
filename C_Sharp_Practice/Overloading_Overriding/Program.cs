using System.Security.Cryptography.X509Certificates;

namespace Overloading_Overriding
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Overriding
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.OverridingMethod();

            //overloading
            Program program = new Program();
            string str = "Hello";
            int num = 10;
            program.OverloadingMethod(str);
            program.OverloadingMethod(str,num);
        }

        //Overloading Method
        public string OverloadingMethod(string str)
        {
            return "Ritesh";
        }

        //Overloading Method
        public string OverloadingMethod(string str,int num)
        {
            return "Ritesh";
        }

        //Overriding Method
        public class BaseClass
        {
            public virtual string OverridingMethod()
            {
                return "";
            }
        }
        //Overriding Method
        public class DerivedClass : BaseClass 
        {
            public override string OverridingMethod()
            {
                return "";
            }
        }
    }
}