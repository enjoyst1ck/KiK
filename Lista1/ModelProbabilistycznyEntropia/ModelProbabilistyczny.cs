namespace ModelProbabilistycznyEntropia
{
    public class ModelProbabilistyczny
    {
        public static Dictionary<char, double> UtworzModelProbabilistyczny(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        Dictionary<char, double> keyValuePairs = new Dictionary<char, double>();

                        int character;
                        int quantity = 0;
                        Console.Write($"Model: ");
                        while ((character = reader.Read()) != -1)
                        {
                            //Console.Write((char)character);

                            if (keyValuePairs.ContainsKey((char)character))
                            {
                                keyValuePairs[(char)character]++;
                            }
                            else
                            {
                                keyValuePairs[(char)character] = 1;
                            }

                            quantity++;
                        }

                        Console.WriteLine();

                        foreach (var pair in keyValuePairs)
                        {
                            Console.WriteLine($"Ilosc wystapien znaku {pair.Key}: {keyValuePairs[pair.Key]}");
                        }
                        Console.WriteLine($"Ilosc wszystkich znakow: {quantity}");

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