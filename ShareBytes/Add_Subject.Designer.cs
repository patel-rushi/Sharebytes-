namespace ShareBytes
{
    partial class Add_Subject
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsub = new System.Windows.Forms.Button();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Subject/Title ";
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(137, 137);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(75, 23);
            this.btnsub.TabIndex = 2;
            this.btnsub.Text = "Add";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(176, 81);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(100, 20);
            this.txtsub.TabIndex = 3;
            // 
            // Add_Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 193);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.label1);
            this.Name = "Add_Subject";
            this.Text = "Add_Sem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.TextBox txtsub;
    }
}