using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrs
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button_edit_apply_Click(object sender, EventArgs e)
        {
            Int32 type, board;
            if (radioButton_edit_mul.Checked == true) type = 1;
            else type = 2;

            if (radioButton_edit_mel.Checked == true) board = 1;
            else board = 2;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `auditorium` (`corpus`, `cabinet`, `square`, `size`, `type`, `board`) VALUES ('@corpus', '@cabinet', '@square', '@size', '@type', '@board')", db.getConnection());
            command.Parameters.Add("@corpus", MySqlDbType.VarChar).Value = comboBox_edit_corpus.Text;
            command.Parameters.Add("@cabinet", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_cabinet.Text);
            command.Parameters.Add("@square", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_square.Text);
            command.Parameters.Add("@size", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_size.Text);
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@board", MySqlDbType.Int32).Value = board;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                textBox_edit_error.Text = "Строка успешно добавлена";
                comboBox_edit_corpus.SelectedIndex = -1;
                maskedTextBox_edit_cabinet.Text = "";
                maskedTextBox_edit_square.Text = "";
                maskedTextBox_edit_size.Text = "";
            }
            else
            {
                textBox_edit_error.Text = "Строка не добавлена";
            }

            db.closeConnection();
        }
    }
}