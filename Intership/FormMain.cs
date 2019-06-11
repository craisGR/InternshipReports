using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intership
{
    public partial class FormMain : Form
    {
        public static string username { get; set; }

        public FormMain()
        {
            InitializeComponent();
            
         
        }

                 
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {    
            FormStudent ObjframeMain = new FormStudent();
            ObjframeMain.Activate();
            ObjframeMain.Show();
        }

        private void MenuButtons_MouseHover(object sender, EventArgs e)
        {
            //show label from menu buttons
            if (sender.GetHashCode() == buttonStudent.GetHashCode())
            {
                labelStudent.Show();
            }
            else if (sender.GetHashCode() == buttonCompany.GetHashCode())
            {
                labelCompany.Show(); 
            }
            else if (sender.GetHashCode() == buttonTeacher.GetHashCode())
            {
                labelTeacher.Show(); 
            }
            else if (sender.GetHashCode() == buttonPrint.GetHashCode())
            {
                labelPrint.Show(); 
            }
            
        }
            

        private void MenuButtons_MouseLeave(object sender, EventArgs e)
        {
            //hide label from menu buttons
            labelStudent.Hide();
            labelTeacher.Hide();
            labelCompany.Hide();
            labelPrint.Hide();
        }
                 

        private void myButton_Logout_Click(object sender, EventArgs e)
        {
            //confirmation message to close application
            if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να τερματίσετε την εφαρμογή;", "Κλείσιμο Προγράμματος", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();//application closed
            } 
        }

        private void myButton_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //application closed
        }

     
       

        private void myButton_addUser_Click(object sender, EventArgs e)
        {
            FormUsers ObjframeMain = new FormUsers();
            ObjframeMain.Activate();
            ObjframeMain.Show();
            
        }


        private void myButton_confbuttons_MouseLeave(object sender, EventArgs e)
        {
            //hide label on mouse over
            label_Conf.Hide();
        }

     
        private void myButton_confbuttons_MouseHover(object sender, EventArgs e)
        {
           //edit label from config buttonns  
           if (sender.GetHashCode() == myButton_ChangePsw.GetHashCode())
            {
                label_Conf.Text = "Αλλαγή Password";
            }
           else if (sender.GetHashCode() == myButton_Singout.GetHashCode())
           {
               label_Conf.Text = "Αποσύνδεση";
           }
           else if (sender.GetHashCode() == myButton_addUser.GetHashCode())
           {
               label_Conf.Text = "Διαχείριση Χρηστών";
           }
           else if (sender.GetHashCode() == myButton_about.GetHashCode())
           {
               label_Conf.Text = "Σχετικά με το Πρόγραμμα";
           }
           label_Conf.Show();//Show label from config buttonns 
        }
             
        private void myCheckBox_ShowConfig_CheckedChanged(object sender, EventArgs e)
        {
            //show/hide config buttons
            if (myCheckBox_ShowConfig.Checked == true)
            {
                myButton_ChangePsw.Show();
                myButton_Singout.Show();
                myButton_about.Show();
                myButton_addUser.Show();
              
            }
            else
            {
                myButton_ChangePsw.Hide();
                myButton_Singout.Hide();
                myButton_about.Hide();
                myButton_addUser.Hide();
            }
        }

        private void myButton_about_Click(object sender, EventArgs e)
        {
            AboutBox ObjframeMain = new AboutBox();
            ObjframeMain.Activate();
            ObjframeMain.Show();
        }
   
        private void myButton_Singout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να αποσυνδεθείτε;","Αποσύνδεση",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Restart();                
            }
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            FormTeacher ObjframeMain = new FormTeacher();
            ObjframeMain.Activate();
            ObjframeMain.view = true;
            ObjframeMain.Show();
            
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            FormCompany ObjframeMain = new FormCompany();
            ObjframeMain.view = true;
            ObjframeMain.Activate();
            ObjframeMain.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelUsername.Text = username.ToUpper();
        }

        private void myButton_ChangePsw_Click(object sender, EventArgs e)
        {
            FormChangePassword ObjframeMain = new FormChangePassword();
            ObjframeMain.Activate();
            ObjframeMain.Show();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            FormReports ObjframeMain = new FormReports();
            ObjframeMain.Activate();
            ObjframeMain.Show();
        }

    }
}
