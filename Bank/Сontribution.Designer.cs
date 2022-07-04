namespace Bank
{
    partial class Сontribution
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
            this.обменныйКурсВалютBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.bankDataSet();
            this.видыВкладовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.видыВкладовTableAdapter = new Bank.bankDataSetTableAdapters.ВидыВкладовTableAdapter();
            this.обменныйКурсВалютTableAdapter = new Bank.bankDataSetTableAdapters.ОбменныйКурсВалютTableAdapter();
            this.кодВидаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.минСуммаВкладаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодвалютыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обменныйКурсВалютBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодВидаВкладаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn,
            this.минСуммаВкладаDataGridViewTextBoxColumn,
            this.кодвалютыDataGridViewTextBoxColumn,
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.видыВкладовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(550, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // обменныйКурсВалютBindingSource
            // 
            this.обменныйКурсВалютBindingSource.DataMember = "ОбменныйКурсВалют";
            this.обменныйКурсВалютBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "bankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // видыВкладовBindingSource
            // 
            this.видыВкладовBindingSource.DataMember = "ВидыВкладов";
            this.видыВкладовBindingSource.DataSource = this.bankDataSet;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // видыВкладовTableAdapter
            // 
            this.видыВкладовTableAdapter.ClearBeforeFill = true;
            // 
            // обменныйКурсВалютTableAdapter
            // 
            this.обменныйКурсВалютTableAdapter.ClearBeforeFill = true;
            // 
            // кодВидаВкладаDataGridViewTextBoxColumn
            // 
            this.кодВидаВкладаDataGridViewTextBoxColumn.DataPropertyName = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.HeaderText = "КодВидаВклада";
            this.кодВидаВкладаDataGridViewTextBoxColumn.Name = "кодВидаВкладаDataGridViewTextBoxColumn";
            this.кодВидаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВидаВкладаDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минимальныйСрокВкладаМесDataGridViewTextBoxColumn
            // 
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.DataPropertyName = "МинимальныйСрокВкладаМес";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.HeaderText = "МинимальныйСрокВкладаМес";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.Name = "минимальныйСрокВкладаМесDataGridViewTextBoxColumn";
            this.минимальныйСрокВкладаМесDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // минСуммаВкладаDataGridViewTextBoxColumn
            // 
            this.минСуммаВкладаDataGridViewTextBoxColumn.DataPropertyName = "МинСуммаВклада";
            this.минСуммаВкладаDataGridViewTextBoxColumn.HeaderText = "МинСуммаВклада";
            this.минСуммаВкладаDataGridViewTextBoxColumn.Name = "минСуммаВкладаDataGridViewTextBoxColumn";
            this.минСуммаВкладаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодвалютыDataGridViewTextBoxColumn
            // 
            this.кодвалютыDataGridViewTextBoxColumn.DataPropertyName = "Код_валюты";
            this.кодвалютыDataGridViewTextBoxColumn.DataSource = this.обменныйКурсВалютBindingSource;
            this.кодвалютыDataGridViewTextBoxColumn.DisplayMember = "Наименование";
            this.кодвалютыDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.кодвалютыDataGridViewTextBoxColumn.HeaderText = "Валюта";
            this.кодвалютыDataGridViewTextBoxColumn.MaxDropDownItems = 1;
            this.кодвалютыDataGridViewTextBoxColumn.Name = "кодвалютыDataGridViewTextBoxColumn";
            this.кодвалютыDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодвалютыDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодвалютыDataGridViewTextBoxColumn.ValueMember = "Код_валюты";
            // 
            // процентнаяСтавкаГодоваяDataGridViewTextBoxColumn
            // 
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.DataPropertyName = "ПроцентнаяСтавкаГодовая";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.HeaderText = "ПроцентнаяСтавкаГодовая";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.Name = "процентнаяСтавкаГодоваяDataGridViewTextBoxColumn";
            this.процентнаяСтавкаГодоваяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Сontribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Сontribution";
            this.Text = "Сontribution";
            this.Load += new System.EventHandler(this.Сontribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обменныйКурсВалютBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.видыВкладовBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private bankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource видыВкладовBindingSource;
        private bankDataSetTableAdapters.ВидыВкладовTableAdapter видыВкладовTableAdapter;
        private System.Windows.Forms.BindingSource обменныйКурсВалютBindingSource;
        private bankDataSetTableAdapters.ОбменныйКурсВалютTableAdapter обменныйКурсВалютTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВидаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минимальныйСрокВкладаМесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn минСуммаВкладаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодвалютыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентнаяСтавкаГодоваяDataGridViewTextBoxColumn;
    }
}