
namespace en_yeni_form
{
    partial class passpanel
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
            this.SuspendLayout();
            // 
            // passpanel
            // 
            this.ClientSize = new System.Drawing.Size(1201, 987);
            this.Name = "passpanel";
            this.Load += new System.EventHandler(this.passpanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.Label label4;
    }
}