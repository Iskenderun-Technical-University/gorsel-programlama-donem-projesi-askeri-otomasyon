
namespace en_yeni_form
{
    partial class repor
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.visionTableAdapter1 = new en_yeni_form.SSForceDataSetTableAdapters.VisionTableAdapter();
            this.ssForceDataSet1 = new en_yeni_form.SSForceDataSet();
            this.CrystalReport11 = new en_yeni_form.CrystalReport1();
            this.ssForceDataSet2 = new en_yeni_form.SSForceDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.ssForceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssForceDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(920, 703);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // visionTableAdapter1
            // 
            this.visionTableAdapter1.ClearBeforeFill = true;
            // 
            // ssForceDataSet1
            // 
            this.ssForceDataSet1.DataSetName = "SSForceDataSet";
            this.ssForceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ssForceDataSet2
            // 
            this.ssForceDataSet2.DataSetName = "SSForceDataSet";
            this.ssForceDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 703);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "repor";
            this.Text = "repor";
            this.Load += new System.EventHandler(this.repor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ssForceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssForceDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SSForceDataSetTableAdapters.VisionTableAdapter visionTableAdapter1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private SSForceDataSet ssForceDataSet1;
        private CrystalReport1 CrystalReport11;
        private SSForceDataSet ssForceDataSet2;
    }
}