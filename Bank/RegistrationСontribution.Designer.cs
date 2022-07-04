namespace Bank
{
    partial class RegistrationСontribution
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.bankDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.view_1TableAdapter = new Bank.bankDataSetTableAdapters.View_1TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВидаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.клиентыDataGridViewTextBoxColumn,
            this.кодВидаВкладаDataGridViewTextBoxColumn,
            this.датаВкладаDataGridViewTextBoxColumn,
            this.датаВозвратаDataGridViewTextBoxColumn,
            this.суммаВкладаDataGridViewTextBoxColumn,
            this.статусВкладаDataGridViewTextBoxColumn,
            this.сотрудникиDataGridViewTextBoxColumn,
            this.кодСотрудникаDataGridViewTextBoxColumn,
            this.кодКлиентаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.view1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(745, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // view1BindingSource
            // 
            this.view1BindingSource.DataMember = "View_1";
            this.view1BindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить данные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(311, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_1TableAdapter
            // 
            this.view_1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодРегистрацииВклада";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодРегистрацииВклада";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // клиентыDataGridViewTextBoxColumn
            // 
            this.клиентыDataGridViewTextBoxColumn.DataPropertyName = "Клиенты";
            this.клиентыDataGridViewTextBoxColumn.HeaderText = "Клиенты";
            this.клиентыDataGridViewTextBoxColumn.Name = "клиентыDataGridViewTextBoxColumn";
            this.клиентыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодВидаВкладаDataGridViewTextBoxColumn
            // 
            this.кодВидаВкладаDataGridViewTextBoxColumn.DataPropertyName = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.HeaderText = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.Name = "кодВидаВкладаDataGridViewTextBoxColumn";
            this.кодВидаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВкладаDataGridViewTextBoxColumn
            // 
            this.датаВкладаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВклада";
            this.датаВкладаDataGridViewTextBoxColumn.HeaderText = "ДатаВклада";
            this.датаВкладаDataGridViewTextBoxColumn.Name = "датаВкладаDataGridViewTextBoxColumn";
            this.датаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаВозвратаDataGridViewTextBoxColumn
            // 
            this.датаВозвратаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВозврата";
            this.датаВозвратаDataGridViewTextBoxColumn.HeaderText = "ДатаВозврата";
            this.датаВозвратаDataGridViewTextBoxColumn.Name = "датаВозвратаDataGridViewTextBoxColumn";
            this.датаВозвратаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // суммаВкладаDataGridViewTextBoxColumn
            // 
            this.суммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "СуммаВклада";
            this.суммаВкладаDataGridViewTextBoxColumn.HeaderText = "СуммаВклада";
            this.суммаВкладаDataGridViewTextBoxColumn.Name = "суммаВкладаDataGridViewTextBoxColumn";
            this.суммаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // статусВкладаDataGridViewTextBoxColumn
            // 
            this.статусВкладаDataGridViewTextBoxColumn.DataPropertyName = "СтатусВклада";
            this.статусВкладаDataGridViewTextBoxColumn.HeaderText = "СтатусВклада";
            this.статусВкладаDataGridViewTextBoxColumn.Name = "статусВкладаDataGridViewTextBoxColumn";
            this.статусВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникиDataGridViewTextBoxColumn
            // 
            this.сотрудникиDataGridViewTextBoxColumn.DataPropertyName = "Сотрудники";
            this.сотрудникиDataGridViewTextBoxColumn.HeaderText = "Сотрудники";
            this.сотрудникиDataGridViewTextBoxColumn.Name = "сотрудникиDataGridViewTextBoxColumn";
            this.сотрудникиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодСотрудникаDataGridViewTextBoxColumn
            // 
            this.кодСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.HeaderText = "КодСотрудника";
            this.кодСотрудникаDataGridViewTextBoxColumn.Name = "кодСотрудникаDataGridViewTextBoxColumn";
            this.кодСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодКлиентаDataGridViewTextBoxColumn
            // 
            this.кодКлиентаDataGridViewTextBoxColumn.DataPropertyName = "КодКлиента";
            this.кодКлиентаDataGridViewTextBoxColumn.HeaderText = "КодКлиента";
            this.кодКлиентаDataGridViewTextBoxColumn.Name = "кодКлиентаDataGridViewTextBoxColumn";
            this.кодКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegistrationСontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrationСontribution";
            this.Text = "RegistrationСontribution";
            this.Load += new System.EventHandler(this.RegistrationСontribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодРегистрацииВкладаDataGridViewTextBoxColumn;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource view1BindingSource;
        private bankDataSetTableAdapters.View_1TableAdapter view_1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВидаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодКлиентаDataGridViewTextBoxColumn;
    }
}