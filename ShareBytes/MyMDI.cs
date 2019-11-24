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
    public partial class MyMDI : Form
    {
        
        public MyMDI()
        {
            InitializeComponent();
        }

        void Close_All_Forms()
        {
            if (Application.OpenForms.OfType<Upload>().Count() == 1)
                Application.OpenForms.OfType<Upload>().First().Close();

            if (Application.OpenForms.OfType<FileAccess>().Count() == 1)
                Application.OpenForms.OfType<FileAccess>().First().Close();

            if (Application.OpenForms.OfType<Shared>().Count() == 1)
                Application.OpenForms.OfType<Shared>().First().Close();

            if (Application.OpenForms.OfType<About_Us>().Count() == 1)
                Application.OpenForms.OfType<About_Us>().First().Close();


        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            About_panel.Visible = false;
            Home_panel.Visible = true;
            FA_panel.Visible = false;
            Upload_panel.Visible = false;
            title.Visible = false;
            shared_panel.Visible = false;
            PB_2.Visible = true;
            PB_1.Visible = true;
            PB_2.BringToFront();
            Version_lbl.Visible = true;
            Version_lbl.BringToFront();
            

        }
         
        private void MyMDI_Load(object sender, EventArgs e)
        {
            Home_btn_Click(sender,e);
        }

        private void Upload_btn_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            PB_1.Visible = false;
            PB_2.Visible = false;
            Version_lbl.Visible = false;
            About_panel.Visible = false;
            Home_panel.Visible = false;
            FA_panel.Visible = false;
            shared_panel.Visible = false;
            Upload_panel.Visible = true;
            title.Text = "Upload";
            title.Visible = true;
            //title.BringToFront();
            Upload obj = new Upload();
            obj.MdiParent = this;
            obj.Show();
        }

        private void FileAccess_btn_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            PB_1.Visible = false;
            PB_2.Visible = false;
            Version_lbl.Visible = false;

            About_panel.Visible = false;
            Home_panel.Visible = false;
            Upload_panel.Visible = false;
            shared_panel.Visible = false;
            FA_panel.Visible = true;
            title.Text = "File Access";
            title.Visible = true;
            //title.BringToFront();
            FileAccess obj = new FileAccess();
            obj.MdiParent = this;
            obj.Show();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            if (Application.OpenForms.OfType<Login>().Count() == 1)
                Application.OpenForms.OfType<Login>().First().Close();
            
            //clsValues.UserID = null;
            //Login obj = new Login();
            //obj.Show();
            //obj.Focus();
            this.Close();

        }

        private void Shared_btn_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            PB_1.Visible = false;
            PB_2.Visible = false;

            Version_lbl.Visible = false;
            About_panel.Visible = false;
            Home_panel.Visible = false;
            Upload_panel.Visible = false;
            FA_panel.Visible = false;
            shared_panel.Visible = true;
            title.Text = "Shared";
            title.Visible = true;

            Shared obj = new Shared();
            obj.MdiParent = this;
            obj.Show();
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            Close_All_Forms();
            PB_1.Visible = false;
            PB_2.Visible = false;

            About_panel.Visible = true;
            Version_lbl.Visible = false;
            Home_panel.Visible = false;
            Upload_panel.Visible = false;
            FA_panel.Visible = false;
            shared_panel.Visible = false;
            title.Text = "About Us";
            title.Visible = true;

            About_Us obj = new About_Us();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
