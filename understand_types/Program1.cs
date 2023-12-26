using System;
public class Program1
{
    static void Main(string[] args)
    {
       /*
        Implecit type conversion
        small type can be converted to large type
        */
        byte b = 255;
        int i = b;
        Console.WriteLine(i);

        /*
        Explicit type conversion
        large type can be converted to small type
        */

        int i1 = 500;
        byte b1 = (byte)i1;
        // Data loss due to conversion
        Console.WriteLine(b1);

        /* Conver non compatible types */
        string s = "123.45";
        float f = Convert.ToSingle(s);
        Console.WriteLine(f);

        /*use parse*/
        string s1 = "123.45";
        float f1 = float.Parse(s1);
        double d1 = double.Parse(s1);
        int i2 = int.Parse(s1);
        Console.WriteLine(f1);
        Console.WriteLine(d1);
        Console.WriteLine(i2);
    }
}
