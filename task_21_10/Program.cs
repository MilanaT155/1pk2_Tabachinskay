namespace task_21_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который 
            //объединяет два словаря.Если ключ присутствует в обоих словарях, суммироватьихзначения
            Dictionary<string, int> dict = new Dictionary<string, int>
            {
                {"first", 13 },
                {"second", 11}
            };

            Dictionary<string, int> dict2 = new Dictionary<string, int>
            {
                {"second", 34 },
                {"therd", 3 }
            };
            Dictionary<string, int> Mergedict = MergeDictionary(dict, dict2);
            foreach (var ints in Mergedict)
            {
                
                Console.WriteLine(ints.Key + "\t" + ints.Value);
              
               
            }

        }
        public static Dictionary<TKey, int> MergeDictionary<TKey>(Dictionary<TKey, int> dict, Dictionary<TKey, int> dict2)
        {
            Dictionary<TKey, int> result = new Dictionary<TKey, int>(dict);
            foreach (var pair in dict2)
            {

                if (result.ContainsKey(pair.Key))
                {
                    result[pair.Key] += pair.Value;
                }
                else
                {
                    result.Add(pair.Key, pair.Value);



                }
            }
            return result;
        }
    }
}
