using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape(10, 10); s.Draw();
            //Circle c = new Circle(9, 9); c.Draw();
            //Square sq = new Square(8, 8); sq.Draw();


            //Shape s1 = new Circle(7,7); s1.Draw();      // Up-casting
            //Shape s2 = new Square(6, 6); s2.Draw();     // Up-casting

            Shape s3 = new Circle(5,5);
            ((Circle)s3).FillCircle();                            // Down-Casting            

            Test t = new Test(1);
            t.Show();
            Console.ReadKey();
        }
    }

    public class Test
    {
        public Test()
        {
            Console.WriteLine("Default Constructor");
        }

        public Test(int x)
        {
            Console.WriteLine($"Parameterized Constructor -> {x}");
        }

        public void Show()
        {
            Console.WriteLine("Test -> Show()");
        }
    }


    public class Shape
    {
        protected int MXpos;
        protected int MYpos;

        public Shape()
        {
            Console.WriteLine($"Default Constructor");
        }

        public Shape(int mXpos,int mYpos)
        {
            MXpos = mXpos;
            MYpos = mYpos;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing a SHAPE at {MXpos},{MYpos}");
        }
    }

    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(int mXpos, int mYpos) : base(mXpos, mYpos)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a CIRCLE at {MXpos},{MYpos}");
        }

        public void FillCircle()
        {
            Console.WriteLine($"Fill a CIRCLE...");
        }
    }

    public class Square : Shape
    {
        public Square()
        {            
        }
        public Square(int mXpos, int mYpos) : base(mXpos, mYpos)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a SQUARE at {MXpos},{MYpos}");
        }

        public void FillSquare()
        {
            Console.WriteLine($"Fill a SQUARE...");
        }
    }

}
