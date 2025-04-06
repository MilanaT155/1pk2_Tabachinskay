namespace task_24_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Реализуйте функцию, которая ищет заданное слово
            //в текстовом файле и возвращает все строки, содержащие это слово (регистронезависимо).
            string file1 = "C:\\work\\Task.txt";
            string word = "Солнце";
            List<string> list = new List<string> (ResultFile(file1, word));

            Console.WriteLine("Строки, содержащие слово '{0}':", word);
            foreach (var line in list)
            {
                Console.WriteLine(line);
            }
        }


        
     
        static List<string> ResultFile(string file, string word)
        {
            List<string> result = new List<string>();
          string[] lines = File.ReadAllLines (file);
            foreach (var line in lines)
            {
               if (line.StartsWith (word))
                {
                    result.Add(line);

                }
                
            }
            return result;

        }
        //    string[] line = File.ReadAllLines(file);
        //    foreach (var lines in line)
        //    {
        //        if (lines.IndexOf(word) >= 0)
        //        {
        //            result.Add(lines);
        //        }

        //    }
        //    return result;
        //}

        }
    }
