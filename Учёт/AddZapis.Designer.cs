namespace Учёт
{
    partial class AddZapis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddZapis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.cbPac = new System.Windows.Forms.ComboBox();
            this.учёт_пациентовDataSet = new Учёт.Учёт_пациентовDataSet();
            this.учётпациентовDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентTableAdapter = new Учёт.Учёт_пациентовDataSetTableAdapters.ПациентTableAdapter();
            this.cbDoc = new System.Windows.Forms.ComboBox();
            this.учёт_пациентовDataSet1 = new Учёт.Учёт_пациентовDataSet1();
            this.врачBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачTableAdapter = new Учёт.Учёт_пациентовDataSet1TableAdapters.ВрачTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётпациентовDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbDoc);
            this.groupBox1.Controls.Add(this.cbPac);
            this.groupBox1.Controls.Add(this.tbRoom);
            this.groupBox1.Controls.Add(this.tbTime);
            this.groupBox1.Controls.Add(this.tbDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(65, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(271, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата приёма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время приёма:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер кабинета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ФИО пациента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ФИО врача:";
            // 
            // tbDate
            // 
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Location = new System.Drawing.Point(136, 34);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(263, 26);
            this.tbDate.TabIndex = 5;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTime.Location = new System.Drawing.Point(147, 68);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(252, 26);
            this.tbTime.TabIndex = 6;
            // 
            // tbRoom
            // 
            this.tbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRoom.Location = new System.Drawing.Point(165, 104);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(234, 26);
            this.tbRoom.TabIndex = 7;
            // 
            // cbPac
            // 
            this.cbPac.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.пациентBindingSource, "ФИО пациента", true));
            this.cbPac.DataSource = this.пациентBindingSource;
            this.cbPac.DisplayMember = "ФИО пациента";
            this.cbPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPac.FormattingEnabled = true;
            this.cbPac.Location = new System.Drawing.Point(147, 139);
            this.cbPac.Name = "cbPac";
            this.cbPac.Size = new System.Drawing.Size(252, 28);
            this.cbPac.TabIndex = 8;
            this.cbPac.ValueMember = "ФИО пациента";
            // 
            // учёт_пациентовDataSet
            // 
            this.учёт_пациентовDataSet.DataSetName = "Учёт_пациентовDataSet";
            this.учёт_пациентовDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учётпациентовDataSetBindingSource
            // 
            this.учётпациентовDataSetBindingSource.DataSource = this.учёт_пациентовDataSet;
            this.учётпациентовDataSetBindingSource.Position = 0;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.учёт_пациентовDataSet;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // cbDoc
            // 
            this.cbDoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.врачBindingSource, "ФИО врача", true));
            this.cbDoc.DataSource = this.врачBindingSource;
            this.cbDoc.DisplayMember = "ФИО врача";
            this.cbDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDoc.FormattingEnabled = true;
            this.cbDoc.Location = new System.Drawing.Point(122, 178);
            this.cbDoc.Name = "cbDoc";
            this.cbDoc.Size = new System.Drawing.Size(277, 28);
            this.cbDoc.TabIndex = 9;
            this.cbDoc.ValueMember = "ФИО врача";
            // 
            // учёт_пациентовDataSet1
            // 
            this.учёт_пациентовDataSet1.DataSetName = "Учёт_пациентовDataSet1";
            this.учёт_пациентовDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // врачBindingSource
            // 
            this.врачBindingSource.DataMember = "Врач";
            this.врачBindingSource.DataSource = this.учёт_пациентовDataSet1;
            // 
            // врачTableAdapter
            // 
            this.врачTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Новая запись";
            // 
            // AddZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 303);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddZapis";
            this.Text = "Добавление новой записи на приём";
            this.Load += new System.EventHandler(this.AddZapis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учётпациентовDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учёт_пациентовDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPac;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbDate;
        private Учёт_пациентовDataSet учёт_пациентовDataSet;
        private System.Windows.Forms.BindingSource учётпациентовDataSetBindingSource;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private Учёт_пациентовDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.ComboBox cbDoc;
        private Учёт_пациентовDataSet1 учёт_пациентовDataSet1;
        private System.Windows.Forms.BindingSource врачBindingSource;
        private Учёт_пациентовDataSet1TableAdapters.ВрачTableAdapter врачTableAdapter;
        private System.Windows.Forms.Label label6;
    }
}