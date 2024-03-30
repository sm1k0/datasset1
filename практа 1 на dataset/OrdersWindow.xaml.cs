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
using практа_1_на_dataset.Prakta1DataSetTableAdapters;

namespace практа_1_на_dataset
{
    /// <summary>
    /// Логика взаимодействия для OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        private readonly OrdersTableAdapter ordersTableAdapter = new OrdersTableAdapter();
        private readonly Prakta1DataSet prakta1DataSet = new Prakta1DataSet();

        public OrdersWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                ordersTableAdapter.Fill(prakta1DataSet.Orders);
                dataGrid.ItemsSource = prakta1DataSet.Orders.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }

        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ClientsWindow());
        }

        private void ProductsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new ProductsWindow());
        }

        private void OrdersButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new OrdersWindow());
        }

        private void OrderRecipientsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new OrderRecipientsWindow());
        }

        private void DeliveryButton_Click(object sender, RoutedEventArgs e)
        {
            OpenWindow(new DeliveryWindow());
        }

        private void OpenWindow(Window window)
        {
            window.Owner = this;
            window.Show();
        }
    }
}