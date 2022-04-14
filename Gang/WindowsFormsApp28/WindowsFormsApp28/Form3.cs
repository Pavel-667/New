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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            frm.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderColor = Color.Black;
            button1.Text = "Бронирования";
            button2.Text = "Номер";
            button3.Text = "Клиент";
            button4.Text = "Платежи";
            button5.Text = "Предприятие";

        }
    }
}
