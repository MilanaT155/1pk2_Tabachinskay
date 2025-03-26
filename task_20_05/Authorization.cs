using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_20_05
{
    public enum AccessLevel
    {
        Guest,
        User,
        Moderator,
        Admin
    }

    internal class Authorization
    {
        public AccessLevel accessLevel {  get; private set; } = AccessLevel.Guest;
        public Authorization(AccessLevel AccessLevel)
        {

            accessLevel = AccessLevel;
        }
        public void Check()
        {
            if (accessLevel == AccessLevel.Moderator|| accessLevel == AccessLevel.Admin)
            {
                Console.WriteLine("Действие выполнено");
            }
            else
            {
                Console.WriteLine("Ошибка. Недостаточно прав");
            }

        }
        public void CanComment()
        {
            if (accessLevel == AccessLevel.Moderator || accessLevel == AccessLevel.Admin || accessLevel == AccessLevel.User)
            {
                Console.WriteLine("Комментарий оставлен");
            }
            else
            {
                Console.WriteLine("Ошибка. Недостаточно прав");
            }
        }
        public void CanRead()
        {
            Console.WriteLine("Вы можете читать");
        }

    }
}
