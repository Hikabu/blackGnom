  namespace blackGnom
{
    public class Layer
    {
         public List<Neuron> Neurons { get; }
         public int Count => Neurons?.Count ?? 0;    

        public Layer(List<Neuron> neurons, NeuronType type = NeuronType.Normal)
        {
            //крч. надо проверить все приходящие нейрону чтобы они соответсвовали именно свему типу 

            Neurons = neurons;  
        }


    }
}
