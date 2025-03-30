namespace task_21_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который находит первый ключ в 
            //словаре, соответствующий заданному значению.Если значения нет, вернуть null.
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                {"first", 1},
                {"second", 2},
                {"third", 0 }
            };

            LocateKey(dictionary);
            foreach (var key in dictionary)
            {
                Console.WriteLine(key+" ");
            }
        }
        static int LocateKey(Dictionary<string, int> dictionary)
        {
            int null1 = Convert.ToInt32(null);
            int Value2 = Convert.ToInt32(dictionary.ContainsValue);
            if (dictionary.ContainsValue == null)
            {
                return null1;
            }
            else
            {
                return Value2;
            }
            
      

        
            
               
        }






        }
    }

