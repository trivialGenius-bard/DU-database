
namespace сампледатабасевалксраугх
{
    partial class DU
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
            this.allDUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new сампледатабасевалксраугх.DataSet2();
            this.Close = new System.Windows.Forms.Button();
            this.allDUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_DUTableAdapter = new сампледатабасевалксраугх.DataSet2TableAdapters.All_DUTableAdapter();
            this.allDUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.номерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.названиеDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.контактыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.allDUBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(30, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 345);
            this.dataGridView1.TabIndex = 12;
            // 
            // allDUBindingSource1
            // 
            this.allDUBindingSource1.DataMember = "All_DU";
            this.allDUBindingSource1.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(675, 403);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(96, 34);
            this.Close.TabIndex = 17;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // allDUBindingSource
            // 
            this.allDUBindingSource.DataMember = "All_DU";
            this.allDUBindingSource.DataSource = this.dataSet2;
            // 
            // all_DUTableAdapter
            // 
            this.all_DUTableAdapter.ClearBeforeFill = true;
            // 
            // allDUBindingSource2
            // 
            this.allDUBindingSource2.DataMember = "All_DU";
            this.allDUBindingSource2.DataSource = this.dataSet2;
            // 
            // номерDataGridViewTextBoxColumn
            // 
            this.номерDataGridViewTextBoxColumn.DataPropertyName = "Номер";
            this.номерDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.номерDataGridViewTextBoxColumn.Name = "номерDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Количество мест";
            this.dataGridViewTextBoxColumn1.HeaderText = "Количество мест";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // контактыDataGridViewTextBoxColumn
            // 
            this.контактыDataGridViewTextBoxColumn.DataPropertyName = "Контакты";
            this.контактыDataGridViewTextBoxColumn.HeaderText = "Контакты";
            this.контактыDataGridViewTextBoxColumn.Name = "контактыDataGridViewTextBoxColumn";
            // 
            // DU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DU";
            this.Text = "DU";
            this.Load += new System.EventHandler(this.DU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDUBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource allDUBindingSource;
        private DataSet2TableAdapters.All_DUTableAdapter all_DUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allDUBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allDUBindingSource2;
        // private System.Windows.Forms.BindingSource dUFreeAgeBindingSource;
        // private DataSet5 dataSet5;
        // private DataSet5TableAdapters.DU_Free_AgeTableAdapter dU_Free_AgeTableAdapter;
    }
}