namespace SportsAchievementsApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxSport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxAthletes = new System.Windows.Forms.ComboBox();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dateTimePickerAchieve = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxAchievements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(241, 56);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Location = new System.Drawing.Point(241, 84);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirth.TabIndex = 2;
            // 
            // textBoxSport
            // 
            this.textBoxSport.Location = new System.Drawing.Point(241, 112);
            this.textBoxSport.Name = "textBoxSport";
            this.textBoxSport.Size = new System.Drawing.Size(200, 22);
            this.textBoxSport.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить спортсмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxAthletes
            // 
            this.comboBoxAthletes.FormattingEnabled = true;
            this.comboBoxAthletes.Location = new System.Drawing.Point(241, 190);
            this.comboBoxAthletes.Name = "comboBoxAthletes";
            this.comboBoxAthletes.Size = new System.Drawing.Size(200, 24);
            this.comboBoxAthletes.TabIndex = 5;
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Location = new System.Drawing.Point(241, 220);
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(200, 22);
            this.textBoxEvent.TabIndex = 6;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(241, 248);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(200, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // dateTimePickerAchieve
            // 
            this.dateTimePickerAchieve.Location = new System.Drawing.Point(241, 276);
            this.dateTimePickerAchieve.Name = "dateTimePickerAchieve";
            this.dateTimePickerAchieve.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAchieve.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить достижения";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Показать достижения";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBoxAchievements
            // 
            this.listBoxAchievements.FormattingEnabled = true;
            this.listBoxAchievements.ItemHeight = 16;
            this.listBoxAchievements.Location = new System.Drawing.Point(504, 187);
            this.listBoxAchievements.Name = "listBoxAchievements";
            this.listBoxAchievements.Size = new System.Drawing.Size(269, 196);
            this.listBoxAchievements.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Имя";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выбор спортсмена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Название события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Вид спорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Результат";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Дата достижения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAchievements);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePickerAchieve);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxEvent);
            this.Controls.Add(this.comboBoxAthletes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSport);
            this.Controls.Add(this.dateTimePickerBirth);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.TextBox textBoxSport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxAthletes;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DateTimePicker dateTimePickerAchieve;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxAchievements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

