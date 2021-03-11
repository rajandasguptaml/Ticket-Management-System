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

namespace Demoproject
{
    /// <summary>
    /// Interaction logic for FinalizeYourTicket.xaml
    /// </summary>
    public partial class FinalizeYourTicket : Window
    {
        public FinalizeYourTicket()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SeatPlan lo = new SeatPlan();
            lo.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Payment Successfully");
            Receipt tb = new Receipt();
            tb.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }
    }
}
