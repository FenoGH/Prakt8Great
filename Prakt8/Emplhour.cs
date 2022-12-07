using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8
{
    internal class Emplhour : Iemloyee
    {
        int hours;
       
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value > 0)
                {
                    hours = value;
                }
                else
                {
                    MessageBox.Show("Колличество часов не может быть меньше нуля");
                }
            }
        }

       public string Name { get; set; }
       public string Family { get; set; }
        public int Salary { get; set; }

        
        public string Information()
        {   
            string result;
            result = ($"Имя: {Name}\nФамилия: {Family}\nЗарплата={Salary * Hours}");
            return result;
        }
    }
}
