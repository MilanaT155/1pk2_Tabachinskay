namespace task_12_01
{
    //    добавить в класс Book метод с помощью которого пользователь возвращаеткнигуиеестатус снова переводится в «свободен»
    //в этом же проекте реализуйте класс Journal(журнал) со следующими данными:
    //дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса:
    //покупка журнала
    //просмотр содержания журнала
    //в этом же проекте реализуйте класс Newspaper(газета) со следующими данными:
    //дата издания, название газеты, заголовок главной полосы, количество страниц, цена
    //функционал класса:

    
    
        public class Book
        {
            public string title;
            public string autor;
            public bool isBorrowed = false;

            public void GetInfo()
            {
                Console.WriteLine($"{autor} : {title}");
            }

            public void GetBook()
            {
                if (!isBorrowed)
                {
                    isBorrowed = true;
                    Console.WriteLine($"книга {title} выдана");
                }
                else
                {
                    Console.WriteLine($"книга {title} в данный момент выдана другому читателю");
                }
            }
            public void ReturnBook()
            {
                if (isBorrowed)
                {
                    isBorrowed = false;
                    Console.WriteLine($"книга {title} возвращена");
                }
                else
                {
                    Console.WriteLine($"книга {title} уже свободна");
                }
            }
        }
        public class Journal
        {
            public string publicationDate;
            public string subject;
            public string title;
            public int pages;
            public decimal price;

            public Journal(string publictionDate, string subject, string title, int pages, decimal price)
            {
                this.publicationDate = publictionDate;
                this.subject = subject;
                this.title = title;
                this.pages = pages;
                this.price = price;
            }
            public void BuyJournal()
            {
                Console.WriteLine($"Журнал '{title}' куплен за {price}");
            }
            public void ViewContents()
            {
                Console.WriteLine($"журнал {title}, тема: {subject}, страниц: {pages}");
            }
        }
        public class Newspaper
        {
            public string publicationDate;
            public string title;
            public string mainHeadline;
            public int pages;
            public decimal price;

            public Newspaper(string publicationDate, string title, string mainHeadline, int pages, decimal price)
            {
                this.publicationDate = publicationDate;
                this.title = title;
                this.mainHeadline = mainHeadline;
                this.pages = pages;
                this.price = price;
            }
            public void BuyNewspaper()
            {
                Console.WriteLine($"Газета {title} куплена за {price}");
            }
            public void ViewContents()
            {
                Console.WriteLine($"газета {title}, Заголовок: {mainHeadline}, Страниц:{pages}");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Book book1 = new Book();
                var book2 = new Book();
                var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
                Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


                book1.autor = "Рей Бредберри";
                book1.title = "Марсианские хроники";
                book1.GetInfo();    //Рей Бредберри : Марсианские хроники

                book2.autor = "Джона Роулинг";
                book2.title = "Гарри Поттер и философский камень";
                book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

                //выдача книги
                book2.GetBook(); // книга выдана на неделю

                //попытка выдать уже занятую книгу
                book2.GetBook(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю
            }
        }
    }

        

