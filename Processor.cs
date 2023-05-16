using System;

namespace ComputerApp
{
    public class Processor
    {
        public string model { get; set; }
        public double frequency { get; set; }

        public Processor(string model, double frequency)
        {
            this.model = model;
            this.frequency = frequency;
        }

        public override string ToString()
        {
            return $"Processor: {model} ({frequency} GHz)";
        }
    }
}
