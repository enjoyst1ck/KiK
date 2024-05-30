namespace Lista2
{
    public class ModelProbabilistyczny
    {
        public static Dictionary<string, double> UtworzModelProbabilistyczny(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        Dictionary<string, double> keyValuePairs = new Dictionary<string, double>();

                        //int character;
                        int quantity = 0;
                        Console.Write($"Model: ");
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            foreach (char ch in line)
                            {
                                string character = ch.ToString();

                                if (keyValuePairs.ContainsKey(character))
                                {
                                    keyValuePairs[character]++;
                                }
                                else
                                {
                                    keyValuePairs[character] = 1;
                                }

                                quantity++;
                            }

                        }

                        Console.WriteLine();

                        foreach (var pair in keyValuePairs)
                        {
                            Console.WriteLine($"Ilosc wystapien znaku {pair.Key}: {keyValuePairs[pair.Key]}");
                        }
                        Console.WriteLine($"Ilosc wszystkich znakow: {keyValuePairs.Count}");

                        Console.WriteLine();

                        Console.Write("Alfabet: { ");
                        foreach (var pair in keyValuePairs)
                        {
                            Console.Write(pair.Key + " ");
                        }
                        Console.Write("}");
                        Console.WriteLine();

                        foreach (var pair in keyValuePairs)
                        {
                            keyValuePairs[pair.Key] = pair.Value / (double)quantity;
                            Console.WriteLine($"P({pair.Key}) = {keyValuePairs[pair.Key]}");
                        }

                        return keyValuePairs;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Wystąpił błąd: {ex.Message}");
                }

            }
            else
            {
                Console.WriteLine("Plik nie istnieje.");
            }

            return null;
        }
    }
}