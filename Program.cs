using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass testClass = new MyClass();
            Console.WriteLine("How many times you want to get yeeted?:");
            String input = Console.ReadLine();
            int yeets = Convert.ToInt32(input);
            for(int i = 0;i < yeets;i++){
                Console.WriteLine(testClass.returnMessage());
            }
        }
    }
}
