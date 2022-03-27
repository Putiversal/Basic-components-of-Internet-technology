namespace Laba_4
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
            this.button_load_file = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.labelFileReadTime = new System.Windows.Forms.Label();
            this.buttonExact = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_load_file
            // 
            this.button_load_file.Location = new System.Drawing.Point(12, 13);
            this.button_load_file.Name = "button_load_file";
            this.button_load_file.Size = new System.Drawing.Size(196, 45);
            this.button_load_file.TabIndex = 0;
            this.button_load_file.Text = "Загрузить текст из файла";
            this.button_load_file.UseVisualStyleBackColor = true;
            this.button_load_file.Click += new System.EventHandler(this.button_load_file_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.Location = new System.Drawing.Point(458, 24);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(301, 22);
            this.textBoxFileReadTime.TabIndex = 1;
            // 
            // labelFileReadTime
            // 
            this.labelFileReadTime.AutoSize = true;
            this.labelFileReadTime.Location = new System.Drawing.Point(253, 27);
            this.labelFileReadTime.Name = "labelFileReadTime";
            this.labelFileReadTime.Size = new System.Drawing.Size(148, 17);
            this.labelFileReadTime.TabIndex = 2;
            this.labelFileReadTime.Text = "Время чтения файла";
            // 
            // buttonExact
            // 
            this.buttonExact.Location = new System.Drawing.Point(12, 100);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(130, 32);
            this.buttonExact.TabIndex = 3;
            this.buttonExact.Text = "Найти слово";
            this.buttonExact.UseVisualStyleBackColor = true;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Слово для поиска:";
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(364, 105);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(235, 22);
            this.textBoxFind.TabIndex = 6;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 16;
            this.listBoxResult.Location = new System.Drawing.Point(12, 203);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(668, 324);
            this.listBoxResult.TabIndex = 9;
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.Location = new System.Drawing.Point(364, 134);
            this.textBoxExactTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.ReadOnly = true;
            this.textBoxExactTime.Size = new System.Drawing.Size(303, 22);
            this.textBoxExactTime.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Время поиска:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.label3);
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

        private System.Windows.Forms.Button button_load_file;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.Label labelFileReadTime;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.Label label3;
    }
}

