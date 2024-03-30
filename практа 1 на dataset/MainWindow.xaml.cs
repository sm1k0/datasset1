using System;
using System.Windows;

namespace практа_1_на_dataset
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
