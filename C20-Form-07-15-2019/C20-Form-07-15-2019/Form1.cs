using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C20_Form_07_15_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReader_Click(object sender, EventArgs e)
        {
            string fullname = txtFullname.Text;
            string email = txtEmail.Text;
            string age = txtAge.Text;
            string phone = txtPhone.Text;
            string isbn = txtIsbn.Text;
            string faculty = txtFacultyId.Text;
            if(fullname!=String.Empty && email!=String.Empty && age!=string.Empty 
                && phone !=string.Empty && isbn !=string.Empty && faculty != string.Empty)
            {
                int newAge;
                int newPhone;

                if (int.TryParse(age,out newAge) && int.TryParse(phone, out newPhone))
                {
                    lblError.Visible = false;
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OSF0P27\ELXANQULIYEV;Initial Catalog=LibraryDBC20;Integrated Security=True");
                    string conCommand = string.Format("Insert into Readers Values('{0}','{1}','{2}','{3}','{4}',2)", fullname, email, phone, age, isbn);

                    SqlCommand com = new SqlCommand(conCommand, con);
                    con.Open();
                    int result = com.ExecuteNonQuery();
                    if (result >= 1)
                    {
                        MessageBox.Show("Readers was successfully");
                    }
                    else
                    {
                        MessageBox.Show("Sql Connection Error");
                    }
                    con.Close();
                }
                else
                {
                    lblError.Text = "Zehmet olmasa telefon ve ya yasi reqem daxil edin.";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Bos biraxmayin.";
                lblError.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
    }
}
