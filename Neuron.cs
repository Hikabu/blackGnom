
namespace blackGnom
{
    public class Neuron
    {
        public List<double> Weight { get; }
        public NeuronType NeuronType { get; }
        public double output { get; private set;


        public Neuron(int inputCount, NeutonType type = NeuronType.Normal)
        {
            NeuronType = tupe;
            Weight = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weight.Add(1);
            }
        
        }

        public double FeedForward(List<double> inputs) #дополнить систему проверок входных корректных данных
            {
                 var sum = 0.0
                for (int i = 0;i < inputs.Count;i++)
                {
                     sum += inputs[i] * Weights[i];
                }

            Output = Sigmoid(sum);
            return Output;
            }
            
            private double Sigmoid(double x)
            {
                 var result = 1.0 / (1.0 + Math.Pow(Math.E, -x)); 
                 return result;  
            }
            
            public override string ToString()
            {
                return Output.ToString();
            }
    }
}
