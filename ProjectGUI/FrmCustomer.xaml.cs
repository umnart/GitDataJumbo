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

            //Class.Cat cat = new Class.Cat();
            //MessageBox.Show(cat.breathing());
            //MessageBox.Show(cat.cry());

            //MessageBox.Show(cat.move());



            Class.Square square = new Class.Square();

            Class.Square square2 = new Class.Square();


            square.Side = 5;
            square2.Side = 10;


            MessageBox.Show(square.Area().ToString());

            MessageBox.Show(square2.Area().ToString());

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
