using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_13_02
{
    internal class Pet
    {
        public string name { set; get; }
        public string animal { set; get; }
        public int age { set; get; }
        private int weight { set; get; }
        private string health { set; get; }
        public void GetWeight(int NewWeight)
        {
            
            weight = NewWeight;
        }
        public void GetHealth(string NewHealth)
        {
           

            health = NewHealth;
        }
        public void Print()
        {
            Console.WriteLine($"Имя: {name} Вид животного: {animal} Возраст: {age} Вес: {weight} Отметка о состоянии здоровья: {health}");

        }

    }
}
