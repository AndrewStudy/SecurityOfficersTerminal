using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityOfficersTerminal.Views
{
    // 9404040
    public partial class ModalWindowForm : Form
    {
        public int id;
        public ModalWindowForm()
        {
            InitializeComponent();
        }

        private void ModalWindowForm_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Enabled = false;
        }


    }
}
