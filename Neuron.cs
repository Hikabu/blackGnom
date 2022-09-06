using System;
using System.Collections.Generic;

namespace blackGnom
{
    public class Neuron
    {
        public List<double> Weight { get; }
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }


        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            NeuronType = type;
            Weights = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        
        }

        public double FeedForward(List<double> inputs)                        //дополнить систему проверок входных корректных данных
            {
            var sum = 0.0;
                for (int i = 0;i < inputs.Count;i++)
                {
                     sum += inputs[i] * Weights[i];
                }

             if(NeuronType != NeuronType.Input)
             {
            Output = Sigmoid(sum);
             }
             else
             {
                Output = sum; 
             }
             
            return Output;
            }
            
            private double Sigmoid(double x)
            {
                 var result = 1.0 / (1.0 + Math.Pow(Math.E, -x)); 
                 return result;  
            }
            

        public void SetWights(params double[] weights)
        {
            //Скорее всего нужно будет удалить после добавления возможности обучения сети (в реальной 
            for(int i = 0; i < weights.Length; i++)
            {
                weights[i] = weights[i];
            }
        }
            public override string ToString()
            {
                return Output.ToString();
            }
    }
}
