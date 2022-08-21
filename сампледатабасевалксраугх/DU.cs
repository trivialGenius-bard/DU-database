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
    public partial class DU : Form
    {
        public Form1 main;
        public DU()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.All_DU". При необходимости она может быть перемещена или удалена.
            this.all_DUTableAdapter.Fill(this.dataSet2.All_DU);

        }

        private void Create_Click(object sender, EventArgs e)
        {

        }
    }
}
