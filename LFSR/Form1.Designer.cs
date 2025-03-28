namespace LFSR
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
            this.RegisterInfoTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InFileTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutFileTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutKeyTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FileEncryptButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterInfoTBox
            // 
            this.RegisterInfoTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterInfoTBox.Location = new System.Drawing.Point(46, 35);
            this.RegisterInfoTBox.Multiline = true;
            this.RegisterInfoTBox.Name = "RegisterInfoTBox";
            this.RegisterInfoTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RegisterInfoTBox.Size = new System.Drawing.Size(333, 78);
            this.RegisterInfoTBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальное значение регистра";
            // 
            // InFileTBox
            // 
            this.InFileTBox.AcceptsTab = true;
            this.InFileTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InFileTBox.Location = new System.Drawing.Point(47, 203);
            this.InFileTBox.Multiline = true;
            this.InFileTBox.Name = "InFileTBox";
            this.InFileTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InFileTBox.Size = new System.Drawing.Size(332, 370);
            this.InFileTBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Входные данные";
            // 
            // OutFileTBox
            // 
            this.OutFileTBox.AcceptsTab = true;
            this.OutFileTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutFileTBox.Location = new System.Drawing.Point(386, 203);
            this.OutFileTBox.Multiline = true;
            this.OutFileTBox.Name = "OutFileTBox";
            this.OutFileTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutFileTBox.Size = new System.Drawing.Size(332, 370);
            this.OutFileTBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(381, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выходные данные";
            // 
            // OutKeyTBox
            // 
            this.OutKeyTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutKeyTBox.Location = new System.Drawing.Point(385, 35);
            this.OutKeyTBox.Multiline = true;
            this.OutKeyTBox.Name = "OutKeyTBox";
            this.OutKeyTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutKeyTBox.Size = new System.Drawing.Size(333, 138);
            this.OutKeyTBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(381, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выходной ключ";
            // 
            // FileEncryptButton
            // 
            this.FileEncryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileEncryptButton.Location = new System.Drawing.Point(728, 98);
            this.FileEncryptButton.Name = "FileEncryptButton";
            this.FileEncryptButton.Size = new System.Drawing.Size(232, 86);
            this.FileEncryptButton.TabIndex = 8;
            this.FileEncryptButton.Text = "Выбрать исходный файл ";
            this.FileEncryptButton.UseVisualStyleBackColor = true;
            this.FileEncryptButton.Click += new System.EventHandler(this.FileEncryptButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(728, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 86);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить файл ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(724, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 60);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выбирает файл, \r\nначинает \r\nшифривать/дешифровать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FileEncryptButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutKeyTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutFileTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InFileTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterInfoTBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegisterInfoTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InFileTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutFileTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutKeyTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FileEncryptButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

