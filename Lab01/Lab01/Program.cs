using System;


namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age;
            int.TryParse(Console.ReadLine(), out age);
           
            Console.WriteLine("age: {0}", age);

        }
    }
}
