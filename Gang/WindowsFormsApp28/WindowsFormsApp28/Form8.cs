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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet14.Предприятие' table. You can move, or remove it, as needed.
            this.предприятиеTableAdapter.Fill(this.dataSet14.Предприятие);
            // TODO: This line of code loads data into the 'dataSet8.Рекламное_агенство' table. You can move, or remove it, as needed.
            this.рекламное_агенствоTableAdapter1.Fill(this.dataSet8.Рекламное_агенство);

            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
            button5.Text = "Добавить";
            label1.Text = "Код_Предприятия";
            label2.Text = "Наименование";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet5.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet5.Tables[0].Rows.Add(row);
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
            string sInsSql = "Insert into Предприятие(название, контактный_номер_телефона, адрес, почта) Values('{0}', '{1}', '{2}', '{3}')";
            string Код_Предприятия = textBox1.Text;
            string Наименование = textBox2.Text;
            string sInsSotr = string.Format(sInsSql, Код_Предприятия, Наименование);
            SqlCommand cmdIns = new SqlCommand(sInsSotr, myConnection);
            cmdIns.ExecuteNonQuery();
            MessageBox.Show(string.Format("[Поле] {0} успешно добавлено", Наименование), "Сообщение");
            this.рекламное_агенствоTableAdapter1.Update(this.dataSet8.Рекламное_агенство);
            this.рекламное_агенствоTableAdapter1.Fill(this.dataSet8.Рекламное_агенство);
        }
    }
}
