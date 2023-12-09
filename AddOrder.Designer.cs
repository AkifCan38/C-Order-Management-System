
namespace Test
{
    partial class AddOrder
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
            CustomerNameInput = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            AddressInput = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            OrderState = new System.Windows.Forms.ComboBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            OrderInput = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            NotesInput = new System.Windows.Forms.TextBox();
            PriceInput = new System.Windows.Forms.NumericUpDown();
            label6 = new System.Windows.Forms.Label();
            addOrderBtn = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            deleteOrder = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PriceInput).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            CustomerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CustomerNameInput.Location = new System.Drawing.Point(19, 46);
            CustomerNameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            CustomerNameInput.Multiline = true;
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.PlaceholderText = "Name , Surname";
            CustomerNameInput.Size = new System.Drawing.Size(456, 46);
            CustomerNameInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(482, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "Order *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(18, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(458, 26);
            label2.TabIndex = 4;
            label2.Text = "Recipient";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(18, 97);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Adress *";
            // 
            // AddressInput
            // 
            AddressInput.Dock = System.Windows.Forms.DockStyle.Fill;
            AddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddressInput.Location = new System.Drawing.Point(19, 133);
            AddressInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AddressInput.Multiline = true;
            AddressInput.Name = "AddressInput";
            AddressInput.PlaceholderText = "Adress";
            AddressInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            AddressInput.Size = new System.Drawing.Size(456, 114);
            AddressInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 252);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Situation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(482, 252);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "Fee";
            // 
            // OrderState
            // 
            OrderState.Dock = System.Windows.Forms.DockStyle.Fill;
            OrderState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            OrderState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            OrderState.Items.AddRange(new object[] { "Sipariş Alındı", "Hazırlanıyor", "Yolda", "Teslim Edildi", "İptal" });
            OrderState.Location = new System.Drawing.Point(19, 293);
            OrderState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OrderState.Name = "OrderState";
            OrderState.Size = new System.Drawing.Size(456, 28);
            OrderState.TabIndex = 12;
            OrderState.SelectedIndexChanged += OrderState_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OrderInput, 1, 3);
            tableLayoutPanel1.Controls.Add(CustomerNameInput, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(AddressInput, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 4);
            tableLayoutPanel1.Controls.Add(OrderState, 0, 5);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(PriceInput, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 2);
            tableLayoutPanel1.Controls.Add(label6, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.101851F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.05202F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.537572F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.57225F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.98266F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.18497F));
            tableLayoutPanel1.Size = new System.Drawing.Size(959, 360);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // OrderInput
            // 
            OrderInput.Dock = System.Windows.Forms.DockStyle.Fill;
            OrderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            OrderInput.Location = new System.Drawing.Point(483, 133);
            OrderInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            OrderInput.Multiline = true;
            OrderInput.Name = "OrderInput";
            OrderInput.PlaceholderText = "Order";
            OrderInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            OrderInput.Size = new System.Drawing.Size(457, 114);
            OrderInput.TabIndex = 14;
            OrderInput.TextChanged += OrderInput_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.12236F));
            tableLayoutPanel2.Controls.Add(NotesInput, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(482, 44);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(459, 50);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // NotesInput
            // 
            NotesInput.Dock = System.Windows.Forms.DockStyle.Fill;
            NotesInput.Location = new System.Drawing.Point(3, 3);
            NotesInput.Multiline = true;
            NotesInput.Name = "NotesInput";
            NotesInput.PlaceholderText = "Order Nots";
            NotesInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            NotesInput.Size = new System.Drawing.Size(453, 44);
            NotesInput.TabIndex = 0;
            // 
            // PriceInput
            // 
            PriceInput.Dock = System.Windows.Forms.DockStyle.Fill;
            PriceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PriceInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            PriceInput.Location = new System.Drawing.Point(482, 291);
            PriceInput.Name = "PriceInput";
            PriceInput.Size = new System.Drawing.Size(459, 30);
            PriceInput.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(482, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(42, 20);
            label6.TabIndex = 14;
            label6.Text = "Nots";
            // 
            // addOrderBtn
            // 
            addOrderBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            addOrderBtn.Location = new System.Drawing.Point(3, 3);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new System.Drawing.Size(805, 51);
            addOrderBtn.TabIndex = 11;
            addOrderBtn.Text = "Add / Update";
            addOrderBtn.UseVisualStyleBackColor = true;
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 360);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(959, 57);
            panel1.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.56726F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.43274F));
            tableLayoutPanel3.Controls.Add(addOrderBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(deleteOrder, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(959, 57);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // deleteOrder
            // 
            deleteOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            deleteOrder.Location = new System.Drawing.Point(814, 3);
            deleteOrder.Name = "deleteOrder";
            deleteOrder.Size = new System.Drawing.Size(142, 51);
            deleteOrder.TabIndex = 12;
            deleteOrder.Text = "Delete";
            deleteOrder.UseVisualStyleBackColor = true;
            deleteOrder.Click += deleteOrder_Click;
            // 
            // AddOrder
            // 
            AcceptButton = addOrderBtn;
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(959, 417);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "AddOrder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sipariş";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PriceInput).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox OrderState;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox OrderInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button deleteOrder;
    private System.Windows.Forms.TextBox NotesInput;
    private System.Windows.Forms.NumericUpDown PriceInput;
  }
}