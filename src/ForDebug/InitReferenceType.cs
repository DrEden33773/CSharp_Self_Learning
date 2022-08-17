namespace CSharp_Self_Learning.src.ForDebug;

// CPP.(__ReferenceTypeName__) <=> CSharp.(__ReferenceTypeName__ &)

public class InitReferenceType
{
    private class UserClass<T>
    {
        public T? Value { get; set; }
        UserClass(T? value) => Value = value;
        public void Echo() => Console.WriteLine($"Value = {Value}");
        public static UserClass<T> Create(T? value) => new UserClass<T>(value);
    }
    private struct UserStruct<T>
    {
        public T? Value { get; set; }
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

        /// Error Code Below => Property (it's like a high level abstract of pointer) need to init
        // UserStruct<int> A;
        // A.Value = 1;
        // UserStruct<string> B;
        // B.Value = "Hello";
        // A.Echo();
        // B.Echo();
        /// Error Code Below

        /// Error Code Below => Class (Reference Type) need to init
        // UserClass<int> AA;
        // AA.Value = 1;
        // UserClass<string> BB;
        // BB.Value = "Hello";
        // AA.Echo();
        // BB.Echo();
        /// Error Code Below

        /// The Following CodeBlock Could Normally Run 
        var structA = UserStruct<int>.Create(1);
        var structB = UserStruct<string>.Create("Hello");
        structA.Echo();
        structB.Echo();
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