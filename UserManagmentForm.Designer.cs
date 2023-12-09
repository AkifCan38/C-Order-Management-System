
namespace OrderMS {
  partial class UserManagmentForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagmentForm));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            UsersTable = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            PasswordInput = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            isAdminCB = new System.Windows.Forms.CheckBox();
            UsernameInput = new System.Windows.Forms.TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersTable).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            tableLayoutPanel1.Size = new System.Drawing.Size(790, 241);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(424, 37);
            label1.TabIndex = 0;
            label1.Text = "User Management";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(UsersTable);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 66);
            panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(424, 173);
            panel1.TabIndex = 1;
            // 
            // UsersTable
            // 
            UsersTable.AllowUserToAddRows = false;
            UsersTable.AllowUserToDeleteRows = false;
            UsersTable.AllowUserToOrderColumns = true;
            UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            UsersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            UsersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            UsersTable.Location = new System.Drawing.Point(0, 0);
            UsersTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UsersTable.Name = "UsersTable";
            UsersTable.ReadOnly = true;
            UsersTable.RowHeadersWidth = 51;
            UsersTable.RowTemplate.Height = 29;
            UsersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            UsersTable.Size = new System.Drawing.Size(424, 173);
            UsersTable.TabIndex = 0;
            UsersTable.DataSourceChanged += UsersTable_DataSourceChanged;
            UsersTable.CellMouseDoubleClick += UsersTable_CellMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(433, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(354, 37);
            label2.TabIndex = 2;
            label2.Text = "Add User";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordInput);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(isAdminCB);
            panel2.Controls.Add(UsernameInput);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(433, 66);
            panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(354, 173);
            panel2.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PasswordInput.Location = new System.Drawing.Point(18, 51);
            PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '*';
            PasswordInput.PlaceholderText = "Password";
            PasswordInput.Size = new System.Drawing.Size(325, 26);
            PasswordInput.TabIndex = 3;
            PasswordInput.TextChanged += PasswordInput_TextChanged;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(18, 124);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(144, 32);
            button1.TabIndex = 2;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // isAdminCB
            // 
            isAdminCB.AutoSize = true;
            isAdminCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            isAdminCB.Location = new System.Drawing.Point(18, 86);
            isAdminCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            isAdminCB.Name = "isAdminCB";
            isAdminCB.Size = new System.Drawing.Size(93, 25);
            isAdminCB.TabIndex = 1;
            isAdminCB.Text = "Executive";
            isAdminCB.UseVisualStyleBackColor = true;
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            UsernameInput.Location = new System.Drawing.Point(18, 13);
            UsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.PlaceholderText = "User Name";
            UsernameInput.Size = new System.Drawing.Size(325, 26);
            UsernameInput.TabIndex = 0;
            UsernameInput.TextChanged += UsernameInput_TextChanged;
            // 
            // UserManagmentForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(790, 241);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "UserManagmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "User Add / Delete";
            TopMost = true;
            Load += UserManagmentForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersTable).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView UsersTable;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox PasswordInput;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox isAdminCB;
    private System.Windows.Forms.TextBox UsernameInput;
  }
}