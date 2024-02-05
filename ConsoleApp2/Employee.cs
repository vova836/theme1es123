using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    ///Названия класса Сотрудник
    /// </summary>
    class Employee
    {
        /// <summary>
        ///Названия компаниии
        /// </summary>
        public string company;
        /// <summary>
        ///Названия должности
        /// </summary>
        public string job;
        /// <summary>
        ///Конструктор без параметров
        /// </summary>
        public Employee()
        {

        }
        /// <summary>
        ///Конструктор с параметрами компания
        /// </summary>
        public Employee(string company)
        {
            this.company = company;
        }
        /// <summary>
        ///Конструктор с параметрами
        /// </summary>
        public Employee(string company, string job)
        {
            this.company = company;
            this.job = job;
        }
        /// <summary>
        /// Метод вывода всей информации об объекте
        /// </summary>
        /// <returns></returns>
        public string Info()
        {
            return $" Компания - {company}\tДолжность -{job} ";
        }
    }
}
