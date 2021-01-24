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
using System.Windows.Shapes;

namespace BodyMassIndex
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        public static double BMIcomputation(ref int refWeight, ref double refHeight)
        {
            double BodyMassIndex = refWeight / (refHeight * refHeight);
            return BodyMassIndex;
        }

        private void BtnCloseFrm2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void FuncForm2()
        {
            MainWindow main = this.Owner as MainWindow;

            if (main != null)
            {
                string name = main.fieldName.Text;
                int age = Int32.Parse(main.fieldAge.Text);
                int weight = Int32.Parse(main.fieldWeight.Text);
                double height = Double.Parse(main.fieldHeight.Text);               

                lblName.Content = "Ваше имя: " + name;
                lblAge.Content = "Возраст: " + age + " лет";
                lblWeight.Content = "Вес: " + weight + " кг";
                lblHeight.Content = "Рост: " + height + " м";
                lblBMI.Content = "Ваш ИМТ: " + BMIcomputation(ref weight, ref height);
            }
        }
    }
}
