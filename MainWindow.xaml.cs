using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Demoproject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string userErr;
        string passErr;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (uName.Text == "")
            {
                userErr = "Please Enter UserName";
                uerErroe.Content = userErr;
            }
            else
            {
                uerErroe.Content = "";
            }

            if (uPass.Password == "")
            {
                passErr = "Please Enter PassWord";
                passError.Content = passErr;
            }
            else
            {
                passError.Content = "";
            }

            if (uName.Text != "" && uPass.Password != "")

            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1KGI9MI\SQLEXPRESS;Initial Catalog=ProjectDemo;Integrated Security=True");
                try
                {
                    con.Open();
                    string query = "select count(*) from [User] where UserName= '" + uName.Text + "' AND Password= '" + uPass.Password + "'   ";
                    SqlCommand sqlcmd = new SqlCommand(query, con);

                    int a = Convert.ToInt32(sqlcmd.ExecuteScalar());

                    if (a == 1)
                    {
                        SeatPlan os = new SeatPlan();
                        os.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }






            





        }

        private void UName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
