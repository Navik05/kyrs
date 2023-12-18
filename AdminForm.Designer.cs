namespace kyrs
{
    partial class AdminForm
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
            this.textBox_admin = new System.Windows.Forms.TextBox();
            this.button_admin_back = new System.Windows.Forms.Button();
            this.button_admin_ok = new System.Windows.Forms.Button();
            this.label_admin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_admin
            // 
            this.textBox_admin.Location = new System.Drawing.Point(193, 167);
            this.textBox_admin.Name = "textBox_admin";
            this.textBox_admin.Size = new System.Drawing.Size(211, 22);
            this.textBox_admin.TabIndex = 7;
            // 
            // button_admin_back
            // 
            this.button_admin_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_admin_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin_back.Location = new System.Drawing.Point(338, 241);
            this.button_admin_back.Name = "button_admin_back";
            this.button_admin_back.Size = new System.Drawing.Size(131, 44);
            this.button_admin_back.TabIndex = 6;
            this.button_admin_back.Text = "Очистить";
            this.button_admin_back.UseVisualStyleBackColor = true;
            // 
            // button_admin_ok
            // 
            this.button_admin_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_admin_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_admin_ok.Location = new System.Drawing.Point(136, 241);
            this.button_admin_ok.Name = "button_admin_ok";
            this.button_admin_ok.Size = new System.Drawing.Size(125, 44);
            this.button_admin_ok.TabIndex = 5;
            this.button_admin_ok.Text = "ОК";
            this.button_admin_ok.UseVisualStyleBackColor = true;
            // 
            // label_admin
            // 
            this.label_admin.AutoSize = true;
            this.label_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_admin.Location = new System.Drawing.Point(168, 81);
            this.label_admin.Name = "label_admin";
            this.label_admin.Size = new System.Drawing.Size(262, 38);
            this.label_admin.TabIndex = 4;
            this.label_admin.Text = "Введите пароль";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 415);
            this.Controls.Add(this.textBox_admin);
            this.Controls.Add(this.button_admin_back);
            this.Controls.Add(this.button_admin_ok);
            this.Controls.Add(this.label_admin);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_admin;
        private System.Windows.Forms.Button button_admin_back;
        private System.Windows.Forms.Button button_admin_ok;
        private System.Windows.Forms.Label label_admin;
    }
}