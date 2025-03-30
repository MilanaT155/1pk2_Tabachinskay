namespace task_21_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
            List<int> list = new List<int>
            { 
                1, 2,3, 3, 4, 6, 5, 6, 7, 8, 9, 10,1,
            };

           List<int> ints =  RemoveDublicates(list);
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }



        }
        public static List<T> RemoveDublicates<T>(List<T> list) 
        {
            SortedSet<T> ints = new SortedSet<T>();
            List<T> ret = new List<T>();
            foreach (T item in list) 
            {
                if (ints.Add(item))
                {
                    ret.Add(item);
                }
            }
           
          return ret;   


        }
    }
}
