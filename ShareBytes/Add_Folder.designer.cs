namespace ShareBytes
{
    partial class Add_Folder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_folders = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Add_bw = new System.ComponentModel.BackgroundWorker();
            this.load_bw = new System.ComponentModel.BackgroundWorker();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.lbl_result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cross = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(109, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.txtFolderName.Location = new System.Drawing.Point(121, 53);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(144, 21);
            this.txtFolderName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "New Folder Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "New Folder";
            // 
            // dgv_folders
            // 
            this.dgv_folders.AllowUserToAddRows = false;
            this.dgv_folders.AllowUserToDeleteRows = false;
            this.dgv_folders.AllowUserToOrderColumns = true;
            this.dgv_folders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_folders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_folders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgv_folders.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_folders.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_folders.Location = new System.Drawing.Point(12, 131);
            this.dgv_folders.Name = "dgv_folders";
            this.dgv_folders.ReadOnly = true;
            this.dgv_folders.RowHeadersVisible = false;
            this.dgv_folders.Size = new System.Drawing.Size(247, 128);
            this.dgv_folders.TabIndex = 19;
            this.dgv_folders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Product_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.ActiveLinkColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "Delete";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.Delete.HeaderText = "Delete";
            this.Delete.LinkColor = System.Drawing.Color.Black;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.VisitedLinkColor = System.Drawing.Color.Black;
            this.Delete.Width = 50;
            // 
            // Add_bw
            // 
            this.Add_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Add_bw_DoWork);
            this.Add_bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Add_bw_RunWorkerCompleted);
            // 
            // load_bw
            // 
            this.load_bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.load_bw_DoWork);
            this.load_bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.load_bw_RunWorkerCompleted);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 1000;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(78, 89);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 4;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circularProgressBar1.ProgressWidth = 4;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(25, 24);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.White;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.White;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 20;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 60;
            this.circularProgressBar1.Visible = false;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.Color.Black;
            this.lbl_result.Location = new System.Drawing.Point(190, 90);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(55, 18);
            this.lbl_result.TabIndex = 21;
            this.lbl_result.Text = "Done !";
            this.lbl_result.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.cross);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 36);
            this.panel1.TabIndex = 22;
            // 
            // cross
            // 
            this.cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross.ForeColor = System.Drawing.Color.White;
            this.cross.Location = new System.Drawing.Point(247, 7);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(19, 23);
            this.cross.TabIndex = 15;
            this.cross.Text = "X";
            this.cross.UseVisualStyleBackColor = true;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // Add_Folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 278);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.dgv_folders);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Folder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Folder";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_folders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_folders;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.ComponentModel.BackgroundWorker Add_bw;
        private System.ComponentModel.BackgroundWorker load_bw;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cross;
    }
}