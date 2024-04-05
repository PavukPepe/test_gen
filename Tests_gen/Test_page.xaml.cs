using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace Tests_gen
{
    /// <summary>
    /// Логика взаимодействия для Test_page.xaml
    /// </summary>
    public partial class Test_page : Page
    {
        int cl = 0;
        int cl_right = 0;
        List<Question> questions = Json_master.Read<List<Question>>("questions.json").Where(item => item.name != null && item.answer_1 != null && item.answer_2 != null && item.answer_3 != null && item.right_answ != 0 && item.description != null).ToList();
        public Test_page()
        {
            InitializeComponent();
            Reload(0);
            /*            foreach (var item in questions)
                        {
                            name_q.Text = item.name;
                            desc_q.Text = item.description;
                            but1.Content = item.answer_1;
                            but2.Content = item.answer_2;
                            but3.Content = item.answer_3;
                        }*/
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            if (questions[cl].right_answ == Answers.Первый)
                cl_right++;
            cl += 1;
            Reload(cl);
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            if (questions[cl].right_answ == Answers.Второй)
                cl_right++;
            cl += 1;
            Reload(cl);
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            if (questions[cl].right_answ == Answers.Третий)
                cl_right++;
            cl += 1;
            Reload(cl);
        }

        void Reload(int cl)
        {
            if (cl > questions.Count - 1)
            {
                name_q.Text = $"Вы ответили на {cl_right} из {cl}";
                but1.IsEnabled = false;
                but2.IsEnabled = false;
                but3.IsEnabled = false;
            }
            else
            {
                Question item = questions[cl];
                name_q.Text = item.name;
                desc_q.Text = item.description;
                but1.Content = item.answer_1;
                but2.Content = item.answer_2;
                but3.Content = item.answer_3;
            }
        }
    }
}
