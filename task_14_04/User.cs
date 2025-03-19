using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task_14_04
{
    internal class User
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public string patromic {  get; set; }
        public int age { get; set; }
        public static User CurrentUser {  get; set; }
        public User(string Name, string Surname, string Patromic,int Age)
        {
           name = Name;
            age = Age;
            patromic = Patromic;    
            surname = Surname;


        }
        public static void Info(string Name, string Surname, string Patromic, int Age)
        {
            CurrentUser = new User(Name, Surname, Patromic, Age);
        }
        
    }
}
