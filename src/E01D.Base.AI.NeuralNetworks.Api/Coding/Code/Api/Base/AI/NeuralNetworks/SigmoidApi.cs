using System;

namespace E01D.AI.NeuralNetworks.Api.AI.NeuralNetworks
{
    public class SigmoidApi
    {
        public double Output(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public double derivative(double x)
        {
            return x * (1 - x);
        }
    }
}
