
namespace SecurityOfficersTerminal
{
    partial class AuthorizationEmployeeForm
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
            this.EmployeeCodeTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeCodeTextBox
            // 
            this.EmployeeCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeeCodeTextBox.Location = new System.Drawing.Point(94, 119);
            this.EmployeeCodeTextBox.Name = "EmployeeCodeTextBox";
            this.EmployeeCodeTextBox.Size = new System.Drawing.Size(165, 31);
            this.EmployeeCodeTextBox.TabIndex = 5;
            this.EmployeeCodeTextBox.TextChanged += new System.EventHandler(this.EmployeeCodeTextBox_TextChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(58, 47);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(238, 33);
            this.Label.TabIndex = 4;
            this.Label.Text = "Вход в систему";
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorizationButton.Location = new System.Drawing.Point(94, 193);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AuthorizationButton.Size = new System.Drawing.Size(165, 33);
            this.AuthorizationButton.TabIndex = 3;
            this.AuthorizationButton.Text = "Войти";
            this.AuthorizationButton.UseVisualStyleBackColor = true;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // AuthorizationEmployeeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 273);
            this.Controls.Add(this.EmployeeCodeTextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.AuthorizationButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationEmployeeForm";
            this.ShowIcon = false;
            this.Text = "Терминал сотрудника охраны: Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeCodeTextBox;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button AuthorizationButton;
    }
}

