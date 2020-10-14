using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Data.SqlClient;

namespace DeitiesClothings
{
    public partial class DesignerOrderScreen : Form
    {
        public double cost = 0;
        SqlConnection conn;
        SqlCommand cmd;
        string conStrTransactions = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Transaction.mdf;Integrated Security=True";
        string conStrCustomer = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Customer.mdf;Integrated Security=True";
        string conStrOrder = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Teddy Bear\Documents\Programming world\C# 2k20\DeitiesClothings\Order.mdf;Integrated Security=True";
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        public DesignerOrderScreen()
        {
            InitializeComponent();
        }

        private void btnSaveAndSend_MouseLeave(object sender, EventArgs e)
        {
            btnSaveAndSend.BackColor = Color.Gold;
            btnSaveAndSend.ForeColor = Color.Black;
        }

        public void sendsms()
        {
            const string accountSid = "ACc678faa4788a073936b6d3dbb1c9dc02";
            const string authToken = "c6661bcde0bcc8967db7cf86a9b67fb5";
            TwilioClient.Init(accountSid,authToken);
            MessageResource.Create(
                to: new Twilio.Types.PhoneNumber("+27624406016"),
                from: new Twilio.Types.PhoneNumber("+18053015996"),
                body: "Test from Twilio"
                );
        }
        private void insertOrder(string desc, string measure, double cost)
        {
            try
            {
                conn = new SqlConnection(conStrOrder);
                conn.Open();
                string inQuery = "INSERT INTO OrderTable VALUES(@Description, @Measurements, @Cost)";
                SqlDataAdapter adp = new SqlDataAdapter();
                cmd = new SqlCommand(inQuery, conn);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Measurements", measure);
                cmd.Parameters.AddWithValue("@Cost", cost);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Querry passed. Order inserted. \n\n Proceed to take customer's details");
            }
            catch (SqlException error)
            {
                MessageBox.Show("ERROR: \n\n\n" + error);
            }
        }
        private void insertCustomer(string fName, string address, int num, string mail)
        {
            try
            {
                conn = new SqlConnection(conStrCustomer);
                conn.Open();
                string inQuery = "INSERT INTO CustomerTable VALUES(@FullName, @Address, @PhoneNum, @Email)";
                SqlDataAdapter adp = new SqlDataAdapter();
                cmd = new SqlCommand(inQuery, conn);
                cmd.Parameters.AddWithValue("@FullName", fName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@PhoneNUm", num);
                cmd.Parameters.AddWithValue("@Email", mail);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Querry Passed. Order and customer records saved");
            } catch (SqlException error)
            {
                MessageBox.Show("ERROR: \n\n\n" + error);
            }
        }
        private void sendMail()
        {
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "teddybearx187@gmail.com",
                    Password = "gxisuffjpbnogxha"
                }
            };
            MailAddress FromEmail = new MailAddress("teddybearx187@gmail.com", "Teddy Bear ARtisT-X");
            MailAddress ToEmail = new MailAddress("tmponya187@hotmail.com", "Test");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Test 2",
                Body = "Test2"
            };
            Message.To.Add(ToEmail);
            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(Message);
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error Happening \n" + e.Error.Message, "Error");
                return;
            }
            MessageBox.Show("Message Sent", "Done");
        }

        private void btnSaveAndSend_MouseEnter(object sender, EventArgs e)
        {
            btnSaveAndSend.BackColor = Color.Black;
            btnSaveAndSend.ForeColor = Color.Gold;
        }

        private void btnSaveAndSend_Click(object sender, EventArgs e)
        {
            string fullName = txtFName.Text;
            int phoneNum = Convert.ToInt32(txtPhoneNum.Text);
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            insertCustomer(fullName, address, phoneNum, email);
            this.Close();
        }

        private void btnBilling_MouseLeave(object sender, EventArgs e)
        {
            btnProceed.BackColor = Color.Black;
            btnProceed.ForeColor = Color.Gold;
        }

        private void btnBilling_MouseEnter(object sender, EventArgs e)
        {
            btnProceed.BackColor = Color.Gold;
            btnProceed.ForeColor = Color.Black;
        }

        private void DesignerOrderScreen_Load(object sender, EventArgs e)
        {
            pnlContacts.Visible = false;

        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ManagementScreen ms = new ManagementScreen();
            ms.ShowDialog();
        }

        private void btnInStorePurchase_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.ShowDialog();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            btnProceed.ForeColor = Color.Black;
            btnProceed.BackColor = Color.Gold;
            string itemType = cbxItemType.SelectedItem.ToString();
            string description = txtDescription.Text;
            string measurements = txtMeasurements.Text;
            if (itemType == "T-shirt")
            {
                cost = 300;
                if (rbxStrock.Checked)
                {
                    cost += 100;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Shirt")
            {
                cost = 350;
                if (rbxStrock.Checked)
                {
                    cost += 100;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Dress")
            {
                cost = 350;
                if (rbxStrock.Checked)
                {
                    cost += 115;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Skirt")
            {
                cost = 300;
                if (rbxStrock.Checked)
                {
                    cost += 50;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Pants")
            {
                cost = 300;
                if (rbxStrock.Checked)
                {
                    cost += 100;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Blazer")
            {
                cost = 400;
                if (rbxStrock.Checked)
                {
                    cost += 120;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Windbreaker")
            {
                cost = 400;
                if (rbxStrock.Checked)
                {
                    cost += 120;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Hoodie")
            {
                cost = 300;
                if (rbxStrock.Checked)
                {
                    cost += 120;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Hat")
            {
                cost = 200;
                if (rbxStrock.Checked)
                {
                    cost += 50;
                }
                txtCost.Text = cost.ToString();
            }
            if (itemType == "Jersey")
            {
                cost = 350;
                if (rbxStrock.Checked)
                {
                    cost += 100;
                }
                txtCost.Text = cost.ToString();
            }
            insertOrder(description, measurements, cost);
            pnlContacts.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.Black;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Black;
            btnCancel.ForeColor = Color.Red;
        }

        private void rbxStrock_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbxPrivate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
