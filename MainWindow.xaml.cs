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

namespace BodyMassIndex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void field_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void btnIMT_Click(object sender, RoutedEventArgs e)
        {
            /* <SolidColorBrush x:Key="ComboBoxItem.ItemsviewHoverFocus.Background" Color="*COLOR*"/>
             * 
            <LinearGradientBrush x:Key="TabItem.MouseOver.Background" */
            try {
                if ((fieldName.Text != "") && (fieldAge.Text != "") && (fieldWeight.Text != "")
                    && (fieldHeight.Text != "")) {
                    if (selectGender.SelectedIndex == -1) {
                        MessageBox.Show("Выберите Ваш пол из выпадающего списка", "Выберите пол",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    } else {
                        Window2 Frm2 = new Window2();

                        Frm2.Owner = this;

                        Frm2.FuncForm2();

                        Frm2.ShowDialog();
                    }
                } else {
                    MessageBox.Show("Введите данные", "Недостаточно данных", MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            } catch (FormatException) {
                MessageBox.Show("Введите рост через символ запятой", "Неправильный ввод", MessageBoxButton.OK,
                       MessageBoxImage.Error);
            }
        }
    }
}
