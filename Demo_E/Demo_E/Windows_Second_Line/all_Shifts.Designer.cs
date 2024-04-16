namespace Demo_E.Windows_Second_Line
{
    partial class all_Shifts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cooker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.admin,
            this.cooker,
            this.officiant});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 503);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // admin
            // 
            this.admin.DataPropertyName = "admin";
            this.admin.HeaderText = "Администратор";
            this.admin.MinimumWidth = 6;
            this.admin.Name = "admin";
            this.admin.Width = 125;
            // 
            // cooker
            // 
            this.cooker.DataPropertyName = "cooker";
            this.cooker.HeaderText = "Повар";
            this.cooker.MinimumWidth = 6;
            this.cooker.Name = "cooker";
            this.cooker.Width = 125;
            // 
            // officiant
            // 
            this.officiant.DataPropertyName = "officiant";
            this.officiant.HeaderText = "Официант";
            this.officiant.MinimumWidth = 6;
            this.officiant.Name = "officiant";
            this.officiant.Width = 125;
            // 
            // all_Shifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 527);
            this.Controls.Add(this.dataGridView1);
            this.Name = "all_Shifts";
            this.Text = "all_Shifts";
            this.Load += new System.EventHandler(this.all_Shifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cooker;
        private System.Windows.Forms.DataGridViewTextBoxColumn officiant;
    }
}