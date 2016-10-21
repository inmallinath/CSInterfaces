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
using CSInterfacesRepository.Service;
using CSInterfaces.Library;

namespace CSInterfaces.CustomerViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {
            ClearListBox();

            ICustomerRepository serviceRepo = new ServiceRepository();
            var customers = serviceRepo.GetCustomers();
            foreach (var customer in customers)
            {
                lstCustomers.Items.Add(customer);
            }
            ShowRepositoryType(serviceRepo);
        }

        public void ClearListBox()
        {
            lstCustomers.Items.Clear();
        }

        private void ShowRepositoryType(ICustomerRepository repository)
        {
            MessageBox.Show(string.Format("Repository Type: \n {0}", repository.GetType().ToString()));
        }
    }
}
