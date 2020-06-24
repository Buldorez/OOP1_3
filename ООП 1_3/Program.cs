using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Console.WriteLine("Введите карточку животного:");
            Console.WriteLine("Введите название животного");
            zoo.animal = Console.ReadLine();
            Console.WriteLine("Введите пол животного");
            zoo.sex = Console.ReadLine();
            Console.WriteLine("Имя животного");
            zoo.name = Console.ReadLine();
            Console.WriteLine("Цена животного");
            zoo.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество");
            zoo.number = Convert.ToInt32(Console.ReadLine());
            zoo.outText();
            Console.ReadLine();
        }
        class Zoo
        {
            public void outText()
            {
                Console.WriteLine($"Животное: {animal}");
                Console.WriteLine($"Пол: {sex}");
                Console.WriteLine($"Имя: {name}");
                Console.WriteLine($"Цена: {price} р.");
                Console.WriteLine($"Количество: {number}");
            }

            public string animal;
            public string sex;
            public string name;
            public int price;
            public int number;
        }
    }
}
