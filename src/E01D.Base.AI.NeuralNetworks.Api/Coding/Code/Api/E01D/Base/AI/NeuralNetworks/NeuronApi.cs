using E01D.Models.AI.NeuralNetworks;

namespace E01D.AI.NeuralNetworks.Api.AI.NeuralNetworks
{
    public class NeuronApi
    {
        public double CalculateWeightedValue(Neuron neuron)
        {
            double x = 0;

            for (var i = 0; i < neuron.Inputs.Length; i++)
            {
                x += neuron.Inputs[i] * neuron.Weights[i];
            }

            x += neuron.BiasWeight;

            return x;
        }

        public double GenerateOutput(Neuron neuron)
        {
            var weightedValue = CalculateWeightedValue(neuron);

            return XNeuralNetworks.Api.Sigmoid.Output(weightedValue); 
        }

        public void RandomizeWeights(Neuron neuron)
        {
            for (var i = 0; i < neuron.Weights.Length; i++)
            {
                neuron.Weights[i] = neuron.Random.NextDouble();
            }

            neuron.BiasWeight = neuron.Random.NextDouble();
        }

        public void AdjustWeights(Neuron neuron)
        {
            for (var i = 0; i < neuron.Weights.Length; i++)
            {
                neuron.Weights[i] += neuron.Error * neuron.Inputs[i];
            }

            neuron.BiasWeight += neuron.Error;
        }
    }
}
