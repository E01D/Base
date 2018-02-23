using System;

namespace E01D.Models.AI.NeuralNetworks
{
    public class Neuron
    {
        public double[] Inputs { get; set; }

        public double[] Weights { get; set; }

        public double Error { get; set; }

        public double BiasWeight { get; set; }

        public Random Random { get; set; } = new Random();

        //public double Output { get; set; }
    }
}
