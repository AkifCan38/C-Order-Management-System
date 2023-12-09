
namespace Test
{
    partial class Panel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            layout = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            addOrderBtn = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            OrderTable = new System.Windows.Forms.DataGridView();
            navbar = new System.Windows.Forms.TableLayoutPanel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            AddUserBn = new System.Windows.Forms.Button();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            layout.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrderTable).BeginInit();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // layout
            // 
            layout.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(layout, "layout");
            layout.Controls.Add(panel2, 0, 1);
            layout.Controls.Add(navbar, 0, 0);
            layout.Name = "layout";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Lavender;
            panel2.Controls.Add(addOrderBtn);
            panel2.Controls.Add(panel3);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // addOrderBtn
            // 
            addOrderBtn.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(addOrderBtn, "addOrderBtn");
            addOrderBtn.ForeColor = System.Drawing.Color.PeachPuff;
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.UseVisualStyleBackColor = false;
            addOrderBtn.Click += addOrderBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(OrderTable);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // OrderTable
            // 
            OrderTable.AllowUserToAddRows = false;
            OrderTable.AllowUserToDeleteRows = false;
            OrderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            OrderTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            OrderTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(OrderTable, "OrderTable");
            OrderTable.MultiSelect = false;
            OrderTable.Name = "OrderTable";
            OrderTable.ReadOnly = true;
            OrderTable.RowTemplate.Height = 29;
            OrderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            OrderTable.DataSourceChanged += OrderTable_DataSourceChanged;
            OrderTable.CellMouseDoubleClick += OrderTable_CellMouseDoubleClick;
            // 
            // navbar
            // 
            navbar.BackColor = System.Drawing.Color.DodgerBlue;
            resources.ApplyResources(navbar, "navbar");
            navbar.Controls.Add(pictureBox1, 0, 0);
            navbar.Controls.Add(label1, 1, 0);
            navbar.Controls.Add(button3, 3, 0);
            navbar.Controls.Add(AddUserBn, 2, 0);
            navbar.Name = "navbar";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = System.Drawing.Color.PeachPuff;
            label1.Name = "label1";
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // AddUserBn
            // 
            AddUserBn.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            AddUserBn.BackgroundImage = OrderMS.Properties.Resources.icons8_add_user_male_40;
            resources.ApplyResources(AddUserBn, "AddUserBn");
            AddUserBn.Name = "AddUserBn";
            AddUserBn.UseVisualStyleBackColor = false;
            AddUserBn.Click += AddUserBn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // Panel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(layout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "Panel";
            FormClosing += Panel_FormClosing_1;
            Load += Panel_Load;
            layout.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrderTable).EndInit();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.TableLayoutPanel navbar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Button AddUserBn;
  }
}