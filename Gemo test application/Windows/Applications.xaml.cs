using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Gemo_test_application
{
    /// <summary>
    /// Логика взаимодействия для Applications.xaml
    /// </summary>
    public partial class Applications : Window
    {
        public Study study;
        public Orders order;
        public GemoTestEntities db = new GemoTestEntities();
        public int idWindow = 0;
        public Results results;

        Register register;
        List<AnalyzesForOrder> analyzeList;

        public Applications(Study study)
        {
            InitializeComponent();

            this.study = study;

            order = new Orders();
            db.Orders.Add(order);
            db.SaveChanges();

            for (int i = 0; i < db.Analyzes.ToList().Count; i++)
            {
                AnalyzesForOrder analyzesForOrder = new AnalyzesForOrder();
                decimal? price = 0;
                analyzesForOrder.id_Analyze = db.Analyzes.ToList()[i].id;
                analyzesForOrder.Needed = true;
                analyzesForOrder.id_Order = order.id;
                int? idElement = db.ElementsNeedForAnalyze.ToList().Where(x => x.id_Analyze == db.Analyzes.ToList()[i].id).FirstOrDefault().id_Element;
                var list = db.ElementsNeedForAnalyze.ToList().Where(x => x.id_Analyze == db.Analyzes.ToList()[i].id).ToList();
                for (int j = 0; j < list.Count(); j++)
                {
                    price += list.ToList()[j].Count * db.Elements.ToList().Where(x => x.id == list.ToList()[j].id_Element).FirstOrDefault().Price * 2;
                }
                analyzesForOrder.Price = price;
                db.AnalyzesForOrder.Add(analyzesForOrder);
            }
            db.SaveChanges();
            register = new Register(this);
            analyzeList = db.AnalyzesForOrder.Where(x => x.id_Order == order.id && x.Needed == true).ToList();
            register.gridAnalyzes.ItemsSource = analyzeList;

            idWindow = 0;

            mainFrame.Navigate(register);
        }



        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (register.datepickerDate.Text.Length > 0 && register.txtAnalyzesPrice.Text.Length > 0 && register.txtDocumentNumber.Text.Length > 0 && register.txtEndPrice.Text.Length > 0 && register.txtServicesPrice.Text.Length > 0 && register.txtStudyName.Text.Length > 0 && register.comboboxDoctor.Text.Length > 0 && register.comboboxPacient.Text.Length > 0 && idWindow == 0)
            {
                analyzeList = db.AnalyzesForOrder.Where(x => x.id_Order == order.id && x.Needed == true).ToList();
                order.Date = Convert.ToDateTime(register.datepickerDate.SelectedDate.Value.ToShortDateString());
                order.EndPrice = register.analyzesPrice + Convert.ToDecimal(register.servicesPrice);
                order.Code = register.txtDocumentNumber.Text;
                order.id_Doctor = db.Doctors.Where(x => x.Name == register.comboboxDoctor.Text).FirstOrDefault().id;
                order.id_Patient = Convert.ToInt32(register.comboboxPacient.Text.Split()[3]);
                order.id_Study = study.id;
                for (int i = 0; i < analyzeList.Count; i++)
                {
                    AnalyzesResults analyzesResults = new AnalyzesResults();
                    analyzesResults.id_Patient = order.id_Patient;
                    analyzesResults.Date = order.Date;
                    analyzesResults.id_Analyze = analyzeList[i].id_Analyze;
                    db.AnalyzesResults.Add(analyzesResults);
                }
                db.SaveChanges();
                MessageBox.Show("Заявка успешно создана!");
                idWindow = 1;
                results = new Results(this);
                mainFrame.Navigate(results);
            }
            else if (idWindow == 1)
            {
                results.db.SaveChanges();
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void btnSeal_Click(object sender, RoutedEventArgs e)
        {
            if (idWindow == 0)
            {
                if (register.datepickerDate.Text.Length > 0 && register.txtAnalyzesPrice.Text.Length > 0 && register.txtDocumentNumber.Text.Length > 0 && register.txtEndPrice.Text.Length > 0 && register.txtServicesPrice.Text.Length > 0 && register.txtStudyName.Text.Length > 0 && register.comboboxDoctor.Text.Length > 0 && register.comboboxPacient.Text.Length > 0)
                {
                    analyzeList = db.AnalyzesForOrder.Where(x => x.id_Order == order.id && x.Needed == true).ToList();
                    order.Date = Convert.ToDateTime(register.datepickerDate.SelectedDate.Value.ToShortDateString());
                    order.EndPrice = register.analyzesPrice + Convert.ToDecimal(register.servicesPrice);
                    order.Code = register.txtDocumentNumber.Text;
                    order.id_Doctor = db.Doctors.Where(x => x.Name == register.comboboxDoctor.Text).FirstOrDefault().id;
                    order.id_Patient = Convert.ToInt32(register.comboboxPacient.Text.Split()[3]);
                    order.id_Study = study.id;
                    for (int i = 0; i < analyzeList.Count; i++)
                    {
                        AnalyzesResults analyzesResults = new AnalyzesResults();
                        analyzesResults.id_Patient = order.id_Patient;
                        analyzesResults.Date = order.Date;
                        analyzesResults.id_Analyze = analyzeList[i].id_Analyze;
                        db.AnalyzesResults.Add(analyzesResults);
                    }
                    db.SaveChanges();
                    StudySealWindow studySealWindow = new StudySealWindow(this);
                    studySealWindow.Show();
                }
                else
                    MessageBox.Show("Заполните все поля!");
            }
            else if(idWindow == 1)
            {
                
            }
        }
    }
}
