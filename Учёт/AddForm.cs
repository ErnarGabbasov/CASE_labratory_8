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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pac main = this.Owner as Pac;
            if (main != null)
            {
                DataRow nRow = main.учёт_пациентовDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbPhone.Text;
                nRow[3] = tbAdress.Text;
                nRow[4] = tbPol.Text;
                nRow[5] = tbDate.Text;
                main.учёт_пациентовDataSet.Tables[0].Rows.Add(nRow);
                main.пациентTableAdapter.Update(main.учёт_пациентовDataSet.Пациент);
                main.учёт_пациентовDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbPhone.Text = "";
                tbAdress.Text = "";
                tbPol.Text = "";
                tbDate.Text = "";
            }
        }
    }
}
