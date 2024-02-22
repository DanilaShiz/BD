namespace Proect5
{
    partial class Register
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
            this.RegB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enterPas = new System.Windows.Forms.TextBox();
            this.enterLog = new System.Windows.Forms.TextBox();
            this.enterPas2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NA = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // RegB
            // 
            this.RegB.Location = new System.Drawing.Point(44, 198);
            this.RegB.Name = "RegB";
            this.RegB.Size = new System.Drawing.Size(94, 23);
            this.RegB.TabIndex = 0;
            this.RegB.Text = "Регистрация";
            this.RegB.UseVisualStyleBackColor = true;
            this.RegB.Click += new System.EventHandler(this.RegB_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(144, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterPas
            // 
            this.enterPas.Location = new System.Drawing.Point(44, 106);
            this.enterPas.Name = "enterPas";
            this.enterPas.Size = new System.Drawing.Size(201, 20);
            this.enterPas.TabIndex = 2;
            // 
            // enterLog
            // 
            this.enterLog.Location = new System.Drawing.Point(44, 60);
            this.enterLog.Name = "enterLog";
            this.enterLog.Size = new System.Drawing.Size(201, 20);
            this.enterLog.TabIndex = 3;
            // 
            // enterPas2
            // 
            this.enterPas2.Location = new System.Drawing.Point(44, 172);
            this.enterPas2.Name = "enterPas2";
            this.enterPas2.PasswordChar = '*';
            this.enterPas2.Size = new System.Drawing.Size(201, 20);
            this.enterPas2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Повторите пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя";
            // 
            // NA
            // 
            this.NA.Enabled = false;
            this.NA.Location = new System.Drawing.Point(44, 227);
            this.NA.Name = "NA";
            this.NA.Size = new System.Drawing.Size(201, 23);
            this.NA.TabIndex = 8;
            this.NA.Text = "New Admin";
            this.NA.UseVisualStyleBackColor = true;
            this.NA.Click += new System.EventHandler(this.NA_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(131, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(298, 281);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterPas2);
            this.Controls.Add(this.enterLog);
            this.Controls.Add(this.enterPas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RegB);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox enterPas;
        private System.Windows.Forms.TextBox enterLog;
        private System.Windows.Forms.TextBox enterPas2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NA;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}