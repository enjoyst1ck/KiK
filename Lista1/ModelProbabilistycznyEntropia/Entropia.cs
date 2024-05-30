namespace ModelProbabilistycznyEntropia
{
    public class Entropia
    {
        public static double ObliczEntropie(Dictionary<char, double> model)
        {
            double entropia = 0, log2x = 0;

            foreach (var pair in model)
            {
                //log2x = Math.Log(pair.Value) / Math.Log(2);
                log2x = Math.Log2(pair.Value);
                entropia += pair.Value * (-log2x);
            }

            return entropia;
        }
    }
}
