using System;

namespace MyCalculator
{
    class Program
    {
        static void Main()
        {
            float value1=0,value2=0;
            char options;
            ///////////////////////option input
            Console.WriteLine("\t\t\t\t\tSimple calculator");
            Console.WriteLine("\t\t\tSelect an Option accroding to your requirement...!!!");
            Console.WriteLine("\t\t\t\t\t'A or a' for Addition");
            Console.WriteLine("\t\t\t\t\t'S or s' for Subtract");
            Console.WriteLine("\t\t\t\t\t'M or m' for Multiply");
            Console.WriteLine("\t\t\t\t\t'D or d' for Division");
            Console.Write("\t\t\t\t\tOption : ");
            options = Convert.ToChar(Console.ReadLine());
            //////////////////values input
            if (options=='a' || options == 'A' || options == 'S' || options == 's' || options == 'D' || options == 'd' || options == 'M' || options == 'm')
            {
                Console.Write("Enter value 1 : ");
                value1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter value 2 : ");
                value2 = Convert.ToInt32(Console.ReadLine());
                    if (options == 'a' || options == 'A')
                    {
                        Console.WriteLine($"\t{value1}+{value2} = " + (value1 + value2));
                    }
                    else if (options == 's' || options == 'S')
                    {
                        Console.WriteLine($"\t{value1} - {value2} = " + (value1 - value2));
                    }
                    else if (options == 'm' || options == 'M')
                    {
                        Console.WriteLine($"\t{value1} x {value2} = " + (value1 * value2));
                    }
                    else if (options == 'd' || options == 'D')
                    {
                    if (value2 == 0)
                    {
                        Console.WriteLine("\t\t\t***You cannot divide a value by '0'***");
                    }
                    else
                    {

                    Console.WriteLine($"\t{value1} / {value2} = " + (value1 / value2));
                    }
                 }
                
            }
            else
            {
                Console.WriteLine("\t\t\t\t\t****kindly provide right input****");
            }
        }

    }
}
