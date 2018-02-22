using E01D.AI.NeuralNetworks.Api.AI.NeuralNetworks;

namespace E01D.AI.NeuralNetworks.Api.AI
{
    public class NeuralNetworkApi
    {
        public NeuronApi Neurons { get; set; } = new NeuronApi();

        public SigmoidApi Sigmoid { get; set; } = new SigmoidApi();

        public TrainingApi Training { get; set; } = new TrainingApi();
    }
}
