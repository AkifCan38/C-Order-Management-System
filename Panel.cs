using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Test {

    public partial class Panel : Form
    {
        readonly int userType = 0;

        public Panel(string userType)
        {
            this.userType = Convert.ToInt32(userType);
            InitializeComponent();
            UpdateTable();

            // Hide add user button if user is not admin
            if (this.userType < 1) AddUserBn.Visible = false;
        }

        public void UpdateTable()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=Database.db"))
            {
                try
                {
                    connection.Open();
                    // Return Orders List ordered by their states
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From tblOrder ORDER BY State ASC", connection);

                    DataSet dset = new DataSet();
                    adapter.Fill(dset, "info");

                    OrderTable.DataSource = dset.Tables[0];

                    // Remove table selection
                    OrderTable.ClearSelection();

                    adapter.Dispose();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        private void Panel_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to date?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Create New Order
        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            AddOrder AddOrderForm = new AddOrder(this);
            AddOrderForm.Show();
        }

        // Edit Order
        private void OrderTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string id = OrderTable.Rows[e.RowIndex].Cells[0].Value.ToString();

            AddOrder AddOrderForm = new AddOrder(id, this);
            AddOrderForm.Show();
        }

        private void OrderTable_DataSourceChanged(object sender, EventArgs e)
        {

            // Rename Table Header Texts
            OrderTable.Columns[0].HeaderText = "No";
            OrderTable.Columns[1].HeaderText = "Customer Name";
            OrderTable.Columns[2].HeaderText = "Order";
            OrderTable.Columns[3].HeaderText = "Adress";
            OrderTable.Columns[4].HeaderText = "Nots";
            OrderTable.Columns[5].HeaderText = "Fee";
            OrderTable.Columns[6].HeaderText = "Situation";

            // Convert States into Text
            for (int i = 0; i < OrderTable.Rows.Count; i++)
            {
                int state = Convert.ToInt32(OrderTable.Rows[i].Cells[6].Value);
                OrderTable.Rows[i].Cells[6].Value = GetState(state);
            }

            // Add currency next to price
            for (int i = 0; i < OrderTable.Rows.Count; i++)
            {
                OrderTable.Rows[i].Cells[5].Value += " COM";
            }

        }

        // Returns Order State converted to text
        private string GetState(int state)
        {
            // Order States
            var stateMap = new Dictionary<int, string>(){
        {0, "Your order has been taken"},
        {1, "getting ready"},
        {2, "on the road"},
        {3, "Was delivered"},
        {4, "Cancel"}
      };

            string output;

            return stateMap.TryGetValue(state, out output) ? output : "default";
        }

        private void AddUserBn_Click(object sender, EventArgs e)
        {
            OrderMS.UserManagmentForm userManagment = new OrderMS.UserManagmentForm();
            userManagment.Show();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
