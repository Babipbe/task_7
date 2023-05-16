using System;

namespace ComputerApp
{
    public class Ram
    {
        public int size { get; set; }
        public string type { get; set; }

        public Ram(int size, string type)
        {
            this.size = size;
            this.type = type;
        }

        public override string ToString()
        {
            return $"RAM: {size} GB ({type})";
        }
    }
}
