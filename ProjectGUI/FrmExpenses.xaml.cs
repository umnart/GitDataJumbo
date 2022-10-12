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
    /// Interaction logic for FrmExpenses.xaml
    /// </summary>
    public partial class FrmExpenses : Window
    {
        public FrmExpenses()
        {
            InitializeComponent();
        }

        private void bntExpenses_Click(object sender, RoutedEventArgs e)
        {
          


            double Income = Convert.ToDouble(TxtIncome.Text);
            double Expenses = Convert.ToDouble(TxtExpenses.Text);
            double Product_Price = Convert.ToDouble(TxtProduct_Price.Text);
         
            double Result = Product_Price / (Income - Expenses);
            
            if (Income > Expenses)
            {
                TxtTotal.Text = Math.Ceiling(Result).ToString();

            }
            else
            {
                MessageBox.Show("จะบ้าหรือ  เงินไม่พอใช้ขนาดนี้ ยังจะอยากได้ของอีก !!!!!!");

            }


        }
    }
}
