using System;

namespace ComputerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var winchester = new Winchester(500, "Seagate");
            var ram = new Ram(8, "DDR4");
            var processor = new Processor("Intel Core i5-11600K", 3.9);
            var videoCard = new VideoCard("NVIDIA GeForce RTX 3060", 12);
            var computer = new Computer(winchester, ram, processor, videoCard);

            Console.WriteLine(computer);
            Console.WriteLine();
            computer.Enable();
            computer.CheckForViruses(); 
            computer.DisplayWinchesterSize();
            computer.Disable();

            Console.ReadLine();
        }
    }
}
