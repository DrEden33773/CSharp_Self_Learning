namespace CSharp_Self_Learning;

public class ReferenceParam
{
    private static void SwapInt32(ref int one, ref int another)
    {
        int temp = one;
        one = another;
        another = temp;
    }
    public static void Example()
    {
        Console.Write("First value => ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Second value => ");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Original => x = {0} , y = {1}", x, y);

        SwapInt32(ref x, ref y);

        Console.WriteLine(" Swapped => x = {0} , y = {1}", x, y);
    }
}