using System;

namespace ExampleOfClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Product videoGame = new Product();
            videoGame.Name = "Dispensary Tycoon";
            videoGame.Price = 14.99;
            System.Console.WriteLine(videoGame.ToString());
        }
    }
}
