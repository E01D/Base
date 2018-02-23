using System;
using E01D.Models.AI.NeuralNetworks;

namespace E01D.AI.NeuralNetworks.Api.AI.NeuralNetworks
{
    public class TrainingApi
    {
        //http://www.codingvision.net/miscellaneous/c-backpropagation-tutorial-xor 
        public NeuralNetwork Train(double[][] inputs, double[] results, int maximumNumberOfEpochs)
        {
            var numberOfNodes = inputs[0].Length;
            var numberOfInputs = inputs[0].Length;

            var network = new NeuralNetwork()
            {
                HiddenNodes = new Neuron[numberOfNodes],
                Output = new Neuron()
                {
                     Inputs = new double[numberOfNodes],
                     Weights = new double[numberOfInputs]
                }
            };

            XNeuralNetworks.Api.Neurons.RandomizeWeights(network.Output);

            for (int i = 0; i < numberOfNodes; i++)
            {
                network.HiddenNodes[i] = new Neuron
                {
                    Weights = new double[numberOfInputs]
                };

                XNeuralNetworks.Api.Neurons.RandomizeWeights(network.HiddenNodes[i]);
            }

            for (int epoch = 0; epoch < maximumNumberOfEpochs; epoch++)
            {
                for (int iExample = 0; iExample < inputs.Length; iExample++)
                {
                    for (int iNode = 0; iNode < numberOfNodes; iNode++)
                    {
                        var neuron = network.HiddenNodes[iNode];

                        network.HiddenNodes[iNode].Inputs = Clone(inputs[iExample]);

                        network.Output.Inputs[iNode] = XNeuralNetworks.Api.Neurons.GenerateOutput(neuron);
                    }

                    var resultOutput = XNeuralNetworks.Api.Neurons.GenerateOutput(network.Output);


                    for (int i = 0; i < numberOfInputs; i++)
                    {
                        var decimalValue = (decimal)inputs[iExample][i];

                        var toStringValue = decimalValue.ToString("C");

                        Console.Write($"{toStringValue}");

                        if (i + 1 < numberOfInputs)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.WriteLine($" = {resultOutput}");

                    // 2) back propagation (adjusts weights)

                    // adjusts the weight of the output neuron, based on its error
                    network.Output.Error = XNeuralNetworks.Api.Sigmoid.derivative(resultOutput) * (results[iExample] - resultOutput);

                    XNeuralNetworks.Api.Neurons.AdjustWeights(network.Output);

                    // then adjusts the hidden neurons' weights, based on their errors
                    for (int iNode = 0; iNode < numberOfNodes; iNode++)
                    {
                        var neuron = network.HiddenNodes[iNode];

                        var neuronOutput = XNeuralNetworks.Api.Neurons.GenerateOutput(neuron);

                        neuron.Error = XNeuralNetworks.Api.Sigmoid.derivative(neuronOutput) * network.Output.Error * network.Output.Weights[iNode];

                        XNeuralNetworks.Api.Neurons.AdjustWeights(neuron);
                    }
                }
            }

            return network;
        }

        public double[] Clone(double[] array)
        {
            double[] newArray = new double[array.LongLength];

            for (int i = 0; i < array.LongLength; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }
    }
}
