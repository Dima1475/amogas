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

namespace Gemo_test_application
{
    /// <summary>
    /// Логика взаимодействия для StudySealWindow.xaml
    /// </summary>
    public partial class StudySealWindow : Window
    {
        GemoTestEntities db = new GemoTestEntities();
        public StudySealWindow(Applications applications)
        {
            InitializeComponent();

            int? idPatient = applications.order.id_Patient;
            int? idGender = db.Patients.Where(x => x.id == idPatient).FirstOrDefault().id_Gender;
            decimal? allSum = 0;
            var list = db.AnalyzesForOrder.Where(x => x.id_Order == applications.order.id && x.Needed == true).ToList();
            datagridSum.ItemsSource = list;
            txtName.Text = "Имя: " + db.Patients.Where(x => x.id == idPatient).FirstOrDefault().Name.Split()[1];
            txtSecondName.Text = "Фамилия: " + db.Patients.Where(x => x.id == idPatient).FirstOrDefault().Name.Split()[0];
            txtMiddleName.Text = "Отчество: " + db.Patients.Where(x => x.id == idPatient).FirstOrDefault().Name.Split()[2];
            txtGender.Text = "Пол: " + db.Genders.Where(x => x.id == idGender).FirstOrDefault().Name;
            txtOrderNumber.Text = "ЗАКАЗ №: " + applications.order.Code;
            for (int i = 0; i < list.Count; i++)
            {
                allSum += list[i].Price;
            }
            txtAllSum.Text = "Итого: " + allSum;

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(canvasStudyForSeal, "Seal");
                Hide();
            }
        }
    }
}
