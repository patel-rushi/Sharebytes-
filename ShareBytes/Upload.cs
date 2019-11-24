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
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
            //AutoFitForm.SetGroupBoxLoction(groupBox1);
        }

        private void InitializeOpenFileDialog()
        {
            this.openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = "C://Desktop";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select files to upload";
            this.openFileDialog1.FileName = "";
            //openFileDialog1.FilterIndex = 1;
        }
        DialogResult dr;
        private void Browse_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
            dr = this.openFileDialog1.ShowDialog();
            DataTable dt = new DataTable();
            //float size = 0;
            dt.Columns.Add("File Name");
            try
            {
                if (dr == DialogResult.OK)
                {
                    foreach (String file in openFileDialog1.FileNames)
                    {
                        try
                        {
                            DataRow ddr = dt.NewRow();
                            ddr["File Name"] =Path.GetFileName(file);
                            dt.Rows.Add(ddr);
                            //size = new FileInfo(openFileDialog1.FileName).Length;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error In your File, it may be corrupted");
                        }
                    }

                    DGV.DataSource = dt;
                    DGV.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
                    DGV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else
                {
                    MessageBox.Show("Please select document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        string globalcmbSub;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Visible = true;
            if (dr == DialogResult.OK)
            {
                if (backgroundWorker1.IsBusy != true)
                {
                    globalcmbSub = cmbsub.Text;
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("Browse files to upload");
                circularProgressBar1.Visible = false;
            }

               

        }


        
        private void Upload_Load(object sender, EventArgs e)
        {
            //AutoFitForm.SetFormToMaximize(this);
            this.ControlBox = false;
            //this.FormBorderStyle = FormBorderStyle.None;
           
            //this.WindowState = FormWindowState.Normal;
            BindcmbFolder();
        }
        

        private void addsub_Click(object sender, EventArgs e)
        {
            Add_Folder obj = new Add_Folder();
            obj.Show();
            obj.Focus();
            
        }
        void BindcmbFolder()
        {
            clsDatastore obj = new clsDatastore();
            try
            {
                string Folders = obj.GetUserFolders();
                string[] arrFname = null;
                DataTable dt = new DataTable();
                dt.Columns.Add("Folders");
                arrFname = Folders.Split(',');

                for (int i = 0; i < arrFname.Length; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Folders"] = arrFname[i];
                    dt.Rows.Add(dr);
                }
                cmbsub.DisplayMember = "Folders";
                cmbsub.ValueMember = "Folders";
                cmbsub.DataSource = dt;
            }
            catch (Exception ex) {
            }
        }
        

        private void cmbsub_DropDown(object sender, EventArgs e)
        {
            circularProgressBar2.Visible = true;
            if (bindfolder_bw.IsBusy != true)
            {
                bindfolder_bw.RunWorkerAsync();
            }
            //BindcmbFolder();
        }
        int value = -1;
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = 0;
            int length= openFileDialog1.FileNames.Length;
            foreach (String file in openFileDialog1.FileNames)
                {
                count++;
                    try
                    {
                    
                        backgroundWorker1.ReportProgress(count,length);
                        clsGooglStorage stobj = new clsGooglStorage();
                        value = stobj.UploadFile(clsValues.UserID, file, globalcmbSub);
                    
                    }
                    catch (Exception ex)
                    {
                        value = 0;
                        //MessageBox.Show("Error : Check your internet connection");
                    }
                }
                if (value == 1)
                {
                    //MessageBox.Show("Document uploaded");
                }
                else
                {
                    value = 0;
                    //MessageBox.Show("Error !"); 
                }
            
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            upload_lbl.Text ="Uploading ("+e.ProgressPercentage.ToString()+" of "+e.UserState+")";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (value == 0||value==-1)
            {
                upload_lbl.Text = "Error !";
            }
            else if (value == 1)
            {
                upload_lbl.Text = "Done !";
                DGV.DataSource = null;
            }
            circularProgressBar1.Visible = false;
        }
        DataTable globalbinddt = new DataTable();
        private void bindfolder_bw_DoWork(object sender, DoWorkEventArgs e)
        {
            clsDatastore obj = new clsDatastore();
            try
            {
                string Folders = obj.GetUserFolders();
                string[] arrFname = null;
                DataTable dt = new DataTable();
                dt.Columns.Add("Folders");
                arrFname = Folders.Split(',');

                for (int i = 0; i < arrFname.Length; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["Folders"] = arrFname[i];
                    dt.Rows.Add(dr);
                }
                globalbinddt = dt;
            }
            catch (Exception ex)
            {
            }
        }

        private void bindfolder_bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            circularProgressBar2.Visible = false;
            cmbsub.DisplayMember = "Folders";
            cmbsub.ValueMember = "Folders";
            cmbsub.DataSource = globalbinddt;
        }
    }
}

        

