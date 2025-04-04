namespace task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Напишите программу со следующими функциями:
            //            1.Выведите информации о всех дисках в системе
            //2.Выведите содержимое каталога C: \Users(названия папок)
            //3.Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            //a) Создание вложенного каталога “temp”
            //b) Вывод информации о текущем каталоге(имя, родитель и тд)
            //c) Вывод информации о вложенном каталоге
            //4.Переместите каталог “temp” по пути “D:\work\newTemp”
            //a) Реализуйте вывод информационного сообщения об успешном(или нет)
            //перемещении
//            5.Удалите каталог “D:\work\temp” и выведите сообщение об успешном(или нет)
//удалении.
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            foreach (DriveInfo drive in driveInfo)

            {

                Console.WriteLine($"Диск: {drive.Name}");
                Console.WriteLine($"Формат: {drive.DriveFormat}");
                Console.WriteLine($"Тип: {drive.DriveType}");
                Console.WriteLine($"Свободно: {drive.AvailableFreeSpace / (1024 * 1024 * 1024)} ГБ");
                Console.WriteLine($"Всего: {drive.TotalSize / (1024 * 1024 * 1024)} ГБ");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");



            }
            string pathName = "C:\\Users";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine($"файлы в папке: ");
                string[] array = Directory.GetDirectories(pathName);
                foreach (string str in array)
                {
                    Console.WriteLine(Path.GetFileName(str));
                }
            }
            string work = "C:\\work";
            string tempPath = Path.Combine(work, "temp");
            string newTemp = Path.Combine(work, "newTemp");
            Directory.CreateDirectory(tempPath);
            Console.WriteLine("Информация о текущем каталоге:");
            DirectoryInfo directoryInfo = new DirectoryInfo(work);
            Console.WriteLine("Имя: "+ directoryInfo.Name);
            Console.WriteLine("Родитель: " + directoryInfo.Parent);
            Console.WriteLine("Полный путь: " + directoryInfo.FullName);
            Console.WriteLine("Время создания: " + directoryInfo.CreationTime);
            Console.WriteLine("Информация о вложенном каталоге:");
            DirectoryInfo directoryInfo2 = new DirectoryInfo(tempPath);
            Console.WriteLine("Имя: " + directoryInfo2.Name);
            Console.WriteLine("Родитель: " + directoryInfo2.Parent);
            Console.WriteLine("Полный путь: " + directoryInfo2.FullName);
            Console.WriteLine("Время создания: " + directoryInfo2.CreationTime);
            try 
            {
                if (Directory.Exists(tempPath))
                {
                    Directory.Move(tempPath, newTemp);
                }
                else
                {
                    Console.WriteLine("Каталога не существует");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ошибка перемещения " + ex.Message);

            }
             try 
             {
                if (Directory.Exists(tempPath))
                {
                    Directory.Delete(tempPath, true);
                }
                else
                {
                    Console.WriteLine("Каталога не существует");
                }
             }
            catch (Exception ex)
             {
                Console.WriteLine("ошибка удаления " + ex.Message);

             }
           



        }
    }
}
