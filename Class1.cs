using System.ComponentModel;

namespace WorkingWithDelegates;

public class Class1
{
    public delegate string[] Filter(string str);

    public delegate void Logger(string message);

    public delegate void TotalDiscount(decimal discount);

    public delegate void Action<T>(T arg);
    public static string[] SplitText(string str) => str.Split(' ');
    public static int TextLength(string str) => str.Split(' ').Length;

    public Class1()
    {
        Book[] bookArray = {
            new Book() { Id = 1, Category = "Fiction", PubYear = 1997 },
            new Book() { Id = 2, Category = "Bios & Memoirs", PubYear = 2015 },
            new Book() { Id = 3, Category = "Business",  PubYear = 2015 },
            new Book() { Id = 4, Category = "Classics" , PubYear = 1962 },
            new Book() { Id = 5, Category = "History" , PubYear = 2001 },
            new Book() { Id = 6, Category = "Fiction",  PubYear = 2001 },
            new Book() { Id = 7, Category = "Bios & Memoirs", PubYear = 1997 }
        };
        //bookArray.RemoveAt(2);
        //bookArray = bookArray.Where((source, index) => index != 2).ToArray();
        //EventHandlerList c;
        //HandledEventHandler cc;
        //HandledEventArgs ccc;
        //System.Threading.CancellationToken;
        //System.Threading.CancellationTokenSource;



    }
}

public class Book
{
    public int  Id { get; set; }
    public string Category { get; set; }
    public int  PubYear { get; set; }
}
public class Person
{
    public string sayHello()
    {
        return "Hello I am a Person.";
    }
}
public class Employee : Person
{
    public new string sayHello()
    {
        return "Hello I am an Employee.";
    }
}
public class Class12
{
    public static void Main(String[] args)
    {
        
    }
}