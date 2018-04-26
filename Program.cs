using System;
using Accord.Neuro;
using Accord.Neuro.Learning;

namespace DeepLearningNetwork
{
    class Program
    {
        static void Main()
        {
            int iteration;
            Console.WriteLine("Enter iteration count");
            var iterationInput = Console.ReadLine();
            int.TryParse(iterationInput, out iteration);

            var network = TrainNetwork(iteration);

            PredictXOR(network);
        }

        private static ActivationNetwork TrainNetwork(int iteration)
        {
            double[][] input =
            {
                new double[] {0, 0}, 
                new double[] {0, 1},
                new double[] {1, 0}, 
                new double[] {1, 1}
            };

            double[][] output =
            {
                new double[] {0}, 
                new double[] {1},
                new double[] {1}, 
                new double[] {0}
            };

            var network = new ActivationNetwork(
                new SigmoidFunction(),
                2,
                4,
                1);

            var teacher = new ResilientBackpropagationLearning(network);

            for (int i = 0; i < iteration; i++)
            {
                double error = teacher.RunEpoch(input, output);
                Console.WriteLine("\nError rate: {0}", error);
            }

            return network;
        }

        private static void PredictXOR(ActivationNetwork network)
        {
            var key = ConsoleKey.A;

            while (key != ConsoleKey.Q)
            {

                Console.WriteLine("\n\nEnter XOR values x,y");
                var xyValues = Console.ReadLine();
                if (xyValues != null)
                {
                    var xor = xyValues.Split(',');

                    var xorResult = network.Compute(new double[] { Convert.ToInt32(xor[0]), Convert.ToInt32(xor[1]) });
                    Console.WriteLine("\nXOR result: {0}", xorResult[0]);
                }

                Console.Write("Press q to quit ..");
                key = Console.ReadKey().Key;
            }
        }
    }
}
