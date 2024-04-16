namespace Demo_E.Windows_Second_Line
{
    partial class Shift
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cooker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.off = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новая смена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(432, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текущая смена";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admin,
            this.cooker,
            this.off});
            this.dataGridView1.Location = new System.Drawing.Point(228, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 216);
            this.dataGridView1.TabIndex = 2;
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
            // off
            // 
            this.off.DataPropertyName = "off";
            this.off.HeaderText = "Официант";
            this.off.MinimumWidth = 6;
            this.off.Name = "off";
            this.off.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 53);
            this.button2.TabIndex = 3;
            this.button2.Text = "Все смены";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Shift";
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cooker;
        private System.Windows.Forms.DataGridViewTextBoxColumn off;
        private System.Windows.Forms.Button button2;
    }
}