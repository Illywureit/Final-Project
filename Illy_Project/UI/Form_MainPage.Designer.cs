namespace Illy_Project.UI
{
    partial class Form_MainPage
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
            this.tabPage_Reports = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ClientReport = new System.Windows.Forms.Button();
            this.buttonPBO = new System.Windows.Forms.Button();
            this.button_Month = new System.Windows.Forms.Button();
            this.button_OrderReport = new System.Windows.Forms.Button();
            this.button_ProductReport = new System.Windows.Forms.Button();
            this.tabPage_Manage = new System.Windows.Forms.TabPage();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Orders = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Client = new System.Windows.Forms.Button();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_Reports.SuspendLayout();
            this.tabPage_Manage.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Reports.Controls.Add(this.button2);
            this.tabPage_Reports.Controls.Add(this.button1);
            this.tabPage_Reports.Controls.Add(this.button_ClientReport);
            this.tabPage_Reports.Controls.Add(this.buttonPBO);
            this.tabPage_Reports.Controls.Add(this.button_Month);
            this.tabPage_Reports.Controls.Add(this.button_OrderReport);
            this.tabPage_Reports.Controls.Add(this.button_ProductReport);
            this.tabPage_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reports.Size = new System.Drawing.Size(457, 213);
            this.tabPage_Reports.TabIndex = 1;
            this.tabPage_Reports.Text = "All Reports";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(300, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 55);
            this.button2.TabIndex = 7;
            this.button2.Text = "Return status of orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(160, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Orders Yearly Comparison";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ClientReport
            // 
            this.button_ClientReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_ClientReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_ClientReport.Location = new System.Drawing.Point(17, 152);
            this.button_ClientReport.Name = "button_ClientReport";
            this.button_ClientReport.Size = new System.Drawing.Size(137, 55);
            this.button_ClientReport.TabIndex = 5;
            this.button_ClientReport.Text = "All clients";
            this.button_ClientReport.UseVisualStyleBackColor = false;
            this.button_ClientReport.Click += new System.EventHandler(this.button_ClientReport_Click);
            // 
            // buttonPBO
            // 
            this.buttonPBO.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPBO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPBO.Location = new System.Drawing.Point(160, 32);
            this.buttonPBO.Name = "buttonPBO";
            this.buttonPBO.Size = new System.Drawing.Size(134, 55);
            this.buttonPBO.TabIndex = 4;
            this.buttonPBO.Text = "Products by orders";
            this.buttonPBO.UseVisualStyleBackColor = false;
            this.buttonPBO.Click += new System.EventHandler(this.buttonPBO_Click);
            // 
            // button_Month
            // 
            this.button_Month.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Month.Location = new System.Drawing.Point(160, 89);
            this.button_Month.Name = "button_Month";
            this.button_Month.Size = new System.Drawing.Size(134, 55);
            this.button_Month.TabIndex = 3;
            this.button_Month.Text = "Orders by month";
            this.button_Month.UseVisualStyleBackColor = false;
            this.button_Month.Click += new System.EventHandler(this.button_Month_Click);
            // 
            // button_OrderReport
            // 
            this.button_OrderReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_OrderReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_OrderReport.Location = new System.Drawing.Point(17, 93);
            this.button_OrderReport.Name = "button_OrderReport";
            this.button_OrderReport.Size = new System.Drawing.Size(137, 55);
            this.button_OrderReport.TabIndex = 2;
            this.button_OrderReport.Text = "All orders";
            this.button_OrderReport.UseVisualStyleBackColor = false;
            this.button_OrderReport.Click += new System.EventHandler(this.button_OrderReport_Click);
            // 
            // button_ProductReport
            // 
            this.button_ProductReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_ProductReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_ProductReport.Location = new System.Drawing.Point(17, 32);
            this.button_ProductReport.Name = "button_ProductReport";
            this.button_ProductReport.Size = new System.Drawing.Size(137, 55);
            this.button_ProductReport.TabIndex = 1;
            this.button_ProductReport.Text = "All products";
            this.button_ProductReport.UseVisualStyleBackColor = false;
            this.button_ProductReport.Click += new System.EventHandler(this.button_ProductReport_Click);
            // 
            // tabPage_Manage
            // 
            this.tabPage_Manage.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Manage.Controls.Add(this.pictureBox6);
            this.tabPage_Manage.Controls.Add(this.pictureBox5);
            this.tabPage_Manage.Controls.Add(this.pictureBox4);
            this.tabPage_Manage.Controls.Add(this.pictureBox3);
            this.tabPage_Manage.Controls.Add(this.button_Return);
            this.tabPage_Manage.Controls.Add(this.button_Orders);
            this.tabPage_Manage.Controls.Add(this.button_Products);
            this.tabPage_Manage.Controls.Add(this.button_Client);
            this.tabPage_Manage.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Manage.Name = "tabPage_Manage";
            this.tabPage_Manage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Manage.Size = new System.Drawing.Size(457, 213);
            this.tabPage_Manage.TabIndex = 0;
            this.tabPage_Manage.Text = "Manage";
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Return.Location = new System.Drawing.Point(173, 34);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(147, 55);
            this.button_Return.TabIndex = 4;
            this.button_Return.Text = "Return         products";
            this.button_Return.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Orders
            // 
            this.button_Orders.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Orders.Location = new System.Drawing.Point(14, 33);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Size = new System.Drawing.Size(146, 55);
            this.button_Orders.TabIndex = 3;
            this.button_Orders.Text = "Orders";
            this.button_Orders.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Orders.UseVisualStyleBackColor = false;
            this.button_Orders.Click += new System.EventHandler(this.button_Orders_Click);
            // 
            // button_Products
            // 
            this.button_Products.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Products.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Products.Location = new System.Drawing.Point(173, 95);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(147, 55);
            this.button_Products.TabIndex = 2;
            this.button_Products.Text = "Products";
            this.button_Products.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Products.UseVisualStyleBackColor = false;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Client
            // 
            this.button_Client.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_Client.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button_Client.Location = new System.Drawing.Point(14, 95);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(146, 55);
            this.button_Client.TabIndex = 1;
            this.button_Client.Text = "Clients";
            this.button_Client.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_Client.UseVisualStyleBackColor = false;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_Manage);
            this.tabControl_main.Controls.Add(this.tabPage_Reports);
            this.tabControl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl_main.Location = new System.Drawing.Point(337, 93);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(465, 246);
            this.tabControl_main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(256, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Water Sport Rental Store";
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.label7);
            this.groupBox_Info.Controls.Add(this.label6);
            this.groupBox_Info.Controls.Add(this.label5);
            this.groupBox_Info.Controls.Add(this.label4);
            this.groupBox_Info.Controls.Add(this.label3);
            this.groupBox_Info.Controls.Add(this.label2);
            this.groupBox_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Info.Location = new System.Drawing.Point(12, 104);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(289, 179);
            this.groupBox_Info.TabIndex = 4;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "My info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(75, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "+972544969595";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(77, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = " 26 Yehuda Hanasi, Tel-Aviv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(76, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Israel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contry: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Illy_Project.Properties.Resources.boats2;
            this.pictureBox2.Location = new System.Drawing.Point(1, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(808, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox6.Image = global::Illy_Project.Properties.Resources.return_icon;
            this.pictureBox6.Location = new System.Drawing.Point(270, 47);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox5.Image = global::Illy_Project.Properties.Resources.product_icon2;
            this.pictureBox5.Location = new System.Drawing.Point(271, 110);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox4.Image = global::Illy_Project.Properties.Resources.order_icon1;
            this.pictureBox4.Location = new System.Drawing.Point(103, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox3.Image = global::Illy_Project.Properties.Resources.client_icon;
            this.pictureBox3.Location = new System.Drawing.Point(106, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 436);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_MainPage";
            this.Text = "Main Page";
            this.tabPage_Reports.ResumeLayout(false);
            this.tabPage_Manage.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_Reports;
        private System.Windows.Forms.TabPage tabPage_Manage;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_Orders;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_OrderReport;
        private System.Windows.Forms.Button button_ProductReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Month;
        private System.Windows.Forms.Button buttonPBO;
        private System.Windows.Forms.Button button_ClientReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}