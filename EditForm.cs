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
        //
        // Закрытие формы
        //
        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //
        // Кнопка выход
        //
        private void button_edit_exit_Click(object sender, EventArgs e)
        {
            Hide();
            SpisokForm spisokForm = new SpisokForm();
            spisokForm.Show();
        }
        //
        // Активация формы
        //
        private void EditForm_Activated(object sender, EventArgs e)
        {
            radioButton_edit_mul.Checked = true;
            radioButton_edit_mel.Checked = true;
            maskedTextBox_edit_line.Enabled = false;
            button_edit_show.Enabled = false;
        }
        //
        // Выбор режима работы
        //
        private void radioButton_edit_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_edit_delete.Checked == true)
            {
                maskedTextBox_edit_line.Enabled = true;
                groupBox_edit_data.Enabled = false;
                button_edit_show.Enabled = true;
            }
            else
            {
                maskedTextBox_edit_line.Enabled = false;
                groupBox_edit_data.Enabled = true;
                button_edit_show.Enabled = false;
            }
        }
        private void radioButton_edit_create_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_edit_delete.Checked == true)
            {
                maskedTextBox_edit_line.Enabled = true;
                groupBox_edit_data.Enabled = false;
                button_edit_show.Enabled = true;
            }
            else
            {
                maskedTextBox_edit_line.Enabled = false;
                groupBox_edit_data.Enabled = true;
                button_edit_show.Enabled = false;
            }
        }
        private void radioButton_edit_change_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_edit_change.Checked == true)
            {
                maskedTextBox_edit_line.Enabled = true;
                groupBox_edit_data.Enabled = true;
                button_edit_show.Enabled = true;
            }
        }
        //
        // Кнопка применить
        //
        private void button_edit_apply_Click(object sender, EventArgs e)
        {
            Int32 mode, type, board;
            DB db = new DB();
            //Режим работы
            if (radioButton_edit_create.Checked == true) mode = 1;
            else if (radioButton_edit_delete.Checked == true) mode = 2;
            else mode = 3;

            switch (mode)
            {
                //Добавление строки
                case 1:
                    //Проверки на полный ввод данных
                    if (inDateEmpty() == true)
                        return;
                    //Проверка на совпадения строки
                    if (isspisokExists() == true)
                        return;

                    //Занесение данных в бд 
                    if (radioButton_edit_mul.Checked == true) type = 1;
                    else type = 2;

                    if (radioButton_edit_mel.Checked == true) board = 1;
                    else board = 2;

                    MySqlCommand command1 = new MySqlCommand("INSERT INTO `spisok` (`corpus`, `cabinet`, `square`, `size`, `type`, `board`) VALUES (@corpus, @cabinet, @square, @size, @type, @board)", db.getConnection());
                    command1.Parameters.Add("@corpus", MySqlDbType.VarChar).Value = comboBox_edit_corpus.Text;
                    command1.Parameters.Add("@cabinet", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_cabinet.Text);
                    command1.Parameters.Add("@square", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_square.Text);
                    command1.Parameters.Add("@size", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_size.Text);
                    command1.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
                    command1.Parameters.Add("@board", MySqlDbType.Int32).Value = board;

                    db.openConnection();

                    if (command1.ExecuteNonQuery() == 1)
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
                    break;

                //Удаление строки
                case 2:
                    //Проверка на ввод номера
                    if (maskedTextBox_edit_line.Text == "") 
                    {
                        textBox_edit_error.Text = "Строка не выбрана";
                        return;
                    }

                    MySqlCommand command2 = new MySqlCommand("DELETE FROM `spisok` WHERE `spisok`.`id` = @id", db.getConnection());
                    command2.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_line.Text);

                    db.openConnection();

                    if (command2.ExecuteNonQuery() == 1)
                    {
                        textBox_edit_error.Text = "Строка успешно удалена";
                        comboBox_edit_corpus.SelectedIndex = -1;
                        maskedTextBox_edit_cabinet.Text = "";
                        maskedTextBox_edit_square.Text = "";
                        maskedTextBox_edit_size.Text = "";
                        maskedTextBox_edit_line.Text = "";
                    }
                    else
                    {
                        textBox_edit_error.Text = "Такой строки не существует";
                        maskedTextBox_edit_line.Text = "";
                    }

                    db.closeConnection();
                    break;

                //Изменение строки
                case 3:
                    //Проверка на ввод номера
                    if (maskedTextBox_edit_line.Text == "")
                    {
                        textBox_edit_error.Text = "Строка не выбрана";
                        return;
                    }

                    //Проверки на полный ввод данных
                    if (inDateEmpty() == true)
                        return;

                    if (radioButton_edit_mul.Checked == true) type = 1;
                    else type = 2;

                    if (radioButton_edit_mel.Checked == true) board = 1;
                    else board = 2;

                    MySqlCommand command3 = new MySqlCommand("UPDATE `spisok` SET `corpus` = @corpus, `cabinet` = @cabinet, `square` = @square, `size` = @size, `type` = @type, `board` = @board WHERE `spisok`.`id` = @id", db.getConnection());
                    command3.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_line.Text);
                    command3.Parameters.Add("@corpus", MySqlDbType.VarChar).Value = comboBox_edit_corpus.Text;
                    command3.Parameters.Add("@cabinet", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_cabinet.Text);
                    command3.Parameters.Add("@square", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_square.Text);
                    command3.Parameters.Add("@size", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_size.Text);
                    command3.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
                    command3.Parameters.Add("@board", MySqlDbType.Int32).Value = board;

                    db.openConnection();

                    if (command3.ExecuteNonQuery() == 1)
                    {
                        textBox_edit_error.Text = "Строка успешно изменена";
                        maskedTextBox_edit_line.Text = "";
                        comboBox_edit_corpus.SelectedIndex = -1;
                        maskedTextBox_edit_cabinet.Text = "";
                        maskedTextBox_edit_square.Text = "";
                        maskedTextBox_edit_size.Text = "";
                    }
                    else
                    {
                        textBox_edit_error.Text = "Такой строки не существует";
                    }

                    db.closeConnection();
                    break;

                default: break;
            }         
        }
        //
        // Кнопка просмотр
        //
        private void button_edit_show_Click(object sender, EventArgs e)
        {
            //Проверка на ввод номера
            if (maskedTextBox_edit_line.Text == "")
            {
                textBox_edit_error.Text = "Строка не выбрана";
                return;
            }

            DB db = new DB();
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `spisok` WHERE `id` = @id ORDER BY `id`", db.getConnection());
            command4.Parameters.Add("@id", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_line.Text);

            db.openConnection();
            MySqlDataReader reader = command4.ExecuteReader();

            if (reader.Read())
            {
                comboBox_edit_corpus.Text = reader[1].ToString();
                maskedTextBox_edit_cabinet.Text = reader[2].ToString();
                maskedTextBox_edit_square.Text = reader[3].ToString();
                maskedTextBox_edit_size.Text = reader[4].ToString();
                if (reader[5].ToString() == "1") radioButton_edit_mul.Checked = true;
                else radioButton_edit_nomul.Checked = true;

                if (reader[6].ToString() == "1") radioButton_edit_mel.Checked = true;
                else radioButton_edit_mark.Checked = true;
            }
            else 
            {
                textBox_edit_error.Text = "Такой строки не существует";
                return;
            }

            reader.Close();
            db.closeConnection();
        }
        //Проверки на полный ввод данных
        public Boolean inDateEmpty()
        {
            if (comboBox_edit_corpus.SelectedIndex == -1)
            {
                textBox_edit_error.Text = "Корпус не выбран";
                return true;
            }

            if (maskedTextBox_edit_cabinet.Text == "")
            {
                textBox_edit_error.Text = "Номер аудитории не задан";
                return true;
            }

            if (maskedTextBox_edit_square.Text == "")
            {
                textBox_edit_error.Text = "Площадь не задана";
                return true;
            }

            if (maskedTextBox_edit_size.Text == "")
            {
                textBox_edit_error.Text = "Количество мест не задано";
                return true;
            }

            return false;
        }

        //Проверка на совпадения строки
        public Boolean isspisokExists()
        {
            Int32 type, board;
            if (radioButton_edit_mul.Checked == true) type = 1;
            else type = 2;

            if (radioButton_edit_mel.Checked == true) board = 1;
            else board = 2;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `spisok` WHERE `corpus` = @corpus AND `cabinet` = @cabinet AND `square` = @square AND `size` = @size AND `type` = @type AND `board` = @board", db.getConnection());
            command.Parameters.Add("@corpus",MySqlDbType.VarChar).Value = comboBox_edit_corpus.Text;
            command.Parameters.Add("@cabinet", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_cabinet.Text);
            command.Parameters.Add("@square", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_square.Text);
            command.Parameters.Add("@size", MySqlDbType.Int32).Value = Convert.ToInt32(maskedTextBox_edit_size.Text);
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("board", MySqlDbType.Int32).Value = board;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                textBox_edit_error.Text = "Такая строка уже существует";
                return true;
            }

            else 
                return false;
        }
    }
}