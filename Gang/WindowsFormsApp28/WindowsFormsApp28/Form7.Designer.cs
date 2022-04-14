
namespace WindowsFormsApp28
{
    partial class Form7
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
            this.рекламноеИзданиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new WindowsFormsApp28.DataSet4();
            this.рекламное_изданиеTableAdapter = new WindowsFormsApp28.DataSet4TableAdapters.Рекламное_изданиеTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.рекламноеизданиеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new WindowsFormsApp28.DataSet7();
            this.рекламное_изданиеTableAdapter1 = new WindowsFormsApp28.DataSet7TableAdapters.Рекламное_изданиеTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSet13 = new WindowsFormsApp28.DataSet13();
            this.платежи2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.платежи2TableAdapter = new WindowsFormsApp28.DataSet13TableAdapters.Платежи2TableAdapter();
            this.коддокументаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпредприятияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.рекламноеИзданиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламноеизданиеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежи2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // рекламноеИзданиеBindingSource
            // 
            this.рекламноеИзданиеBindingSource.DataMember = "Рекламное издание";
            this.рекламноеИзданиеBindingSource.DataSource = this.dataSet4;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламное_изданиеTableAdapter
            // 
            this.рекламное_изданиеTableAdapter.ClearBeforeFill = true;
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
            this.textBox1.Location = new System.Drawing.Point(12, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(226, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 50);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.коддокументаDataGridViewTextBoxColumn,
            this.кодпредприятияDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.платежи2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // рекламноеизданиеBindingSource1
            // 
            this.рекламноеизданиеBindingSource1.DataMember = "Рекламное_издание";
            this.рекламноеизданиеBindingSource1.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламное_изданиеTableAdapter1
            // 
            this.рекламное_изданиеTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet13";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // платежи2BindingSource
            // 
            this.платежи2BindingSource.DataMember = "Платежи2";
            this.платежи2BindingSource.DataSource = this.dataSet13;
            // 
            // платежи2TableAdapter
            // 
            this.платежи2TableAdapter.ClearBeforeFill = true;
            // 
            // коддокументаDataGridViewTextBoxColumn
            // 
            this.коддокументаDataGridViewTextBoxColumn.DataPropertyName = "Код_документа";
            this.коддокументаDataGridViewTextBoxColumn.HeaderText = "Код_документа";
            this.коддокументаDataGridViewTextBoxColumn.Name = "коддокументаDataGridViewTextBoxColumn";
            this.коддокументаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодпредприятияDataGridViewTextBoxColumn
            // 
            this.кодпредприятияDataGridViewTextBoxColumn.DataPropertyName = "Код_предприятия";
            this.кодпредприятияDataGridViewTextBoxColumn.HeaderText = "Код_предприятия";
            this.кодпредприятияDataGridViewTextBoxColumn.Name = "кодпредприятияDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 267);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Платежи";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.рекламноеИзданиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламноеизданиеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.платежи2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource рекламноеИзданиеBindingSource;
        private DataSet4TableAdapters.Рекламное_изданиеTableAdapter рекламное_изданиеTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource рекламноеизданиеBindingSource1;
        private DataSet7TableAdapters.Рекламное_изданиеTableAdapter рекламное_изданиеTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DataSet13 dataSet13;
        private System.Windows.Forms.BindingSource платежи2BindingSource;
        private DataSet13TableAdapters.Платежи2TableAdapter платежи2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn коддокументаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпредприятияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
    }
}