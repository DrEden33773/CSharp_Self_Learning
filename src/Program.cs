using CSharp_Self_Learning;
using CSharp_Self_Learning.src.ForDebug;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine();

        Program.Opration(); // Program.Opration(); <=> Operation();

        Console.WriteLine();
    }
    private static void Opration()
    {
        Greeting.Example();
        // TypeConversion.Example();
        // InitClass.Example();
        // ReferenceParam.Example();
        OfficialStack<int>.IntExample();
        // ExpressionModel.Example();
        DelegateDemo.Example();
        InitReferenceType.Example();
        OfficialList<int>.Example();
    }

}