// See https://aka.ms/new-console-template for more information
var arr = new int[3];

//Unlike the Javascrip you can have multiples catch in one try
try
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(arr[i]);
    }

    Register("")
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Indece not found!");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
}
catch(MyException ex) 
{ 
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.WhenHappened);
    Console.WriteLine("Something went wrong!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Something went wrong!");
}
finally
{
    Console.WriteLine("Finally end!");
}

private static void Register(string text)
{
    if (string.IsNullOrEmpty(text))
        throw new ArgumentNullException("The string can not be empty or null");
}

public class MyException : Exception
{
    public MyException (DateTime date)
    {
        WhenHappened = date;
    }

    public DateTime WhenHappened { get; set; }
}