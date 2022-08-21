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
    public partial class Queue : Form
    {
        public Form1 main;
        public Queue()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.queue_DUTableAdapter.Fill(dataSet1.Queue_DU, Convert.ToInt32(comboBox1.Text));
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Queue_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.DU". При необходимости она может быть перемещена или удалена.
           // this.dUTableAdapter.Fill(this.dataSet1.DU);

        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
