using System;
using System.Collections.Generic;
using System.IO;
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

namespace Tests_gen
{
    /// <summary>
    /// Логика взаимодействия для Alter_page.xaml
    /// </summary>
    public partial class Alter_page : Page
    {
        List<Question> _questions = new List<Question>();
        public Alter_page()
        {
            InitializeComponent();
            Reload();
        }

        void Reload()
        {
            table_grid.ItemsSource = Json_master.Read<List<Question>>("questions.json");
        }

        private void table_grid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Json_master.Write(table_grid.Items, "questions.json");
        }

        private void table_grid_TouchEnter(object sender, TouchEventArgs e)
        {
            Json_master.Write(table_grid.Items, "questions.json");
        }

        private void table_grid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Json_master.Write(table_grid.Items, "questions.json");
        }
    }
}
