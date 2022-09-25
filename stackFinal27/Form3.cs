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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = Convert.ToInt16(textBox2.Text);
                for (int i = 0; i < n - k; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView5.Rows.Add();
                }
                for (int i = 0; i < n - l - k; i++)
                    dataGridView5.Rows[n - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView1.Rows[n - l - i - 1].Cells[0].Value = null;
                for (int i = n - l; i < n; i++)
                    dataGridView5.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < n - k; i++)
                    dataGridView2.Rows[n - k - i - 1].Cells[0].Value = dataGridView5.Rows[i].Cells[0].Value;
            }
            else if (radioButton2.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = Convert.ToInt16(textBox2.Text);
                for (int i = 0; i < n - k; i++)
                    dataGridView2.Rows.Add();
                for (int i = 0; i < n - l - k; i++)
                    dataGridView2.Rows[n - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView1.Rows[n - l - i - 1].Cells[0].Value = null;
                for (int i = n - l; i < n; i++)
                    dataGridView2.Rows[(n + k) - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
            }
            else if (radioButton3.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = Convert.ToInt16(textBox2.Text);
                for (int i = 0; i < n - k; i++)
                    dataGridView2.Rows.Add();
                for (int i = 0; i < l; i++)
                    dataGridView2.Rows[n - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView1.Rows[n - k - i - 1].Cells[0].Value = null;
                for (int i = n - l + k; i < n; i++)
                    dataGridView2.Rows[(n - k) + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
            }
            else if (radioButton4.Checked)
            {
                int l = Convert.ToInt16(textBox1.Text);
                int n = dataGridView1.RowCount - 1;
                int k = Convert.ToInt16(textBox2.Text);
                for (int i = 0; i < n - k; i++)
                {
                    dataGridView2.Rows.Add();
                    dataGridView5.Rows.Add();
                }
                for (int i = 0; i < l; i++)
                    dataGridView5.Rows[n - k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < k; i++)
                    dataGridView1.Rows[n - k - i - 1].Cells[0].Value = null;
                for (int i = n - l + k; i < n; i++)
                    dataGridView5.Rows[(n - k) + k - i - 1].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                for (int i = 0; i < n - k; i++)
                    dataGridView2.Rows[n - k - i - 1].Cells[0].Value = dataGridView5.Rows[i].Cells[0].Value;
            }
        }
    }
}
