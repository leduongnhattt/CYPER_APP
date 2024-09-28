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
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cYPER_DBDataSet = new CYPER_SYSTEM.CYPER_DBDataSet();
            this.dICHVUTableAdapter = new CYPER_SYSTEM.CYPER_DBDataSetTableAdapters.DICHVUTableAdapter();
            this.maDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDichVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnhImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.mALOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cYPER_DBDataSet)).BeginInit();
            this.SuspendLayout();

            // dataGridViewmMenu
            this.dataGridViewmMenu.AutoGenerateColumns = false;
            this.dataGridViewmMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.maDichVuDataGridViewTextBoxColumn,
                this.tenDichVuDataGridViewTextBoxColumn,
                this.donGiaDataGridViewTextBoxColumn,
                this.HinhAnhImage,
                this.mALOAIDataGridViewTextBoxColumn});
            this.dataGridViewmMenu.DataSource = this.dICHVUBindingSource;
            this.dataGridViewmMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewmMenu.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewmMenu.Name = "dataGridViewmMenu";
            this.dataGridViewmMenu.RowHeadersWidth = 51;
            this.dataGridViewmMenu.RowTemplate.Height = 100; // Set row height to 100 pixels
            this.dataGridViewmMenu.Size = new System.Drawing.Size(774, 384);
            this.dataGridViewmMenu.TabIndex = 0;

            // dICHVUBindingSource
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.cYPER_DBDataSet;

            // cYPER_DBDataSet
            this.cYPER_DBDataSet.DataSetName = "CYPER_DBDataSet";
            this.cYPER_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            // dICHVUTableAdapter
            this.dICHVUTableAdapter.ClearBeforeFill = true;

            // maDichVuDataGridViewTextBoxColumn
            this.maDichVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maDichVuDataGridViewTextBoxColumn.DataPropertyName = "MaDichVu";
            this.maDichVuDataGridViewTextBoxColumn.HeaderText = "MaDichVu";
            this.maDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDichVuDataGridViewTextBoxColumn.Name = "maDichVuDataGridViewTextBoxColumn";
            this.maDichVuDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDichVuDataGridViewTextBoxColumn.Width = 98;

            // tenDichVuDataGridViewTextBoxColumn
            this.tenDichVuDataGridViewTextBoxColumn.DataPropertyName = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.HeaderText = "TenDichVu";
            this.tenDichVuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDichVuDataGridViewTextBoxColumn.Name = "tenDichVuDataGridViewTextBoxColumn";
            this.tenDichVuDataGridViewTextBoxColumn.Width = 125;

            // donGiaDataGridViewTextBoxColumn
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.Width = 125;

            // HinhAnhImage
            this.HinhAnhImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HinhAnhImage.DataPropertyName = "HinhAnhImage";
            this.HinhAnhImage.HeaderText = "HinhAnh";
            this.HinhAnhImage.MinimumWidth = 6;
            this.HinhAnhImage.Name = "HinhAnhImage";
            this.HinhAnhImage.Width = 50; 
            this.HinhAnhImage.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center align images
            this.HinhAnhImage.ImageLayout = DataGridViewImageCellLayout.Zoom; 

            // mALOAIDataGridViewTextBoxColumn
            this.mALOAIDataGridViewTextBoxColumn.DataPropertyName = "MALOAI";
            this.mALOAIDataGridViewTextBoxColumn.HeaderText = "MALOAI";
            this.mALOAIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mALOAIDataGridViewTextBoxColumn.Name = "mALOAIDataGridViewTextBoxColumn";
            this.mALOAIDataGridViewTextBoxColumn.Width = 125;

            // DichVu
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 384);
            this.Controls.Add(this.dataGridViewmMenu);
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
