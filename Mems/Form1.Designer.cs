
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
            this.SocOpinion = new System.Windows.Forms.Button();
            this.opinion = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            this.panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureRight
            // 
            this.pictureRight.Location = new System.Drawing.Point(19, 20);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(300, 248);
            this.pictureRight.TabIndex = 0;
            this.pictureRight.TabStop = false;
            this.pictureRight.Click += new System.EventHandler(this.picRightClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Какой мем смешнее?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(258, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кликни по выбранному варианту";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(361, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 69);
            this.label6.TabIndex = 7;
            this.label6.Text = "VS";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.SocOpinion);
            this.panel.Controls.Add(this.opinion);
            this.panel.Controls.Add(this.Exit);
            this.panel.Location = new System.Drawing.Point(12, 481);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(838, 53);
            this.panel.TabIndex = 8;
            // 
            // SocOpinion
            // 
            this.SocOpinion.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SocOpinion.Location = new System.Drawing.Point(595, 11);
            this.SocOpinion.Name = "SocOpinion";
            this.SocOpinion.Size = new System.Drawing.Size(222, 30);
            this.SocOpinion.TabIndex = 2;
            this.SocOpinion.Text = "Общий рейтинг";
            this.SocOpinion.UseVisualStyleBackColor = true;
            this.SocOpinion.Click += new System.EventHandler(this.SocOpinion_Click);
            // 
            // opinion
            // 
            this.opinion.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opinion.Location = new System.Drawing.Point(312, 11);
            this.opinion.Name = "opinion";
            this.opinion.Size = new System.Drawing.Size(256, 31);
            this.opinion.TabIndex = 1;
            this.opinion.Text = "Мой рейтинг";
            this.opinion.UseVisualStyleBackColor = true;
            this.opinion.Click += new System.EventHandler(this.opinion_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(21, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(260, 32);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureLeft);
            this.panel2.Location = new System.Drawing.Point(33, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 354);
            this.panel2.TabIndex = 9;
            // 
            // pictureLeft
            // 
            this.pictureLeft.Location = new System.Drawing.Point(20, 20);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(280, 248);
            this.pictureLeft.TabIndex = 0;
            this.pictureLeft.TabStop = false;
            this.pictureLeft.Click += new System.EventHandler(this.picLeftClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureRight);
            this.panel3.Location = new System.Drawing.Point(483, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 354);
            this.panel3.TabIndex = 10;
            // 
            // Mems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 546);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button SocOpinion;
        private System.Windows.Forms.Button opinion;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureLeft;
    }
}

