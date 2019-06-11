using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Intership
{
    public partial class FormChangePassword : Form
    {
       
        public FormChangePassword()
        {
            InitializeComponent();
        }

        private void myButtonOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();


            if (textBoxNewPwd.Text != textBoxRepeatNewPwd.Text)
            {
                MessageBox.Show("Το νέο συνθυματικό στα 2 πεδία δεν συμφωνεί", "Λάθος Καταχώρηση", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (textBoxNewPwd.Text == "")
            {
                MessageBox.Show("Δεν έχει οριστεί νέο συνθυματικό", "Λάθος Καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                //check db if only 1 user exist ingore blank spaces in username field
                string query = "SELECT * from Users where username='" + FormMain.username + "'and password='" + textBoxCurrentPwd.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows.Count == 1)
                {
                    SqlCommand commandupdate = con.CreateCommand();
                    commandupdate.CommandType = CommandType.Text;
                    commandupdate.CommandText = "UPDATE Users SET password = '" + textBoxRepeatNewPwd.Text + "' WHERE username = '" + FormMain.username + "'";
                    commandupdate.ExecuteNonQuery();
                    MessageBox.Show("Το συνθυματικό για τον χρήστη '" + FormMain.username.ToUpper() + "' ΄έχει αλλάξει!", "Επιτυχής Καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Το τρέχον συνθυματικό δεν είναι σωστό", "Λάθος Καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Change_Password_Load(object sender, EventArgs e)
        {
            this.Text = this.Text.ToString() + " '" + FormMain.username.ToUpper() + "'";
        }

        private void myButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNewPwd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPwd.Text.Length > 0)
            {
                textBoxRepeatNewPwd.Enabled = true;
            }
            else
            {
                textBoxRepeatNewPwd.Enabled = false;
                textBoxRepeatNewPwd.Text = "";
            }
        }

        private void textBoxCurrentPwd_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCurrentPwd.Text.Length > 0)
            {
                textBoxNewPwd.Enabled = true;
            }
            else
            {
                textBoxNewPwd.Enabled = false;
            }
        }

       
    }
}
