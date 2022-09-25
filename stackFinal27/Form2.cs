using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stackFinal27
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton8.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = dataGridView2.RowCount - 1;
                for (int i = 0; i < n + k; i++)
                {
                    dataGridView6.Rows.Add();
                    dataGridView3.Rows.Add();
                }
                for (int i = 0; i < l; i++)
                    dataGridView6.Rows[n + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView6.Rows[(n + k) - l - i - 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                for (int i = l; i < n; i++)
                    dataGridView6.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < n + k; i++)
                    dataGridView3.Rows[n + k - i - 1].Cells[0].Value = dataGridView6.Rows[i].Cells[0].Value;
            }
            else if (radioButton2.Checked || radioButton7.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = dataGridView2.RowCount - 1;
                for (int i = 0; i < n + k; i++)
                    dataGridView3.Rows.Add();
                for (int i = 0; i < l; i++)
                    dataGridView3.Rows[n + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView3.Rows[(n + k) - l - i - 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                for (int i = l; i < n; i++)
                    dataGridView3.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
            }
            else if (radioButton3.Checked || radioButton6.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = dataGridView2.RowCount - 1;
                for (int i = 0; i < n + k; i++)
                {
                    dataGridView6.Rows.Add();
                    dataGridView3.Rows.Add();
                }
                for (int i = 0; i < l; i++)
                    dataGridView6.Rows[n + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView6.Rows[(n + k) - l - i - 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                for (int i = l; i < n; i++)
                    dataGridView6.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < n + k; i++)
                    dataGridView3.Rows[n + k - i - 1].Cells[0].Value = dataGridView6.Rows[i].Cells[0].Value;
            }
            else if (radioButton4.Checked || radioButton5.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = dataGridView2.RowCount - 1;
                for (int i = 0; i < n + k; i++)
                    dataGridView3.Rows.Add();
                for (int i = 0; i < l; i++)
                    dataGridView3.Rows[n + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView3.Rows[(n + k) - l - i - 1].Cells[0].Value = dataGridView2.Rows[i].Cells[0].Value;
                for (int i = l; i < n; i++)
                    dataGridView3.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
            }
            else MessageBox.Show("Оберіть тип стеків!","Помилка!");
        }
    }
}
