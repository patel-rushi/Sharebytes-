using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShareBytes
{
    public partial class Shared : Form
    {
        public Shared()
        {
            InitializeComponent();
        }

        private void Shared_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            lbl_loading.Visible = true;
            circularProgressBar1.Visible = true;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
        DataTable globaldt = new DataTable();
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            clsGooglStorage obj = new clsGooglStorage();
            DataTable dt = obj.ListObjects("shared" + "/");
            globaldt = dt;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DGV.DataSource = globaldt;
            DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            DGV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            lbl_loading.Visible = false;
            circularProgressBar1.Visible = false;

        }
        int Downloadresult = -1;
        private void Downloadbg_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = "C:\\Users\\" + Environment.UserName + "\\Downloads\\Sharebytes\\" + clsValues.UserID;

            try
            {
                clsGooglStorage obj = new clsGooglStorage();
                if (Directory.Exists(path))
                {
                    obj.DownloadObject(clsValues.UserID, FolderName, FileName);
                    //MessageBox.Show("Done ! Check \"Downloads\\Sharebytes\\" + clsValues.UserID + "\" Folder");
                    Downloadresult = 1;
                }
                else
                {
                    Directory.CreateDirectory(path);
                    obj.DownloadObject(clsValues.UserID, FolderName, FileName);
                    Downloadresult = 1;
                    //MessageBox.Show("Done ! Check \"Downloads\\Sharebytes\\" + clsValues.UserID + "\" Folder");
                }

            }
            catch (Exception ex)
            {
                Downloadresult = 0;
            }
        }
        string FolderName;
        string FileName;
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                circularProgressBar2.Visible = true;
                Download_lbl.Visible = true;
                Download_lbl.Text = "Downloading...";
                FolderName = "shared" + "/" + DGV["File Name", e.RowIndex].Value.ToString();
                FileName = DGV["File Name", e.RowIndex].Value.ToString();
                if (Downloadbg.IsBusy != true)
                {
                    Downloadbg.RunWorkerAsync();
                }

            }
        }

        private void Downloadbg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Downloadresult == 1)
            {
                circularProgressBar2.Visible = false;
                Download_lbl.Visible = true;
                Download_lbl.Text = "Download Complete !";
            }
            else
            {
                circularProgressBar2.Visible = false;
                Download_lbl.Visible = true;
                Download_lbl.Text = "Download Failed !";
            }
        }
    }
}
