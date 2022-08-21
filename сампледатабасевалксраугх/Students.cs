using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сампледатабасевалксраугх
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.Обучающиеся". При необходимости она может быть перемещена или удалена.
            обучающиесяTableAdapter.Fill(dataSet3.Обучающиеся);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet3.Обучающиеся". При необходимости она может быть перемещена или удалена.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
