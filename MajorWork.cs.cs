﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Surname_Group_Course_project
{
    class MajorWork
    {
        // Вміст робочого об'єкта
        // Поля
        private string Data; //вхідні дані
        private string Result; // Поле результату
                               // Методи
        public void Write(string D)// метод запису даних в об'єкт.
        {
            this.Data = D;
        }
        public string Read()
        {
            return this.Result;// метод відображення результату
        }
        public void Task() // метод реалізації програмного завдання
        {
        }
    }
}