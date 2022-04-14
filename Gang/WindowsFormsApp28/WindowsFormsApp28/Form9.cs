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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet6.Представитель_рекламного_агенства' table. You can move, or remove it, as needed.
            this.представитель_рекламного_агенстваTableAdapter.Fill(this.dataSet6.Представитель_рекламного_агенства);
            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
            button5.Text = "Добавить";
            label1.Text = "Имя";
            label2.Text = "Фамилия";
            label3.Text = "Отчество";
            label4.Text = "Номер";
            label5.Text = "Должность";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet6.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet6.Tables[0].Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user121_db;persist security info=True;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection myConnection = new SqlConnection(@connect);
            myConnection.Open();
            string sInsSql = "Insert into Представитель_рекламного_агенства(имя, фамилия, отчество, номер_телефона, должность) Values('{0}', '{1}', '{2}', '{3}', '{4}' )";
            string имя = textBox1.Text;
            string фамилия = textBox2.Text;
            string отчество = textBox3.Text;
            string номер_телефона = textBox4.Text;
            string должность = textBox5.Text;
            string sInsSotr = string.Format(sInsSql, имя, фамилия, отчество, номер_телефона, должность);
            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
            cmdIns.ExecuteNonQuery();
            MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", имя), "Сообщение");
            this.представитель_рекламного_агенстваTableAdapter.Update(this.dataSet6.Представитель_рекламного_агенства);
            this.представитель_рекламного_агенстваTableAdapter.Fill(this.dataSet6.Представитель_рекламного_агенства);
        }
    }
}
