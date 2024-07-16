class Program
{
    static void Main()
    {
        string vegetables = "potato";
        string fruits = "orange";
        string juice = "pineapple";

        Console.WriteLine(vegetables);
        Console.WriteLine(fruits);
        Console.WriteLine(juice);

        var n1 = 2;
        var n2 = 10;
        var n3 = 11;

        if (n1 < 10)
        {
            Console.WriteLine("The value of n1 is less than 10");
        }

        if (n2 >= 10)
        {
            Console.WriteLine("The value of n2 is greater than or equal to 10");
        }

        if (n3 <= 10)
        {
            Console.WriteLine("The value of n3 is less than or equal to ten");
        }

        if (n3 > 10 && n3 <= 25)
        {
            Console.WriteLine("The value of n3 is greater than 10 and n3 is less than or equal to 25");
        }
        else
        {
            Console.WriteLine("The value of n3 is greater than 25");
        }

        var rest = n2 % n1;
        Console.WriteLine("The remainder of n2 divided by n1 is: " + rest);

        var quotient = n2 / 2;
        Console.WriteLine("The quotient of n2 divided by 2 is: " + quotient);

        int age = 25;
        Console.WriteLine("I am " + age + " years old");

        age = 5;
        Console.WriteLine("My brother is " + age + " years old");
    }
}
