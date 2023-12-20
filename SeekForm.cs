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
    public partial class SeekForm : Form
    {
        public SeekForm()
        {
            InitializeComponent();
        }
        //
        // Закрытие формы
        //
        private void SeekForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //
        // Кнопка выход
        //
        private void button_seek_exit_Click(object sender, EventArgs e)
        {
            Hide();
            SpisokForm spisokForm = new SpisokForm();
            spisokForm.Show();
        }
        //
        // Активация формы
        //
        private void SeekForm_Activated(object sender, EventArgs e)
        {
            radioButton_seek_mul.Checked = true;
            radioButton_seek_mel.Checked = true;
            comboBox_seek_corpus.Enabled = false;
            maskedTextBox_seek_cabinet.Enabled = false;
            panel_seek_type.Enabled = false;
            panel_seek_board.Enabled = false;
            groupBox_seek_square.Enabled = false;
            groupBox_seek_size.Enabled = false;
        }
        //
        // Выбор полей поиска
        //
        private void checkBox_seek_corpus_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_seek_corpus.Enabled = checkBox_seek_corpus.Checked;
            maskedTextBox_seek_cabinet.Enabled = checkBox_seek_cabinet.Checked;
            groupBox_seek_size.Enabled = checkBox_seek_size.Checked;
            groupBox_seek_square.Enabled = checkBox_seek_square.Checked;
            panel_seek_type.Enabled = checkBox_seek_type.Checked;
            panel_seek_board.Enabled = checkBox_seek_board.Checked;
        }
        //
        // Кнопка применить
        //
        private void button_seek_apply_Click(object sender, EventArgs e)
        {
            // Массив фильтров
            String[] parameters = new String[6];
            for (int i = 0; i < 6; i++) 
            {
                parameters[i] = null;
                switch (i)
                {
                    case 0:
                        if (checkBox_seek_corpus.Checked)
                        {
                            if (comboBox_seek_corpus.SelectedIndex != -1)
                                parameters[i] = comboBox_seek_corpus.Text;
                        }
                        break;
                    case 1:
                        if (checkBox_seek_cabinet.Checked)
                        {
                            if (maskedTextBox_seek_cabinet.Text != "")
                                parameters[i] = maskedTextBox_seek_cabinet.Text;
                        }
                        break;
                    case 2:
                        if (checkBox_seek_square.Checked)
                        {
                            if (maskedTextBox_seek_square.Text != "")
                                parameters[i] = maskedTextBox_seek_square.Text;
                        }
                        break;
                    case 3:
                        if (checkBox_seek_size.Checked)
                        {
                            if (maskedTextBox_seek_size.Text != "")
                                parameters[i] = maskedTextBox_seek_size.Text;
                        }
                        break;
                    case 4:
                        if (checkBox_seek_type.Checked)
                        {
                            if (radioButton_seek_mul.Checked)
                                parameters[i] = "1";
                            else
                                parameters[i] = "2";
                        }
                        break;
                    case 5:
                        if (checkBox_seek_board.Checked)
                        {
                            if (radioButton_seek_mel.Checked)
                                parameters[i] = "1";
                            else
                                parameters[i] = "2";
                        }
                        break;
                }
            }

            Int32 k = 0;
            DB db = new DB();

            //Прототит универсального запроса
            MySqlCommand command = new MySqlCommand("SELECT * FROM `auditorium` " +
            "WHERE (`corpus` LIKE @corpus OR @corpus IS NULL)" +
            "AND (`cabinet` = @cabinet OR @cabinet IS NULL) " +
            "AND (`square` = @square OR @square IS NULL)" +
            "AND (`size` = @size OR @size IS NULL)" +
            "AND (`type` = @type OR @type IS NULL)" +
            "AND (`board` = @board OR @board IS NULL)", db.getConnection());
            command.Parameters.Add("@corpus", MySqlDbType.VarChar).Value = parameters[0];
            //command.Parameters.Add("@=", MySqlDbType.VarChar).Value = "=";
            command.Parameters.Add("@cabinet", MySqlDbType.VarChar).Value = parameters[1];
            command.Parameters.Add("@square", MySqlDbType.VarChar).Value = parameters[2];
            command.Parameters.Add("@size", MySqlDbType.VarChar).Value = parameters[3];
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = parameters[4];
            command.Parameters.Add("@board", MySqlDbType.VarChar).Value = parameters[5];

            //Поиск и сохранение подходящих строк
            db.openConnection();

            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                for (int i = 0; i < 7; i++)
                    data[data.Count - 1][i] = reader[i].ToString();
                k++;
            }

            reader.Close();
            db.closeConnection();

            //Вывод строк
            dataGridView_seek.Rows.Clear();
            textBox_seek_coincidence.Text = Convert.ToString(k);
            if (k != 0)
            {
                foreach (string[] s in data)
                    dataGridView_seek.Rows.Add(s);
                textBox_seek_error.Text = "Подходящие строки";
            }
            else
            {
                textBox_seek_error.Text = "Нет подходящих строк";
            }
        }
    }
}
