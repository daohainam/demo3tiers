namespace PresentationTier
{
    partial class ManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.tsbNewBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtSearchTerm = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnBookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewBook,
            this.toolStripSeparator1,
            this.txtSearchTerm,
            this.tsbSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ssStatus
            // 
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslStatus});
            this.ssStatus.Location = new System.Drawing.Point(0, 325);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(649, 22);
            this.ssStatus.TabIndex = 1;
            this.ssStatus.Text = "statusStrip1";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBookId,
            this.columnBookTitle,
            this.columnBookAuthor,
            this.columnBookPrice});
            this.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookList.Location = new System.Drawing.Point(0, 25);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.Size = new System.Drawing.Size(649, 300);
            this.dgvBookList.TabIndex = 2;
            // 
            // tsbNewBook
            // 
            this.tsbNewBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewBook.Image")));
            this.tsbNewBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBook.Name = "tsbNewBook";
            this.tsbNewBook.Size = new System.Drawing.Size(65, 22);
            this.tsbNewBook.Text = "New book";
            this.tsbNewBook.Click += new System.EventHandler(this.tsbNewBook_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(200, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(46, 22);
            this.tsbSearch.Text = "Search";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // sslStatus
            // 
            this.sslStatus.Name = "sslStatus";
            this.sslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // columnBookId
            // 
            this.columnBookId.DataPropertyName = "Id";
            this.columnBookId.HeaderText = "BookId";
            this.columnBookId.Name = "columnBookId";
            this.columnBookId.ReadOnly = true;
            this.columnBookId.Visible = false;
            // 
            // columnBookTitle
            // 
            this.columnBookTitle.DataPropertyName = "Title";
            this.columnBookTitle.HeaderText = "Title";
            this.columnBookTitle.Name = "columnBookTitle";
            this.columnBookTitle.ReadOnly = true;
            // 
            // columnBookAuthor
            // 
            this.columnBookAuthor.DataPropertyName = "Author";
            this.columnBookAuthor.FillWeight = 50F;
            this.columnBookAuthor.HeaderText = "Authors";
            this.columnBookAuthor.Name = "columnBookAuthor";
            this.columnBookAuthor.ReadOnly = true;
            // 
            // columnBookPrice
            // 
            this.columnBookPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.columnBookPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.columnBookPrice.FillWeight = 20F;
            this.columnBookPrice.HeaderText = "Price";
            this.columnBookPrice.Name = "columnBookPrice";
            this.columnBookPrice.ReadOnly = true;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 347);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Management";
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.ToolStripButton tsbNewBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtSearchTerm;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripStatusLabel sslStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBookPrice;
    }
}

