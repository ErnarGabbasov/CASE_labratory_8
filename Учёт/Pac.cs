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
    public partial class Pac : Form
    {
        public Pac()
        {
            InitializeComponent();
        }

        private void Pac_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учёт_пациентовDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.учёт_пациентовDataSet.Пациент);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        // Сохранение новых данных
        private void button2_Click(object sender, EventArgs e)
        {
            пациентTableAdapter.Update(учёт_пациентовDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Owner = this;
            addForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchPacient searchForm = new SearchPacient();
            searchForm.Owner = this;
            searchForm.Show();
        }
    }
}
