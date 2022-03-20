namespace MenuFrm
{
    partial class Baslat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baslat));
            this.btnOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOyna
            // 
            this.btnOyna.BackColor = System.Drawing.Color.Indigo;
            this.btnOyna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOyna.Font = new System.Drawing.Font("Swis721 BdOul BT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnOyna.ForeColor = System.Drawing.Color.DarkSalmon;
            this.btnOyna.Location = new System.Drawing.Point(239, 419);
            this.btnOyna.Name = "btnOyna";
            this.btnOyna.Size = new System.Drawing.Size(115, 46);
            this.btnOyna.TabIndex = 0;
            this.btnOyna.Text = "OYNA";
            this.btnOyna.UseVisualStyleBackColor = false;
            this.btnOyna.Click += new System.EventHandler(this.btnOyna_Click);
            // 
            // Baslat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 477);
            this.Controls.Add(this.btnOyna);
            this.Name = "Baslat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taboo";
            
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOyna;
    }
}