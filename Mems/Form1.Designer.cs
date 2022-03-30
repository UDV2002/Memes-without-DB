
namespace Mems
{
    partial class Mems
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mems));
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.opinion = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureRight
            // 
            this.pictureRight.Location = new System.Drawing.Point(568, 119);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(450, 442);
            this.pictureRight.TabIndex = 0;
            this.pictureRight.TabStop = false;
            this.pictureRight.Click += new System.EventHandler(this.picRightClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Какой мем смешнее?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(320, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кликни по выбранному варианту";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(484, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 71);
            this.label6.TabIndex = 7;
            this.label6.Text = "VS";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.opinion);
            this.panel.Controls.Add(this.Exit);
            this.panel.Location = new System.Drawing.Point(21, 646);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(997, 53);
            this.panel.TabIndex = 8;
            // 
            // opinion
            // 
            this.opinion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opinion.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opinion.Location = new System.Drawing.Point(532, 11);
            this.opinion.Name = "opinion";
            this.opinion.Size = new System.Drawing.Size(449, 31);
            this.opinion.TabIndex = 1;
            this.opinion.Text = "Мой рейтинг";
            this.opinion.UseVisualStyleBackColor = false;
            this.opinion.Click += new System.EventHandler(this.opinion_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Exit.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(18, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(458, 32);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(564, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pictureLeft
            // 
            this.pictureLeft.Location = new System.Drawing.Point(12, 119);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(474, 442);
            this.pictureLeft.TabIndex = 0;
            this.pictureLeft.TabStop = false;
            this.pictureLeft.Click += new System.EventHandler(this.picLeftClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Mems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1030, 721);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureRight);
            this.Controls.Add(this.pictureLeft);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Mems";
            this.Text = "Mems";
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button opinion;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.Label label1;
    }
}

