namespace WindowsFormsApplication1
{
    partial class ucmodule4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucmodule4));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet10 = new WindowsFormsApplication1.inventoryDataSet10();
            this.clientTableAdapter = new WindowsFormsApplication1.inventoryDataSet10TableAdapters.ClientTableAdapter();
            this.paimentTableAdapter1 = new WindowsFormsApplication1.inventoryDataSet10TableAdapters.PaimentTableAdapter();
            this.paimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paimentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paimentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.inventoryDataSet10;
            // 
            // inventoryDataSet10
            // 
            this.inventoryDataSet10.DataSetName = "inventoryDataSet10";
            this.inventoryDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // paimentTableAdapter1
            // 
            this.paimentTableAdapter1.ClearBeforeFill = true;
            // 
            // paimentBindingSource
            // 
            this.paimentBindingSource.DataMember = "Paiment";
            this.paimentBindingSource.DataSource = this.inventoryDataSet10;
            // 
            // paimentBindingSource1
            // 
            this.paimentBindingSource1.DataMember = "Paiment";
            this.paimentBindingSource1.DataSource = this.inventoryDataSet10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Montant";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // ucmodule4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.Name = "ucmodule4";
            this.Size = new System.Drawing.Size(918, 650);
            this.Load += new System.EventHandler(this.ucmodule4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paimentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private inventoryDataSet10 inventoryDataSet10;
        private inventoryDataSet10TableAdapters.ClientTableAdapter clientTableAdapter;
        private inventoryDataSet10TableAdapters.PaimentTableAdapter paimentTableAdapter1;
        private System.Windows.Forms.BindingSource paimentBindingSource;
        private System.Windows.Forms.BindingSource paimentBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
