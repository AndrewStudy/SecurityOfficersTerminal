using SecurityOfficersTerminal.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityOfficersTerminal
{
    public partial class AuthorizationEmployeeForm : Form
    {
        DBConnection DBConnection = new DBConnection();
        public AuthorizationEmployeeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var EmployeeCode = EmployeeCodeTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand($"SELECT id, department, employee_code FROM Employees WHERE employee_code = @eC AND department = @dPRTM", DBConnection.getConnection());
            command.Parameters.Add("@eC", SqlDbType.VarChar).Value = EmployeeCode;
            command.Parameters.Add("@dPRTM", SqlDbType.VarChar).Value = "Охрана";

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                ListPassesViewForm ToForm = new ListPassesViewForm();
                this.Hide();
                ToForm.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Не корректный вход");
        }

        private void EmployeeCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeCodeTextBox.PasswordChar = '*';
            EmployeeCodeTextBox.MaxLength = 7;
        }
    }
}
