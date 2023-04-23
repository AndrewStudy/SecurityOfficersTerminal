
namespace SecurityOfficersTerminal.Views
{
    partial class ModalWindowAccessForm
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
            this.PatronymicBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AccesSuccessButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PatronymicBox
            // 
            this.PatronymicBox.AutoSize = true;
            this.PatronymicBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatronymicBox.Location = new System.Drawing.Point(113, 105);
            this.PatronymicBox.Name = "PatronymicBox";
            this.PatronymicBox.Size = new System.Drawing.Size(65, 20);
            this.PatronymicBox.TabIndex = 21;
            this.PatronymicBox.Text = "Иванов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Отчество:";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AutoSize = true;
            this.FirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameBox.Location = new System.Drawing.Point(113, 73);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(65, 20);
            this.FirstNameBox.TabIndex = 19;
            this.FirstNameBox.Text = "Иванов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(63, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Имя:";
            // 
            // LastNameBox
            // 
            this.LastNameBox.AutoSize = true;
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameBox.Location = new System.Drawing.Point(113, 40);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(65, 20);
            this.LastNameBox.TabIndex = 17;
            this.LastNameBox.Text = "Иванов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Фамилия:";
            // 
            // AccesSuccessButton
            // 
            this.AccesSuccessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccesSuccessButton.Location = new System.Drawing.Point(142, 158);
            this.AccesSuccessButton.Name = "AccesSuccessButton";
            this.AccesSuccessButton.Size = new System.Drawing.Size(210, 29);
            this.AccesSuccessButton.TabIndex = 26;
            this.AccesSuccessButton.Text = "Разрешить доступ";
            this.AccesSuccessButton.UseVisualStyleBackColor = true;
            this.AccesSuccessButton.Click += new System.EventHandler(this.AccesSuccessButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(255, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(211, 24);
            this.dateTimePicker.TabIndex = 27;
            this.dateTimePicker.Value = new System.DateTime(2023, 4, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(251, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Время:";
            // 
            // ModalWindowAccessForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.AccesSuccessButton);
            this.Controls.Add(this.PatronymicBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalWindowAccessForm";
            this.ShowIcon = false;
            this.Text = "Интерфейс: Работа с заявкой | Разрешение доступа";
            this.Load += new System.EventHandler(this.ModalWindowForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label PatronymicBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label FirstNameBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label LastNameBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AccesSuccessButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
    }
}