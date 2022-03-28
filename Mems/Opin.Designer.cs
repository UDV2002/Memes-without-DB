
namespace Mems
{
    partial class Opin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOpin = new System.Windows.Forms.DataGridView();
            this.Mem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.Label();
            this.OpinExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOpin
            // 
            this.dataGridViewOpin.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridViewOpin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOpin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mem});
            this.dataGridViewOpin.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.dataGridViewOpin.Location = new System.Drawing.Point(12, 94);
            this.dataGridViewOpin.Name = "dataGridViewOpin";
            this.dataGridViewOpin.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOpin.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOpin.RowHeadersWidth = 51;
            this.dataGridViewOpin.RowTemplate.Height = 24;
            this.dataGridViewOpin.Size = new System.Drawing.Size(352, 389);
            this.dataGridViewOpin.TabIndex = 0;
            // 
            // Mem
            // 
            this.Mem.HeaderText = "Название";
            this.Mem.MinimumWidth = 6;
            this.Mem.Name = "Mem";
            this.Mem.ReadOnly = true;
            this.Mem.Width = 300;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(84, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 33);
            this.name.TabIndex = 1;
            this.name.Text = "Мой рейтинг";
            // 
            // OpinExit
            // 
            this.OpinExit.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpinExit.Location = new System.Drawing.Point(12, 507);
            this.OpinExit.Name = "OpinExit";
            this.OpinExit.Size = new System.Drawing.Size(348, 46);
            this.OpinExit.TabIndex = 2;
            this.OpinExit.Text = "Выход";
            this.OpinExit.UseVisualStyleBackColor = true;
            this.OpinExit.Click += new System.EventHandler(this.OpinExit_Click);
            // 
            // Opin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 554);
            this.Controls.Add(this.OpinExit);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dataGridViewOpin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Opin";
            this.Text = "My rating";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOpin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOpin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button OpinExit;
    }
}