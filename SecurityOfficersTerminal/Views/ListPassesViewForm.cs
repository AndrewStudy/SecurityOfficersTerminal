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

namespace SecurityOfficersTerminal.Views
{
    public partial class ListPassesViewForm : Form
    {
        DBConnection dBConnection = new DBConnection();
        public ListPassesViewForm()
        {
            InitializeComponent();
            CreateColums();
            RefreshDataGrid(PassesListGridView);
        }

        private void ListPassesViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateColums()
        {
            PassesListGridView.Columns.Add("id","№");
            PassesListGridView.Columns.Add("last_name","Фамилия");
            PassesListGridView.Columns.Add("first_name","Имя");
            PassesListGridView.Columns.Add("patronymic","Отчество");
            PassesListGridView.Columns.Add("id_passport_data","Номер паспорта");
            PassesListGridView.Columns.Add("id_division","Подразделение");
            PassesListGridView.Columns.Add("typePasse","Тип");
        }

        private void ReadSingleRows(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
            record.GetString(4), record.GetString(5),record.GetString(6));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"SELECT id, last_name, first_name, patronymic," +
                $"(SELECT passport_number FROM Passport_Data WHERE id = User_Private_Visit.id_passport_data)," +
                $"(SELECT division FROM Division WHERE id = User_Private_Visit.id_division)," +
                $"'Личное'FROM User_Private_Visit WHERE id_status = 2";

            SqlCommand command = new SqlCommand(query,dBConnection.getConnection());

            dBConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRows(dgw,reader);
            }
            reader.Close();

            dBConnection.closeConnection();
        }

        private void RefreshTableButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(PassesListGridView);
        }

        int selectedRow;
        private void PassesListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex; // Назначаем id строки которую выбрали

            if (e.RowIndex >= 0)
            {
                ModalWindowAccessForm NewForm = new ModalWindowAccessForm();

                int id = selectedRow;
                NewForm.InputTextBox(id +1);

                NewForm.id = id + 1;

                this.Hide();
                NewForm.ShowDialog();
                this.Show();
            }
                
        }

        

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
