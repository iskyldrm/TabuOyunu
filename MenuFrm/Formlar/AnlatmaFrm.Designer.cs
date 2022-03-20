namespace MenuFrm
{
    partial class AnlatmaFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnlatmaFrm));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.lblT1name = new System.Windows.Forms.Label();
            this.lblT2name = new System.Windows.Forms.Label();
            this.lblT1skor = new System.Windows.Forms.Label();
            this.lblT2skor = new System.Windows.Forms.Label();
            this.btnGeriSayım = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAna = new System.Windows.Forms.Button();
            this.btnYasak1 = new System.Windows.Forms.Button();
            this.btnYasak2 = new System.Windows.Forms.Button();
            this.btnYasak3 = new System.Windows.Forms.Button();
            this.btnPas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(84, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 52);
            this.textBox2.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(270, 441);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(85, 22);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "İSAK YILDIRIM";
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCorrect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorrect.BackgroundImage")));
            this.btnCorrect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrect.Location = new System.Drawing.Point(192, 70);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(119, 52);
            this.btnCorrect.TabIndex = 7;
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDecline.BackgroundImage")));
            this.btnDecline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecline.Location = new System.Drawing.Point(84, 70);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(111, 52);
            this.btnDecline.TabIndex = 8;
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // lblT1name
            // 
            this.lblT1name.AutoSize = true;
            this.lblT1name.BackColor = System.Drawing.Color.Transparent;
            this.lblT1name.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT1name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblT1name.Location = new System.Drawing.Point(18, 9);
            this.lblT1name.Name = "lblT1name";
            this.lblT1name.Size = new System.Drawing.Size(60, 46);
            this.lblT1name.TabIndex = 10;
            this.lblT1name.Text = "T1";
            // 
            // lblT2name
            // 
            this.lblT2name.AutoSize = true;
            this.lblT2name.BackColor = System.Drawing.Color.Transparent;
            this.lblT2name.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT2name.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblT2name.Location = new System.Drawing.Point(317, 9);
            this.lblT2name.Name = "lblT2name";
            this.lblT2name.Size = new System.Drawing.Size(60, 46);
            this.lblT2name.TabIndex = 11;
            this.lblT2name.Text = "T2";
            // 
            // lblT1skor
            // 
            this.lblT1skor.AutoSize = true;
            this.lblT1skor.BackColor = System.Drawing.Color.Transparent;
            this.lblT1skor.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT1skor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblT1skor.Location = new System.Drawing.Point(27, 55);
            this.lblT1skor.Name = "lblT1skor";
            this.lblT1skor.Size = new System.Drawing.Size(40, 46);
            this.lblT1skor.TabIndex = 12;
            this.lblT1skor.Text = "0";
            // 
            // lblT2skor
            // 
            this.lblT2skor.AutoSize = true;
            this.lblT2skor.BackColor = System.Drawing.Color.Transparent;
            this.lblT2skor.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblT2skor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblT2skor.Location = new System.Drawing.Point(317, 55);
            this.lblT2skor.Name = "lblT2skor";
            this.lblT2skor.Size = new System.Drawing.Size(40, 46);
            this.lblT2skor.TabIndex = 13;
            this.lblT2skor.Text = "0";
            // 
            // btnGeriSayım
            // 
            this.btnGeriSayım.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeriSayım.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeriSayım.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeriSayım.Location = new System.Drawing.Point(27, 377);
            this.btnGeriSayım.Name = "btnGeriSayım";
            this.btnGeriSayım.Size = new System.Drawing.Size(328, 86);
            this.btnGeriSayım.TabIndex = 14;
            this.btnGeriSayım.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAna.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAna.Location = new System.Drawing.Point(84, 18);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(227, 46);
            this.btnAna.TabIndex = 15;
            this.btnAna.UseVisualStyleBackColor = false;
            // 
            // btnYasak1
            // 
            this.btnYasak1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYasak1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYasak1.Location = new System.Drawing.Point(27, 151);
            this.btnYasak1.Name = "btnYasak1";
            this.btnYasak1.Size = new System.Drawing.Size(328, 52);
            this.btnYasak1.TabIndex = 16;
            this.btnYasak1.UseVisualStyleBackColor = false;
            // 
            // btnYasak2
            // 
            this.btnYasak2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYasak2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYasak2.Location = new System.Drawing.Point(25, 227);
            this.btnYasak2.Name = "btnYasak2";
            this.btnYasak2.Size = new System.Drawing.Size(330, 51);
            this.btnYasak2.TabIndex = 17;
            this.btnYasak2.UseVisualStyleBackColor = false;
            // 
            // btnYasak3
            // 
            this.btnYasak3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnYasak3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYasak3.Location = new System.Drawing.Point(27, 301);
            this.btnYasak3.Name = "btnYasak3";
            this.btnYasak3.Size = new System.Drawing.Size(328, 51);
            this.btnYasak3.TabIndex = 18;
            this.btnYasak3.UseVisualStyleBackColor = false;
            // 
            // btnPas
            // 
            this.btnPas.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPas.Location = new System.Drawing.Point(122, 459);
            this.btnPas.Name = "btnPas";
            this.btnPas.Size = new System.Drawing.Size(124, 33);
            this.btnPas.TabIndex = 19;
            this.btnPas.Text = "PAS";
            this.btnPas.UseVisualStyleBackColor = false;
            this.btnPas.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnlatmaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 492);
            this.Controls.Add(this.btnPas);
            this.Controls.Add(this.btnYasak3);
            this.Controls.Add(this.btnYasak2);
            this.Controls.Add(this.btnYasak1);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnGeriSayım);
            this.Controls.Add(this.lblT2skor);
            this.Controls.Add(this.lblT1skor);
            this.Controls.Add(this.lblT2name);
            this.Controls.Add(this.lblT1name);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox2);
            this.Name = "AnlatmaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnlatmaFrm";
            this.Load += new System.EventHandler(this.AnlatmaFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox7;
        private Button btnCorrect;
        private Button btnDecline;
        private Label lblT1name;
        private Label lblT2name;
        private Label lblT1skor;
        private Label lblT2skor;
        private Button btnGeriSayım;
        private System.Windows.Forms.Timer timer1;
        private Button btnAna;
        private Button btnYasak1;
        private Button btnYasak2;
        private Button btnYasak3;
        private Button btnPas;
    }
}