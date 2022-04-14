
namespace WindowsFormsApp28
{
    partial class Form6
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
            this.рекламаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new WindowsFormsApp28.DataSet3();
            this.рекламаTableAdapter = new WindowsFormsApp28.DataSet3TableAdapters.РекламаTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataSet9 = new WindowsFormsApp28.DataSet9();
            this.рекламаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.рекламаTableAdapter1 = new WindowsFormsApp28.DataSet9TableAdapters.РекламаTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.спецификацияПлатежа2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet15 = new WindowsFormsApp28.DataSet15();
            this.рекламаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet10 = new WindowsFormsApp28.DataSet10();
            this.рекламаTableAdapter2 = new WindowsFormsApp28.DataSet10TableAdapters.РекламаTableAdapter();
            this.спецификация_Платежа2TableAdapter = new WindowsFormsApp28.DataSet15TableAdapters.Спецификация_Платежа2TableAdapter();
            this.dataSet18 = new WindowsFormsApp28.DataSet18();
            this.клиент1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиент1TableAdapter = new WindowsFormsApp28.DataSet18TableAdapters.Клиент1TableAdapter();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.паспортныеДанныеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияПлатежа2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // рекламаBindingSource
            // 
            this.рекламаBindingSource.DataMember = "Реклама";
            this.рекламаBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламаTableAdapter
            // 
            this.рекламаTableAdapter.ClearBeforeFill = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 35;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 220);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // dataSet9
            // 
            this.dataSet9.DataSetName = "DataSet9";
            this.dataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламаBindingSource1
            // 
            this.рекламаBindingSource1.DataMember = "Реклама";
            this.рекламаBindingSource1.DataSource = this.dataSet9;
            // 
            // рекламаTableAdapter1
            // 
            this.рекламаTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.паспортныеДанныеDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиент1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // спецификацияПлатежа2BindingSource
            // 
            this.спецификацияПлатежа2BindingSource.DataMember = "Спецификация_Платежа2";
            this.спецификацияПлатежа2BindingSource.DataSource = this.dataSet15;
            // 
            // dataSet15
            // 
            this.dataSet15.DataSetName = "DataSet15";
            this.dataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламаBindingSource2
            // 
            this.рекламаBindingSource2.DataMember = "Реклама";
            this.рекламаBindingSource2.DataSource = this.dataSet10;
            // 
            // dataSet10
            // 
            this.dataSet10.DataSetName = "DataSet10";
            this.dataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рекламаTableAdapter2
            // 
            this.рекламаTableAdapter2.ClearBeforeFill = true;
            // 
            // спецификация_Платежа2TableAdapter
            // 
            this.спецификация_Платежа2TableAdapter.ClearBeforeFill = true;
            // 
            // dataSet18
            // 
            this.dataSet18.DataSetName = "DataSet18";
            this.dataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиент1BindingSource
            // 
            this.клиент1BindingSource.DataMember = "Клиент1";
            this.клиент1BindingSource.DataSource = this.dataSet18;
            // 
            // клиент1TableAdapter
            // 
            this.клиент1TableAdapter.ClearBeforeFill = true;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // паспортныеДанныеDataGridViewTextBoxColumn
            // 
            this.паспортныеДанныеDataGridViewTextBoxColumn.DataPropertyName = "Паспортные_Данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.HeaderText = "Паспортные_Данные";
            this.паспортныеДанныеDataGridViewTextBoxColumn.Name = "паспортныеДанныеDataGridViewTextBoxColumn";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 283);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.спецификацияПлатежа2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рекламаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиент1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource рекламаBindingSource;
        private DataSet3TableAdapters.РекламаTableAdapter рекламаTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private DataSet9 dataSet9;
        private System.Windows.Forms.BindingSource рекламаBindingSource1;
        private DataSet9TableAdapters.РекламаTableAdapter рекламаTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet10 dataSet10;
        private System.Windows.Forms.BindingSource рекламаBindingSource2;
        private DataSet10TableAdapters.РекламаTableAdapter рекламаTableAdapter2;
        private DataSet15 dataSet15;
        private System.Windows.Forms.BindingSource спецификацияПлатежа2BindingSource;
        private DataSet15TableAdapters.Спецификация_Платежа2TableAdapter спецификация_Платежа2TableAdapter;
        private DataSet18 dataSet18;
        private System.Windows.Forms.BindingSource клиент1BindingSource;
        private DataSet18TableAdapters.Клиент1TableAdapter клиент1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn паспортныеДанныеDataGridViewTextBoxColumn;
    }
}