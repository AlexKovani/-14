using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название животного cat или dog: ");
            string name = Console.ReadLine();
            if (name == "dog" || name == "Dog" || name == "DOG")
            {
                Dog dog = new Dog(name);
                dog.ShowInfo();
            }
            else
            {
                if (name == "cat" || name == "Cat" || name == "CAT")
                {
                    Cat cat = new Cat(name);
                    cat.ShowInfo();
                }

                Console.WriteLine("Ошибка ввода!");
            }
            Console.ReadKey();
        }
    }
}
