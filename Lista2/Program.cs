using System.Reflection;
using System.Text;

namespace Lista2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            string[] alfabet = ["A", "a", "Ą", "ą", "B", "b", "C", "c", "Ć", "ć", 
                                "D", "d", "E", "e", "Ę", "ę", "F", "f", "G", "g", 
                                "H", "h", "I", "i", "J", "j", "K", "k", "L", "l",
                                "Ł", "ł", "M", "m", "N", "n", "Ń", "ń", "O", "o", "Ó", "ó",
                                "P", "p", "Q", "q", "R", "r", "S", "s", "Ś", "ś", "T", "t", "U", "u",
                                "W", "w", "X", "x", "Y", "y", "Z", "z", "Ź", "ź", "Ż", "ż"];

            string[] smallAlfabet = ["a", "ą", "b", "c", "ć", "d", "e", "ę", 
                                     "f", "g", "h", "i", "j", "k", "l", "ł", 
                                     "m", "n", "ń", "o", "ó", "p", "q", "r", 
                                     "s", "ś", "t", "u", "w", "x", "y", "z", "ź", "ż"];

            string[] bigAlfabet = ["A", "Ą", "B", "C", "Ć", "D", "E", "Ę", 
                                   "F", "G", "H", "I", "J", "K", "L", "Ł", 
                                   "M", "N", "Ń", "O", "Ó", "P", "Q", "R", 
                                   "S", "Ś", "T", "U", "W", "X", "Y", "Z", "Ź", "Ż"] ;

            //Words.GenerateWordsWithEqualProbabilities(smallAlfabet, 200);

            string binPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(binPath, "4wyrazy.txt");

            ModelProbabilistyczny.UtworzModelProbabilistyczny(filePath);

        }
    }
}
