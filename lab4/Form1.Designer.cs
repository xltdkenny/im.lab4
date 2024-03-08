namespace lab4
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edMaxBorn = new System.Windows.Forms.NumericUpDown();
            this.edMinBorn = new System.Windows.Forms.NumericUpDown();
            this.edMaxLive = new System.Windows.Forms.NumericUpDown();
            this.edMinLive = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinLive)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btReload);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.edMaxBorn);
            this.panel1.Controls.Add(this.edMinBorn);
            this.panel1.Controls.Add(this.edMaxLive);
            this.panel1.Controls.Add(this.edMinLive);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 425);
            this.panel1.TabIndex = 1;
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(40, 379);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(132, 23);
            this.btReload.TabIndex = 12;
            this.btReload.Text = "Смена паттерна";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "The number of neighbors to be born";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "The number of neighbors for survival";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rules";
            // 
            // edMaxBorn
            // 
            this.edMaxBorn.Location = new System.Drawing.Point(67, 212);
            this.edMaxBorn.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.edMaxBorn.Name = "edMaxBorn";
            this.edMaxBorn.Size = new System.Drawing.Size(55, 20);
            this.edMaxBorn.TabIndex = 4;
            this.edMaxBorn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edMinBorn
            // 
            this.edMinBorn.Location = new System.Drawing.Point(67, 183);
            this.edMinBorn.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.edMinBorn.Name = "edMinBorn";
            this.edMinBorn.Size = new System.Drawing.Size(55, 20);
            this.edMinBorn.TabIndex = 3;
            this.edMinBorn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edMaxLive
            // 
            this.edMaxLive.Location = new System.Drawing.Point(67, 120);
            this.edMaxLive.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.edMaxLive.Name = "edMaxLive";
            this.edMaxLive.Size = new System.Drawing.Size(55, 20);
            this.edMaxLive.TabIndex = 2;
            this.edMaxLive.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // edMinLive
            // 
            this.edMinLive.Location = new System.Drawing.Point(67, 88);
            this.edMinLive.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.edMinLive.Name = "edMinLive";
            this.edMinLive.Size = new System.Drawing.Size(55, 20);
            this.edMinLive.TabIndex = 1;
            this.edMinLive.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(40, 319);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(132, 45);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMaxLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edMinLive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edMinLive;
        private System.Windows.Forms.NumericUpDown edMinBorn;
        private System.Windows.Forms.NumericUpDown edMaxLive;
        private System.Windows.Forms.NumericUpDown edMaxBorn;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

