using System;

class Program
{
    static void Main(string[] args)
    {
        // Test default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString()); // Should print "1/1"
        Console.WriteLine(f1.GetDecimalValue());  // Should print "1"

        // Test constructor with one parameter
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString()); // Should print "5/1"
        Console.WriteLine(f2.GetDecimalValue());  // Should print "5"

        // Test constructor with two parameters
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString()); // Should print "3/4"
        Console.WriteLine(f3.GetDecimalValue());  // Should print "0.75"

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString()); // Should print "1/3"
        Console.WriteLine(f4.GetDecimalValue());  // Should print "0.3333333333333333"

        // Test getters and setters
        f4.Top = 2;
        f4.Bottom = 5;
        Console.WriteLine(f4.GetFractionString()); // Should print "2/5"
        Console.WriteLine(f4.GetDecimalValue());  // Should print "0.4"
    }
}
