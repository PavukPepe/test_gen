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

namespace Tests_gen
{
    /// <summary>
    /// Логика взаимодействия для Tests_win.xaml
    /// </summary>
    public partial class Tests_win : Window
    {
        public Tests_win(bool admin)
        {
            InitializeComponent();
            if (!admin)
            {
                alter_but.IsEnabled = false;
            }
        }

        private void alter_but_Click(object sender, RoutedEventArgs e)
        {
            content_frame.Content = new Alter_page();
        }

        private void exit_but_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            Close();
            win.Show();
        }

        private void pass_but_Click(object sender, RoutedEventArgs e)
        {
            var questions = Json_master.Read<List<Question>>("questions.json").Where(item => item.name != null && item.answer_1 != null && item.answer_2 != null && item.answer_3 != null && item.right_answ != 0 && item.description!=null);
            if (questions.Count() == 0) 
                content_frame.Content = new None_page();
            else
            {
                content_frame.Content = new Test_page();
            }
        }
    }
}
