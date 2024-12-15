public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        if (this != null && MyProperty != null)
        {
            // Access MyProperty safely
            Console.WriteLine(MyProperty);
        }
        else
        {
            Console.WriteLine("MyProperty is null.");
        }
    }
} 

public class Program
{
    public static void Main(string[] args)
    {
        ExampleClass obj = null;
        obj.MyMethod();
        obj = new ExampleClass(10);
        obj.MyMethod();
    }
}