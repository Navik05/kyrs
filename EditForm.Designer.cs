namespace kyrs
{
    partial class EditForm
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
            this.button_edit_show = new System.Windows.Forms.Button();
            this.textBox_edit_error = new System.Windows.Forms.TextBox();
            this.button_edit_exit = new System.Windows.Forms.Button();
            this.button_edit_apply = new System.Windows.Forms.Button();
            this.groupBox_edit_line = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_edit_line = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_edit_list = new System.Windows.Forms.Label();
            this.textBox_edit_list = new System.Windows.Forms.TextBox();
            this.groupBox_edit_data = new System.Windows.Forms.GroupBox();
            this.panel_edit_board = new System.Windows.Forms.Panel();
            this.label_edit_board = new System.Windows.Forms.Label();
            this.radioButton_edit_mark = new System.Windows.Forms.RadioButton();
            this.radioButton_edit_mel = new System.Windows.Forms.RadioButton();
            this.label_edit_type = new System.Windows.Forms.Label();
            this.radioButton_edit_nomul = new System.Windows.Forms.RadioButton();
            this.radioButton_edit_mul = new System.Windows.Forms.RadioButton();
            this.label_edit_size = new System.Windows.Forms.Label();
            this.maskedTextBox_edit_size = new System.Windows.Forms.MaskedTextBox();
            this.label_edit_square = new System.Windows.Forms.Label();
            this.maskedTextBox_edit_square = new System.Windows.Forms.MaskedTextBox();
            this.label_edit_auditorium = new System.Windows.Forms.Label();
            this.maskedTextBox_edit_cabinet = new System.Windows.Forms.MaskedTextBox();
            this.label_edit_corpus = new System.Windows.Forms.Label();
            this.comboBox_edit_corpus = new System.Windows.Forms.ComboBox();
            this.groupBox_edit_mode = new System.Windows.Forms.GroupBox();
            this.radioButton_edit_change = new System.Windows.Forms.RadioButton();
            this.radioButton_edit_delete = new System.Windows.Forms.RadioButton();
            this.radioButton_edit_create = new System.Windows.Forms.RadioButton();
            this.groupBox_edit_line.SuspendLayout();
            this.groupBox_edit_data.SuspendLayout();
            this.panel_edit_board.SuspendLayout();
            this.groupBox_edit_mode.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_edit_show
            // 
            this.button_edit_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_show.Location = new System.Drawing.Point(612, 225);
            this.button_edit_show.Name = "button_edit_show";
            this.button_edit_show.Size = new System.Drawing.Size(143, 48);
            this.button_edit_show.TabIndex = 13;
            this.button_edit_show.Text = "Просмотр";
            this.button_edit_show.UseVisualStyleBackColor = true;
            // 
            // textBox_edit_error
            // 
            this.textBox_edit_error.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_edit_error.Enabled = false;
            this.textBox_edit_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_edit_error.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_edit_error.Location = new System.Drawing.Point(602, 52);
            this.textBox_edit_error.Multiline = true;
            this.textBox_edit_error.Name = "textBox_edit_error";
            this.textBox_edit_error.Size = new System.Drawing.Size(398, 88);
            this.textBox_edit_error.TabIndex = 12;
            // 
            // button_edit_exit
            // 
            this.button_edit_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_exit.Location = new System.Drawing.Point(718, 301);
            this.button_edit_exit.Name = "button_edit_exit";
            this.button_edit_exit.Size = new System.Drawing.Size(143, 48);
            this.button_edit_exit.TabIndex = 11;
            this.button_edit_exit.Text = "Выход";
            this.button_edit_exit.UseVisualStyleBackColor = true;
            this.button_edit_exit.Click += new System.EventHandler(this.button_edit_exit_Click);
            // 
            // button_edit_apply
            // 
            this.button_edit_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_edit_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_edit_apply.Location = new System.Drawing.Point(826, 225);
            this.button_edit_apply.Name = "button_edit_apply";
            this.button_edit_apply.Size = new System.Drawing.Size(143, 48);
            this.button_edit_apply.TabIndex = 10;
            this.button_edit_apply.Text = "Применить";
            this.button_edit_apply.UseVisualStyleBackColor = true;
            this.button_edit_apply.Click += new System.EventHandler(this.button_edit_apply_Click);
            // 
            // groupBox_edit_line
            // 
            this.groupBox_edit_line.Controls.Add(this.maskedTextBox_edit_line);
            this.groupBox_edit_line.Controls.Add(this.label1);
            this.groupBox_edit_line.Controls.Add(this.label_edit_list);
            this.groupBox_edit_line.Controls.Add(this.textBox_edit_list);
            this.groupBox_edit_line.Location = new System.Drawing.Point(283, 4);
            this.groupBox_edit_line.Name = "groupBox_edit_line";
            this.groupBox_edit_line.Size = new System.Drawing.Size(284, 136);
            this.groupBox_edit_line.TabIndex = 9;
            this.groupBox_edit_line.TabStop = false;
            // 
            // maskedTextBox_edit_line
            // 
            this.maskedTextBox_edit_line.Location = new System.Drawing.Point(232, 89);
            this.maskedTextBox_edit_line.Mask = "00";
            this.maskedTextBox_edit_line.Name = "maskedTextBox_edit_line";
            this.maskedTextBox_edit_line.Size = new System.Drawing.Size(46, 22);
            this.maskedTextBox_edit_line.TabIndex = 9;
            this.maskedTextBox_edit_line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выбранная строка:";
            // 
            // label_edit_list
            // 
            this.label_edit_list.AutoSize = true;
            this.label_edit_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_list.Location = new System.Drawing.Point(6, 31);
            this.label_edit_list.Name = "label_edit_list";
            this.label_edit_list.Size = new System.Drawing.Size(214, 20);
            this.label_edit_list.TabIndex = 7;
            this.label_edit_list.Text = "Всего позиций в списке:";
            // 
            // textBox_edit_list
            // 
            this.textBox_edit_list.Enabled = false;
            this.textBox_edit_list.Location = new System.Drawing.Point(232, 33);
            this.textBox_edit_list.Name = "textBox_edit_list";
            this.textBox_edit_list.Size = new System.Drawing.Size(46, 22);
            this.textBox_edit_list.TabIndex = 0;
            // 
            // groupBox_edit_data
            // 
            this.groupBox_edit_data.Controls.Add(this.panel_edit_board);
            this.groupBox_edit_data.Controls.Add(this.label_edit_type);
            this.groupBox_edit_data.Controls.Add(this.radioButton_edit_nomul);
            this.groupBox_edit_data.Controls.Add(this.radioButton_edit_mul);
            this.groupBox_edit_data.Controls.Add(this.label_edit_size);
            this.groupBox_edit_data.Controls.Add(this.maskedTextBox_edit_size);
            this.groupBox_edit_data.Controls.Add(this.label_edit_square);
            this.groupBox_edit_data.Controls.Add(this.maskedTextBox_edit_square);
            this.groupBox_edit_data.Controls.Add(this.label_edit_auditorium);
            this.groupBox_edit_data.Controls.Add(this.maskedTextBox_edit_cabinet);
            this.groupBox_edit_data.Controls.Add(this.label_edit_corpus);
            this.groupBox_edit_data.Controls.Add(this.comboBox_edit_corpus);
            this.groupBox_edit_data.Location = new System.Drawing.Point(4, 158);
            this.groupBox_edit_data.Name = "groupBox_edit_data";
            this.groupBox_edit_data.Size = new System.Drawing.Size(563, 246);
            this.groupBox_edit_data.TabIndex = 8;
            this.groupBox_edit_data.TabStop = false;
            this.groupBox_edit_data.Text = "Данные";
            // 
            // panel_edit_board
            // 
            this.panel_edit_board.Controls.Add(this.label_edit_board);
            this.panel_edit_board.Controls.Add(this.radioButton_edit_mark);
            this.panel_edit_board.Controls.Add(this.radioButton_edit_mel);
            this.panel_edit_board.Location = new System.Drawing.Point(354, 124);
            this.panel_edit_board.Name = "panel_edit_board";
            this.panel_edit_board.Size = new System.Drawing.Size(190, 95);
            this.panel_edit_board.TabIndex = 13;
            // 
            // label_edit_board
            // 
            this.label_edit_board.AutoSize = true;
            this.label_edit_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_board.Location = new System.Drawing.Point(3, 15);
            this.label_edit_board.Name = "label_edit_board";
            this.label_edit_board.Size = new System.Drawing.Size(166, 18);
            this.label_edit_board.TabIndex = 15;
            this.label_edit_board.Text = "Характеристика доски";
            // 
            // radioButton_edit_mark
            // 
            this.radioButton_edit_mark.AutoSize = true;
            this.radioButton_edit_mark.Location = new System.Drawing.Point(6, 62);
            this.radioButton_edit_mark.Name = "radioButton_edit_mark";
            this.radioButton_edit_mark.Size = new System.Drawing.Size(101, 20);
            this.radioButton_edit_mark.TabIndex = 14;
            this.radioButton_edit_mark.TabStop = true;
            this.radioButton_edit_mark.Text = "Маркерная";
            this.radioButton_edit_mark.UseVisualStyleBackColor = true;
            // 
            // radioButton_edit_mel
            // 
            this.radioButton_edit_mel.AutoSize = true;
            this.radioButton_edit_mel.Location = new System.Drawing.Point(6, 36);
            this.radioButton_edit_mel.Name = "radioButton_edit_mel";
            this.radioButton_edit_mel.Size = new System.Drawing.Size(86, 20);
            this.radioButton_edit_mel.TabIndex = 13;
            this.radioButton_edit_mel.TabStop = true;
            this.radioButton_edit_mel.Text = "Меловая";
            this.radioButton_edit_mel.UseVisualStyleBackColor = true;
            // 
            // label_edit_type
            // 
            this.label_edit_type.AutoSize = true;
            this.label_edit_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_type.Location = new System.Drawing.Point(179, 139);
            this.label_edit_type.Name = "label_edit_type";
            this.label_edit_type.Size = new System.Drawing.Size(109, 18);
            this.label_edit_type.TabIndex = 12;
            this.label_edit_type.Text = "Тип аудитории";
            // 
            // radioButton_edit_nomul
            // 
            this.radioButton_edit_nomul.AutoSize = true;
            this.radioButton_edit_nomul.Location = new System.Drawing.Point(182, 186);
            this.radioButton_edit_nomul.Name = "radioButton_edit_nomul";
            this.radioButton_edit_nomul.Size = new System.Drawing.Size(53, 20);
            this.radioButton_edit_nomul.TabIndex = 11;
            this.radioButton_edit_nomul.TabStop = true;
            this.radioButton_edit_nomul.Text = "Нет";
            this.radioButton_edit_nomul.UseVisualStyleBackColor = true;
            // 
            // radioButton_edit_mul
            // 
            this.radioButton_edit_mul.AutoSize = true;
            this.radioButton_edit_mul.Location = new System.Drawing.Point(182, 160);
            this.radioButton_edit_mul.Name = "radioButton_edit_mul";
            this.radioButton_edit_mul.Size = new System.Drawing.Size(141, 20);
            this.radioButton_edit_mul.TabIndex = 10;
            this.radioButton_edit_mul.TabStop = true;
            this.radioButton_edit_mul.Text = "Мультимедийная";
            this.radioButton_edit_mul.UseVisualStyleBackColor = true;
            // 
            // label_edit_size
            // 
            this.label_edit_size.AutoSize = true;
            this.label_edit_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_size.Location = new System.Drawing.Point(16, 139);
            this.label_edit_size.Name = "label_edit_size";
            this.label_edit_size.Size = new System.Drawing.Size(130, 18);
            this.label_edit_size.TabIndex = 8;
            this.label_edit_size.Text = "Количество мест";
            // 
            // maskedTextBox_edit_size
            // 
            this.maskedTextBox_edit_size.Location = new System.Drawing.Point(38, 160);
            this.maskedTextBox_edit_size.Mask = "000";
            this.maskedTextBox_edit_size.Name = "maskedTextBox_edit_size";
            this.maskedTextBox_edit_size.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_edit_size.TabIndex = 7;
            this.maskedTextBox_edit_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_edit_size.ValidatingType = typeof(int);
            // 
            // label_edit_square
            // 
            this.label_edit_square.AutoSize = true;
            this.label_edit_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_square.Location = new System.Drawing.Point(388, 30);
            this.label_edit_square.Name = "label_edit_square";
            this.label_edit_square.Size = new System.Drawing.Size(73, 18);
            this.label_edit_square.TabIndex = 6;
            this.label_edit_square.Text = "Площадь";
            // 
            // maskedTextBox_edit_square
            // 
            this.maskedTextBox_edit_square.Location = new System.Drawing.Point(391, 53);
            this.maskedTextBox_edit_square.Mask = "000";
            this.maskedTextBox_edit_square.Name = "maskedTextBox_edit_square";
            this.maskedTextBox_edit_square.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_edit_square.TabIndex = 5;
            this.maskedTextBox_edit_square.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_edit_square.ValidatingType = typeof(int);
            // 
            // label_edit_auditorium
            // 
            this.label_edit_auditorium.AutoSize = true;
            this.label_edit_auditorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_auditorium.Location = new System.Drawing.Point(179, 30);
            this.label_edit_auditorium.Name = "label_edit_auditorium";
            this.label_edit_auditorium.Size = new System.Drawing.Size(131, 18);
            this.label_edit_auditorium.TabIndex = 4;
            this.label_edit_auditorium.Text = "Номер аудитории";
            // 
            // maskedTextBox_edit_cabinet
            // 
            this.maskedTextBox_edit_cabinet.Location = new System.Drawing.Point(203, 53);
            this.maskedTextBox_edit_cabinet.Mask = "000";
            this.maskedTextBox_edit_cabinet.Name = "maskedTextBox_edit_cabinet";
            this.maskedTextBox_edit_cabinet.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_edit_cabinet.TabIndex = 3;
            this.maskedTextBox_edit_cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_edit_cabinet.ValidatingType = typeof(int);
            // 
            // label_edit_corpus
            // 
            this.label_edit_corpus.AutoSize = true;
            this.label_edit_corpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_edit_corpus.Location = new System.Drawing.Point(47, 30);
            this.label_edit_corpus.Name = "label_edit_corpus";
            this.label_edit_corpus.Size = new System.Drawing.Size(58, 18);
            this.label_edit_corpus.TabIndex = 2;
            this.label_edit_corpus.Text = "Корпус";
            // 
            // comboBox_edit_corpus
            // 
            this.comboBox_edit_corpus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_edit_corpus.FormattingEnabled = true;
            this.comboBox_edit_corpus.Items.AddRange(new object[] {
            "А",
            "АХК",
            "Б",
            "В",
            "Г",
            "ГК",
            "Д",
            "К",
            "НК",
            "ПК",
            "УПК"});
            this.comboBox_edit_corpus.Location = new System.Drawing.Point(19, 51);
            this.comboBox_edit_corpus.Name = "comboBox_edit_corpus";
            this.comboBox_edit_corpus.Size = new System.Drawing.Size(121, 24);
            this.comboBox_edit_corpus.TabIndex = 1;
            // 
            // groupBox_edit_mode
            // 
            this.groupBox_edit_mode.AutoSize = true;
            this.groupBox_edit_mode.Controls.Add(this.radioButton_edit_change);
            this.groupBox_edit_mode.Controls.Add(this.radioButton_edit_delete);
            this.groupBox_edit_mode.Controls.Add(this.radioButton_edit_create);
            this.groupBox_edit_mode.Location = new System.Drawing.Point(4, 4);
            this.groupBox_edit_mode.Name = "groupBox_edit_mode";
            this.groupBox_edit_mode.Size = new System.Drawing.Size(260, 136);
            this.groupBox_edit_mode.TabIndex = 7;
            this.groupBox_edit_mode.TabStop = false;
            this.groupBox_edit_mode.Text = "Режим работы";
            // 
            // radioButton_edit_change
            // 
            this.radioButton_edit_change.AutoSize = true;
            this.radioButton_edit_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_edit_change.Location = new System.Drawing.Point(19, 91);
            this.radioButton_edit_change.Name = "radioButton_edit_change";
            this.radioButton_edit_change.Size = new System.Drawing.Size(235, 24);
            this.radioButton_edit_change.TabIndex = 3;
            this.radioButton_edit_change.TabStop = true;
            this.radioButton_edit_change.Text = "Редактирование строки";
            this.radioButton_edit_change.UseVisualStyleBackColor = true;
            this.radioButton_edit_change.CheckedChanged += new System.EventHandler(this.radioButton_edit_change_CheckedChanged);
            // 
            // radioButton_edit_delete
            // 
            this.radioButton_edit_delete.AutoSize = true;
            this.radioButton_edit_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_edit_delete.Location = new System.Drawing.Point(19, 61);
            this.radioButton_edit_delete.Name = "radioButton_edit_delete";
            this.radioButton_edit_delete.Size = new System.Drawing.Size(176, 24);
            this.radioButton_edit_delete.TabIndex = 2;
            this.radioButton_edit_delete.TabStop = true;
            this.radioButton_edit_delete.Text = "Удаление строки";
            this.radioButton_edit_delete.UseVisualStyleBackColor = true;
            this.radioButton_edit_delete.CheckedChanged += new System.EventHandler(this.radioButton_edit_delete_CheckedChanged);
            // 
            // radioButton_edit_create
            // 
            this.radioButton_edit_create.AutoSize = true;
            this.radioButton_edit_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton_edit_create.Location = new System.Drawing.Point(19, 31);
            this.radioButton_edit_create.Name = "radioButton_edit_create";
            this.radioButton_edit_create.Size = new System.Drawing.Size(196, 24);
            this.radioButton_edit_create.TabIndex = 1;
            this.radioButton_edit_create.TabStop = true;
            this.radioButton_edit_create.Text = "Добавление строки";
            this.radioButton_edit_create.UseVisualStyleBackColor = true;
            this.radioButton_edit_create.CheckedChanged += new System.EventHandler(this.radioButton_edit_create_CheckedChanged);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 441);
            this.Controls.Add(this.button_edit_show);
            this.Controls.Add(this.textBox_edit_error);
            this.Controls.Add(this.button_edit_exit);
            this.Controls.Add(this.button_edit_apply);
            this.Controls.Add(this.groupBox_edit_line);
            this.Controls.Add(this.groupBox_edit_data);
            this.Controls.Add(this.groupBox_edit_mode);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Activated += new System.EventHandler(this.EditForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.groupBox_edit_line.ResumeLayout(false);
            this.groupBox_edit_line.PerformLayout();
            this.groupBox_edit_data.ResumeLayout(false);
            this.groupBox_edit_data.PerformLayout();
            this.panel_edit_board.ResumeLayout(false);
            this.panel_edit_board.PerformLayout();
            this.groupBox_edit_mode.ResumeLayout(false);
            this.groupBox_edit_mode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_edit_show;
        private System.Windows.Forms.TextBox textBox_edit_error;
        private System.Windows.Forms.Button button_edit_exit;
        private System.Windows.Forms.Button button_edit_apply;
        private System.Windows.Forms.GroupBox groupBox_edit_line;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_edit_line;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_edit_list;
        private System.Windows.Forms.TextBox textBox_edit_list;
        private System.Windows.Forms.GroupBox groupBox_edit_data;
        private System.Windows.Forms.Panel panel_edit_board;
        private System.Windows.Forms.Label label_edit_board;
        private System.Windows.Forms.RadioButton radioButton_edit_mark;
        private System.Windows.Forms.RadioButton radioButton_edit_mel;
        private System.Windows.Forms.Label label_edit_type;
        private System.Windows.Forms.RadioButton radioButton_edit_nomul;
        private System.Windows.Forms.RadioButton radioButton_edit_mul;
        private System.Windows.Forms.Label label_edit_size;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_edit_size;
        private System.Windows.Forms.Label label_edit_square;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_edit_square;
        private System.Windows.Forms.Label label_edit_auditorium;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_edit_cabinet;
        private System.Windows.Forms.Label label_edit_corpus;
        private System.Windows.Forms.ComboBox comboBox_edit_corpus;
        private System.Windows.Forms.GroupBox groupBox_edit_mode;
        private System.Windows.Forms.RadioButton radioButton_edit_change;
        private System.Windows.Forms.RadioButton radioButton_edit_delete;
        private System.Windows.Forms.RadioButton radioButton_edit_create;
    }
}