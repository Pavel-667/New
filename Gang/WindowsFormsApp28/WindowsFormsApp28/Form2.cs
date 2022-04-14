﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Логин";
            label2.Text = "Пароль";
            button1.Text = "Войти";
            button2.Text = "Регистрация";
            textBox2.UseSystemPasswordChar = true;
            this.BackColor = System.Drawing.Color.White;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connect = "data source=stud-mssql.sttec.yar.ru,38325;initial catalog=user121_db;persist security info=True;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";
            string command = "Select * from mdk where login='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            SqlConnection myConnection = new SqlConnection(connect);
            SqlCommand myCommand = new SqlCommand(command, myConnection);
            myConnection.Open();
            SqlDataReader rd = myCommand.ExecuteReader();
            string login = "null";
            string password = "null";
            while (rd.Read())
            {
                login = rd.GetString(0);
                password = rd.GetString(3);
            }
            myConnection.Close();
            if ((login == "null") || (password == "null"))
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            else
            {
                Form3 frm = new Form3();
                frm.Show();
                Hide();
            }
        }
    }
}
