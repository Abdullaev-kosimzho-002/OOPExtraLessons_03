// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Metanit Tests.

//Question 1.
/*
class  Person
{
    public string name = "Sam";
    public int age; 

    public Person(string name, int age)
    {
        this.name = name; this.age = age;

    }
}
class Program
{
    static void Main()
    {
        Person tom = new Person("Tom", 34) { name = "Bob", age = 29 }; 
        Console.WriteLine(tom.name);

    }
}
*/

//Question 2.
/*
class Person
{
    public string name = "Ben";
    public int age = 18;
    public string email = "ben@gmail.com";

    public Person (string name)
    {
        this.name = name;
    }
    public Person (string name, int age) : this(name)
    {
        this.age = age;  
    }
    public Person(string name, int age, string email) : this("Bob", age)
    {
        this.email = email; 
    }
}
class Program
{
    static void Main()
    {
        Person tom = new Person("Tom", 31, "tom@gmail.com");
        Console.WriteLine(tom.name);
        Console.WriteLine(tom.age);
        Console.WriteLine(tom.email);
    }
}
*/

//Question 5.
/*
class Person
{
    int age = 26;
    string name = "Tom";

    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
    public void  AgeTtring()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}
class Program
{
    static void Main()
    {
        Person tom = new Person(19, "Bob");
        tom.AgeTtring();
        //  Console.WriteLine(tom.name);
    }
}
*/

//Question 1.
/*
class Person
{
    private int age = 15;

    public int Age
    {
        get { return age;}
        set { }
    }
}
class Program
{
    static void Main()
    {
        Person tom = new Person();
        tom.Age = 25;
        Console.WriteLine(tom.Age);

    }
}
*/

//Question 1.
/*
class Person
{
    int retir = 60;
    public static void ChangeRetir(int years)
    {
        ret
    }
}
*/

//Question 2.

/*
class Person
{
    public static int retir = 60;
    int _age; 
    static Person()
    {
        Console.WriteLine($"Начальный пенсионат: {retir}");
    }
    public Person(int age)
    {
        _age = age;
    }
    public void Display()
    {
        if(_age >= retir)
        {
            Console.WriteLine("Вы уже на пенсии");

        }else
        {
            Console.WriteLine($"До пенсии осталось: {retir - _age}");
        }
    }
}
class Program
{
    static void Main()
    {
        Person tom;
        tom = new Person(34);
        Person.retir = 65;
        tom.Display(); 
    
    
    }
}
*/

//Question 3.

class Example
{
    public const double KOEF = 4.5;
    public readonly double field;

    public Example(int f)
    {
        field = f * KOEF;
    }
   // public void Mains()
   // {
     //   Console.WriteLine(field);
   // }

}
class Program
{
    static void Main()
    {
        Example example = new Example(10);
        Console.WriteLine(example.field);
     //   example.Mains();    
    
    }
}
























































































































































