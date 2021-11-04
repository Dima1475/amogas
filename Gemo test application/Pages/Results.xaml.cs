using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        Applications applications;
        List<AnalyzesResults> results;
        AnalyzesResults result;

        public GemoTestEntities db = new GemoTestEntities();

        public Results(Applications applications)
        {
            InitializeComponent();

            this.applications = applications;

            
            txtName.Text = db.Study.Find(applications.order.id_Study).Name + " - РЕЗУЛЬТАТ";
            txtDate.Text = "Дата проведения исследования: " + applications.order.Date.Value.ToShortDateString();
            txtDoctor.Text = "Исследование провел: " + db.Doctors.Find(applications.order.id_Doctor).Name;
            txtNumber.Text = "Номер документа заказа: " + applications.order.Code;

            Update();
            
        }

        private void Update()
        {
            gridResults.ItemsSource = null;
            gridResults.ItemsSource = db.AnalyzesResults.Where(x => x.id_Patient == applications.order.id_Patient && x.Date == applications.order.Date).Distinct().ToList();
        }
    }
}
