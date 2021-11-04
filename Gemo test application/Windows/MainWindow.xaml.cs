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

namespace Gemo_test_application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GemoTestEntities db = new GemoTestEntities();
        Study selectedStudy;

        public MainWindow()
        {
            InitializeComponent();
            gridStudyTypes.ItemsSource = db.Study.ToList();
        }

        private void gridStudyTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStudy = gridStudyTypes.SelectedValue as Study;
            Applications application = new Applications(selectedStudy);
            Hide();
            application.Show();
        }
    }
}
