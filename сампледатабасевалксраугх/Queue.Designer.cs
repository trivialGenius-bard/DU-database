
namespace сампледатабасевалксраугх
{
    partial class Queue
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
            this.имяРебенкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерВОчередиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queueDUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new сампледатабасевалксраугх.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dUBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dUBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.dUTableAdapter = new сампледатабасевалксраугх.DataSet1TableAdapters.DUTableAdapter();
            this.queue_DUTableAdapter = new сампледатабасевалксраугх.DataSet1TableAdapters.Queue_DUTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueDUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource)).BeginInit();
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
            this.имяРебенкаDataGridViewTextBoxColumn,
            this.номерДУDataGridViewTextBoxColumn,
            this.номерВОчередиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.queueDUBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 347);
            this.dataGridView1.TabIndex = 11;
            // 
            // имяРебенкаDataGridViewTextBoxColumn
            // 
            this.имяРебенкаDataGridViewTextBoxColumn.DataPropertyName = "Имя ребенка";
            this.имяРебенкаDataGridViewTextBoxColumn.HeaderText = "Имя ребенка";
            this.имяРебенкаDataGridViewTextBoxColumn.Name = "имяРебенкаDataGridViewTextBoxColumn";
            // 
            // номерДУDataGridViewTextBoxColumn
            // 
            this.номерДУDataGridViewTextBoxColumn.DataPropertyName = "Номер ДУ";
            this.номерДУDataGridViewTextBoxColumn.HeaderText = "Номер ДУ";
            this.номерДУDataGridViewTextBoxColumn.Name = "номерДУDataGridViewTextBoxColumn";
            // 
            // номерВОчередиDataGridViewTextBoxColumn
            // 
            this.номерВОчередиDataGridViewTextBoxColumn.DataPropertyName = "Номер в очереди";
            this.номерВОчередиDataGridViewTextBoxColumn.HeaderText = "Номер в очереди";
            this.номерВОчередиDataGridViewTextBoxColumn.Name = "номерВОчередиDataGridViewTextBoxColumn";
            // 
            // queueDUBindingSource
            // 
            this.queueDUBindingSource.DataMember = "Queue_DU";
            this.queueDUBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.dUBindingSource2, "Number", true));
            this.comboBox1.DataSource = this.dUBindingSource1;
            this.comboBox1.DisplayMember = "Number";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(61, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(651, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // dUBindingSource2
            // 
            this.dUBindingSource2.DataMember = "DU";
            this.dUBindingSource2.DataSource = this.dataSet1;
            // 
            // dUBindingSource1
            // 
            this.dUBindingSource1.DataMember = "DU";
            this.dUBindingSource1.DataSource = this.dataSet1;
            // 
            // dUBindingSource
            // 
            this.dUBindingSource.DataMember = "DU";
            this.dUBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ДУ";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(24, 399);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(99, 35);
            this.Create.TabIndex = 14;
            this.Create.Text = "Создать отчет";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(669, 399);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(96, 34);
            this.Close.TabIndex = 15;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // dUTableAdapter
            // 
            this.dUTableAdapter.ClearBeforeFill = true;
            // 
            // queue_DUTableAdapter
            // 
            this.queue_DUTableAdapter.ClearBeforeFill = true;
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Queue";
            this.Text = "Queue";
            this.Load += new System.EventHandler(this.Queue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queueDUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dUBindingSource;
        private DataSet1TableAdapters.DUTableAdapter dUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяРебенкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерВОчередиDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource queueDUBindingSource;
        private DataSet1TableAdapters.Queue_DUTableAdapter queue_DUTableAdapter;
        private System.Windows.Forms.BindingSource dUBindingSource2;
        private System.Windows.Forms.BindingSource dUBindingSource1;
    }
}