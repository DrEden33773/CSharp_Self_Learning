namespace CSharp_Self_Learning.src.ForDebug;

public class InitReferenceType
{
    private class UserClass<T>
    {
        public T? Value;
        UserClass(T? value) => Value = value;
        public void Echo() => Console.WriteLine($"Value = {Value}");
        public static UserClass<T> Create(T? value) => new UserClass<T>(value);
    }
    private struct UserStruct<T>
    {
        public T? Value;
        UserStruct(T? value) => Value = value;
        public void Echo() => Console.WriteLine($"Value = {Value}");
        public static UserStruct<T> Create(T? value) => new UserStruct<T>(value);
    }
    public static void Example()
    {
        var classA = UserClass<int>.Create(1);
        var classB = UserClass<string>.Create("Hello");
        classA.Echo();
        classB.Echo();

        UserStruct<int> A;
        A.Value = 1;
        UserStruct<string> B;
        B.Value = "Hello";
        A.Echo();
        B.Echo();

        /// The Following CodeBlock Could Normally Run 
        // var structA = UserStruct<int>.Create(1);
        // var structB = UserStruct<string>.Create("Hello");
        // structA.Echo();
        // structB.Echo();
        /// The Former CodeBlock Could Normally Run 

        int[] ArrayA = { 1, 2, 3, 4 };
        string[] ArrayB = { "Hello", "World" };
        foreach (var item in ArrayA)
            Console.Write(item + " ");
        Console.WriteLine();
        foreach (var item in ArrayB)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}