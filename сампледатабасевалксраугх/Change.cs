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
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            this.childTableAdapter.Update(this.dataSet4);
        }

        private void Change_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet4.Child". При необходимости она может быть перемещена или удалена.
            this.childTableAdapter.Fill(this.dataSet4.Child);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
