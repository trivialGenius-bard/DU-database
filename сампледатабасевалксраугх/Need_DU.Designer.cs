
namespace сампледатабасевалксраугх
{
    partial class Need_DU
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
            this.dataSet6 = new сампледатабасевалксраугх.DataSet6();
            this.needDUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.need_DUTableAdapter = new сампледатабасевалксраугх.DataSet6TableAdapters.Need_DUTableAdapter();
            this.iDРебенкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерВОчередиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.needDUBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDРебенкаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.номерВОчередиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.needDUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(777, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // needDUBindingSource
            // 
            this.needDUBindingSource.DataMember = "Need_DU";
            this.needDUBindingSource.DataSource = this.dataSet6;
            // 
            // need_DUTableAdapter
            // 
            this.need_DUTableAdapter.ClearBeforeFill = true;
            // 
            // iDРебенкаDataGridViewTextBoxColumn
            // 
            this.iDРебенкаDataGridViewTextBoxColumn.DataPropertyName = "ID Ребенка";
            this.iDРебенкаDataGridViewTextBoxColumn.HeaderText = "ID Ребенка";
            this.iDРебенкаDataGridViewTextBoxColumn.Name = "iDРебенкаDataGridViewTextBoxColumn";
            this.iDРебенкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерВОчередиDataGridViewTextBoxColumn
            // 
            this.номерВОчередиDataGridViewTextBoxColumn.DataPropertyName = "Номер в очереди";
            this.номерВОчередиDataGridViewTextBoxColumn.HeaderText = "Номер в очереди";
            this.номерВОчередиDataGridViewTextBoxColumn.Name = "номерВОчередиDataGridViewTextBoxColumn";
            this.номерВОчередиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Need_DU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Need_DU";
            this.Text = "Need_DU";
            this.Load += new System.EventHandler(this.Need_DU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.needDUBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource needDUBindingSource;
        private DataSet6TableAdapters.Need_DUTableAdapter need_DUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDРебенкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВОчередиDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}