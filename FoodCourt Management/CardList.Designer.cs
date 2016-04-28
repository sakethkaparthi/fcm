namespace FoodCourt_Management
{
    partial class CardList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.defaultersToolStrip = new System.Windows.Forms.ToolStrip();
            this.defaultersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cARDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bALANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new FoodCourt_Management.DataSet1();
            this.cARDTableAdapter = new FoodCourt_Management.DataSet1TableAdapters.CARDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.defaultersToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cARDNODataGridViewTextBoxColumn,
            this.bALANCEDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cARDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(341, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // defaultersToolStrip
            // 
            this.defaultersToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultersToolStripButton});
            this.defaultersToolStrip.Location = new System.Drawing.Point(0, 0);
            this.defaultersToolStrip.Name = "defaultersToolStrip";
            this.defaultersToolStrip.Size = new System.Drawing.Size(382, 25);
            this.defaultersToolStrip.TabIndex = 1;
            this.defaultersToolStrip.Text = "defaultersToolStrip";
            // 
            // defaultersToolStripButton
            // 
            this.defaultersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.defaultersToolStripButton.Name = "defaultersToolStripButton";
            this.defaultersToolStripButton.Size = new System.Drawing.Size(64, 22);
            this.defaultersToolStripButton.Text = "Defaulters";
            this.defaultersToolStripButton.Click += new System.EventHandler(this.defaultersToolStripButton_Click);
            // 
            // cARDNODataGridViewTextBoxColumn
            // 
            this.cARDNODataGridViewTextBoxColumn.DataPropertyName = "CARD_NO";
            this.cARDNODataGridViewTextBoxColumn.HeaderText = "CARD_NO";
            this.cARDNODataGridViewTextBoxColumn.Name = "cARDNODataGridViewTextBoxColumn";
            this.cARDNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bALANCEDataGridViewTextBoxColumn
            // 
            this.bALANCEDataGridViewTextBoxColumn.DataPropertyName = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.HeaderText = "BALANCE";
            this.bALANCEDataGridViewTextBoxColumn.Name = "bALANCEDataGridViewTextBoxColumn";
            this.bALANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.HeaderText = "STATUS";
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            this.sTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cARDBindingSource
            // 
            this.cARDBindingSource.DataMember = "CARD";
            this.cARDBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARDTableAdapter
            // 
            this.cARDTableAdapter.ClearBeforeFill = true;
            // 
            // CardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.defaultersToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CardList";
            this.Text = "CardList";
            this.Load += new System.EventHandler(this.CardList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.defaultersToolStrip.ResumeLayout(false);
            this.defaultersToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cARDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cARDBindingSource;
        private DataSet1TableAdapters.CARDTableAdapter cARDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bALANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip defaultersToolStrip;
        private System.Windows.Forms.ToolStripButton defaultersToolStripButton;
    }
}