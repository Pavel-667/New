
namespace WindowsFormsApp28
{
    partial class Form4
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
            this.налогиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new WindowsFormsApp28.DataSet11();
            this.представительрекламодателяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp28.DataSet1();
            this.представитель_рекламодателяTableAdapter = new WindowsFormsApp28.DataSet1TableAdapters.Представитель_рекламодателяTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.налогиTableAdapter = new WindowsFormsApp28.DataSet11TableAdapters.НалогиTableAdapter();
            this.dataSet16 = new WindowsFormsApp28.DataSet16();
            this.бронированияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.бронированияTableAdapter = new WindowsFormsApp28.DataSet16TableAdapters.БронированияTableAdapter();
            this.номербронироваияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаБронированияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодномераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.налогиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.представительрекламодателяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронированияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 168);
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
            this.номербронироваияDataGridViewTextBoxColumn,
            this.датаБронированияDataGridViewTextBoxColumn,
            this.датазаездаDataGridViewTextBoxColumn,
            this.датавыездаDataGridViewTextBoxColumn,
            this.кодномераDataGridViewTextBoxColumn,
            this.кодклиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.бронированияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // налогиBindingSource
            // 
            this.налогиBindingSource.DataMember = "Налоги";
            this.налогиBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet11";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // представительрекламодателяBindingSource
            // 
            this.представительрекламодателяBindingSource.DataMember = "Представитель_рекламодателя";
            this.представительрекламодателяBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // представитель_рекламодателяTableAdapter
            // 
            this.представитель_рекламодателяTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(174, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // налогиTableAdapter
            // 
            this.налогиTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet16
            // 
            this.dataSet16.DataSetName = "DataSet16";
            this.dataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // бронированияBindingSource
            // 
            this.бронированияBindingSource.DataMember = "Бронирования";
            this.бронированияBindingSource.DataSource = this.dataSet16;
            // 
            // бронированияTableAdapter
            // 
            this.бронированияTableAdapter.ClearBeforeFill = true;
            // 
            // номербронироваияDataGridViewTextBoxColumn
            // 
            this.номербронироваияDataGridViewTextBoxColumn.DataPropertyName = "Номер_бронироваия";
            this.номербронироваияDataGridViewTextBoxColumn.HeaderText = "Номер_бронироваия";
            this.номербронироваияDataGridViewTextBoxColumn.Name = "номербронироваияDataGridViewTextBoxColumn";
            // 
            // датаБронированияDataGridViewTextBoxColumn
            // 
            this.датаБронированияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Бронирования";
            this.датаБронированияDataGridViewTextBoxColumn.HeaderText = "Дата_Бронирования";
            this.датаБронированияDataGridViewTextBoxColumn.Name = "датаБронированияDataGridViewTextBoxColumn";
            // 
            // датазаездаDataGridViewTextBoxColumn
            // 
            this.датазаездаDataGridViewTextBoxColumn.DataPropertyName = "Дата_заезда";
            this.датазаездаDataGridViewTextBoxColumn.HeaderText = "Дата_заезда";
            this.датазаездаDataGridViewTextBoxColumn.Name = "датазаездаDataGridViewTextBoxColumn";
            // 
            // датавыездаDataGridViewTextBoxColumn
            // 
            this.датавыездаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выезда";
            this.датавыездаDataGridViewTextBoxColumn.HeaderText = "Дата_выезда";
            this.датавыездаDataGridViewTextBoxColumn.Name = "датавыездаDataGridViewTextBoxColumn";
            // 
            // кодномераDataGridViewTextBoxColumn
            // 
            this.кодномераDataGridViewTextBoxColumn.DataPropertyName = "Код_номера";
            this.кодномераDataGridViewTextBoxColumn.HeaderText = "Код_номера";
            this.кодномераDataGridViewTextBoxColumn.Name = "кодномераDataGridViewTextBoxColumn";
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 194);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирования";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.налогиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.представительрекламодателяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бронированияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource представительрекламодателяBindingSource;
        private DataSet1TableAdapters.Представитель_рекламодателяTableAdapter представитель_рекламодателяTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private DataSet11 dataSet11;
        private System.Windows.Forms.BindingSource налогиBindingSource;
        private DataSet11TableAdapters.НалогиTableAdapter налогиTableAdapter;
        private DataSet16 dataSet16;
        private System.Windows.Forms.BindingSource бронированияBindingSource;
        private DataSet16TableAdapters.БронированияTableAdapter бронированияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номербронироваияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаБронированияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодномераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
    }
}