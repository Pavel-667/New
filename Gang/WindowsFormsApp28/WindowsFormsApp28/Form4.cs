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
    public partial class Form4 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        string connectionString = @"data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user121_db;persist security info=True;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";
        string sql = "SELECT * FROM Бронирования";
        public Form4()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet16.Бронирования' table. You can move, or remove it, as needed.
            this.бронированияTableAdapter.Fill(this.dataSet16.Бронирования);
            // TODO: This line of code loads data into the 'dataSet11.Налоги' table. You can move, or remove it, as needed.
            this.налогиTableAdapter.Fill(this.dataSet11.Налоги);
            // TODO: This line of code loads data into the 'dataSet1.Представитель_рекламодателя' table. You can move, or remove it, as needed.
            this.представитель_рекламодателяTableAdapter.Fill(this.dataSet1.Представитель_рекламодателя);
            button1.Text = "Назад";
            button2.Text = "Добавить";
            button3.Text = "Удалить";
            button4.Text = "Сохранить";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet1.Tables[0].NewRow(); // добавляем новую строку в DataTable
            dataSet1.Tables[0].Rows.Add(row);
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);
                commandBuilder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("Представитель_рекламодателя", connection);
                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Код_Налога", SqlDbType.Int, 50, "Код_Налога"));
                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Наименование_Налога", SqlDbType.NVarChar, 50, "Наименование_Налога"));
                SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 0, "id");
                parameter.Direction = ParameterDirection.Output;
                adapter.Update(ds);
            }
        }
    }
}
