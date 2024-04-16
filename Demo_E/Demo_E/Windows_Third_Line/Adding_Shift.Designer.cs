namespace Demo_E.Windows_Third_Line
{
    partial class Adding_Shift
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sername_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_worker_selected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(628, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите сотрудника в таблице слева, затем нажмите на стрелочку между таблицами д" +
    "ля переноса\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.sername,
            this.groupNumber});
            this.dataGridView1.Location = new System.Drawing.Point(99, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 508);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id сотрудника";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // sername
            // 
            this.sername.DataPropertyName = "sername";
            this.sername.HeaderText = "Фамилия";
            this.sername.MinimumWidth = 6;
            this.sername.Name = "sername";
            this.sername.Width = 125;
            // 
            // groupNumber
            // 
            this.groupNumber.DataPropertyName = "groupNumber";
            this.groupNumber.HeaderText = "Профессия";
            this.groupNumber.MinimumWidth = 6;
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_selected,
            this.name_selected,
            this.sername_selected,
            this.status_worker_selected});
            this.dataGridView2.Location = new System.Drawing.Point(1065, 161);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(792, 508);
            this.dataGridView2.TabIndex = 5;
            // 
            // id_selected
            // 
            this.id_selected.DataPropertyName = "id";
            this.id_selected.HeaderText = "id сотрудника";
            this.id_selected.MinimumWidth = 6;
            this.id_selected.Name = "id_selected";
            this.id_selected.Width = 125;
            // 
            // name_selected
            // 
            this.name_selected.DataPropertyName = "name";
            this.name_selected.HeaderText = "Имя";
            this.name_selected.MinimumWidth = 6;
            this.name_selected.Name = "name_selected";
            this.name_selected.Width = 125;
            // 
            // sername_selected
            // 
            this.sername_selected.DataPropertyName = "sername";
            this.sername_selected.HeaderText = "Фамилия";
            this.sername_selected.MinimumWidth = 6;
            this.sername_selected.Name = "sername_selected";
            this.sername_selected.Width = 125;
            // 
            // status_worker_selected
            // 
            this.status_worker_selected.DataPropertyName = "groupNumber";
            this.status_worker_selected.HeaderText = "Статус сотрудника";
            this.status_worker_selected.MinimumWidth = 6;
            this.status_worker_selected.Name = "status_worker_selected";
            this.status_worker_selected.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(869, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "-->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(697, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(475, 22);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(798, 685);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Сохранить смену";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(828, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите дату смены";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(825, 161);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Adding_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1924, 897);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Adding_Shift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding_Shift";
            this.Load += new System.EventHandler(this.Adding_Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sername;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn sername_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_worker_selected;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}