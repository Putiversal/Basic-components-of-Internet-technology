namespace Laba_5
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
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExact = new System.Windows.Forms.Button();
            this.labelFileReadTime = new System.Windows.Forms.Label();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.button_load_file = new System.Windows.Forms.Button();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(45, 246);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(668, 276);
            this.listBoxResult.TabIndex = 18;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(396, 72);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(235, 22);
            this.textBoxFind.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Слово для поиска:";
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(45, 72);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(130, 32);
            this.buttonExact.TabIndex = 15;
            this.buttonExact.Text = "Найти слово";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // labelFileReadTime
            // 
            this.labelFileReadTime.AutoSize = true;
            this.labelFileReadTime.Location = new System.Drawing.Point(286, 22);
            this.labelFileReadTime.Name = "labelFileReadTime";
            this.labelFileReadTime.Size = new System.Drawing.Size(148, 17);
            this.labelFileReadTime.TabIndex = 14;
            this.labelFileReadTime.Text = "Время чтения файла";
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(491, 19);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(301, 22);
            this.textBoxFileReadTime.TabIndex = 13;
            // 
            // button_load_file
            // 
            this.button_load_file.Location = new System.Drawing.Point(45, 8);
            this.button_load_file.Name = "button_load_file";
            this.button_load_file.Size = new System.Drawing.Size(196, 45);
            this.button_load_file.TabIndex = 12;
            this.button_load_file.Text = "Загрузить текст из файла";
            this.button_load_file.UseVisualStyleBackColor = true;
            this.button_load_file.Click += new System.EventHandler(this.button_load_file_Click);
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(396, 101);
            this.textBoxMaxDist.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(99, 22);
            this.textBoxMaxDist.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Максимальное расстояние";
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(396, 131);
            this.textBoxThreadCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(89, 22);
            this.textBoxThreadCount.TabIndex = 24;
            this.textBoxThreadCount.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Количество потоков:";
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(396, 216);
            this.textBoxThreadCountAll.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.ReadOnly = true;
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(97, 22);
            this.textBoxThreadCountAll.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Вычисленное количество потоков:";
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.Location = new System.Drawing.Point(396, 186);
            this.textBoxApproxTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.ReadOnly = true;
            this.textBoxApproxTime.Size = new System.Drawing.Size(303, 22);
            this.textBoxApproxTime.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 189);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Время поиска:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 545);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.labelFileReadTime);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.button_load_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.Label labelFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Button button_load_file;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Label label4;
    }
}

