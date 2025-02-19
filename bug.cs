public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Some code here
        if (MyProperty == 0)
        {
            // Bug: Accessing a disposed object
            Console.WriteLine(MyProperty);
        }
        // More code here

    }
}