namespace praktik_8_sakharov
{
    partial class FormAutorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label_auto = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_wrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log.Location = new System.Drawing.Point(288, 136);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(301, 38);
            this.textBox_log.TabIndex = 0;
            // 
            // label_auto
            // 
            this.label_auto.AutoSize = true;
            this.label_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_auto.Location = new System.Drawing.Point(281, 71);
            this.label_auto.Name = "label_auto";
            this.label_auto.Size = new System.Drawing.Size(229, 39);
            this.label_auto.TabIndex = 1;
            this.label_auto.Text = "Авторизация";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_enter.Location = new System.Drawing.Point(346, 285);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(137, 47);
            this.btn_enter.TabIndex = 2;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pass.Location = new System.Drawing.Point(288, 180);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(301, 38);
            this.textBox_pass.TabIndex = 0;
            // 
            // label_log
            // 
            this.label_log.AutoSize = true;
            this.label_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_log.Location = new System.Drawing.Point(120, 133);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(113, 39);
            this.label_log.TabIndex = 1;
            this.label_log.Text = "Логин";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(120, 177);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(137, 39);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Пароль";
            // 
            // label_wrong
            // 
            this.label_wrong.AutoSize = true;
            this.label_wrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_wrong.ForeColor = System.Drawing.Color.Red;
            this.label_wrong.Location = new System.Drawing.Point(153, 233);
            this.label_wrong.Name = "label_wrong";
            this.label_wrong.Size = new System.Drawing.Size(551, 39);
            this.label_wrong.TabIndex = 3;
            this.label_wrong.Text = "Неправильный логин или пароль";
            this.label_wrong.Visible = false;
            // 
            // FormAutorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_wrong);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_log);
            this.Controls.Add(this.label_auto);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_log);
            this.Name = "FormAutorization";
            this.Text = "Войдите в систему...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_auto;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_wrong;
    }
}

