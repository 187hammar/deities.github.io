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
    public partial class Form1 : Form
    {
        public List<int>amount = new List<int>();
        public double totalAmount;
        public string item = "";
        public double price;
        public double totalPrice;
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Clothes.mdf;Integrated Security=True";
        string conStrTransactions = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Transaction.mdf;Integrated Security=True";
        SqlConnection conn; //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Transaction.mdf";Integrated Security=True
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        public void newTransaction(string description, double total)
        {
            try
            {
                DateTime date = DateTime.Now;
                conn = new SqlConnection(conStrTransactions);
                conn.Open();
                string inSql = "INSERT INTO TransactionTable VALUES(@Date, @TotalAmount, @Description)";
                SqlDataAdapter adp = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(inSql, conn);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@TotalAmount", total);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("ERROR:" + error.ToString());
            }
        }
        public void getItem(int itemId)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            string sqlQuery = "SELECT * FROM ClothesTable WHERE Id LIKE '%" + itemId + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);
            cmd = new SqlCommand(sqlQuery, conn);
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds, "ClothesTable");

            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    string[] ItemName = new string[1];
                    string[] ItemPrice = new string[1];

                    for (int i = 1; i <= 1; i++)
                    {
                        ItemName[i - 1] = reader.GetValue(1).ToString();
                        ItemPrice[i - 1] = reader.GetValue(3).ToString();
                        price = Convert.ToDouble(ItemPrice[i-1]);
                        totalPrice += price;
                        lblTotalAmount.Text = Convert.ToString(Math.Round(totalPrice, 2));
                    }

                    for (int i = 0; i < ItemName.Length; i++)
                    {
                        listBox1.Items.Add(ItemName[i].ToString());
                        listBox1.Items.Add("R"+ItemPrice[i].ToString());
                        listBox1.Items.Add("----------------------------------------");
                    }
                }
            }
            finally
            {
                reader.Close();
            }
            conn.Close();
        }

        private void pbx7_Click(object sender, EventArgs e)
        {
            getItem(10001);
        }

        private void pbx3_Click(object sender, EventArgs e)
        {
            getItem(10002);
        }

        private void pbx5_Click(object sender, EventArgs e)
        {
            getItem(10003);
        }

        private void pbx10_Click(object sender, EventArgs e)
        {
            getItem(10004);
        }

        private void pbx2_Click(object sender, EventArgs e)
        {
            getItem(10005);
        }

        private void pbx4_Click(object sender, EventArgs e)
        {
            getItem(10006);
        }

        private void pbx9_Click(object sender, EventArgs e)
        {
            getItem(10007);
        }

        private void pbx1_Click(object sender, EventArgs e)
        {
            getItem(10008);
        }

        private void pbx6_Click(object sender, EventArgs e)
        {
            getItem(10009);
        }

        private void pbx8_Click(object sender, EventArgs e)
        {
            getItem(10010);
        }

        private void pbx20_Click(object sender, EventArgs e)
        {
            getItem(10011);
        }

        private void pbx19_Click(object sender, EventArgs e)
        {
            getItem(10012);
        }

        private void pbx18_Click(object sender, EventArgs e)
        {
            getItem(10013);
        }

        private void pbx17_Click(object sender, EventArgs e)
        {
            getItem(10014);
        }

        private void pbx11_Click(object sender, EventArgs e)
        {
            getItem(10015);
        }

        private void pbx12_Click(object sender, EventArgs e)
        {
            getItem(10016);
        }

        private void pbx13_Click(object sender, EventArgs e)
        {
            getItem(10017);
        }

        private void pbx15_Click(object sender, EventArgs e)
        {
            getItem(10018);
        }

        private void pbx16_Click(object sender, EventArgs e)
        {
            getItem(10019);
        }

        private void pbx14_Click(object sender, EventArgs e)
        {
            getItem(10020);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlBilling.Visible = true;
        }

        private void btnBilling_MouseEnter(object sender, EventArgs e)
        {
            btnBilling.BackColor = Color.Gold;
            btnBilling.ForeColor = Color.Black;
        }

        private void btnBilling_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnBilling_MouseLeave(object sender, EventArgs e)
        {
            btnBilling.BackColor = Color.Black;
            btnBilling.ForeColor = Color.Gold;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBilling.Visible = false;
            listBox1.Dock = DockStyle.Fill;
            pnlTotalLabelandButton.Dock = DockStyle.Bottom;

        }

        private void btn1_MouseEnter_1(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Gold;
            btn1.ForeColor = Color.Black;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Black;
            btn1.ForeColor = Color.Gold;
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Gold;
            btn2.ForeColor = Color.Black;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Black;
            btn2.ForeColor = Color.Gold;
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Gold;
            btn3.ForeColor = Color.Black;
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Black;
            btn3.ForeColor = Color.Gold;
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Gold;
            btn4.ForeColor = Color.Black;
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Black;
            btn4.ForeColor = Color.Gold;
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            btn5.BackColor = Color.Gold;
            btn5.ForeColor = Color.Black;
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {
            btn5.BackColor = Color.Black;
            btn5.ForeColor = Color.Gold;
        }

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            btn6.BackColor = Color.Gold;
            btn6.ForeColor = Color.Black;
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            btn6.BackColor = Color.Black;
            btn6.ForeColor = Color.Gold;
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            btn7.BackColor = Color.Gold;
            btn7.ForeColor = Color.Black;
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            btn7.BackColor = Color.Black;
            btn7.ForeColor = Color.Gold;
        }

        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            btn8.BackColor = Color.Gold;
            btn8.ForeColor = Color.Black;
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            btn8.BackColor = Color.Black;
            btn8.ForeColor = Color.Gold;
        }

        private void btn9_MouseEnter(object sender, EventArgs e)
        {
            btn9.BackColor = Color.Gold;
            btn9.ForeColor = Color.Black;
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            btn9.BackColor = Color.Black;
            btn9.ForeColor = Color.Gold;
        }

        private void btn0_MouseEnter(object sender, EventArgs e)
        {
            btn0.BackColor = Color.Gold;
            btn0.ForeColor = Color.Black;
        }

        private void btn0_MouseLeave(object sender, EventArgs e)
        {
            btn0.BackColor = Color.Black;
            btn0.ForeColor = Color.Gold;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            amount.Add(1);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            amount.Add(2);
            lblAmountPaid.Text =string.Join("", amount);

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            amount.Add(3);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            amount.Add(4);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            amount.Add(5);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            amount.Add(6);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            amount.Add(7);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            amount.Add(8);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            amount.Add(9);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            amount.Add(0);
            lblAmountPaid.Text = string.Join("", amount);
        }

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Black;
            btnCalculate.ForeColor = Color.Gold;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Gold;
            btnCalculate.ForeColor = Color.Black;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (int digit in amount)
            {
                total = 10 * total + digit;
            }
            totalAmount = Convert.ToDouble(total);
            lblChangeAmount.Text = Convert.ToString(totalAmount - totalPrice);
            string description = " ";
            for (int i = 0; i < listBox1.Items.Count; i+=3)
            {
                string items = listBox1.Items[i].ToString();
                description += items + ", ";
            }
            newTransaction(description, totalAmount);
        }

        private void btnBackspace_MouseEnter(object sender, EventArgs e)
        {
            btnBackspace.BackColor = Color.Black;
            btnBackspace.ForeColor = Color.Red;
        }

        private void btnBackspace_MouseLeave(object sender, EventArgs e)
        {
            btnBackspace.BackColor = Color.Black;
            btnBackspace.ForeColor = Color.Gold;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Black;
            btnClear.ForeColor = Color.Gold;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Red;
            btnClear.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            amount.Clear();
            totalPrice = 0;
            totalAmount = 0;
            lblAmountPaid.Text = "";
            lblChangeAmount.Text = "";
            lblTotalAmount.Text = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            amount.RemoveAt(amount.Count-1);
            lblAmountPaid.Text = string.Join("", amount);

        }

        private void btnDesignerOrder_Click(object sender, EventArgs e)
        {
            DesignerOrderScreen dos = new DesignerOrderScreen();
            dos.ShowDialog();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ManagementScreen ms = new ManagementScreen();
            ms.ShowDialog();
        }
    }
}
