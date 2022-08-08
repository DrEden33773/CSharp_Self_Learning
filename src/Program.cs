using CSharp_Self_Learning;

internal class Program
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
        ReferenceParam.Example();
    }

}