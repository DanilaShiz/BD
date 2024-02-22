namespace Proect5
{
    partial class Login
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
            this.AutB = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enterPas = new System.Windows.Forms.TextBox();
            this.enterLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AutB
            // 
            this.AutB.Location = new System.Drawing.Point(29, 154);
            this.AutB.Name = "AutB";
            this.AutB.Size = new System.Drawing.Size(112, 23);
            this.AutB.TabIndex = 0;
            this.AutB.Text = "Авторизироваться";
            this.AutB.UseVisualStyleBackColor = true;
            this.AutB.Click += new System.EventHandler(this.AutB_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enterPas
            // 
            this.enterPas.Location = new System.Drawing.Point(29, 113);
            this.enterPas.Name = "enterPas";
            this.enterPas.PasswordChar = '*';
            this.enterPas.Size = new System.Drawing.Size(185, 20);
            this.enterPas.TabIndex = 2;
            // 
            // enterLog
            // 
            this.enterLog.Location = new System.Drawing.Point(29, 50);
            this.enterLog.Name = "enterLog";
            this.enterLog.Size = new System.Drawing.Size(185, 20);
            this.enterLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(29, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Войти как гость";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(254, 241);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterLog);
            this.Controls.Add(this.enterPas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AutB);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AutB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox enterPas;
        private System.Windows.Forms.TextBox enterLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}