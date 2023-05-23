namespace Учёт
{
    partial class ZapisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZapisForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.датаПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКабинетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.записиПриёмовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учёт_пациентовDataSet2 = new Учёт.Учёт_пациентовDataSet2();
            this.записи_приёмовTableAdapter = new Учёт.Учёт_пациентовDataSet2TableAdapters.Записи_приёмовTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиПриёмовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.датаПриёмаDataGridViewTextBoxColumn,
            this.времяПриёмаDataGridViewTextBoxColumn,
            this.номерКабинетаDataGridViewTextBoxColumn,
            this.фИОПациентаDataGridViewTextBoxColumn,
            this.фИОВрачаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.записиПриёмовBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(707, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // датаПриёмаDataGridViewTextBoxColumn
            // 
            this.датаПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Дата приёма";
            this.датаПриёмаDataGridViewTextBoxColumn.HeaderText = "Дата приёма";
            this.датаПриёмаDataGridViewTextBoxColumn.Name = "датаПриёмаDataGridViewTextBoxColumn";
            this.датаПриёмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // времяПриёмаDataGridViewTextBoxColumn
            // 
            this.времяПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Время приёма";
            this.времяПриёмаDataGridViewTextBoxColumn.HeaderText = "Время приёма";
            this.времяПриёмаDataGridViewTextBoxColumn.Name = "времяПриёмаDataGridViewTextBoxColumn";
            this.времяПриёмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерКабинетаDataGridViewTextBoxColumn
            // 
            this.номерКабинетаDataGridViewTextBoxColumn.DataPropertyName = "Номер кабинета";
            this.номерКабинетаDataGridViewTextBoxColumn.HeaderText = "Номер кабинета";
            this.номерКабинетаDataGridViewTextBoxColumn.Name = "номерКабинетаDataGridViewTextBoxColumn";
            this.номерКабинетаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фИОПациентаDataGridViewTextBoxColumn
            // 
            this.фИОПациентаDataGridViewTextBoxColumn.DataPropertyName = "ФИО пациента";
            this.фИОПациентаDataGridViewTextBoxColumn.HeaderText = "ФИО пациента";
            this.фИОПациентаDataGridViewTextBoxColumn.Name = "фИОПациентаDataGridViewTextBoxColumn";
            this.фИОПациентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОПациентаDataGridViewTextBoxColumn.Width = 180;
            // 
            // фИОВрачаDataGridViewTextBoxColumn
            // 
            this.фИОВрачаDataGridViewTextBoxColumn.DataPropertyName = "ФИО врача";
            this.фИОВрачаDataGridViewTextBoxColumn.HeaderText = "ФИО врача";
            this.фИОВрачаDataGridViewTextBoxColumn.Name = "фИОВрачаDataGridViewTextBoxColumn";
            this.фИОВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОВрачаDataGridViewTextBoxColumn.Width = 180;
            // 
            // записиПриёмовBindingSource
            // 
            this.записиПриёмовBindingSource.DataMember = "Записи приёмов";
            this.записиПриёмовBindingSource.DataSource = this.учёт_пациентовDataSet2;
            // 
            // учёт_пациентовDataSet2
            // 
            this.учёт_пациентовDataSet2.DataSetName = "Учёт_пациентовDataSet2";
            this.учёт_пациентовDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записи_приёмовTableAdapter
            // 
            this.записи_приёмовTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(38, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(300, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Linen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(571, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Закрыть";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ZapisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(731, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZapisForm";
            this.Text = "Записи приёмов";
            this.Load += new System.EventHandler(this.ZapisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиПриёмовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public Учёт_пациентовDataSet2 учёт_пациентовDataSet2;
        public System.Windows.Forms.BindingSource записиПриёмовBindingSource;
        public Учёт_пациентовDataSet2TableAdapters.Записи_приёмовTableAdapter записи_приёмовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКабинетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}