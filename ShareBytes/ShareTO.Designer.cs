namespace ShareBytes
{
    partial class ShareTO
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
            this.lbl = new System.Windows.Forms.Label();
            this.frnd_id = new System.Windows.Forms.TextBox();
            this.Share = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.result_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cross = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl.Location = new System.Drawing.Point(31, 43);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 18);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Friend Id :";
            // 
            // frnd_id
            // 
            this.frnd_id.Location = new System.Drawing.Point(124, 44);
            this.frnd_id.Name = "frnd_id";
            this.frnd_id.Size = new System.Drawing.Size(100, 20);
            this.frnd_id.TabIndex = 3;
            // 
            // Share
            // 
            this.Share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Share.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Share.Location = new System.Drawing.Point(95, 92);
            this.Share.Name = "Share";
            this.Share.Size = new System.Drawing.Size(75, 31);
            this.Share.TabIndex = 4;
            this.Share.Text = "Share";
            this.Share.UseVisualStyleBackColor = true;
            this.Share.Click += new System.EventHandler(this.Share_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
            this.circularProgressBar1.Location = new System.Drawing.Point(176, 92);
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
            this.circularProgressBar1.TabIndex = 14;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 60;
            this.circularProgressBar1.Visible = false;
            // 
            // result_lbl
            // 
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Arial", 12F);
            this.result_lbl.ForeColor = System.Drawing.Color.Black;
            this.result_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.result_lbl.Location = new System.Drawing.Point(173, 98);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(12, 18);
            this.result_lbl.TabIndex = 15;
            this.result_lbl.Text = ".";
            this.result_lbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.cross);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 25);
            this.panel1.TabIndex = 16;
            // 
            // cross
            // 
            this.cross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cross.ForeColor = System.Drawing.Color.White;
            this.cross.Location = new System.Drawing.Point(244, 3);
            this.cross.Name = "cross";
            this.cross.Size = new System.Drawing.Size(19, 23);
            this.cross.TabIndex = 14;
            this.cross.Text = "X";
            this.cross.UseVisualStyleBackColor = true;
            this.cross.Click += new System.EventHandler(this.cross_Click);
            // 
            // ShareTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(268, 127);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.Share);
            this.Controls.Add(this.frnd_id);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShareTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShareTO";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox frnd_id;
        private System.Windows.Forms.Button Share;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cross;
    }
}