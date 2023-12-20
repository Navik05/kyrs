namespace kyrs
{
    partial class SeekForm
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
            this.button_seek_apply = new System.Windows.Forms.Button();
            this.button_seek_exit = new System.Windows.Forms.Button();
            this.textBox_seek_error = new System.Windows.Forms.TextBox();
            this.dataGridView_seek = new System.Windows.Forms.DataGridView();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_corpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTextBox_seek_size = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_seek_square = new System.Windows.Forms.MaskedTextBox();
            this.groupBox_seek_exact = new System.Windows.Forms.GroupBox();
            this.panel_seek_type = new System.Windows.Forms.Panel();
            this.radioButton_seek_nomul = new System.Windows.Forms.RadioButton();
            this.label_seek_type = new System.Windows.Forms.Label();
            this.radioButton_seek_mul = new System.Windows.Forms.RadioButton();
            this.label_seek_auditorium = new System.Windows.Forms.Label();
            this.maskedTextBox_seek_cabinet = new System.Windows.Forms.MaskedTextBox();
            this.panel_seek_board = new System.Windows.Forms.Panel();
            this.radioButton_seek_mark = new System.Windows.Forms.RadioButton();
            this.label_seek_board = new System.Windows.Forms.Label();
            this.radioButton_seek_mel = new System.Windows.Forms.RadioButton();
            this.label_seek_corpus = new System.Windows.Forms.Label();
            this.comboBox_seek_corpus = new System.Windows.Forms.ComboBox();
            this.groupBox_seek_choice = new System.Windows.Forms.GroupBox();
            this.checkBox_seek_size = new System.Windows.Forms.CheckBox();
            this.checkBox_seek_board = new System.Windows.Forms.CheckBox();
            this.checkBox_seek_cabinet = new System.Windows.Forms.CheckBox();
            this.checkBox_seek_type = new System.Windows.Forms.CheckBox();
            this.checkBox_seek_corpus = new System.Windows.Forms.CheckBox();
            this.checkBox_seek_square = new System.Windows.Forms.CheckBox();
            this.groupBox_seek_line = new System.Windows.Forms.GroupBox();
            this.textBox_seek_coincidence = new System.Windows.Forms.TextBox();
            this.label_seek_coincidence = new System.Windows.Forms.Label();
            this.groupBox_seek_size = new System.Windows.Forms.GroupBox();
            this.groupBox_seek_square = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seek)).BeginInit();
            this.groupBox_seek_exact.SuspendLayout();
            this.panel_seek_type.SuspendLayout();
            this.panel_seek_board.SuspendLayout();
            this.groupBox_seek_choice.SuspendLayout();
            this.groupBox_seek_line.SuspendLayout();
            this.groupBox_seek_size.SuspendLayout();
            this.groupBox_seek_square.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_seek_apply
            // 
            this.button_seek_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_seek_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_seek_apply.Location = new System.Drawing.Point(561, 211);
            this.button_seek_apply.Name = "button_seek_apply";
            this.button_seek_apply.Size = new System.Drawing.Size(143, 48);
            this.button_seek_apply.TabIndex = 21;
            this.button_seek_apply.Text = "Применить";
            this.button_seek_apply.UseVisualStyleBackColor = true;
            this.button_seek_apply.Click += new System.EventHandler(this.button_seek_apply_Click);
            // 
            // button_seek_exit
            // 
            this.button_seek_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_seek_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_seek_exit.Location = new System.Drawing.Point(561, 294);
            this.button_seek_exit.Name = "button_seek_exit";
            this.button_seek_exit.Size = new System.Drawing.Size(143, 48);
            this.button_seek_exit.TabIndex = 20;
            this.button_seek_exit.Text = "Выход";
            this.button_seek_exit.UseVisualStyleBackColor = true;
            this.button_seek_exit.Click += new System.EventHandler(this.button_seek_exit_Click);
            // 
            // textBox_seek_error
            // 
            this.textBox_seek_error.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_seek_error.Enabled = false;
            this.textBox_seek_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_seek_error.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_seek_error.Location = new System.Drawing.Point(453, 114);
            this.textBox_seek_error.Multiline = true;
            this.textBox_seek_error.Name = "textBox_seek_error";
            this.textBox_seek_error.Size = new System.Drawing.Size(398, 49);
            this.textBox_seek_error.TabIndex = 19;
            // 
            // dataGridView_seek
            // 
            this.dataGridView_seek.AllowUserToAddRows = false;
            this.dataGridView_seek.AllowUserToDeleteRows = false;
            this.dataGridView_seek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_seek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_corpus,
            this.Column_cabinet,
            this.Column_square,
            this.Column_size,
            this.Column_type,
            this.Column_board});
            this.dataGridView_seek.Location = new System.Drawing.Point(12, 397);
            this.dataGridView_seek.Name = "dataGridView_seek";
            this.dataGridView_seek.ReadOnly = true;
            this.dataGridView_seek.RowHeadersVisible = false;
            this.dataGridView_seek.RowHeadersWidth = 51;
            this.dataGridView_seek.RowTemplate.Height = 24;
            this.dataGridView_seek.Size = new System.Drawing.Size(860, 181);
            this.dataGridView_seek.TabIndex = 18;
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "№";
            this.Column_id.MinimumWidth = 6;
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            this.Column_id.Width = 25;
            // 
            // Column_corpus
            // 
            this.Column_corpus.HeaderText = "Корпус";
            this.Column_corpus.MinimumWidth = 6;
            this.Column_corpus.Name = "Column_corpus";
            this.Column_corpus.ReadOnly = true;
            this.Column_corpus.Width = 125;
            // 
            // Column_cabinet
            // 
            this.Column_cabinet.HeaderText = "Номер аудитории";
            this.Column_cabinet.MinimumWidth = 6;
            this.Column_cabinet.Name = "Column_cabinet";
            this.Column_cabinet.ReadOnly = true;
            this.Column_cabinet.Width = 125;
            // 
            // Column_square
            // 
            this.Column_square.HeaderText = "Площадь";
            this.Column_square.MinimumWidth = 6;
            this.Column_square.Name = "Column_square";
            this.Column_square.ReadOnly = true;
            this.Column_square.Width = 125;
            // 
            // Column_size
            // 
            this.Column_size.HeaderText = "Количество мест";
            this.Column_size.MinimumWidth = 6;
            this.Column_size.Name = "Column_size";
            this.Column_size.ReadOnly = true;
            this.Column_size.Width = 125;
            // 
            // Column_type
            // 
            this.Column_type.HeaderText = "Тип";
            this.Column_type.MinimumWidth = 6;
            this.Column_type.Name = "Column_type";
            this.Column_type.ReadOnly = true;
            this.Column_type.Width = 125;
            // 
            // Column_board
            // 
            this.Column_board.HeaderText = "Характеристика доски";
            this.Column_board.MinimumWidth = 6;
            this.Column_board.Name = "Column_board";
            this.Column_board.ReadOnly = true;
            this.Column_board.Width = 125;
            // 
            // maskedTextBox_seek_size
            // 
            this.maskedTextBox_seek_size.Location = new System.Drawing.Point(58, 31);
            this.maskedTextBox_seek_size.Mask = "000";
            this.maskedTextBox_seek_size.Name = "maskedTextBox_seek_size";
            this.maskedTextBox_seek_size.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_seek_size.TabIndex = 9;
            this.maskedTextBox_seek_size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_seek_size.ValidatingType = typeof(int);
            // 
            // maskedTextBox_seek_square
            // 
            this.maskedTextBox_seek_square.Location = new System.Drawing.Point(44, 31);
            this.maskedTextBox_seek_square.Mask = "000";
            this.maskedTextBox_seek_square.Name = "maskedTextBox_seek_square";
            this.maskedTextBox_seek_square.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_seek_square.TabIndex = 6;
            this.maskedTextBox_seek_square.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_seek_square.ValidatingType = typeof(int);
            // 
            // groupBox_seek_exact
            // 
            this.groupBox_seek_exact.Controls.Add(this.panel_seek_type);
            this.groupBox_seek_exact.Controls.Add(this.label_seek_auditorium);
            this.groupBox_seek_exact.Controls.Add(this.maskedTextBox_seek_cabinet);
            this.groupBox_seek_exact.Controls.Add(this.panel_seek_board);
            this.groupBox_seek_exact.Controls.Add(this.label_seek_corpus);
            this.groupBox_seek_exact.Controls.Add(this.comboBox_seek_corpus);
            this.groupBox_seek_exact.Location = new System.Drawing.Point(12, 114);
            this.groupBox_seek_exact.Name = "groupBox_seek_exact";
            this.groupBox_seek_exact.Size = new System.Drawing.Size(395, 184);
            this.groupBox_seek_exact.TabIndex = 15;
            this.groupBox_seek_exact.TabStop = false;
            this.groupBox_seek_exact.Text = "Поиск точного совпадения";
            // 
            // panel_seek_type
            // 
            this.panel_seek_type.Controls.Add(this.radioButton_seek_nomul);
            this.panel_seek_type.Controls.Add(this.label_seek_type);
            this.panel_seek_type.Controls.Add(this.radioButton_seek_mul);
            this.panel_seek_type.Location = new System.Drawing.Point(10, 84);
            this.panel_seek_type.Name = "panel_seek_type";
            this.panel_seek_type.Size = new System.Drawing.Size(167, 84);
            this.panel_seek_type.TabIndex = 18;
            // 
            // radioButton_seek_nomul
            // 
            this.radioButton_seek_nomul.AutoSize = true;
            this.radioButton_seek_nomul.Location = new System.Drawing.Point(6, 60);
            this.radioButton_seek_nomul.Name = "radioButton_seek_nomul";
            this.radioButton_seek_nomul.Size = new System.Drawing.Size(53, 20);
            this.radioButton_seek_nomul.TabIndex = 15;
            this.radioButton_seek_nomul.TabStop = true;
            this.radioButton_seek_nomul.Text = "Нет";
            this.radioButton_seek_nomul.UseVisualStyleBackColor = true;
            // 
            // label_seek_type
            // 
            this.label_seek_type.AutoSize = true;
            this.label_seek_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seek_type.Location = new System.Drawing.Point(3, 13);
            this.label_seek_type.Name = "label_seek_type";
            this.label_seek_type.Size = new System.Drawing.Size(109, 18);
            this.label_seek_type.TabIndex = 16;
            this.label_seek_type.Text = "Тип аудитории";
            // 
            // radioButton_seek_mul
            // 
            this.radioButton_seek_mul.AutoSize = true;
            this.radioButton_seek_mul.Location = new System.Drawing.Point(6, 34);
            this.radioButton_seek_mul.Name = "radioButton_seek_mul";
            this.radioButton_seek_mul.Size = new System.Drawing.Size(141, 20);
            this.radioButton_seek_mul.TabIndex = 14;
            this.radioButton_seek_mul.TabStop = true;
            this.radioButton_seek_mul.Text = "Мультимедийная";
            this.radioButton_seek_mul.UseVisualStyleBackColor = true;
            // 
            // label_seek_auditorium
            // 
            this.label_seek_auditorium.AutoSize = true;
            this.label_seek_auditorium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seek_auditorium.Location = new System.Drawing.Point(233, 31);
            this.label_seek_auditorium.Name = "label_seek_auditorium";
            this.label_seek_auditorium.Size = new System.Drawing.Size(131, 18);
            this.label_seek_auditorium.TabIndex = 8;
            this.label_seek_auditorium.Text = "Номер аудитории";
            // 
            // maskedTextBox_seek_cabinet
            // 
            this.maskedTextBox_seek_cabinet.Location = new System.Drawing.Point(252, 56);
            this.maskedTextBox_seek_cabinet.Mask = "000";
            this.maskedTextBox_seek_cabinet.Name = "maskedTextBox_seek_cabinet";
            this.maskedTextBox_seek_cabinet.Size = new System.Drawing.Size(80, 22);
            this.maskedTextBox_seek_cabinet.TabIndex = 7;
            this.maskedTextBox_seek_cabinet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_seek_cabinet.ValidatingType = typeof(int);
            // 
            // panel_seek_board
            // 
            this.panel_seek_board.Controls.Add(this.radioButton_seek_mark);
            this.panel_seek_board.Controls.Add(this.label_seek_board);
            this.panel_seek_board.Controls.Add(this.radioButton_seek_mel);
            this.panel_seek_board.Location = new System.Drawing.Point(194, 84);
            this.panel_seek_board.Name = "panel_seek_board";
            this.panel_seek_board.Size = new System.Drawing.Size(182, 84);
            this.panel_seek_board.TabIndex = 17;
            // 
            // radioButton_seek_mark
            // 
            this.radioButton_seek_mark.AutoSize = true;
            this.radioButton_seek_mark.Location = new System.Drawing.Point(6, 60);
            this.radioButton_seek_mark.Name = "radioButton_seek_mark";
            this.radioButton_seek_mark.Size = new System.Drawing.Size(101, 20);
            this.radioButton_seek_mark.TabIndex = 14;
            this.radioButton_seek_mark.TabStop = true;
            this.radioButton_seek_mark.Text = "Маркерная";
            this.radioButton_seek_mark.UseVisualStyleBackColor = true;
            // 
            // label_seek_board
            // 
            this.label_seek_board.AutoSize = true;
            this.label_seek_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seek_board.Location = new System.Drawing.Point(3, 13);
            this.label_seek_board.Name = "label_seek_board";
            this.label_seek_board.Size = new System.Drawing.Size(166, 18);
            this.label_seek_board.TabIndex = 15;
            this.label_seek_board.Text = "Характеристика доски";
            // 
            // radioButton_seek_mel
            // 
            this.radioButton_seek_mel.AutoSize = true;
            this.radioButton_seek_mel.Location = new System.Drawing.Point(6, 34);
            this.radioButton_seek_mel.Name = "radioButton_seek_mel";
            this.radioButton_seek_mel.Size = new System.Drawing.Size(86, 20);
            this.radioButton_seek_mel.TabIndex = 13;
            this.radioButton_seek_mel.TabStop = true;
            this.radioButton_seek_mel.Text = "Меловая";
            this.radioButton_seek_mel.UseVisualStyleBackColor = true;
            // 
            // label_seek_corpus
            // 
            this.label_seek_corpus.AutoSize = true;
            this.label_seek_corpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seek_corpus.Location = new System.Drawing.Point(66, 31);
            this.label_seek_corpus.Name = "label_seek_corpus";
            this.label_seek_corpus.Size = new System.Drawing.Size(58, 18);
            this.label_seek_corpus.TabIndex = 6;
            this.label_seek_corpus.Text = "Корпус";
            // 
            // comboBox_seek_corpus
            // 
            this.comboBox_seek_corpus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_seek_corpus.FormattingEnabled = true;
            this.comboBox_seek_corpus.Items.AddRange(new object[] {
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
            this.comboBox_seek_corpus.Location = new System.Drawing.Point(34, 54);
            this.comboBox_seek_corpus.Name = "comboBox_seek_corpus";
            this.comboBox_seek_corpus.Size = new System.Drawing.Size(121, 24);
            this.comboBox_seek_corpus.TabIndex = 5;
            // 
            // groupBox_seek_choice
            // 
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_size);
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_board);
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_cabinet);
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_type);
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_corpus);
            this.groupBox_seek_choice.Controls.Add(this.checkBox_seek_square);
            this.groupBox_seek_choice.Location = new System.Drawing.Point(307, 12);
            this.groupBox_seek_choice.Name = "groupBox_seek_choice";
            this.groupBox_seek_choice.Size = new System.Drawing.Size(544, 87);
            this.groupBox_seek_choice.TabIndex = 14;
            this.groupBox_seek_choice.TabStop = false;
            this.groupBox_seek_choice.Text = "Искать :";
            // 
            // checkBox_seek_size
            // 
            this.checkBox_seek_size.AutoSize = true;
            this.checkBox_seek_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_size.Location = new System.Drawing.Point(309, 21);
            this.checkBox_seek_size.Name = "checkBox_seek_size";
            this.checkBox_seek_size.Size = new System.Drawing.Size(145, 24);
            this.checkBox_seek_size.TabIndex = 3;
            this.checkBox_seek_size.Text = "Вместимость";
            this.checkBox_seek_size.UseVisualStyleBackColor = true;
            this.checkBox_seek_size.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // checkBox_seek_board
            // 
            this.checkBox_seek_board.AutoSize = true;
            this.checkBox_seek_board.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_board.Location = new System.Drawing.Point(309, 51);
            this.checkBox_seek_board.Name = "checkBox_seek_board";
            this.checkBox_seek_board.Size = new System.Drawing.Size(223, 24);
            this.checkBox_seek_board.TabIndex = 5;
            this.checkBox_seek_board.Text = "Характеристику доски";
            this.checkBox_seek_board.UseVisualStyleBackColor = true;
            this.checkBox_seek_board.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // checkBox_seek_cabinet
            // 
            this.checkBox_seek_cabinet.AutoSize = true;
            this.checkBox_seek_cabinet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_cabinet.Location = new System.Drawing.Point(122, 21);
            this.checkBox_seek_cabinet.Name = "checkBox_seek_cabinet";
            this.checkBox_seek_cabinet.Size = new System.Drawing.Size(181, 24);
            this.checkBox_seek_cabinet.TabIndex = 1;
            this.checkBox_seek_cabinet.Text = "Номер аудитории";
            this.checkBox_seek_cabinet.UseVisualStyleBackColor = true;
            this.checkBox_seek_cabinet.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // checkBox_seek_type
            // 
            this.checkBox_seek_type.AutoSize = true;
            this.checkBox_seek_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_type.Location = new System.Drawing.Point(122, 51);
            this.checkBox_seek_type.Name = "checkBox_seek_type";
            this.checkBox_seek_type.Size = new System.Drawing.Size(156, 24);
            this.checkBox_seek_type.TabIndex = 4;
            this.checkBox_seek_type.Text = "Тип аудитории";
            this.checkBox_seek_type.UseVisualStyleBackColor = true;
            this.checkBox_seek_type.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // checkBox_seek_corpus
            // 
            this.checkBox_seek_corpus.AutoSize = true;
            this.checkBox_seek_corpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_corpus.Location = new System.Drawing.Point(11, 21);
            this.checkBox_seek_corpus.Name = "checkBox_seek_corpus";
            this.checkBox_seek_corpus.Size = new System.Drawing.Size(89, 24);
            this.checkBox_seek_corpus.TabIndex = 0;
            this.checkBox_seek_corpus.Text = "Корпус";
            this.checkBox_seek_corpus.UseVisualStyleBackColor = true;
            this.checkBox_seek_corpus.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // checkBox_seek_square
            // 
            this.checkBox_seek_square.AutoSize = true;
            this.checkBox_seek_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_seek_square.Location = new System.Drawing.Point(11, 51);
            this.checkBox_seek_square.Name = "checkBox_seek_square";
            this.checkBox_seek_square.Size = new System.Drawing.Size(110, 24);
            this.checkBox_seek_square.TabIndex = 2;
            this.checkBox_seek_square.Text = "Площадь";
            this.checkBox_seek_square.UseVisualStyleBackColor = true;
            this.checkBox_seek_square.CheckedChanged += new System.EventHandler(this.checkBox_seek_corpus_CheckedChanged);
            // 
            // groupBox_seek_line
            // 
            this.groupBox_seek_line.Controls.Add(this.textBox_seek_coincidence);
            this.groupBox_seek_line.Controls.Add(this.label_seek_coincidence);
            this.groupBox_seek_line.Location = new System.Drawing.Point(12, 12);
            this.groupBox_seek_line.Name = "groupBox_seek_line";
            this.groupBox_seek_line.Size = new System.Drawing.Size(289, 87);
            this.groupBox_seek_line.TabIndex = 13;
            this.groupBox_seek_line.TabStop = false;
            // 
            // textBox_seek_coincidence
            // 
            this.textBox_seek_coincidence.Enabled = false;
            this.textBox_seek_coincidence.Location = new System.Drawing.Point(235, 34);
            this.textBox_seek_coincidence.Name = "textBox_seek_coincidence";
            this.textBox_seek_coincidence.Size = new System.Drawing.Size(46, 22);
            this.textBox_seek_coincidence.TabIndex = 9;
            // 
            // label_seek_coincidence
            // 
            this.label_seek_coincidence.AutoSize = true;
            this.label_seek_coincidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_seek_coincidence.Location = new System.Drawing.Point(2, 34);
            this.label_seek_coincidence.Name = "label_seek_coincidence";
            this.label_seek_coincidence.Size = new System.Drawing.Size(118, 20);
            this.label_seek_coincidence.TabIndex = 8;
            this.label_seek_coincidence.Text = "Совпадений:";
            // 
            // groupBox_seek_size
            // 
            this.groupBox_seek_size.Controls.Add(this.maskedTextBox_seek_size);
            this.groupBox_seek_size.Location = new System.Drawing.Point(206, 304);
            this.groupBox_seek_size.Name = "groupBox_seek_size";
            this.groupBox_seek_size.Size = new System.Drawing.Size(201, 78);
            this.groupBox_seek_size.TabIndex = 17;
            this.groupBox_seek_size.TabStop = false;
            this.groupBox_seek_size.Text = "Вместимость";
            // 
            // groupBox_seek_square
            // 
            this.groupBox_seek_square.Controls.Add(this.maskedTextBox_seek_square);
            this.groupBox_seek_square.Location = new System.Drawing.Point(12, 304);
            this.groupBox_seek_square.Name = "groupBox_seek_square";
            this.groupBox_seek_square.Size = new System.Drawing.Size(177, 78);
            this.groupBox_seek_square.TabIndex = 16;
            this.groupBox_seek_square.TabStop = false;
            this.groupBox_seek_square.Text = "Площадь";
            // 
            // SeekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 578);
            this.Controls.Add(this.button_seek_apply);
            this.Controls.Add(this.button_seek_exit);
            this.Controls.Add(this.textBox_seek_error);
            this.Controls.Add(this.dataGridView_seek);
            this.Controls.Add(this.groupBox_seek_size);
            this.Controls.Add(this.groupBox_seek_square);
            this.Controls.Add(this.groupBox_seek_exact);
            this.Controls.Add(this.groupBox_seek_choice);
            this.Controls.Add(this.groupBox_seek_line);
            this.Name = "SeekForm";
            this.Text = "SeekForm";
            this.Activated += new System.EventHandler(this.SeekForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeekForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_seek)).EndInit();
            this.groupBox_seek_exact.ResumeLayout(false);
            this.groupBox_seek_exact.PerformLayout();
            this.panel_seek_type.ResumeLayout(false);
            this.panel_seek_type.PerformLayout();
            this.panel_seek_board.ResumeLayout(false);
            this.panel_seek_board.PerformLayout();
            this.groupBox_seek_choice.ResumeLayout(false);
            this.groupBox_seek_choice.PerformLayout();
            this.groupBox_seek_line.ResumeLayout(false);
            this.groupBox_seek_line.PerformLayout();
            this.groupBox_seek_size.ResumeLayout(false);
            this.groupBox_seek_size.PerformLayout();
            this.groupBox_seek_square.ResumeLayout(false);
            this.groupBox_seek_square.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_seek_apply;
        private System.Windows.Forms.Button button_seek_exit;
        private System.Windows.Forms.TextBox textBox_seek_error;
        private System.Windows.Forms.DataGridView dataGridView_seek;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_seek_size;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_seek_square;
        private System.Windows.Forms.GroupBox groupBox_seek_exact;
        private System.Windows.Forms.Panel panel_seek_type;
        private System.Windows.Forms.RadioButton radioButton_seek_nomul;
        private System.Windows.Forms.Label label_seek_type;
        private System.Windows.Forms.RadioButton radioButton_seek_mul;
        private System.Windows.Forms.Label label_seek_auditorium;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_seek_cabinet;
        private System.Windows.Forms.Panel panel_seek_board;
        private System.Windows.Forms.RadioButton radioButton_seek_mark;
        private System.Windows.Forms.Label label_seek_board;
        private System.Windows.Forms.RadioButton radioButton_seek_mel;
        private System.Windows.Forms.Label label_seek_corpus;
        private System.Windows.Forms.ComboBox comboBox_seek_corpus;
        private System.Windows.Forms.GroupBox groupBox_seek_choice;
        private System.Windows.Forms.CheckBox checkBox_seek_size;
        private System.Windows.Forms.CheckBox checkBox_seek_board;
        private System.Windows.Forms.CheckBox checkBox_seek_cabinet;
        private System.Windows.Forms.CheckBox checkBox_seek_type;
        private System.Windows.Forms.CheckBox checkBox_seek_corpus;
        private System.Windows.Forms.CheckBox checkBox_seek_square;
        private System.Windows.Forms.GroupBox groupBox_seek_line;
        private System.Windows.Forms.TextBox textBox_seek_coincidence;
        private System.Windows.Forms.Label label_seek_coincidence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_corpus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_square;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_board;
        private System.Windows.Forms.GroupBox groupBox_seek_size;
        private System.Windows.Forms.GroupBox groupBox_seek_square;
    }
}