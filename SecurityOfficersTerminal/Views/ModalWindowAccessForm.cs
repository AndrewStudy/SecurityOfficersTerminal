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
    // 9404040
    public partial class ModalWindowAccessForm : Form
    {
        DBConnection dbConnect = new DBConnection();

        public int id;
        public ModalWindowAccessForm()
        {
            InitializeComponent();
        }

        private void ModalWindowForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
        }

        
        private void AccesSuccessButton_Click(object sender, EventArgs e)
        {
            var ArrivalTime = dateTimePicker.Value;

            var TimeArrival = $"SELECT id_arrival_time FROM User_Private_Visit";
            
            dbConnect.openConnection();
            var cmd = new SqlCommand(TimeArrival,dbConnect.getConnection());
            var idTime = cmd.ExecuteScalar();

            var UpdateTimeArrival = $"UPDATE Arrival_Time SET time_arrival = {ArrivalTime} WHERE id =  {idTime}";
            var command = new SqlCommand(UpdateTimeArrival, dbConnect.getConnection());
            command.ExecuteNonQuery();
            dbConnect.closeConnection();
            MessageBox.Show("Данные о разрешении на проход на территорию внесены!");
        }
        public void InputTextBox(int id)
        {
            SqlCommand command = new SqlCommand($"SELECT last_name, first_name, patronymic FROM User_Private_Visit WHERE id ={id}", dbConnect.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;

            dbConnect.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            LastNameBox.Text = reader.GetString(0);
            FirstNameBox.Text = reader.GetString(1);
            PatronymicBox.Text = reader.GetString(2);
            reader.Close();

            dbConnect.closeConnection();
        }
    }
}
