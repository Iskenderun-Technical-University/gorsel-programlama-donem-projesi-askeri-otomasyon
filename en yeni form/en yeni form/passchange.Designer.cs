
namespace en_yeni_form
{
    partial class passchange
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.mesajreturn = new System.Windows.Forms.Label();
            this.Capctha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttDegis = new System.Windows.Forms.Button();
            this.guessWhat = new System.Windows.Forms.TextBox();
            this.yenipass2 = new System.Windows.Forms.TextBox();
            this.yenipass = new System.Windows.Forms.TextBox();
            this.eskipass = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 38);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(136, 34);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfaya Dön";
            this.anaSayfaToolStripMenuItem.Click += new System.EventHandler(this.anaSayfaToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil Std", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "sıfre degıstır";
            // 
            // mesajreturn
            // 
            this.mesajreturn.AutoSize = true;
            this.mesajreturn.Location = new System.Drawing.Point(147, 404);
            this.mesajreturn.Name = "mesajreturn";
            this.mesajreturn.Size = new System.Drawing.Size(0, 21);
            this.mesajreturn.TabIndex = 33;
            // 
            // Capctha
            // 
            this.Capctha.AutoSize = true;
            this.Capctha.BackColor = System.Drawing.Color.Transparent;
            this.Capctha.Location = new System.Drawing.Point(47, 353);
            this.Capctha.Name = "Capctha";
            this.Capctha.Size = new System.Drawing.Size(46, 17);
            this.Capctha.TabIndex = 32;
            this.Capctha.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "New Pass Again";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "New Pass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Old Pass";
            // 
            // buttDegis
            // 
            this.buttDegis.Location = new System.Drawing.Point(183, 444);
            this.buttDegis.Name = "buttDegis";
            this.buttDegis.Size = new System.Drawing.Size(100, 56);
            this.buttDegis.TabIndex = 28;
            this.buttDegis.Text = "Şifreyi Değiştir";
            this.buttDegis.UseVisualStyleBackColor = true;
            this.buttDegis.Click += new System.EventHandler(this.buttDegis_Click_1);
            // 
            // guessWhat
            // 
            this.guessWhat.Location = new System.Drawing.Point(183, 349);
            this.guessWhat.Name = "guessWhat";
            this.guessWhat.Size = new System.Drawing.Size(100, 22);
            this.guessWhat.TabIndex = 27;
            // 
            // yenipass2
            // 
            this.yenipass2.Location = new System.Drawing.Point(183, 280);
            this.yenipass2.Name = "yenipass2";
            this.yenipass2.PasswordChar = '*';
            this.yenipass2.Size = new System.Drawing.Size(100, 22);
            this.yenipass2.TabIndex = 26;
            // 
            // yenipass
            // 
            this.yenipass.Location = new System.Drawing.Point(183, 213);
            this.yenipass.Name = "yenipass";
            this.yenipass.PasswordChar = '*';
            this.yenipass.Size = new System.Drawing.Size(100, 22);
            this.yenipass.TabIndex = 25;
            // 
            // eskipass
            // 
            this.eskipass.Location = new System.Drawing.Point(183, 148);
            this.eskipass.Name = "eskipass";
            this.eskipass.PasswordChar = '*';
            this.eskipass.Size = new System.Drawing.Size(100, 22);
            this.eskipass.TabIndex = 24;
            // 
            // passchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::en_yeni_form.Properties.Resources.WhatsApp_Image_2022_05_16_at_00_17_09__1_;
            this.ClientSize = new System.Drawing.Size(323, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mesajreturn);
            this.Controls.Add(this.Capctha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttDegis);
            this.Controls.Add(this.guessWhat);
            this.Controls.Add(this.yenipass2);
            this.Controls.Add(this.yenipass);
            this.Controls.Add(this.eskipass);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "passchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "m";
            this.Load += new System.EventHandler(this.passchange_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mesajreturn;
        private System.Windows.Forms.Label Capctha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttDegis;
        private System.Windows.Forms.TextBox guessWhat;
        private System.Windows.Forms.TextBox yenipass2;
        private System.Windows.Forms.TextBox yenipass;
        private System.Windows.Forms.TextBox eskipass;
    }
}