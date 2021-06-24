
namespace searchingBooksDatabase
{
    partial class frmBooks
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
            this.btnAll = new System.Windows.Forms.Button();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.sQLBooksDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sQLBooksDBDataSet = new searchingBooksDatabase.SQLBooksDBDataSet();
            this.sQLBooksDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(592, 497);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(196, 27);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "Show All Records";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // grdBooks
            // 
            this.grdBooks.AutoGenerateColumns = false;
            this.grdBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.DataSource = this.sQLBooksDBDataSetBindingSource1;
            this.grdBooks.Location = new System.Drawing.Point(12, 34);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(757, 335);
            this.grdBooks.TabIndex = 1;
            // 
            // sQLBooksDBDataSetBindingSource
            // 
            this.sQLBooksDBDataSetBindingSource.DataSource = this.sQLBooksDBDataSet;
            this.sQLBooksDBDataSetBindingSource.Position = 0;
            // 
            // sQLBooksDBDataSet
            // 
            this.sQLBooksDBDataSet.DataSetName = "SQLBooksDBDataSet";
            this.sQLBooksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sQLBooksDBDataSetBindingSource1
            // 
            this.sQLBooksDBDataSetBindingSource1.DataSource = this.sQLBooksDBDataSet;
            this.sQLBooksDBDataSetBindingSource1.Position = 0;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.btnAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBooks_FormClosing);
            this.Load += new System.EventHandler(this.frmBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sQLBooksDBDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.BindingSource sQLBooksDBDataSetBindingSource;
        private SQLBooksDBDataSet sQLBooksDBDataSet;
        private System.Windows.Forms.BindingSource sQLBooksDBDataSetBindingSource1;
    }
}

