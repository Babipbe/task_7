using System;

namespace ComputerApp
{
    public class Winchester
    {
        public int size { get; set; }
        public string type { get; set; }

        public Winchester(int size, string type)
        {
            this.size = size;
            this.type = type;
        }

        public override string ToString()
        {
            return $"Winchester: {size}GB {type}";
        }
    }
}
