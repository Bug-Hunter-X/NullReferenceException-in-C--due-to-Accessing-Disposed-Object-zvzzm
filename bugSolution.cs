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
            // Solution: Check for null before accessing member
            if (this != null && MyProperty != null)
            {
                Console.WriteLine(MyProperty);
            }
            else
            {
                Console.WriteLine("Object is null");
            }
        }
        // More code here

    }
}