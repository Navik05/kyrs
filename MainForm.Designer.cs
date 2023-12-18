namespace kyrs
{
    partial class MainForm
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
            this.button_main_adminexit = new System.Windows.Forms.Button();
            this.button_main_admin = new System.Windows.Forms.Button();
            this.button_main_exit = new System.Windows.Forms.Button();
            this.button_main_game = new System.Windows.Forms.Button();
            this.button_main_spisok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_main_adminexit
            // 
            this.button_main_adminexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_adminexit.Location = new System.Drawing.Point(777, 87);
            this.button_main_adminexit.Name = "button_main_adminexit";
            this.button_main_adminexit.Size = new System.Drawing.Size(167, 42);
            this.button_main_adminexit.TabIndex = 10;
            this.button_main_adminexit.Text = "Выход из режима";
            this.button_main_adminexit.UseVisualStyleBackColor = true;
            // 
            // button_main_admin
            // 
            this.button_main_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_admin.Location = new System.Drawing.Point(630, 12);
            this.button_main_admin.Name = "button_main_admin";
            this.button_main_admin.Size = new System.Drawing.Size(314, 69);
            this.button_main_admin.TabIndex = 9;
            this.button_main_admin.Text = "Режим администратора";
            this.button_main_admin.UseVisualStyleBackColor = true;
            // 
            // button_main_exit
            // 
            this.button_main_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_exit.Location = new System.Drawing.Point(180, 378);
            this.button_main_exit.Name = "button_main_exit";
            this.button_main_exit.Size = new System.Drawing.Size(432, 82);
            this.button_main_exit.TabIndex = 8;
            this.button_main_exit.Text = "Выход из программы";
            this.button_main_exit.UseVisualStyleBackColor = true;
            // 
            // button_main_game
            // 
            this.button_main_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_game.Location = new System.Drawing.Point(180, 258);
            this.button_main_game.Name = "button_main_game";
            this.button_main_game.Size = new System.Drawing.Size(432, 82);
            this.button_main_game.TabIndex = 7;
            this.button_main_game.Text = "Игра \"Города России\"";
            this.button_main_game.UseVisualStyleBackColor = true;
            // 
            // button_main_spisok
            // 
            this.button_main_spisok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_spisok.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_spisok.Location = new System.Drawing.Point(180, 146);
            this.button_main_spisok.Name = "button_main_spisok";
            this.button_main_spisok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_main_spisok.Size = new System.Drawing.Size(432, 82);
            this.button_main_spisok.TabIndex = 6;
            this.button_main_spisok.Text = "Работа со списком";
            this.button_main_spisok.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 581);
            this.Controls.Add(this.button_main_adminexit);
            this.Controls.Add(this.button_main_admin);
            this.Controls.Add(this.button_main_exit);
            this.Controls.Add(this.button_main_game);
            this.Controls.Add(this.button_main_spisok);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_main_adminexit;
        private System.Windows.Forms.Button button_main_admin;
        private System.Windows.Forms.Button button_main_exit;
        private System.Windows.Forms.Button button_main_game;
        private System.Windows.Forms.Button button_main_spisok;
    }
}