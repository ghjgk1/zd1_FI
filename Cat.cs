using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cat
{
    //Создадим класс “Кот”
    internal class Cat
    {
        //скрытое поле имя
        private string name;

        //свойство, для вззаимодействия с полем имя
        public string Name
        {
            // получение значения
            get { return name; }
            // установка значения
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                //условие проверяет на то что в перемнной буквы и она не пустая
                if (OnlyLetters && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }

            }
        }

        //Конструктор для создания нового экземпляра
        public Cat(string CatName)
        {
            Name = CatName;
        }

        public Cat()
        {
        }

        //Метод, который бы позволял опознать отдельно взятого кота
        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
        }

        //скрытое поле вес
        private string ves;

        // свойство, для вззаимодействия с полем вес
        public string Ves
        {
            get
            {
                return ves;
            }
            set
            {
                //проверка на некоректность ввода и число не бесконечнность и 0<x!=0
                if (Convert.ToDouble(value) > 0)
                {
                    ves = value;
                }
                else
                {
                    Console.WriteLine("Weight is not correct");
                }
            }
        }


        public void CName(string CatName)
        {
            Name = CatName;
        }

        public void CatInfo()
        {
            Console.WriteLine($"{name}-{ves}");
        }

    }
}
