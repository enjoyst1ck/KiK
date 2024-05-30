using System.Reflection;

namespace ModelProbabilistycznyEntropia
{
    public class Program
    {
        static void Main(string[] args)
        {
            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(binPath, "lista1.txt");

            Console.WriteLine("Generowanie pliku:");
            GenerateText.GenerateFile();

            Dictionary<char, double> model = ModelProbabilistyczny.UtworzModelProbabilistyczny(filePath);

            double entropia = Entropia.ObliczEntropie(model);

            Console.WriteLine($"Entropia dla podanego modelu wynosi: {entropia}");
        }
    }
}