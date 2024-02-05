using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    ///Названия класса Человек
    /// </summary>
    class Person
    {
        /// <summary>
        ///Возраст человека
        /// </summary>
        public int age;
        /// <summary>
        ///Имя человека
        /// </summary>
        public string name;
        /// <summary>
        ///Фамилия человека
        /// </summary>
        public string surname;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Person()
        {

        }
        /// <summary>
        /// Конструктор с параметрам Возраст
        /// </summary>
        public Person(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Конструктор с параметрами Возраст и Имя
        /// </summary>
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        public Person(int age, string name, string surname)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
        }
        /// <summary>
        /// Метод вывода всей информации об объекте
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Возраст человека - {age}\tИмя человека- {name}\tФамилия человека- {surname}";
        }

    }
}
