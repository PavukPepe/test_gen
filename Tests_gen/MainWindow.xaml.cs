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
using System.IO;


namespace Tests_gen
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

        private void pas_but_Click(object sender, RoutedEventArgs e)
        {
            Tests_win win = new Tests_win(false);
            Close();
            win.Show();
        }

        private void alt_but_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("questions.json"))
            {
                File.WriteAllText("questions.json", "[]");
            }
            password.Visibility = Visibility.Visible;
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (password.Text == "пароль")
            {
                Tests_win win = new Tests_win(true);
                Close();
                win.Show();
            }
        }
    }
}
