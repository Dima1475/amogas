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
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        GemoTestEntities db = new GemoTestEntities();
        Orders order;
        public OrdersWindow()
        {
            InitializeComponent();
            datagridOrders.ItemsSource = db.Orders.ToList();
        }

        private void btnAddNewOrder_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Hide();
            mainWindow.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (order != null)
            {
                Applications applications = new Applications(order.Study);
                Hide();
                applications.order = order;
                applications.idWindow = 1;
                applications.results = new Results(applications);
                applications.mainFrame.Navigate(applications.results);
                applications.ShowDialog();
                Show();
            }
            else
                MessageBox.Show("Выберите заказ из списка!");
        }

        private void datagridOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            order = datagridOrders.SelectedValue as Orders;
        }
    }
}
