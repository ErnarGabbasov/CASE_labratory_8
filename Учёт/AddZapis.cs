using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Учёт
{
    public partial class AddZapis : Form
    {
        public AddZapis()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddZapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учёт_пациентовDataSet1.Врач". При необходимости она может быть перемещена или удалена.
            this.врачTableAdapter.Fill(this.учёт_пациентовDataSet1.Врач);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учёт_пациентовDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.учёт_пациентовDataSet.Пациент);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZapisForm main = this.Owner as ZapisForm;
            if (main != null)
            {
                DataRow nRow = main.учёт_пациентовDataSet2.Tables[0].NewRow();
                nRow[0] = tbDate.Text;
                nRow[1] = tbTime.Text;
                nRow[2] = tbRoom.Text;
                nRow[3] = cbPac.Text;
                nRow[4] = cbDoc.Text;
                main.учёт_пациентовDataSet2.Tables[0].Rows.Add(nRow);
                main.записи_приёмовTableAdapter.Update(main.учёт_пациентовDataSet2.Записи_приёмов);
                main.учёт_пациентовDataSet2.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbDate.Text = "";
                tbTime.Text = "";
                tbRoom.Text = "";
                cbPac.Text = "";
                cbDoc.Text = "";
            }
        }
    }
}
