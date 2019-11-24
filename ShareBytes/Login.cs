using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Datastore.V1;


namespace ShareBytes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp obj = new SignUp();
            obj.Show();
            obj.Focus();
            
        }
        void stoploading()
        {
            circularProgressBar1.Visible = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void UserId_MouseClick(object sender, MouseEventArgs e)
        {
            UserId.Text = null;
        }

        

        private void UserId_Leave(object sender, EventArgs e)
        {
            
            if (UserId.Text == "")
            {
                UserId.Text = "User Id";
            }
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = null;
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
            }
        }
        int loginresult = 0;
        int errorcode = 0;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            CheckInternetConnection conn = new CheckInternetConnection();
            if (conn.IsConnectedToInternet() == true)
            {
                clsDatastore obj = new clsDatastore();
                DatastoreQueryResults result = obj.Login(UserId.Text, Password.Text);
                loginresult = result.Entities.Count;
                
            }
            else
            {
                errorcode = 1;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (errorcode == 0)
            {
                if (loginresult > 0)
                {
                    clsValues.UserID = UserId.Text;
                    MyMDI mdiobj = new MyMDI();
                    mdiobj.Show();
                    mdiobj.Focus();
                    stoploading();
                }
                else
                {
                    stoploading();
                    MessageBox.Show("Invalid Username/Password");
                }
            }
            else
            {
                stoploading();
                MessageBox.Show("Check your internet connection and Try Again !");
            }
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
