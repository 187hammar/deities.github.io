namespace DeitiesClothings
{
    partial class ManagementScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnDesignerOrder = new System.Windows.Forms.Button();
            this.btnInStorePurchase = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClothes = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblManagement = new System.Windows.Forms.Label();
            this.txtMeasurements = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnManagement);
            this.panel1.Controls.Add(this.btnDesignerOrder);
            this.panel1.Controls.Add(this.btnInStorePurchase);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 780);
            this.panel1.TabIndex = 1;
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.Gold;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.Black;
            this.btnManagement.Location = new System.Drawing.Point(2, 276);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(244, 75);
            this.btnManagement.TabIndex = 21;
            this.btnManagement.Text = "Management";
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnDesignerOrder
            // 
            this.btnDesignerOrder.BackColor = System.Drawing.Color.Black;
            this.btnDesignerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesignerOrder.ForeColor = System.Drawing.Color.Gold;
            this.btnDesignerOrder.Location = new System.Drawing.Point(2, 195);
            this.btnDesignerOrder.Name = "btnDesignerOrder";
            this.btnDesignerOrder.Size = new System.Drawing.Size(244, 75);
            this.btnDesignerOrder.TabIndex = 20;
            this.btnDesignerOrder.Text = "Designer Order";
            this.btnDesignerOrder.UseVisualStyleBackColor = false;
            this.btnDesignerOrder.Click += new System.EventHandler(this.btnDesignerOrder_Click);
            // 
            // btnInStorePurchase
            // 
            this.btnInStorePurchase.BackColor = System.Drawing.Color.Black;
            this.btnInStorePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInStorePurchase.ForeColor = System.Drawing.Color.Gold;
            this.btnInStorePurchase.Location = new System.Drawing.Point(3, 114);
            this.btnInStorePurchase.Name = "btnInStorePurchase";
            this.btnInStorePurchase.Size = new System.Drawing.Size(244, 75);
            this.btnInStorePurchase.TabIndex = 19;
            this.btnInStorePurchase.Text = "In-store Purchase";
            this.btnInStorePurchase.UseVisualStyleBackColor = false;
            this.btnInStorePurchase.Click += new System.EventHandler(this.btnInStorePurchase_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::DeitiesClothings.Properties.Resources.Annotation_2020_09_06_172921__2_;
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(244, 105);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 1;
            this.pbxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtMeasurements);
            this.panel2.Controls.Add(this.btnCustomers);
            this.panel2.Controls.Add(this.btnTransaction);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnClothes);
            this.panel2.Controls.Add(this.dgvData);
            this.panel2.Controls.Add(this.lblManagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 780);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Gold;
            this.btnCustomers.Location = new System.Drawing.Point(764, 58);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(244, 75);
            this.btnCustomers.TabIndex = 24;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.Black;
            this.btnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.Gold;
            this.btnTransaction.Location = new System.Drawing.Point(514, 58);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(244, 75);
            this.btnTransaction.TabIndex = 23;
            this.btnTransaction.Text = "Transactions";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gold;
            this.btnOrder.Location = new System.Drawing.Point(264, 58);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(244, 75);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClothes
            // 
            this.btnClothes.BackColor = System.Drawing.Color.Black;
            this.btnClothes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClothes.ForeColor = System.Drawing.Color.Gold;
            this.btnClothes.Location = new System.Drawing.Point(14, 58);
            this.btnClothes.Name = "btnClothes";
            this.btnClothes.Size = new System.Drawing.Size(244, 75);
            this.btnClothes.TabIndex = 21;
            this.btnClothes.Text = "Clothes";
            this.btnClothes.UseVisualStyleBackColor = false;
            this.btnClothes.Click += new System.EventHandler(this.btnClothes_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(14, 139);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(994, 483);
            this.dgvData.TabIndex = 8;
            // 
            // lblManagement
            // 
            this.lblManagement.AutoSize = true;
            this.lblManagement.Font = new System.Drawing.Font("Monotype Corsiva", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagement.ForeColor = System.Drawing.Color.Gold;
            this.lblManagement.Location = new System.Drawing.Point(6, 9);
            this.lblManagement.Name = "lblManagement";
            this.lblManagement.Size = new System.Drawing.Size(195, 46);
            this.lblManagement.TabIndex = 7;
            this.lblManagement.Text = "Management";
            // 
            // txtMeasurements
            // 
            this.txtMeasurements.BackColor = System.Drawing.Color.Black;
            this.txtMeasurements.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasurements.ForeColor = System.Drawing.Color.Gold;
            this.txtMeasurements.Location = new System.Drawing.Point(14, 672);
            this.txtMeasurements.Name = "txtMeasurements";
            this.txtMeasurements.Size = new System.Drawing.Size(568, 38);
            this.txtMeasurements.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gold;
            this.textBox1.Location = new System.Drawing.Point(588, 628);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 38);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gold;
            this.textBox2.Location = new System.Drawing.Point(356, 628);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 38);
            this.textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gold;
            this.textBox3.Location = new System.Drawing.Point(14, 628);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 38);
            this.textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Gold;
            this.textBox4.Location = new System.Drawing.Point(588, 672);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(226, 38);
            this.textBox4.TabIndex = 29;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ManagementScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagementScreen";
            this.Text = "ManagementScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagementScreen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnDesignerOrder;
        private System.Windows.Forms.Button btnInStorePurchase;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblManagement;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClothes;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMeasurements;
        private System.Windows.Forms.TextBox textBox4;
    }
}