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
    public partial class Chck_Free_Places : Form
    {
        public Chck_Free_Places()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check_DUTableAdapter.Fill(dataSet5.Check_DU, Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
