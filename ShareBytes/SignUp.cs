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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            if (bwSignUp.IsBusy != true)
            {
                bwSignUp.RunWorkerAsync();
            }
        }
        int errorcode=-1;

        private void bwSignUp_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                clsDatastore obj = new clsDatastore();
                clsGooglStorage gobj = new clsGooglStorage();
                int dsvalue = 0, bvalue = 0;
                bvalue = gobj.CreateBucket(CollegeId.Text);
                dsvalue = obj.SignUp(CollegeId.Text, UserName.Text, EmailId.Text, Password.Text);
                if (dsvalue == 1&&bvalue==1)
                {
                    errorcode = 0;
                }
                else
                {
                    errorcode = 1;
                    //MessageBox.Show("Error : Check your Internet Connection ! or Email this issue to \"official.rusapp@gmail.com\"");
                }

            }
            catch (Google.GoogleApiException ex) 
                when(ex.Error.Code==409)
            {
                errorcode = 2;
                //MessageBox.Show("User Already Exist, Try to Login");
            }
            catch(Exception Ex)
            {
                errorcode = 3;
                //MessageBox.Show("Error : Check your Internet Connection");
            }

        }

        
        private void bwSignUp_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(errorcode==0)
            {
                circularProgressBar1.Visible = false;
                MessageBox.Show("User Created !");
                this.Close();
                
            }
            else if(errorcode == 1 || errorcode == 3)
            {
                circularProgressBar1.Visible = false;
                MessageBox.Show("Error : Check your Internet Connection");
            }
            else if(errorcode==2)
            {
                circularProgressBar1.Visible = false;
                MessageBox.Show("User Already Exist, Try to Login");
            }
            circularProgressBar1.Visible = false;

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
