using System.Xml;

class Program
{
    static void Main(string[] args)
    {   
        TestRef testRef = new TestRef();
        testRef.RefDisplay();

        Console.WriteLine();

        TestOut testOut = new TestOut();    
        testOut.OutDisplay();

        Console.ReadLine();

        int num = 100; //Must be initialize for ref
        RefMethod(ref num);
        Console.WriteLine(num.ToString());

        OutMethod(out int outNum); // No need to initialize for out
        Console.WriteLine(outNum);
    }

    static void OutMethod(out int outNum)
    {
        outNum = 9999;
    }

    public static void RefMethod(ref int num)
    {
        num = 1000;
    }

    public static void TestRefParam(ref int value1,ref int value2)
    {

    }
}

class TestRef
{
    private string name = "Ref Welcome";

    public void RefDisplay()
    {
        RefDisplay2(ref name,ref name);
        Console.WriteLine(name);
    }

    public void RefDisplay2(ref string x,ref string y)
    {
        Console.WriteLine(name);
        x = "Ref Welcome 1";
        Console.WriteLine(name);
        y = "Ref Welcome 2";
        Console.WriteLine(name);
        name = "Ref Welcome 3";
    }
}

class TestOut
{
    private string name = "Out Welcome";

    public void OutDisplay()
    {
        OutDisplay2(out name, out name);
        Console.WriteLine(name);
    }

    public void OutDisplay2(out string x, out string y)
    {
        Console.WriteLine(name);
        x = "Out Welcome 1";
        Console.WriteLine(name);
        y = "Out Welcome 2";
        Console.WriteLine(name);
        name = "Out Welcome 3";
    }
}



