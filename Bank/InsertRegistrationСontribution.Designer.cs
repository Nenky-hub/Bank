namespace Bank
{
    partial class InsertRegistrationСontribution
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.bankDataSet();
            this.банкDataSet = new Bank.БанкDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.view4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.view3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.view_2TableAdapter = new Bank.bankDataSetTableAdapters.View_2TableAdapter();
            this.view_4TableAdapter = new Bank.bankDataSetTableAdapters.View_4TableAdapter();
            this.view2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_3TableAdapter = new Bank.bankDataSetTableAdapters.View_3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиенты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вид вклада";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата вклада";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.view2BindingSource;
            this.comboBox1.DisplayMember = "ФИО";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "КодКлиента";
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "View_2";
            this.view2BindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // банкDataSet
            // 
            this.банкDataSet.DataSetName = "БанкDataSet";
            this.банкDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.view4BindingSource;
            this.comboBox2.DisplayMember = "ВидыВкладов";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "КодВидаВклада";
            // 
            // view4BindingSource
            // 
            this.view4BindingSource.DataMember = "View_4";
            this.view4BindingSource.DataSource = this.bankDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата возврата";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 189);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Сумма вклада";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "действует",
            "закрыт"});
            this.comboBox3.Location = new System.Drawing.Point(144, 224);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Статус вклада";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.view3BindingSource;
            this.comboBox4.DisplayMember = "Сотрудники";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(144, 261);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.ValueMember = "КодСотрудника";
            // 
            // view3BindingSource
            // 
            this.view3BindingSource.DataMember = "View_3";
            this.view3BindingSource.DataSource = this.bankDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Сотрудники";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_2TableAdapter
            // 
            this.view_2TableAdapter.ClearBeforeFill = true;
            // 
            // view_4TableAdapter
            // 
            this.view_4TableAdapter.ClearBeforeFill = true;
            // 
            // view2BindingSource1
            // 
            this.view2BindingSource1.DataMember = "View_2";
            this.view2BindingSource1.DataSource = this.bankDataSet;
            // 
            // view_3TableAdapter
            // 
            this.view_3TableAdapter.ClearBeforeFill = true;
            // 
            // InsertRegistrationСontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertRegistrationСontribution";
            this.Text = "InsertRegistrationСontribution";
            this.Load += new System.EventHandler(this.InsertRegistrationСontribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.банкDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private БанкDataSet банкDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private bankDataSetTableAdapters.View_2TableAdapter view_2TableAdapter;
        private System.Windows.Forms.BindingSource view4BindingSource;
        private bankDataSetTableAdapters.View_4TableAdapter view_4TableAdapter;
        private System.Windows.Forms.BindingSource view2BindingSource1;
        private System.Windows.Forms.BindingSource view3BindingSource;
        private bankDataSetTableAdapters.View_3TableAdapter view_3TableAdapter;
    }
}