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
    public partial class DU_Stud : Form
    {
        public DU_Stud()
        {
            InitializeComponent();
        }

        private void DU_Stud_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dU_StudTableAdapter.Fill(this.dataSet7.DU_Stud, Convert.ToInt32(comboBox1.Text));
        }
    }
}
