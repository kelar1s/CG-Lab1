﻿namespace Lab1Filters
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.размытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрГауссаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чБToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2086, 1213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фильтрToolStripMenuItem,
            this.фильтрToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(2143, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открToolStripMenuItem});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(80, 34);
            this.фильтрToolStripMenuItem.Text = "Файл";
            // 
            // открToolStripMenuItem
            // 
            this.открToolStripMenuItem.Name = "открToolStripMenuItem";
            this.открToolStripMenuItem.Size = new System.Drawing.Size(213, 40);
            this.открToolStripMenuItem.Text = "Открыть";
            this.открToolStripMenuItem.Click += new System.EventHandler(this.открToolStripMenuItem_Click);
            // 
            // фильтрToolStripMenuItem1
            // 
            this.фильтрToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem});
            this.фильтрToolStripMenuItem1.Name = "фильтрToolStripMenuItem1";
            this.фильтрToolStripMenuItem1.Size = new System.Drawing.Size(116, 34);
            this.фильтрToolStripMenuItem1.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.чБToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.повыситьЯркостьToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеToolStripMenuItem,
            this.фильтрГауссаToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 1300);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1881, 65);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1914, 1302);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // размытиеToolStripMenuItem
            // 
            this.размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            this.размытиеToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.размытиеToolStripMenuItem.Text = " Размытие";
            this.размытиеToolStripMenuItem.Click += new System.EventHandler(this.размытиеToolStripMenuItem_Click);
            // 
            // фильтрГауссаToolStripMenuItem
            // 
            this.фильтрГауссаToolStripMenuItem.Name = "фильтрГауссаToolStripMenuItem";
            this.фильтрГауссаToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.фильтрГауссаToolStripMenuItem.Text = "фильтр Гаусса";
            this.фильтрГауссаToolStripMenuItem.Click += new System.EventHandler(this.фильтрГауссаToolStripMenuItem_Click);
            // 
            // чБToolStripMenuItem
            // 
            this.чБToolStripMenuItem.Name = "чБToolStripMenuItem";
            this.чБToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.чБToolStripMenuItem.Text = "ЧБ";
            this.чБToolStripMenuItem.Click += new System.EventHandler(this.чБToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // повыситьЯркостьToolStripMenuItem
            // 
            this.повыситьЯркостьToolStripMenuItem.Name = "повыситьЯркостьToolStripMenuItem";
            this.повыситьЯркостьToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.повыситьЯркостьToolStripMenuItem.Text = "Повысить Яркость";
            this.повыситьЯркостьToolStripMenuItem.Click += new System.EventHandler(this.повыситьЯркостьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2143, 1414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem размытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрГауссаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чБToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьЯркостьToolStripMenuItem;
    }
}

