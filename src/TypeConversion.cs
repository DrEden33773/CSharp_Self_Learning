namespace CSharp_Self_Learning.src;

public class TypeConversion
{
    public static void Example()
    {
        int i = 75;
        float f = 53.005f; // cannot write 53.005 here, that means `double` type
        double d = 2345.7652;
        bool b = true;

        // do not use => 
        // var i_trans = (double)(i);

        Console.WriteLine(i.ToString());
        Console.WriteLine(f.ToString());
        Console.WriteLine(d.ToString());
        Console.WriteLine(b.ToString());

        Console.WriteLine();
    }
}