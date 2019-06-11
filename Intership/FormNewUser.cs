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
    public partial class FormUsers : Form
    {

        SqlConnection con;
        string selectedUsername; 

        public FormUsers()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP\SQLEXPRESS;Initial Catalog=intership;Integrated Security=True";
            con.Open();
        }

        private void myButtonOK_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Users where username='" + textBoxUsername.Text.Trim() + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(query, con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (textBoxPassword.Text != textBoxVerifyPassword.Text)
            {
                MessageBox.Show("Το συνθυματικό στα 2 πεδία δεν συμφωνεί!", "Λάθος Καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Δεν έχει οριστεί νέο συνθυματικό!", "Λάθος Καταχώρηση", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
            else if (dt1.Rows.Count == 1)
            {
                MessageBox.Show("Ο χρήστης " + textBoxUsername.Text.ToString() + " υπάρχει. Χρησιμοποιήστε άλλο Όνομα Χρήστη!", "Δημιουργία Χρήστη", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand commandcreate = con.CreateCommand();
                commandcreate.CommandType = CommandType.Text;
                commandcreate.CommandText = "INSERT into Users (username, password) values ('" + textBoxUsername.Text.ToString() + "', '" + textBoxPassword.Text.ToString() + "')";
                commandcreate.ExecuteNonQuery();
                MessageBox.Show("Ο χρήστης " + textBoxUsername.Text.ToString() + " δημιουργήθηκε!", "Δημιουργία Χρήστη", MessageBoxButtons.OK, MessageBoxIcon.Information); //confirmation message
                tabControl1.SelectedIndex = 0;
                this.usersTableAdapter.Fill(this.intershipDataSet.Users);
                selectedUsername = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
            }
          
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length > 0)
            {
                textBoxVerifyPassword.Enabled = true;
            }
            else
            {
                textBoxVerifyPassword.Enabled = false;
                textBoxVerifyPassword.Text = "";
            }
        }

        private void myButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intershipDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.intershipDataSet.Users);
            selectedUsername = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
        }

       
        private void myButtonDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUsername == "admin")
            { 
                MessageBox.Show("Δεν μπορείτε να διαγράψετε τον χρήστη: '" + selectedUsername.ToUpper() + "' ", "Διαγραφή Χρήστη!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedUsername == FormMain.username)
            {
                MessageBox.Show("Δεν μπορείτε να διαγράψετε τον χρήστη: '" + selectedUsername.ToUpper() + "' γιατί είστε συνδεμένος με το συγκερκιμένο χρήστη.", "Διαγραφή Χρήστη!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult dialogResult = MessageBox.Show("Είστε σίγουρος οτι θέλετε να διαγράψετε τον χρήστη: '" + selectedUsername.ToUpper() + "' ;", "Διαγραφή Χρήστη!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Users WHERE username='" + selectedUsername + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ο χρήστης '" + selectedUsername.ToUpper() + "' διαγράφηκε", "Διαγραφή Χρήστη!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.usersTableAdapter.Fill(this.intershipDataSet.Users);
                    selectedUsername = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
                }    
            }
                   
        }

        private void myButtonNewUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;    
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUsername = listBoxUsers.GetItemText(listBoxUsers.SelectedItem);
        }
    } 
}
