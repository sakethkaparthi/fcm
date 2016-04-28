namespace FoodCourt_Management
{
    partial class Feedbacks
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
            this.dataSet2 = new FoodCourt_Management.DataSet2();
            this.fEEDBACKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEEDBACKTableAdapter = new FoodCourt_Management.DataSet2TableAdapters.FEEDBACKTableAdapter();
            this.rEGNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fEEDBACKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rATINGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEDBACKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rEGNODataGridViewTextBoxColumn,
            this.fEEDBACKDataGridViewTextBoxColumn,
            this.rATINGDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fEEDBACKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(67, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fEEDBACKBindingSource
            // 
            this.fEEDBACKBindingSource.DataMember = "FEEDBACK";
            this.fEEDBACKBindingSource.DataSource = this.dataSet2;
            // 
            // fEEDBACKTableAdapter
            // 
            this.fEEDBACKTableAdapter.ClearBeforeFill = true;
            // 
            // rEGNODataGridViewTextBoxColumn
            // 
            this.rEGNODataGridViewTextBoxColumn.DataPropertyName = "REGNO";
            this.rEGNODataGridViewTextBoxColumn.HeaderText = "REGNO";
            this.rEGNODataGridViewTextBoxColumn.Name = "rEGNODataGridViewTextBoxColumn";
            // 
            // fEEDBACKDataGridViewTextBoxColumn
            // 
            this.fEEDBACKDataGridViewTextBoxColumn.DataPropertyName = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.HeaderText = "FEEDBACK";
            this.fEEDBACKDataGridViewTextBoxColumn.Name = "fEEDBACKDataGridViewTextBoxColumn";
            // 
            // rATINGDataGridViewTextBoxColumn
            // 
            this.rATINGDataGridViewTextBoxColumn.DataPropertyName = "RATING";
            this.rATINGDataGridViewTextBoxColumn.HeaderText = "RATING";
            this.rATINGDataGridViewTextBoxColumn.Name = "rATINGDataGridViewTextBoxColumn";
            // 
            // Feedbacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 271);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Feedbacks";
            this.Text = "Feedbacks";
            this.Load += new System.EventHandler(this.Feedbacks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEEDBACKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource fEEDBACKBindingSource;
        private DataSet2TableAdapters.FEEDBACKTableAdapter fEEDBACKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fEEDBACKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rATINGDataGridViewTextBoxColumn;
    }
}