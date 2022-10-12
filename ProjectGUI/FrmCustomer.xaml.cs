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

namespace ProjectGUI
{
    /// <summary>
    /// Interaction logic for FrmCustomer.xaml
    /// </summary>
    public partial class FrmCustomer : Window
    {
        public FrmCustomer()
        {
            InitializeComponent();

            //Customer customer = new Customer();
            //customer.Name = "Jumbo";
            //customer.Lastname1 = "TwoYou";

            //MessageBox.Show("Hello" + "  " +customer.Name +"  "+ customer.Lastname1 );

            Class.Cat cat = new Class.Cat();
            MessageBox.Show(cat.breathing());
            MessageBox.Show(cat.cry());

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
