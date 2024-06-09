using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kolomieiets_722_a_2_Project_1
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
        // У методі Task реалізується завдання: якщо кількість введених цифр більше 5,
        // то результат = true, інакше False.
        public void Task() // метод реалізації програмного завдання
        {
            if (this.Data.Length > 5)
            {
                this.Result = Convert.ToString(true);

            }
            else
            {
                this.Result = Convert.ToString(false);
            }
        }
    }
}