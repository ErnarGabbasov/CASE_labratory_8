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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dr main = this.Owner as Dr;
            if (main != null)
            {
                DataRow nRow = main.учёт_пациентовDataSet1.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbSp.Text;
                nRow[3] = tbSt.Text;
                main.учёт_пациентовDataSet1.Tables[0].Rows.Add(nRow);
                main.врачTableAdapter.Update(main.учёт_пациентовDataSet1.Врач);
                main.учёт_пациентовDataSet1.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbSp.Text = "";
                tbSt.Text = "";
            }
        }
    }
}
