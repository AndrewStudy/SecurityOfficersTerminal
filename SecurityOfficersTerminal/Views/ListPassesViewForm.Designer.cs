
namespace SecurityOfficersTerminal.Views
{
    partial class ListPassesViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RefreshTableButton = new System.Windows.Forms.Button();
            this.PassesListGridView = new System.Windows.Forms.DataGridView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassesListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshTableButton
            // 
            this.RefreshTableButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshTableButton.Location = new System.Drawing.Point(619, 12);
            this.RefreshTableButton.Name = "RefreshTableButton";
            this.RefreshTableButton.Size = new System.Drawing.Size(169, 28);
            this.RefreshTableButton.TabIndex = 3;
            this.RefreshTableButton.Text = "Обновить список";
            this.RefreshTableButton.UseVisualStyleBackColor = true;
            this.RefreshTableButton.Click += new System.EventHandler(this.RefreshTableButton_Click);
            // 
            // PassesListGridView
            // 
            this.PassesListGridView.AllowUserToAddRows = false;
            this.PassesListGridView.AllowUserToDeleteRows = false;
            this.PassesListGridView.AllowUserToResizeColumns = false;
            this.PassesListGridView.AllowUserToResizeRows = false;
            this.PassesListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PassesListGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PassesListGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PassesListGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PassesListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PassesListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassesListGridView.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.PassesListGridView.Location = new System.Drawing.Point(12, 55);
            this.PassesListGridView.MultiSelect = false;
            this.PassesListGridView.Name = "PassesListGridView";
            this.PassesListGridView.ReadOnly = true;
            this.PassesListGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassesListGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PassesListGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PassesListGridView.ShowCellErrors = false;
            this.PassesListGridView.ShowRowErrors = false;
            this.PassesListGridView.Size = new System.Drawing.Size(776, 341);
            this.PassesListGridView.TabIndex = 2;
            this.PassesListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PassesListGridView_CellClick);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(315, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(86, 28);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTextBox.Location = new System.Drawing.Point(12, 14);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(297, 26);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ListPassesViewForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RefreshTableButton);
            this.Controls.Add(this.PassesListGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListPassesViewForm";
            this.ShowIcon = false;
            this.Text = "Терминал сотрудника охраны: Список заявок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListPassesViewForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PassesListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshTableButton;
        private System.Windows.Forms.DataGridView PassesListGridView;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}