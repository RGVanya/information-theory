namespace RSA
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
            this.ButtonR = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.TextBoxQ = new System.Windows.Forms.TextBox();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.TextBoxEuler = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonEnc = new System.Windows.Forms.RadioButton();
            this.radioButtonDec = new System.Windows.Forms.RadioButton();
            this.buttonStartAlgorithm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonR
            // 
            this.ButtonR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonR.Location = new System.Drawing.Point(12, 138);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(322, 59);
            this.ButtonR.TabIndex = 0;
            this.ButtonR.Text = "Рассчет парметров ключа";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 203);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(322, 59);
            this.buttonOpenFile.TabIndex = 3;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // TextBoxQ
            // 
            this.TextBoxQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxQ.Location = new System.Drawing.Point(12, 37);
            this.TextBoxQ.Name = "TextBoxQ";
            this.TextBoxQ.Size = new System.Drawing.Size(233, 30);
            this.TextBoxQ.TabIndex = 6;
            // 
            // TextBoxP
            // 
            this.TextBoxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxP.Location = new System.Drawing.Point(12, 102);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(233, 30);
            this.TextBoxP.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Q (Простое число)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "P (Простое число)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(257, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "R (Произведение P и Q)";
            // 
            // TextBoxR
            // 
            this.TextBoxR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxR.Location = new System.Drawing.Point(258, 37);
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.ReadOnly = true;
            this.TextBoxR.Size = new System.Drawing.Size(232, 30);
            this.TextBoxR.TabIndex = 11;
            // 
            // TextBoxEuler
            // 
            this.TextBoxEuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxEuler.Location = new System.Drawing.Point(258, 102);
            this.TextBoxEuler.Name = "TextBoxEuler";
            this.TextBoxEuler.ReadOnly = true;
            this.TextBoxEuler.Size = new System.Drawing.Size(232, 30);
            this.TextBoxEuler.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(257, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "φ(R)";
            // 
            // TextBoxE
            // 
            this.TextBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxE.Location = new System.Drawing.Point(498, 37);
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.Size = new System.Drawing.Size(232, 30);
            this.TextBoxE.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(497, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Открытый E";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxD.Location = new System.Drawing.Point(494, 102);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(232, 30);
            this.TextBoxD.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(493, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Закрытый D";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile.Location = new System.Drawing.Point(12, 268);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(322, 59);
            this.buttonSaveFile.TabIndex = 18;
            this.buttonSaveFile.Text = "Сохранить в файл";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(12, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(322, 59);
            this.button6.TabIndex = 19;
            this.button6.Text = "Очистить поля";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInput.Location = new System.Drawing.Point(354, 166);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxInput.Size = new System.Drawing.Size(328, 356);
            this.TextBoxInput.TabIndex = 20;
            // 
            // TextBoxOutput
            // 
            this.TextBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxOutput.Location = new System.Drawing.Point(688, 166);
            this.TextBoxOutput.Multiline = true;
            this.TextBoxOutput.Name = "TextBoxOutput";
            this.TextBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxOutput.Size = new System.Drawing.Size(328, 356);
            this.TextBoxOutput.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(349, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Входные данные";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(688, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Выходные данные";
            // 
            // radioButtonEnc
            // 
            this.radioButtonEnc.AutoSize = true;
            this.radioButtonEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEnc.Location = new System.Drawing.Point(769, 37);
            this.radioButtonEnc.Name = "radioButtonEnc";
            this.radioButtonEnc.Size = new System.Drawing.Size(134, 29);
            this.radioButtonEnc.TabIndex = 24;
            this.radioButtonEnc.TabStop = true;
            this.radioButtonEnc.Text = "Шифрация";
            this.radioButtonEnc.UseVisualStyleBackColor = true;
            this.radioButtonEnc.CheckedChanged += new System.EventHandler(this.radioButtonEnc_CheckedChanged);
            // 
            // radioButtonDec
            // 
            this.radioButtonDec.AutoSize = true;
            this.radioButtonDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDec.Location = new System.Drawing.Point(769, 72);
            this.radioButtonDec.Name = "radioButtonDec";
            this.radioButtonDec.Size = new System.Drawing.Size(162, 29);
            this.radioButtonDec.TabIndex = 25;
            this.radioButtonDec.TabStop = true;
            this.radioButtonDec.Text = "Дешифрация";
            this.radioButtonDec.UseVisualStyleBackColor = true;
            this.radioButtonDec.CheckedChanged += new System.EventHandler(this.radioButtonDec_CheckedChanged);
            // 
            // buttonStartAlgorithm
            // 
            this.buttonStartAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartAlgorithm.Location = new System.Drawing.Point(12, 398);
            this.buttonStartAlgorithm.Name = "buttonStartAlgorithm";
            this.buttonStartAlgorithm.Size = new System.Drawing.Size(322, 59);
            this.buttonStartAlgorithm.TabIndex = 26;
            this.buttonStartAlgorithm.Text = "Запуск алгоритма";
            this.buttonStartAlgorithm.UseVisualStyleBackColor = true;
            this.buttonStartAlgorithm.Click += new System.EventHandler(this.buttonStartAlgorithm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 539);
            this.Controls.Add(this.buttonStartAlgorithm);
            this.Controls.Add(this.radioButtonDec);
            this.Controls.Add(this.radioButtonEnc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxOutput);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxEuler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.TextBoxQ);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.ButtonR);
            this.Name = "Form1";
            this.Text = "RSA (лаб 3)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.TextBox TextBoxEuler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxOutput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonEnc;
        private System.Windows.Forms.RadioButton radioButtonDec;
        private System.Windows.Forms.Button buttonStartAlgorithm;
    }
}

