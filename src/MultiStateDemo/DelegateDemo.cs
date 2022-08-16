namespace CSharp_Self_Learning;

// Delegate => Object-Orinted Function Pointer/Reference (Type-Safety is guaranteed)

public class DelegateDemo
{
    delegate double DelegateFunction(double input);

    class Multiplier
    {
        double _factor;
        public Multiplier(double factor) => _factor = factor;
        public double Multiply(double x) => x * _factor;
    }

    static double[] Apply(double[] a, DelegateFunction f)
    {
        var result = new double[a.Length];
        for (int i = 0; i < a.Length; i++)
            result[i] = f(a[i]);
        return result;
    }

    public static void Example()
    {
        // Definations:
        double[] a = { 0.0, 0.5, 1.0 };
        double[] squares = Apply(a, (x) => x * x);   // Lambda expression
        double[] cubes = Apply(a, (x) => x * x * x); // Lambda expression
        double[] sines = Apply(a, Math.Sin);
        Multiplier m = new(2.0);
        double[] doubles = Apply(a, m.Multiply);

        // Output:
        Console.WriteLine(
            "Original => {0}", string.Join(", ", a)
        );
        Console.WriteLine(
            "Squares => {0}", string.Join(", ", squares)
        );
        Console.WriteLine(
            "Cubes => {0}", string.Join(", ", cubes)
        );
        Console.WriteLine(
            "Sines => {0}", string.Join(", ", sines)
        );
        Console.WriteLine(
            "Doubles => {0}", string.Join(", ", doubles)
        );
        Console.WriteLine();
        // Delegate => Could refer a `Static` or `Non-Static` function
        // But the refered function must contain { same return type & same parameter list } to the Delegate
    }
}