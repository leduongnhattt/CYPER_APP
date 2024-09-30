using System.Windows.Forms;

namespace CYPER_SYSTEM.Víews
{
    partial class DichVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewmMenu = new System.Windows.Forms.DataGridView();
            this.maDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cYPER_DBDataSet = new CYPER_SYSTEM.CYPER_DBDataSet();
            this.dICHVUTableAdapter = new CYPER_SYSTEM.CYPER_DBDataSetTableAdapters.DICHVUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cYPER_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewmMenu
            // 
            this.dataGridViewmMenu.AutoGenerateColumns = false;
            this.dataGridViewmMenu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewmMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDichVuDataGridViewTextBoxColumn,
            this.tenDichVuDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.mALOAIDataGridViewTextBoxColumn});
            this.dataGridViewmMenu.DataSource = this.dICHVUBindingSource;
            this.dataGridViewmMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewmMenu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewmMenu.Name = "dataGridViewmMenu";
            this.dataGridViewmMenu.RowHeadersWidth = 51;
            this.dataGridViewmMenu.RowTemplate.Height = 100;
            this.dataGridViewmMenu.Size = new System.Drawing.Size(834, 520);
            this.dataGridViewmMenu.TabIndex = 0;
            this.dataGridViewmMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewmMenu_CellContentClick);
            this.dataGridViewmMenu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewmMenu_CellFormatting);
            // 
            // maDichVuDataGridViewTextBoxColumn
            // 
            this.maDichVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maDichVuDataGridViewTextBoxColumn.DataPropertyName = "MaDichVu";
            this.maDichVuDataGridViewTextBoxColumn.HeaderText = "MaDichVu";
            this.maDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDichVuDataGridViewTextBoxColumn.Name = "maDichVuDataGridViewTextBoxColumn";
            this.maDichVuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDichVuDataGridViewTextBoxColumn.Width = 98;
            // 
            // tenDichVuDataGridViewTextBoxColumn
            // 
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            this.tenDichVuDataGridViewTextBoxColumn.Width = 125;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // mALOAIDataGridViewTextBoxColumn
            // 
            this.mALOAIDataGridViewTextBoxColumn.DataPropertyName = "MALOAI";
            this.mALOAIDataGridViewTextBoxColumn.HeaderText = "MALOAI";
            this.mALOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOAIDataGridViewTextBoxColumn.Name = "mALOAIDataGridViewTextBoxColumn";
            this.mALOAIDataGridViewTextBoxColumn.Width = 125;
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.cYPER_DBDataSet;
            // 
            // cYPER_DBDataSet
            // 
            this.cYPER_DBDataSet.DataSetName = "CYPER_DBDataSet";
            this.cYPER_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 520);
            this.Controls.Add(this.dataGridViewmMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DichVu";
            this.Text = "DichVu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cYPER_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #region Windows Form Designer generated code

        // Add other methods or event handlers if necessary

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmMenu;
        private CYPER_DBDataSet cYPER_DBDataSet;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private CYPER_DBDataSetTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnhImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOAIDataGridViewTextBoxColumn;
    }
}
