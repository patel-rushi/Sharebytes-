using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShareBytes
{
    public partial class ShareTO : Form
    {
        string FolderName;
        string FileName;

        public ShareTO(string Foldername, string Filename)
        {
            FolderName = Foldername;
            FileName = Filename;
            InitializeComponent();
        }
        string id;
        private void Share_Click(object sender, EventArgs e)
        {
            if (frnd_id.Text != "")
            {
                circularProgressBar1.Visible = true;
                result_lbl.Visible = false;
                id = frnd_id.Text;
                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Enter a ID");
                
            }
        }
        int errorcode=-1;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                clsGooglStorage obj = new clsGooglStorage();
                //FileAccess FA = new FileAccess();
                obj.CopyObject(clsValues.UserID, FolderName, id, "shared/"+FileName);
                errorcode = 0;
            }
            catch(Exception ex) {
                errorcode = 1;
            }
           }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(errorcode==0)
            {
                result_lbl.Text = "Done !";
                frnd_id.Text = null;
                result_lbl.Visible = true;
                circularProgressBar1.Visible = false;
                
            }
            else
            {
                result_lbl.Text = "Error !";
                result_lbl.Visible = true;
                circularProgressBar1.Visible = false;
            }
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
