using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учёт
{
    public partial class ZapisForm : Form
    {
        public ZapisForm()
        {
            InitializeComponent();
        }

        private void ZapisForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учёт_пациентовDataSet2.Записи_приёмов". При необходимости она может быть перемещена или удалена.
            this.записи_приёмовTableAdapter.Fill(this.учёт_пациентовDataSet2.Записи_приёмов);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            записи_приёмовTableAdapter.Update(учёт_пациентовDataSet2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddZapis addzapis = new AddZapis();
            addzapis.Owner = this;
            addzapis.Show();
        }
    }
}
