using System.Collections.Generic;

namespace blackGnom
{
    public class Layer
    {
         public List<Neuron> Neurons { get; }
         public int Count => Neurons?.Count ?? 0;    

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            //крч. надо проверить все приходящие нейронs чтобы они соответсвовали именно свему типу 

            Neurons = neurons;  
        }

        public List<double> GetSignals()
        {
            var result = new List<double>();
            foreach(var neuron in Neurons)
            {
                result.Add(neuron.Output);
            }
            return result;
        }
    }
}
