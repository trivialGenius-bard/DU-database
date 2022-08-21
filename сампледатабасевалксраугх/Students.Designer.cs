
namespace сампледатабасевалксраугх
{
    partial class Students
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
            this.Close = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.обучающиесяBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new сампледатабасевалксраугх.DataSet3();
            this.обучающиесяBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.обучающиесяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обучающиесяTableAdapter = new сампледатабасевалксраугх.DataSet3TableAdapters.ОбучающиесяTableAdapter();
            this.dataSet3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.обучающиесяBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.родственникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяРодственникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(675, 395);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(96, 34);
            this.Close.TabIndex = 20;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(30, 395);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(99, 35);
            this.Create.TabIndex = 19;
            this.Create.Text = "Создать отчет";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.родственникDataGridViewTextBoxColumn,
            this.имяРодственникаDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.обучающиесяBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(30, 21);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(741, 345);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // обучающиесяBindingSource2
            // 
            this.обучающиесяBindingSource2.DataMember = "Обучающиеся";
            this.обучающиесяBindingSource2.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // обучающиесяBindingSource1
            // 
            this.обучающиесяBindingSource1.DataMember = "Обучающиеся";
            this.обучающиесяBindingSource1.DataSource = this.dataSet3;
            // 
            // обучающиесяBindingSource
            // 
            this.обучающиесяBindingSource.DataMember = "Обучающиеся";
            this.обучающиесяBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3BindingSource
            // 
            this.dataSet3BindingSource.DataSource = this.dataSet3;
            this.dataSet3BindingSource.Position = 0;
            // 
            // обучающиесяTableAdapter
            // 
            this.обучающиесяTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet3BindingSource1
            // 
            this.dataSet3BindingSource1.DataSource = this.dataSet3;
            this.dataSet3BindingSource1.Position = 0;
            // 
            // обучающиесяBindingSource3
            // 
            this.обучающиесяBindingSource3.DataMember = "Обучающиеся";
            this.обучающиесяBindingSource3.DataSource = this.dataSet3BindingSource1;
            // 
            // родственникDataGridViewTextBoxColumn
            // 
            this.родственникDataGridViewTextBoxColumn.DataPropertyName = "Родственник";
            this.родственникDataGridViewTextBoxColumn.HeaderText = "Родственник";
            this.родственникDataGridViewTextBoxColumn.Name = "родственникDataGridViewTextBoxColumn";
            this.родственникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяРодственникаDataGridViewTextBoxColumn
            // 
            this.имяРодственникаDataGridViewTextBoxColumn.DataPropertyName = "Имя родственника";
            this.имяРодственникаDataGridViewTextBoxColumn.HeaderText = "Имя родственника";
            this.имяРодственникаDataGridViewTextBoxColumn.Name = "имяРодственникаDataGridViewTextBoxColumn";
            this.имяРодственникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обучающиесяBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet3BindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource обучающиесяBindingSource;
        private System.Windows.Forms.BindingSource обучающиесяBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBrthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource обучающиесяBindingSource2;
        private DataSet3TableAdapters.ОбучающиесяTableAdapter обучающиесяTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn родственникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяРодственникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource обучающиесяBindingSource3;
        private System.Windows.Forms.BindingSource dataSet3BindingSource1;
    }
}