using CSInterfaces.Library;
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

namespace CSInterfaces.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerRepository customerRepo = new CustomerRepository();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConcrete_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            Customer[] customers;
            customers = customerRepo.GetCustomers();

            foreach (var customer in customers)
            {
                CustomerListBox.Items.Add(customer);
            }
        }

        private void btnInterface_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void btnInterface_Copy_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();
        }

        private void ClearListBox()
        {
            CustomerListBox.Items.Clear();
        }
    }
}
