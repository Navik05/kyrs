namespace kyrs
{
    partial class SpisokForm
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
            this.dataGridView_spisok = new System.Windows.Forms.DataGridView();
            this.Column_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_corpus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_spisok = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_spisok_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_spisok_search = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_spisok_game = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_spisok_main = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_spisok)).BeginInit();
            this.menuStrip_spisok.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_spisok
            // 
            this.dataGridView_spisok.AllowUserToAddRows = false;
            this.dataGridView_spisok.AllowUserToDeleteRows = false;
            this.dataGridView_spisok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_spisok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_num,
            this.Column_corpus,
            this.Column_cabinet,
            this.Column_square,
            this.Column_size,
            this.Column_type,
            this.Column_board});
            this.dataGridView_spisok.Location = new System.Drawing.Point(1, 33);
            this.dataGridView_spisok.Name = "dataGridView_spisok";
            this.dataGridView_spisok.ReadOnly = true;
            this.dataGridView_spisok.RowHeadersVisible = false;
            this.dataGridView_spisok.RowHeadersWidth = 51;
            this.dataGridView_spisok.RowTemplate.Height = 24;
            this.dataGridView_spisok.Size = new System.Drawing.Size(1010, 514);
            this.dataGridView_spisok.TabIndex = 2;
            // 
            // Column_num
            // 
            this.Column_num.HeaderText = "№";
            this.Column_num.MinimumWidth = 6;
            this.Column_num.Name = "Column_num";
            this.Column_num.ReadOnly = true;
            this.Column_num.Width = 25;
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
            // menuStrip_spisok
            // 
            this.menuStrip_spisok.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_spisok.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_spisok_edit,
            this.ToolStripMenuItem_spisok_search,
            this.ToolStripMenuItem_spisok_game,
            this.ToolStripMenuItem_spisok_main});
            this.menuStrip_spisok.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_spisok.Name = "menuStrip_spisok";
            this.menuStrip_spisok.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip_spisok.TabIndex = 3;
            // 
            // ToolStripMenuItem_spisok_edit
            // 
            this.ToolStripMenuItem_spisok_edit.Name = "ToolStripMenuItem_spisok_edit";
            this.ToolStripMenuItem_spisok_edit.Size = new System.Drawing.Size(188, 24);
            this.ToolStripMenuItem_spisok_edit.Text = "Редактирование списка";
            // 
            // ToolStripMenuItem_spisok_search
            // 
            this.ToolStripMenuItem_spisok_search.Name = "ToolStripMenuItem_spisok_search";
            this.ToolStripMenuItem_spisok_search.Size = new System.Drawing.Size(73, 24);
            this.ToolStripMenuItem_spisok_search.Text = "Запрос";
            // 
            // ToolStripMenuItem_spisok_game
            // 
            this.ToolStripMenuItem_spisok_game.Name = "ToolStripMenuItem_spisok_game";
            this.ToolStripMenuItem_spisok_game.Size = new System.Drawing.Size(176, 24);
            this.ToolStripMenuItem_spisok_game.Text = "Игра \"Города России\"";
            // 
            // ToolStripMenuItem_spisok_main
            // 
            this.ToolStripMenuItem_spisok_main.Name = "ToolStripMenuItem_spisok_main";
            this.ToolStripMenuItem_spisok_main.Size = new System.Drawing.Size(183, 24);
            this.ToolStripMenuItem_spisok_main.Text = "Выход в главное меню";
            // 
            // SpisokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 570);
            this.Controls.Add(this.menuStrip_spisok);
            this.Controls.Add(this.dataGridView_spisok);
            this.Name = "SpisokForm";
            this.Text = "Аудиторный фонд";
            this.Activated += new System.EventHandler(this.SpisokForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_spisok)).EndInit();
            this.menuStrip_spisok.ResumeLayout(false);
            this.menuStrip_spisok.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_spisok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_corpus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_square;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_board;
        private System.Windows.Forms.MenuStrip menuStrip_spisok;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_spisok_edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_spisok_search;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_spisok_game;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_spisok_main;
    }
}