using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp28
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet13.Платежи2' table. You can move, or remove it, as needed.
            this.платежи2TableAdapter.Fill(this.dataSet13.Платежи2);
            // TODO: This line of code loads data into the 'dataSet7.Рекламное_издание' table. You can move, or remove it, as needed.
            this.рекламное_изданиеTableAdapter1.Fill(this.dataSet7.Рекламное_издание);
            // TODO: This line of code loads data into the 'dataSet4.Рекламное_издание' table. You can move, or remove it, as needed.
            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
            button5.Text = "Добавить";
            label1.Text = "Код_предприятия";
            label2.Text = "Дата";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet4.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet4.Tables[0].Rows.Add(row);
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
            
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user121_db;persist security info=True;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            string sInsSql = "Insert into Платежи2(Код_предприятия, Дата) Values('{0}', '{1}')";
            string Код_предприятия = textBox1.Text;
            string Дата = textBox2.Text;
            string sInsSotr = string.Format(sInsSql, Код_предприятия, Дата);
            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
            cmdIns.ExecuteNonQuery();
            MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", Код_предприятия), "Сообщение");
            this.рекламное_изданиеTableAdapter1.Update(this.dataSet7.Рекламное_издание);
            this.рекламное_изданиеTableAdapter1.Fill(this.dataSet7.Рекламное_издание);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
