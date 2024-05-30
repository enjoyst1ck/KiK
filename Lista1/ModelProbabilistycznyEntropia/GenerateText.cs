using System.Reflection;
using System.Text;

namespace ModelProbabilistycznyEntropia
{
    public class GenerateText
    {
        public static void GenerateFile()
        {
            Dictionary<char, double> model = new Dictionary<char, double>();

            model.Add('A', 0.8);
            model.Add('B', 0.2);

            double dystrybuanta = 0;
            StringBuilder sb = new StringBuilder();

            foreach (var key in model.Keys.ToList())
            {
                dystrybuanta += model[key];
                model[key] = dystrybuanta;
            }

            Random random = new Random();
            double next = random.NextDouble();
            int j = 0;

            for (int i=0; i<100000; i++)
            {
                next = random.NextDouble();
                j = 0;

                while (next > model.ElementAt(j).Value)
                {
                    j++;
                }

                sb.Append(model.ElementAt(j).Key.ToString());
            }

            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(binPath, "lista1.txt");

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(sb.ToString());
                }
                Console.WriteLine($"Plik został zapisany w lokalizacji: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Nie udalo sie zapisac pliku, error message: {ex.Message}");
            }
        }
    }
}
