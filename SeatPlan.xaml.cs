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
using System.Data.SqlClient;

namespace Demoproject
{
    /// <summary>
    /// Interaction logic for SeatPlan.xaml
    /// </summary>
    public partial class SeatPlan : Window
    {
        public SeatPlan()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-1KGI9MI\SQLEXPRESS;Initial Catalog=ProjectDemo;Integrated Security=True");

            con2.Open();

            SqlCommand cmd3 = new SqlCommand(@"INSERT INTO [dbo].[seat]
           ([address]
           ,[destination]
           ,[date]
           ,[name]
           ,[type]
           ,[seat1])
     VALUES
           ('" + aaa.SelectedItem.ToString() + "' , '" + bbb.SelectedItem.ToString() + "' ,'" + kl.DisplayDate.ToString() + "' ,'" + mn.Text + "' ,'" + lm.SelectedItem.ToString()
           
           + "' ,'" + pl.SelectedItem.ToString() + "')", con2);


            try
            {
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con2.Close();
            }

            MessageBox.Show("Done");

            FinalizeYourTicket ok = new FinalizeYourTicket();
            ok.Show();
            this.Hide();

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }

        private void Mn_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
           
            string name = "Passenger Name: " + mn.Text;
            string date = "Journey Date: " + kl.DisplayDate.ToString();
            string tseat = "Seat Type : " + lm.SelectedItem.ToString();
            string dformme = "From : " + aaa.SelectedItem.ToString();
            string dto = "To : " + bbb.SelectedItem.ToString();
            string fto = "Total Amount : " + fai.Text;


            string details = name + "\n" + date + "\n" + tseat + "\n" + dformme + "\n" + dto + "\n" + fto ;


            output.Text = details;

           
        }
    }
}
