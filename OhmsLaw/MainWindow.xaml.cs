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

namespace OhmsLaw
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // изначально выбрана радиокнопка для расчёта тока
            cbAmps.IsChecked = true;
            cbOhmParralel.IsChecked = false;
            cbOhms.IsChecked = false;
            cbOhmsPos.IsChecked = false;
            cbVolts.IsChecked = false;
        }

        // создаём экземпляр класса 
        OhmLaw ohm = new OhmLaw();

         
    private void btn_math_Click(object sender, RoutedEventArgs e)
        {
            // инструкции для нажатия кнопки "Расчитать"
            // если выбран расчёт тока
            if(cbAmps.IsChecked == true)
            {
               // то вызываем метод класса и присваиваем его значение в метку
                lbl_finish_answer.Content = ohm.Amper(Convert.ToDouble(textBoxFirst.Text), Convert.ToDouble(textBoxSecond.Text)).ToString() ;
            }

            // если выбран расчёт напряжения
            else if (cbVolts.IsChecked == true)
            {
                // то вызываем метод класса и присваиваем его значение в метку
                lbl_finish_answer.Content = ohm.Volt(Convert.ToDouble(textBoxFirst.Text), Convert.ToDouble(textBoxSecond.Text)).ToString();
            }

            // если выбран расчёт последовательного сопротивления 
            else if (cbOhmsPos.IsChecked == true)
            {
                // то вызываем метод класса и присваиваем его значение в метку
                lbl_finish_answer.Content = ohm.OhmPos(Convert.ToDouble(textBoxFirst.Text), Convert.ToDouble(textBoxSecond.Text)).ToString();
            }

            // если выбран расчёт параллельного сопротивления
            else if (cbOhmParralel.IsChecked == true)
            {
                // то вызываем метод класса и присваиваем его значение в метку
                lbl_finish_answer.Content = ohm.OhmsParralel(Convert.ToDouble(textBoxFirst.Text), Convert.ToDouble(textBoxSecond.Text)).ToString();
            }

            // если выбран расчёт сопротивления
            else if (cbOhms.IsChecked == true)
            {
                // то вызываем метод класса и присваиваем его значение в метку
                lbl_finish_answer.Content = ohm.Ohms(Convert.ToDouble(textBoxFirst.Text), Convert.ToDouble(textBoxSecond.Text)).ToString();
            }

            // если не выбрано ничего или больше одного элемента ( чего не должно быть )
            else
            {
                // вывести сообщение об ошибке
                MessageBox.Show("Неправильно выбраны параметры, убедитесь что всё выбрано правильно и повторите ещё раз.");
            }
            
        }

        private void cbAmps_Checked(object sender, RoutedEventArgs e)
        {
                // инструкции для выбранного CheckBox'a 
                // присваиваем остальным статус false
                // скрываем метки которые нам не нужны и делаем видимыми те, которые нужно использовать
                cbOhmParralel.IsChecked = false;
                cbOhms.IsChecked = false;
                cbOhmsPos.IsChecked = false;
                cbVolts.IsChecked = false;
                lblA_R.Visibility = Visibility.Visible;
                lblA_U.Visibility = Visibility.Visible;

                lblR_A.Visibility = Visibility.Hidden;
                lblR_U.Visibility = Visibility.Hidden;
                lblR_R1.Visibility = Visibility.Hidden;
                lblR_R2.Visibility = Visibility.Hidden;

                lblV_A.Visibility = Visibility.Hidden;
                lblV_R.Visibility = Visibility.Hidden;

                lbl_answer_a.Visibility = Visibility.Visible;
                lbl_answer_ohm.Visibility = Visibility.Hidden;
                lbl_answer_volt.Visibility = Visibility.Hidden;

            
        }

        private void cbVolts_Checked(object sender, RoutedEventArgs e)
        {
            // инструкции для выбранного CheckBox'a 
            // присваиваем остальным статус false
            // скрываем метки которые нам не нужны и делаем видимыми те, которые нужно использовать

            cbAmps.IsChecked = false;
            cbOhmParralel.IsChecked = false;
            cbOhms.IsChecked = false;
            cbOhmsPos.IsChecked = false;
            lblA_R.Visibility = Visibility.Hidden;
            lblA_U.Visibility = Visibility.Hidden;

            lblR_A.Visibility = Visibility.Hidden;
            lblR_U.Visibility = Visibility.Hidden;
            lblR_R1.Visibility = Visibility.Hidden;
            lblR_R2.Visibility = Visibility.Hidden;

            lblV_A.Visibility = Visibility.Visible;
            lblV_R.Visibility = Visibility.Visible;

            lbl_answer_a.Visibility = Visibility.Hidden;
            lbl_answer_ohm.Visibility = Visibility.Hidden;
            lbl_answer_volt.Visibility = Visibility.Visible;
        }

        private void cbOhms_Checked(object sender, RoutedEventArgs e)
        {
            // инструкции для выбранного CheckBox'a 
            // присваиваем остальным статус false
            // скрываем метки которые нам не нужны и делаем видимыми те, которые нужно использовать

            cbAmps.IsChecked = false;
            cbOhmParralel.IsChecked = false;
            cbOhmsPos.IsChecked = false;
            cbVolts.IsChecked = false;
            lblA_R.Visibility = Visibility.Hidden;
            lblA_U.Visibility = Visibility.Hidden;

            lblR_A.Visibility = Visibility.Visible;
            lblR_U.Visibility = Visibility.Visible;
            lblR_R1.Visibility = Visibility.Hidden;
            lblR_R2.Visibility = Visibility.Hidden;

            lblV_A.Visibility = Visibility.Hidden;
            lblV_R.Visibility = Visibility.Hidden;

            lbl_answer_a.Visibility = Visibility.Hidden;
            lbl_answer_ohm.Visibility = Visibility.Visible;
            lbl_answer_volt.Visibility = Visibility.Hidden;
        }

        private void cbOhmParralel_Checked(object sender, RoutedEventArgs e)
        {
            // инструкции для выбранного CheckBox'a 
            // присваиваем остальным статус false
            // скрываем метки которые нам не нужны и делаем видимыми те, которые нужно использовать

            cbAmps.IsChecked = false;
            cbOhms.IsChecked = false;
            cbOhmsPos.IsChecked = false;
            cbVolts.IsChecked = false;
            lblA_R.Visibility = Visibility.Hidden;
            lblA_U.Visibility = Visibility.Hidden;

            lblR_A.Visibility = Visibility.Hidden;
            lblR_U.Visibility = Visibility.Hidden;
            lblR_R1.Visibility = Visibility.Visible;
            lblR_R2.Visibility = Visibility.Visible;

            lblV_A.Visibility = Visibility.Hidden;
            lblV_R.Visibility = Visibility.Hidden;

            lbl_answer_a.Visibility = Visibility.Hidden;
            lbl_answer_ohm.Visibility = Visibility.Visible;
            lbl_answer_volt.Visibility = Visibility.Hidden;
        }

        private void cbOhmsPos_Checked(object sender, RoutedEventArgs e)
        {
            // инструкции для выбранного CheckBox'a 
            // присваиваем остальным статус false
            // скрываем метки которые нам не нужны и делаем видимыми те, которые нужно использовать

            cbAmps.IsChecked = false;
            cbOhmParralel.IsChecked = false;
            cbOhms.IsChecked = false;
            cbVolts.IsChecked = false;
            lblA_R.Visibility = Visibility.Hidden;
            lblA_U.Visibility = Visibility.Hidden;

            lblR_A.Visibility = Visibility.Hidden;
            lblR_U.Visibility = Visibility.Hidden;
            lblR_R1.Visibility = Visibility.Visible;
            lblR_R2.Visibility = Visibility.Visible;

            lblV_A.Visibility = Visibility.Hidden;
            lblV_R.Visibility = Visibility.Hidden;

            lbl_answer_a.Visibility = Visibility.Hidden;
            lbl_answer_ohm.Visibility = Visibility.Visible;
            lbl_answer_volt.Visibility = Visibility.Hidden;
        }
    }
}
