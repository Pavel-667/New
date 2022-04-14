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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet18.Клиент1' table. You can move, or remove it, as needed.
            this.клиент1TableAdapter.Fill(this.dataSet18.Клиент1);
            // TODO: This line of code loads data into the 'dataSet15.Спецификация_Платежа2' table. You can move, or remove it, as needed.
            this.спецификация_Платежа2TableAdapter.Fill(this.dataSet15.Спецификация_Платежа2);
            // TODO: This line of code loads data into the 'dataSet10.Реклама' table. You can move, or remove it, as needed.
            this.рекламаTableAdapter2.Fill(this.dataSet10.Реклама);


            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
            button5.Text = "Добавить";
            label1.Text = "Код_Клиента";
            label2.Text = "ФИО";
            label3.Text = "Паспортные_данные";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet3.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet3.Tables[0].Rows.Add(row);
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
            string sInsSql = "Insert into Клиент1(Код_клиента, ФИО, Паспортные_данные) Values('{0}', '{1}', '{2}', '{3}', '{4}')";
            string Код_Клиента = textBox1.Text;
            string ФИО = textBox2.Text;
            string Паспортные_данные = textBox3.Text;
            string sInsSotr = string.Format(sInsSql, Код_Клиента, ФИО, Паспортные_данные );
            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
            cmdIns.ExecuteNonQuery();
            MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", "ФИО"), "Сообщение");
            this.рекламаTableAdapter2.Update(this.dataSet10.Реклама);
            this.рекламаTableAdapter2.Fill(this.dataSet10.Реклама);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
