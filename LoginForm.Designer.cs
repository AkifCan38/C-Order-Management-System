
namespace Test
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new System.Windows.Forms.Button();
            username = new System.Windows.Forms.TextBox();
            password = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = System.Drawing.Color.CornflowerBlue;
            login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            login.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            login.ForeColor = System.Drawing.Color.White;
            login.Location = new System.Drawing.Point(103, 308);
            login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            login.Name = "login";
            login.Size = new System.Drawing.Size(252, 36);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // username
            // 
            username.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            username.Location = new System.Drawing.Point(103, 178);
            username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            username.Name = "username";
            username.PlaceholderText = "Kullanıcı Adı";
            username.Size = new System.Drawing.Size(252, 32);
            username.TabIndex = 2;
            username.KeyDown += username_KeyDown;
            // 
            // password
            // 
            password.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            password.Location = new System.Drawing.Point(103, 230);
            password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Şifre";
            password.Size = new System.Drawing.Size(252, 32);
            password.TabIndex = 3;
            password.KeyDown += password_KeyDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = OrderMS.Properties.Resources.icons8_lock_96;
            pictureBox1.Location = new System.Drawing.Point(178, 42);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(96, 96);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(password);
            panel1.Controls.Add(login);
            panel1.Controls.Add(username);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(453, 434);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Coral;
            label2.Location = new System.Drawing.Point(103, 140);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(269, 20);
            label2.TabIndex = 6;
            label2.Text = "Order Management Automation";
            // 
            // label1
            // 
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(32, 363);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(395, 40);
            label1.TabIndex = 5;
            label1.Text = "You must log in to use the Order Management System. If you don't have an account, contact an administrator.";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(453, 434);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order Management Automation";
            TopMost = true;
            FormClosing += LoginForm_FormClosing;
            Shown += Login_Shown;
            Enter += login_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

