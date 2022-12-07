using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prakt8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Emplhour employee1 = new Emplhour(); Emplsalar employee2 = new Emplsalar(); 



        private void About2st(object sender, RoutedEventArgs e)
        {
            string info = "";
            string name2 = Name2.Text;
            string fam2 = Fam2.Text;
            int.TryParse(ZP2.Text, out int ch1); int.TryParse(days.Text, out int ch2);
            if (ch1 != 0 && ch2 != 0)
            {
                employee2.Name = name2; employee2.Family = fam2; employee2.Salary = ch1; employee2.Days = ch2;
                info = employee2.Information();
                Rez.Text = info;
            }
            else { MessageBox.Show("Ошибка введенных данных"); }

        }

        private void About1st(object sender, RoutedEventArgs e)
        {
            string info = "";
            string name1 = Name1.Text;
            string fam1 = Fam1.Text;
            int.TryParse(ZP1.Text, out int ch1); int.TryParse(hrs.Text, out int ch2);
            if (ch1 != 0 && ch2 != 0)
                {
                employee1.Name = name1; employee1.Family = fam1; employee1.Salary = ch1; employee1.Hours = ch2;
                info = employee1.Information();
                Rez.Text = info;
            }
            else { MessageBox.Show("Ошибка введенных данных"); }
        }

        

        private void Sravn_Click(object sender, RoutedEventArgs e)
        { bool znach;
            string family1 = Fam1.Text;
            string family2 = Fam2.Text;
            family1 = family1.Replace(" ", "");
            family2 = family2.Replace(" ", "");
            znach = family1.Equals(family2);
            if (znach)
            {
                MessageBox.Show("Фамилии одинаковы по размеру");
            }
            else
            {
                MessageBox.Show("Фамилли не одинаковы по размеру");
            }

        }

        private void AboutProg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс – работник. Создать классы - служащий с почасовой оплатой, служащий с окладом.\nКлассы должны включать конструкторы, функцию для формирования строки информации о работнике.\nОпределить функцию начисления зарплаты.\nСравнение производить по фамилии.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
