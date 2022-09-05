namespace blackGnom
{
    public class NeuralNetworks
    {
        public Drevo Drevo { get; }
        public List<Layer> layers { get; }

        public NeuralNetworks(Drevo drevo)
        {
            Drevo = drevo;

            layers = new List<Layer>();

            CreateInputLayer();
            CreateHiddenLayers();
            CreateOutputLayer();
        }

        public double FeedForward(List<double> inputSignals)
        {
            for (int i = 0; i < inputSignals.Count; i++)
            {
                var signal = new List<double> inputSignals)           //21- 27 строчки можно закрепить в новый метод 
                var neuron = layers[0].Neurons[i];

                neuron.FeedForward()
            } 

        private void CreateOutputLayer()
        {
            var OutputNeurons = new List<Neuron>();
            var lastLayer = Layers.Last();
            for (int i = 0; i < Drevo.OutputCount; i++)
            {
                var neuron = new Neuron(lastLayer.Count, NeuronType.Output);
                OutputNeurons.Add(neuron);
            }
            var OutputLayer = new Layer(OutputNeurons, NeuronType.Output);
            Layers.Add(OutputLayer);
        }
        private void CreateHiddenLayer()
        {
            for (int j = 0; int < Drevo.HiddenLayers.Count; j++)
            {
                var hiddentNeurons = new List<Neuron>();
                var lastLayer = Layers.Last();
                for (int i = 0; i < Drevo.HiddenLayers[j]; i++)
                {
                    var neuron = new Neuron(lastLayer.Count);
                    hiddenNeurons.Add(neuron);
                }
                var hiddenLayer = new Layer(hiddenNeurons);
                Layers.Add(hiddenLayer);
            }
        }    
        private void CreateInputLayer()
        {
            var inputNeurons = new List<Neuron>();
            for(int i = 0; i < Drevo.InputCount; i ++)
            {
                var neuron = new Neuron(1, NeuronType.Input);
                inputNeurons.Add(neuron);                                                         // нейронка в  три основных слоя
            }
            var inputLayer = new Layer(inputNeurons, NeuronType.Input);
            Layers.Add(inputLayer); 
        }
    }
}
