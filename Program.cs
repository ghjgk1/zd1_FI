using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Создаем первого кота
                Cat Cat1 = new Cat();

                //Создаем второго кота
                Cat Cat2 = new Cat();

                //Добавляем имя первого кота
                do
                {
                    Console.WriteLine("Введите имя первого кота");
                    Cat1.Name = Console.ReadLine();
                }
                while (Cat1.Name == null);

                //Добавляем имя второго кота
                do
                {
                    Console.WriteLine("Введите имя второго кота");
                    Cat2.Name = Console.ReadLine();
                }
                while (Cat2.Name == null);

                //Добавляем вес первого кота
                Console.WriteLine("Введите вес первого кота");
                Cat1.Ves = Console.ReadLine();

                //Добавляем вес второго кота
                Console.WriteLine("Введите вес второго кота");
                Cat2.Ves = Console.ReadLine();


                //Мяукаем первым котом
                Cat1.Meow();

                //Мяукаем вторым котом
                Cat2.Meow();

                //Выводим информацию о первом коте
                Cat1.CatInfo();

                //Выводим информацию о втором коте
                Cat2.CatInfo();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }
       
    }
}
