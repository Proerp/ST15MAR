namespace PresentationLayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tsChild = new System.Windows.Forms.ToolStrip();
            this.tsChildaaa = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewDownloadLogEvent01 = new System.Windows.Forms.DataGridView();
            this.S1DownLoadDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S1DownLoadRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S1Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloadLogEvent01)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tsChild
            // 
            this.tsChild.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsChildaaa});
            this.tsChild.Location = new System.Drawing.Point(0, 0);
            this.tsChild.Name = "tsChild";
            this.tsChild.Size = new System.Drawing.Size(581, 25);
            this.tsChild.TabIndex = 1;
            this.tsChild.Text = "toolStrip1";
            // 
            // tsChildaaa
            // 
            this.tsChildaaa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsChildaaa.Image = ((System.Drawing.Image)(resources.GetObject("tsChildaaa.Image")));
            this.tsChildaaa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChildaaa.Name = "tsChildaaa";
            this.tsChildaaa.Size = new System.Drawing.Size(23, 22);
            this.tsChildaaa.Text = "toolStripButton1";
            // 
            // dataGridViewDownloadLogEvent01
            // 
            this.dataGridViewDownloadLogEvent01.AllowUserToAddRows = false;
            this.dataGridViewDownloadLogEvent01.AllowUserToDeleteRows = false;
            this.dataGridViewDownloadLogEvent01.AllowUserToResizeRows = false;
            this.dataGridViewDownloadLogEvent01.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDownloadLogEvent01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDownloadLogEvent01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S1DownLoadDate,
            this.S1DownLoadRows,
            this.S1Description});
            this.dataGridViewDownloadLogEvent01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDownloadLogEvent01.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewDownloadLogEvent01.Name = "dataGridViewDownloadLogEvent01";
            this.dataGridViewDownloadLogEvent01.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewDownloadLogEvent01.RowHeadersVisible = false;
            this.dataGridViewDownloadLogEvent01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDownloadLogEvent01.Size = new System.Drawing.Size(581, 657);
            this.dataGridViewDownloadLogEvent01.TabIndex = 2;
            // 
            // S1DownLoadDate
            // 
            this.S1DownLoadDate.DataPropertyName = "DownLoadDate";
            this.S1DownLoadDate.FillWeight = 159F;
            this.S1DownLoadDate.HeaderText = "Server 1";
            this.S1DownLoadDate.Name = "S1DownLoadDate";
            // 
            // S1DownLoadRows
            // 
            this.S1DownLoadRows.DataPropertyName = "DownLoadRows";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.S1DownLoadRows.DefaultCellStyle = dataGridViewCellStyle1;
            this.S1DownLoadRows.FillWeight = 70F;
            this.S1DownLoadRows.HeaderText = " No.";
            this.S1DownLoadRows.Name = "S1DownLoadRows";
            // 
            // S1Description
            // 
            this.S1Description.DataPropertyName = "Description";
            this.S1Description.HeaderText = "Description";
            this.S1Description.Name = "S1Description";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 682);
            this.Controls.Add(this.dataGridViewDownloadLogEvent01);
            this.Controls.Add(this.tsChild);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsChild.ResumeLayout(false);
            this.tsChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDownloadLogEvent01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsChild;
        private System.Windows.Forms.ToolStripButton tsChildaaa;
        private System.Windows.Forms.DataGridView dataGridViewDownloadLogEvent01;
        private System.Windows.Forms.DataGridViewTextBoxColumn S1DownLoadDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn S1DownLoadRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn S1Description;
    }
}