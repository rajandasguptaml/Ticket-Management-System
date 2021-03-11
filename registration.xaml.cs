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
    /// Interaction logic for registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        string userErr;
        string passErr;
        string conErr;
        string eErr;
       // string genErr;
        string fnErr;
        string lnErr;
        string cpassErr;
        string matchErr;





        public registration()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (uname1.Text == "")
            {
                userErr = "Please Enter UserNAme";
                uerErroe.Content = userErr;
            }
            else
            {
                uerErroe.Content = "";
            }

            if (upass1.Password == "")
            {
                passErr = "Please Enter PassWord";
                passError.Content = passErr;
            }
            else
            {
                passError.Content = "";
            }


            if (cpssError.Password == "")
            {
                cpassErr = "Please Enter PassWord Again";
                cpError.Content = cpassErr;
            }
            else
            {
                cpError.Content = "";
            }



            if (upass1.Password == cpssError.Password)
            {
                matchError.Content = "";
            }
            else
            {

                matchErr = "Password not Same";
                matchError.Content = matchErr;
            }







            if (contact.Text == "")
            {
                conErr = "Please Enter Contact";
                conError.Content = conErr;
            }
            else
            {
                conError.Content = "";
            }

            if (email.Text == "")
            {
                eErr = "Please Enter Email";
                emailError.Content = eErr;
            }
            else
            {
                emailError.Content = "";
            }

            //try
            //{

            //    if (cmbbox.SelectedItem == "")
            //    {
            //        genErr = "Please Enter Gender";
            //        genError.Content = genErr;
            //    }
            //    else
            //    {
            //        genError.Content = "";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}




            if (Fname.Text == "")
            {
                fnErr = "Please Enter First Name";
                fnError.Content = fnErr;
            }
            else
            {
                fnError.Content = "";
            }


            if (Lname.Text == "")
            {
                lnErr = "Please Enter Last Name";
                lnError.Content = lnErr;
            }
            else
            {
                lnError.Content = "";
            }



            if (Fname.Text != "" && Lname.Text != "" && contact.Text != "" && email.Text != "" && uname1.Text != "" && upass1.Password != "" && cpssError.Password != "" && upass1.Password == cpssError.Password)
            {

                SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-1KGI9MI\SQLEXPRESS;Initial Catalog=ProjectDemo;Integrated Security=True");


                SqlCommand cmd1 = new SqlCommand(@"INSERT INTO [dbo].[reg1]
           ([firstname]
           ,[lastname]
           ,[contact]
           ,[gender]
           ,[email]
           ,[UserName]
           ,[Password])
     VALUES
           ('" + Fname.Text + "' , '" + Lname.Text + "' ,'" + contact.Text + "' ,'" + cmbbox.SelectedItem.ToString() + "' ,'" + email.Text + "' ,'" + uname1.Text + "','" + upass1.Password + "' )", con1);

                SqlCommand cmd2 = new SqlCommand(@"INSERT INTO [dbo].[User]
           ([UserName]
           ,[Password])
     VALUES
           ('" + uname1.Text + "' , '" + upass1.Password + "')", con1);



                con1.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con1.Close();
                MessageBox.Show("Registration Successfully");

                Window1 ol = new Window1();
                ol.Show();
                this.Hide();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 ol = new Window1();
            ol.Show();
            this.Hide();
        }
    }
}
