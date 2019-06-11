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
    public partial class Frm_login : Form
    {
       

        public Frm_login()
        {
            InitializeComponent();
            myCheckBox_pswRev.Hide();
        }
                             
        private void myCheckBox_pswRev_CheckedChanged(object sender, EventArgs e)
        {
            //show or hide password characters
            if (myCheckBox_pswRev.Checked == true)
                textBox_password.UseSystemPasswordChar = false;
            else
                textBox_password.UseSystemPasswordChar = true;
        }

        private void myButton_Logout_Click(object sender, EventArgs e)
        {
            //terminate the application
            Application.Exit();
        }
        
        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

            //Show reveal password only if you type in password field
            if (textBox_password.TextLength > 0)
            {
                myCheckBox_pswRev.Show();
            }
            else
            {
                myCheckBox_pswRev.Hide();
            }
        }

        private void myButton_login_Click(object sender, EventArgs e)
        {
            //conect with db
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();

            //check db if only 1 user exist ingore blank spaces in username field
            string query = "SELECT * from Users where username='" + txtBox_usrname.Text.Trim() + "'and password='" + textBox_password.Text + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                //Go to Main Form
                
                FormMain ObjframeMain = new FormMain();
                this.Hide();
                FormMain.username = txtBox_usrname.Text.Trim();
                ObjframeMain.Activate();
                ObjframeMain.Show();
            } 
            else
            {
                MessageBox.Show("Λάθος username ή password!!!", "Προσοχή!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

    }    
}
