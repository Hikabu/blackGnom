using System.Collections.Generic;

namespace blackGnom
{
    public class Drevo
    {
        public int InputCount { get; }
        public int OutputCount { get; }
        public List<int> HiddenLayers { get; }

        public Drevo(int inputCount, int outputCount, params int[] layers)
        {

            InputCount = inputCount;
            OutputCount = outputCount;
            HiddenLayers = new List<int>();
            HiddenLayers.AddRange(layers);
        }
    }
}
