using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prakt8
{
    internal class Emplsalar: Iemloyee
    {
        int days;
        public int Days
        {
            get
            {
                return days;
            }
            set
            {
                if (value > 0)
                {
                    days = value;
                }
                else
                {
                    MessageBox.Show("Колличество дней не может быть меньше нуля");
                }
            }
        }

        public string Name { get; set; }
        public string Family { get; set; }
        public int Salary { get; set; }


        public string Information ()
        {
            string result;
            result = ($"Имя: {Name}\nФамилия: {Family}\nЗарплата={((Convert.ToDouble(Salary) / 22)*Days)}");
            return result;
        }
    }
}
