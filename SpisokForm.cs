using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.LinkLabel;

namespace kyrs
{
    public partial class SpisokForm : Form
    {
        public SpisokForm()
        {
            InitializeComponent();
        }
        //
        // Закрытие формы
        //
        private void SpisokForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //
        // Кнопка редактирования
        //
        private void ToolStripMenuItem_spisok_edit_Click(object sender, EventArgs e)
        {
            Hide();
            EditForm editForm = new EditForm();
            editForm.Show();
        }
        //
        // Активация формы
        //
        private void SpisokForm_Activated(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `auditorium` ORDER BY `id`", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            for (int i = 0; reader.Read(); i++)
            {
                if (dataGridView_spisok.Rows.Count <= i)
                {
                    dataGridView_spisok.Rows.Add();
                }
                for (int j = 0; j < 7; j++)
                {
                    dataGridView_spisok.Rows[i].Cells[j].Value = reader[j].ToString();
                }
            }

            reader.Close();
            db.closeConnection();   
        }
    }
}
