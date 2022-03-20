namespace MenuFrm.Formlar
{
    partial class Takım1KartSecme
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
        static public string Takım = "Takım1 Kart Seçme Sırası";
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Takım1KartSecme));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSecmeSaniye = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBack = new System.Windows.Forms.Label();
            this.lblPasue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            //
              
            
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(55, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = Takım;
            // 
            // lblSecmeSaniye
            // 
            this.lblSecmeSaniye.AutoSize = true;
            this.lblSecmeSaniye.BackColor = System.Drawing.Color.Transparent;
            this.lblSecmeSaniye.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecmeSaniye.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSecmeSaniye.Location = new System.Drawing.Point(317, 203);
            this.lblSecmeSaniye.Name = "lblSecmeSaniye";
            this.lblSecmeSaniye.Size = new System.Drawing.Size(0, 46);
            this.lblSecmeSaniye.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblBack.Location = new System.Drawing.Point(12, 9);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(67, 54);
            this.lblBack.TabIndex = 2;
            this.lblBack.Text = "<-";
            this.lblBack.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPasue
            // 
            this.lblPasue.AutoSize = true;
            this.lblPasue.BackColor = System.Drawing.Color.Transparent;
            this.lblPasue.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPasue.Location = new System.Drawing.Point(578, 16);
            this.lblPasue.Name = "lblPasue";
            this.lblPasue.Size = new System.Drawing.Size(42, 46);
            this.lblPasue.TabIndex = 3;
            this.lblPasue.Text = "II";
            this.lblPasue.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(540, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "PLAY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Takım1KartSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPasue);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblSecmeSaniye);
            this.Controls.Add(this.label1);
            this.Name = "Takım1KartSecme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım1KartSeçme";
            this.Load += new System.EventHandler(this.Takım1KartSecme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label label1;
        public Label lblSecmeSaniye;
        public System.Windows.Forms.Timer timer1;
        public Label lblBack;
        public Label lblPasue;
        public Label label3;
    }
}