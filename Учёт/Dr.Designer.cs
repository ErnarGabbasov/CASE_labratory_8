namespace Учёт
{
    partial class Dr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dr));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.специальностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стажРаботыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.врачBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учёт_пациентовDataSet1 = new Учёт.Учёт_пациентовDataSet1();
            this.врачTableAdapter = new Учёт.Учёт_пациентовDataSet1TableAdapters.ВрачTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDВрачаDataGridViewTextBoxColumn,
            this.фИОВрачаDataGridViewTextBoxColumn,
            this.специальностьDataGridViewTextBoxColumn,
            this.стажРаботыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.врачBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(473, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDВрачаDataGridViewTextBoxColumn
            // 
            this.iDВрачаDataGridViewTextBoxColumn.DataPropertyName = "ID врача";
            this.iDВрачаDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDВрачаDataGridViewTextBoxColumn.Name = "iDВрачаDataGridViewTextBoxColumn";
            this.iDВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDВрачаDataGridViewTextBoxColumn.Width = 25;
            // 
            // фИОВрачаDataGridViewTextBoxColumn
            // 
            this.фИОВрачаDataGridViewTextBoxColumn.DataPropertyName = "ФИО врача";
            this.фИОВрачаDataGridViewTextBoxColumn.HeaderText = "ФИО врача";
            this.фИОВрачаDataGridViewTextBoxColumn.Name = "фИОВрачаDataGridViewTextBoxColumn";
            this.фИОВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОВрачаDataGridViewTextBoxColumn.Width = 170;
            // 
            // специальностьDataGridViewTextBoxColumn
            // 
            this.специальностьDataGridViewTextBoxColumn.DataPropertyName = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.специальностьDataGridViewTextBoxColumn.Name = "специальностьDataGridViewTextBoxColumn";
            this.специальностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.специальностьDataGridViewTextBoxColumn.Width = 130;
            // 
            // стажРаботыDataGridViewTextBoxColumn
            // 
            this.стажРаботыDataGridViewTextBoxColumn.DataPropertyName = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.HeaderText = "Стаж работы";
            this.стажРаботыDataGridViewTextBoxColumn.Name = "стажРаботыDataGridViewTextBoxColumn";
            this.стажРаботыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // врачBindingSource
            // 
            this.врачBindingSource.DataMember = "Врач";
            this.врачBindingSource.DataSource = this.учёт_пациентовDataSet1;
            // 
            // учёт_пациентовDataSet1
            // 
            this.учёт_пациентовDataSet1.DataSetName = "Учёт_пациентовDataSet1";
            this.учёт_пациентовDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // врачTableAdapter
            // 
            this.врачTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(530, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(530, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Linen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(530, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 46);
            this.button3.TabIndex = 5;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(530, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 46);
            this.button4.TabIndex = 6;
            this.button4.Text = "Найти";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Dr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 267);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dr";
            this.Text = "Врачи";
            this.Load += new System.EventHandler(this.ZapisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public Учёт_пациентовDataSet1 учёт_пациентовDataSet1;
        public System.Windows.Forms.BindingSource врачBindingSource;
        public Учёт_пациентовDataSet1TableAdapters.ВрачTableAdapter врачTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn специальностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стажРаботыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}