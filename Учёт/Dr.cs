using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Учёт.Учёт_пациентовDataSet1TableAdapters;

namespace Учёт
{
    public partial class Dr : Form
    {
        public Dr()
        {
            InitializeComponent();
        }

        private void ZapisForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учёт_пациентовDataSet1.Врач". При необходимости она может быть перемещена или удалена.
            this.врачTableAdapter.Fill(this.учёт_пациентовDataSet1.Врач);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            врачTableAdapter.Update(учёт_пациентовDataSet1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Owner = this;
            doctor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchDoctor searchDoctor = new SearchDoctor();
            searchDoctor.Owner = this;
            searchDoctor.Show();
        }
    }
}
