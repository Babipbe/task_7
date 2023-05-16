using System;

namespace ComputerApp
{
    public class Computer
    {
        public Winchester winchester { get; set; }
        public Ram ram { get; set; }
        public Processor processor { get; set; }
        public VideoCard videoCard { get; set; }
        public bool isEnabled { get; private set; } = false;

        public Computer(Winchester winchester, Ram ram, Processor processor, VideoCard videoCard)
        {
            this.winchester = winchester;
            this.ram = ram;
            this.processor = processor;
            this.videoCard = videoCard;
        }

        public void Enable()
        {
            if (!isEnabled)
            {
                Console.WriteLine("Computer is being enabled...");
                isEnabled = true;
            }
            else
            {
                Console.WriteLine("Computer is already enabled.");
            }
        }

        public void Disable()
        {
            if (isEnabled)
            {
                Console.WriteLine("Computer is being disabled...");
                isEnabled = false;
            }
            else
            {
                Console.WriteLine("Computer is already disabled.");
            }
        }

        public void CheckForViruses()
        {
            Console.WriteLine("Checking for viruses...");
            // TODO: add virus scanning logic
        }

        public void DisplayWinchesterSize()
        {
            Console.WriteLine($"Winchester size: {winchester.size}GB");
        }

        public override string ToString()
        {
            return $"Computer specifications:\n{winchester}\n{ram}\n{processor}\n{videoCard}";
        }
    }
}
