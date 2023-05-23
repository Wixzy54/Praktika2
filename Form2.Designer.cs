namespace Praktika
{
    partial class Form2
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
            this.Dobav = new System.Windows.Forms.Button();
            this.Udal = new System.Windows.Forms.Button();
            this.Zadan1 = new System.Windows.Forms.Button();
            this.Zadan2 = new System.Windows.Forms.Button();
            this.Zadan3 = new System.Windows.Forms.Button();
            this.Zadan4 = new System.Windows.Forms.Button();
            this.Vihod = new System.Windows.Forms.Button();
            this.Zadan5 = new System.Windows.Forms.Button();
            this.Zadan6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dobav
            // 
            this.Dobav.Location = new System.Drawing.Point(296, 478);
            this.Dobav.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dobav.Name = "Dobav";
            this.Dobav.Size = new System.Drawing.Size(93, 82);
            this.Dobav.TabIndex = 0;
            this.Dobav.Text = "Добавить данные";
            this.Dobav.UseVisualStyleBackColor = true;
            this.Dobav.Click += new System.EventHandler(this.button1_Click);
            // 
            // Udal
            // 
            this.Udal.Location = new System.Drawing.Point(395, 478);
            this.Udal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Udal.Name = "Udal";
            this.Udal.Size = new System.Drawing.Size(105, 82);
            this.Udal.TabIndex = 1;
            this.Udal.Text = "Удаление данных";
            this.Udal.UseVisualStyleBackColor = true;
            this.Udal.Click += new System.EventHandler(this.Udal_Click);
            // 
            // Zadan1
            // 
            this.Zadan1.Location = new System.Drawing.Point(57, 12);
            this.Zadan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan1.Name = "Zadan1";
            this.Zadan1.Size = new System.Drawing.Size(93, 75);
            this.Zadan1.TabIndex = 2;
            this.Zadan1.Text = "Начисленная зарплата в месяц, руб";
            this.Zadan1.UseVisualStyleBackColor = true;
            this.Zadan1.Click += new System.EventHandler(this.Zadan1_Click);
            // 
            // Zadan2
            // 
            this.Zadan2.Location = new System.Drawing.Point(57, 94);
            this.Zadan2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan2.Name = "Zadan2";
            this.Zadan2.Size = new System.Drawing.Size(93, 75);
            this.Zadan2.TabIndex = 3;
            this.Zadan2.Text = "Подоходный налог с начисленной суммы, руб.";
            this.Zadan2.UseVisualStyleBackColor = true;
            this.Zadan2.Click += new System.EventHandler(this.Zadan2_Click);
            // 
            // Zadan3
            // 
            this.Zadan3.Location = new System.Drawing.Point(57, 174);
            this.Zadan3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan3.Name = "Zadan3";
            this.Zadan3.Size = new System.Drawing.Size(93, 75);
            this.Zadan3.TabIndex = 4;
            this.Zadan3.Text = "Отчисление в пенсионный фонд, руб.";
            this.Zadan3.UseVisualStyleBackColor = true;
            this.Zadan3.Click += new System.EventHandler(this.Zadan3_Click);
            // 
            // Zadan4
            // 
            this.Zadan4.Location = new System.Drawing.Point(57, 255);
            this.Zadan4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan4.Name = "Zadan4";
            this.Zadan4.Size = new System.Drawing.Size(93, 75);
            this.Zadan4.TabIndex = 5;
            this.Zadan4.Text = "Сумма к выдаче, руб.";
            this.Zadan4.UseVisualStyleBackColor = true;
            this.Zadan4.Click += new System.EventHandler(this.Zadan4_Click);
            // 
            // Vihod
            // 
            this.Vihod.BackColor = System.Drawing.Color.IndianRed;
            this.Vihod.Location = new System.Drawing.Point(1363, 478);
            this.Vihod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Vihod.Name = "Vihod";
            this.Vihod.Size = new System.Drawing.Size(197, 82);
            this.Vihod.TabIndex = 6;
            this.Vihod.Text = "Выход из аккаунта";
            this.Vihod.UseVisualStyleBackColor = false;
            this.Vihod.Click += new System.EventHandler(this.Vihod_Click);
            // 
            // Zadan5
            // 
            this.Zadan5.Location = new System.Drawing.Point(57, 336);
            this.Zadan5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan5.Name = "Zadan5";
            this.Zadan5.Size = new System.Drawing.Size(93, 75);
            this.Zadan5.TabIndex = 7;
            this.Zadan5.Text = "Сотрудники со стажем от 5 до 10 лет.";
            this.Zadan5.UseVisualStyleBackColor = true;
            this.Zadan5.Click += new System.EventHandler(this.Zadan5_Click);
            // 
            // Zadan6
            // 
            this.Zadan6.Location = new System.Drawing.Point(57, 417);
            this.Zadan6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zadan6.Name = "Zadan6";
            this.Zadan6.Size = new System.Drawing.Size(93, 75);
            this.Zadan6.TabIndex = 8;
            this.Zadan6.Text = "Сортировка сотрудников по отделам";
            this.Zadan6.UseVisualStyleBackColor = true;
            this.Zadan6.Click += new System.EventHandler(this.Zadan6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1341, 459);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 614);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zadan6);
            this.Controls.Add(this.Zadan5);
            this.Controls.Add(this.Vihod);
            this.Controls.Add(this.Zadan4);
            this.Controls.Add(this.Zadan3);
            this.Controls.Add(this.Zadan2);
            this.Controls.Add(this.Zadan1);
            this.Controls.Add(this.Udal);
            this.Controls.Add(this.Dobav);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dobav;
        private System.Windows.Forms.Button Udal;
        private System.Windows.Forms.Button Zadan1;
        private System.Windows.Forms.Button Zadan2;
        private System.Windows.Forms.Button Zadan3;
        private System.Windows.Forms.Button Zadan4;
        private System.Windows.Forms.Button Vihod;
        private System.Windows.Forms.Button Zadan5;
        private System.Windows.Forms.Button Zadan6;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}