using System;

namespace ComputerApp
{
    public class VideoCard
    {
        public string model { get; set; }
        public int memorySize { get; set; }

        public VideoCard(string model, int memorySize)
        {
            this.model = model;
            this.memorySize = memorySize;
        }

        public override string ToString()
        {
            return $"Video Card: {model} {memorySize}GB";
        }
    }
}
