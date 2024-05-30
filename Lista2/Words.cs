using System.Text;

namespace Lista2
{
    public class Words
    {
        public static StringBuilder GenerateWordsWithEqualProbabilities(string[] alphabet, int quantityWords)
        {
            StringBuilder sb = new StringBuilder();

            int k;
            int count = alphabet.Count();
            double[] dystrybuanta = new double[count];

            double temp = 1 / (double)count;
            dystrybuanta[0] = temp;

            Random random = new Random();
            double next;

            WriteAlphabet(alphabet);

            for (int i = 1; i < count; i++)
            {
                dystrybuanta[i] = dystrybuanta[i - 1] + temp;
            }

            //petla do tworzenia tyle ile slow
            for(int i=0; i<quantityWords; i++)
            {
                //petla do tworzenia pojedynczego slowa
                for(int j=0; j<4; j++)
                {
                    next = random.NextDouble();
                    k = 0;

                    while (next > dystrybuanta[k])
                    {
                        k++;
                    }

                    sb.Append(alphabet[k]);
                    Console.Write(alphabet[k]);
                }

                sb.AppendLine();
                Console.WriteLine();
            }

            return sb;
        }

        private static void WriteAlphabet(string[] alphabet)
        {
            Console.Write($" Alfabet:");

            for (int i = 0; i < alphabet.Count(); i++)
            {
                Console.Write($" {alphabet[i]} ");
            }

            Console.WriteLine();
        }

        public static StringBuilder UtworzModelProbabilistyczny()
        {
            StringBuilder sb = new StringBuilder();

            return sb;
        }
    }
}
