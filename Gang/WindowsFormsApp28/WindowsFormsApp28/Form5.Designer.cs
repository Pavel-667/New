
namespace WindowsFormsApp28
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.планBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet12 = new WindowsFormsApp28.DataSet12();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.рекламодательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new WindowsFormsApp28.DataSet2();
            this.рекламодательTableAdapter = new WindowsFormsApp28.DataSet2TableAdapters.РекламодательTableAdapter();
            this.планTableAdapter = new WindowsFormsApp28.DataSet12TableAdapters.ПланTableAdapter();
            this.dataSet17 = new WindowsFormsApp28.DataSet17();
            this.номерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номерTableAdapter = new WindowsFormsApp28.DataSet17TableAdapters.НомерTableAdapter();
            this.кодномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номеркомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.числоместDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьзасуткиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.планBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламодательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодномераDataGridViewTextBoxColumn,
            this.номеркомнатыDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.числоместDataGridViewTextBoxColumn,
            this.стоимостьзасуткиDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.номерBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // планBindingSource
            // 
            this.планBindingSource.DataMember = "План";
            this.планBindingSource.DataSource = this.dataSet12;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet12";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Выполнить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код_номера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Код_Комнаты";
            // 
            // рекламодательBindingSource
            // 
            this.рекламодательBindingSource.DataMember = "Рекламодатель";
            this.рекламодательBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламодательTableAdapter
            // 
            this.рекламодательTableAdapter.ClearBeforeFill = true;
            // 
            // планTableAdapter
            // 
            this.планTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet17
            // 
            this.dataSet17.DataSetName = "DataSet17";
            this.dataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // номерBindingSource
            // 
            this.номерBindingSource.DataMember = "Номер";
            this.номерBindingSource.DataSource = this.dataSet17;
            // 
            // номерTableAdapter
            // 
            this.номерTableAdapter.ClearBeforeFill = true;
            // 
            // кодномераDataGridViewTextBoxColumn
            // 
            this.кодномераDataGridViewTextBoxColumn.DataPropertyName = "Код_номера";
            this.кодномераDataGridViewTextBoxColumn.HeaderText = "Код_номера";
            this.кодномераDataGridViewTextBoxColumn.Name = "кодномераDataGridViewTextBoxColumn";
            // 
            // номеркомнатыDataGridViewTextBoxColumn
            // 
            this.номеркомнатыDataGridViewTextBoxColumn.DataPropertyName = "Номер_комнаты";
            this.номеркомнатыDataGridViewTextBoxColumn.HeaderText = "Номер_комнаты";
            this.номеркомнатыDataGridViewTextBoxColumn.Name = "номеркомнатыDataGridViewTextBoxColumn";
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            // 
            // числоместDataGridViewTextBoxColumn
            // 
            this.числоместDataGridViewTextBoxColumn.DataPropertyName = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.HeaderText = "Число_мест";
            this.числоместDataGridViewTextBoxColumn.Name = "числоместDataGridViewTextBoxColumn";
            // 
            // стоимостьзасуткиDataGridViewTextBoxColumn
            // 
            this.стоимостьзасуткиDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_за_сутки";
            this.стоимостьзасуткиDataGridViewTextBoxColumn.HeaderText = "Стоимость_за_сутки";
            this.стоимостьзасуткиDataGridViewTextBoxColumn.Name = "стоимостьзасуткиDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Номер";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.планBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламодательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номерBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource рекламодательBindingSource;
        private DataSet2TableAdapters.РекламодательTableAdapter рекламодательTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet12 dataSet12;
        private System.Windows.Forms.BindingSource планBindingSource;
        private DataSet12TableAdapters.ПланTableAdapter планTableAdapter;
        private DataSet17 dataSet17;
        private System.Windows.Forms.BindingSource номерBindingSource;
        private DataSet17TableAdapters.НомерTableAdapter номерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номеркомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn числоместDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьзасуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
    }
}