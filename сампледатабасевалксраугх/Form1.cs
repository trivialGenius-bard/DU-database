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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void пОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.main = this;
            q.Show();
        }

        private void лицензииНаПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DU du = new DU();
            du.main = this;
            du.Show();
        }

        private void программноеОбеспечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s.Show();
        }

        private void установленноеНаПКПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chck_Free_Places chck = new Chck_Free_Places();
            chck.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.Show();
        }

        private void детиНуждающихсяВДУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Need_DU nd = new Need_DU();
            nd.Show();
        }

        private void обучающиесяВДУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DU_Stud dU_Stud = new DU_Stud();
            dU_Stud.Show();
        }
    }
}
