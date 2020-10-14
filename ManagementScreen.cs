using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeitiesClothings
{
    public partial class ManagementScreen : Form
    {
        SqlCommand cmd;
        string conStringClothes = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Clothes.mdf;Integrated Security=True";
        string conStringOrder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Order.mdf;Integrated Security=True";
        string conStringTransaction = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Transaction.mdf;Integrated Security=True";
        string conStringCustomers = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Customer.mdf;Integrated Security=True";
        public ManagementScreen()
        {
            InitializeComponent();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            DesignerOrderScreen dos = new DesignerOrderScreen();
            dos.ShowDialog();
        }

        private void btnInStorePurchase_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void btnDesignerOrder_Click(object sender, EventArgs e)
        {
            DesignerOrderScreen dos = new DesignerOrderScreen();
            dos.ShowDialog();
        }

        private void viewDB(string conStr, string table)
        {
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            string sqlSelect = "SELECT * FROM "+table+"";
            cmd = new SqlCommand(sqlSelect, conn);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds, table);

            dgvData.DataSource = ds;
            dgvData.DataMember = table;
            conn.Close();
        }

        private void ManagementScreen_Load(object sender, EventArgs e)
        {
            viewDB(conStringClothes, "ClothesTable");
            btnClothes.BackColor = Color.Gold;
            btnClothes.ForeColor = Color.Black;
            btnTransaction.BackColor = Control.DefaultBackColor;
            btnTransaction.ForeColor = Control.DefaultForeColor;
            btnOrder.BackColor = Control.DefaultBackColor;
            btnOrder.ForeColor = Control.DefaultForeColor;
            btnCustomers.BackColor = Control.DefaultBackColor;
            btnCustomers.ForeColor = Control.DefaultForeColor;
        }

        private void btnClothes_Click(object sender, EventArgs e)
        {
            viewDB(conStringClothes, "ClothesTable");
            btnClothes.BackColor = Color.Gold;
            btnClothes.ForeColor = Color.Black;
            btnTransaction.BackColor = Control.DefaultBackColor;
            btnTransaction.ForeColor = Control.DefaultForeColor;
            btnOrder.BackColor = Control.DefaultBackColor;
            btnOrder.ForeColor = Control.DefaultForeColor;
            btnCustomers.BackColor = Control.DefaultBackColor;
            btnCustomers.ForeColor = Control.DefaultForeColor;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            viewDB(conStringOrder, "OrderTable");
            btnClothes.BackColor = Control.DefaultBackColor;
            btnClothes.ForeColor = Control.DefaultForeColor;
            btnTransaction.BackColor = Control.DefaultBackColor;
            btnTransaction.ForeColor = Control.DefaultForeColor;
            btnOrder.BackColor = Color.Gold;
            btnOrder.ForeColor = Color.Black;
            btnCustomers.BackColor = Control.DefaultBackColor;
            btnCustomers.ForeColor = Control.DefaultForeColor;
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            viewDB(conStringTransaction, "TransactionTable");
            btnClothes.BackColor = Control.DefaultBackColor;
            btnClothes.ForeColor = Control.DefaultForeColor;
            btnTransaction.BackColor = Color.Gold;
            btnTransaction.ForeColor = Color.Black;
            btnOrder.BackColor = Control.DefaultBackColor;
            btnOrder.ForeColor = Control.DefaultForeColor;
            btnCustomers.BackColor = Control.DefaultBackColor;
            btnCustomers.ForeColor = Control.DefaultForeColor;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            viewDB(conStringCustomers, "CustomerTable");
            btnClothes.BackColor = Control.DefaultBackColor;
            btnClothes.ForeColor = Control.DefaultForeColor;
            btnTransaction.BackColor = Control.DefaultBackColor;
            btnTransaction.ForeColor = Control.DefaultForeColor;
            btnOrder.BackColor = Control.DefaultBackColor;
            btnOrder.ForeColor = Control.DefaultForeColor;
            btnCustomers.BackColor = Color.Gold;
            btnCustomers.ForeColor = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
