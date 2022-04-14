using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet17.Номер' table. You can move, or remove it, as needed.
            this.номерTableAdapter.Fill(this.dataSet17.Номер);
            // TODO: This line of code loads data into the 'dataSet12.План' table. You can move, or remove it, as needed.
            this.планTableAdapter.Fill(this.dataSet12.План);
            // TODO: This line of code loads data into the 'dataSet2.Рекламодатель' table. You can move, or remove it, as needed.
            this.рекламодательTableAdapter.Fill(this.dataSet2.Рекламодатель);
            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet2.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet2.Tables[0].Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
