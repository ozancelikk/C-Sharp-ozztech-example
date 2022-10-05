using System;   

namespace metot2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result = add2(10,20);
            //Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            

        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int add2(int sayi1,int sayi2)
        {
            var result = sayi1 + sayi2;
            return result;
        }
        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
      
    }
}
