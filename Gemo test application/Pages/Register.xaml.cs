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
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        GemoTestEntities db = new GemoTestEntities();
        Applications applications;
        Analyzes analyzes = null;

        public double servicesPrice = 0;
        public decimal? analyzesPrice = 0;
        public List<int?> analyzesIds = new List<int?>();

        public Register(Applications applications)
        {
            InitializeComponent();

            this.applications = applications;

            txtStudyName.Text = applications.study.Name;

            gridServices.ItemsSource = db.ServicesForStudy.Where(x => x.id_Study == applications.study.id).ToList();

            comboboxDoctor.ItemsSource = db.Doctors.ToList().Select(x => x.Name);
            comboboxPacient.ItemsSource = db.Patients.ToList().Select(x => x.Name + " " + x.id);

            db.Services.ToList().ForEach(x => servicesPrice += Convert.ToDouble(x.Price));
            txtServicesPrice.Text = $"Итого стоимость услуг: {servicesPrice}р";

            updateSum();
        }

        private void updateSum()
        {
            applications.db.SaveChanges();
            analyzesIds = db.AnalyzesForOrder.Where(x => x.id_Order == applications.order.id && x.Needed == true).Select(x => x.id_Analyze).ToList();
            analyzesPrice = 0;
            for (int i = 0; i < analyzesIds.Count; i++)
            {
                db.ElementsNeedForAnalyze.ToList().Where(x => x.id_Analyze == analyzesIds[i]).ToList().ForEach(x => analyzesPrice += x.Count * x.Elements.Price * 2);
            }
            txtAnalyzesPrice.Text = $"Итого стоимость анализов: {analyzesPrice}";

            txtEndPrice.Text = $"ИТОГ: {Convert.ToDouble(analyzesPrice) + servicesPrice}р";
        }

        private void btnRefeshPrice_Click(object sender, RoutedEventArgs e)
        {
            updateSum();
        }
    }
}
