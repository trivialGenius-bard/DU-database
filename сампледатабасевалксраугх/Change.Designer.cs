
namespace сампледатабасевалксраугх
{
    partial class Change
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
            this.idChDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBrthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new сампледатабасевалксраугх.DataSet4();
            this.Close = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.childTableAdapter = new сампледатабасевалксраугх.DataSet4TableAdapters.ChildTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idChDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.dateBrthDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.sxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.childBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // idChDataGridViewTextBoxColumn
            // 
            this.idChDataGridViewTextBoxColumn.DataPropertyName = "Id_Ch";
            this.idChDataGridViewTextBoxColumn.HeaderText = "Id_Ch";
            this.idChDataGridViewTextBoxColumn.Name = "idChDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // dateBrthDataGridViewTextBoxColumn
            // 
            this.dateBrthDataGridViewTextBoxColumn.DataPropertyName = "Date_Brth";
            this.dateBrthDataGridViewTextBoxColumn.HeaderText = "Date_Brth";
            this.dateBrthDataGridViewTextBoxColumn.Name = "dateBrthDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // sxDataGridViewTextBoxColumn
            // 
            this.sxDataGridViewTextBoxColumn.DataPropertyName = "Sx";
            this.sxDataGridViewTextBoxColumn.HeaderText = "Sx";
            this.sxDataGridViewTextBoxColumn.Name = "sxDataGridViewTextBoxColumn";
            // 
            // childBindingSource
            // 
            this.childBindingSource.DataMember = "Child";
            this.childBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(692, 352);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(96, 34);
            this.Close.TabIndex = 17;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(12, 351);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(99, 35);
            this.Create.TabIndex = 16;
            this.Create.Text = "Изменить";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // childTableAdapter
            // 
            this.childTableAdapter.ClearBeforeFill = true;
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Change";
            this.Text = "Change";
            this.Load += new System.EventHandler(this.Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Create;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource childBindingSource;
        private DataSet4TableAdapters.ChildTableAdapter childTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idChDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBrthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sxDataGridViewTextBoxColumn;
    }
}