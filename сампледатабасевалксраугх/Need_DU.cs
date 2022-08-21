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
    public partial class Need_DU : Form
    {
        public Need_DU()
        {
            InitializeComponent();
        }

        private void Need_DU_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet6.Need_DU". При необходимости она может быть перемещена или удалена.
            this.need_DUTableAdapter.Fill(this.dataSet6.Need_DU);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
