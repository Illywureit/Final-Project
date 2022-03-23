namespace hontashvili_family.UI
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
            this.button_ProductReport = new System.Windows.Forms.Button();
            this.tabPage_Manage = new System.Windows.Forms.TabPage();
            this.button_Orders = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.button_Client = new System.Windows.Forms.Button();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.button_Return = new System.Windows.Forms.Button();
            this.tabPage_Reports.SuspendLayout();
            this.tabPage_Manage.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.Controls.Add(this.button_ProductReport);
            this.tabPage_Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reports.Size = new System.Drawing.Size(757, 301);
            this.tabPage_Reports.TabIndex = 1;
            this.tabPage_Reports.Text = "All Reports";
            this.tabPage_Reports.UseVisualStyleBackColor = true;
            // 
            // button_ProductReport
            // 
            this.button_ProductReport.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ProductReport.Location = new System.Drawing.Point(27, 32);
            this.button_ProductReport.Name = "button_ProductReport";
            this.button_ProductReport.Size = new System.Drawing.Size(127, 55);
            this.button_ProductReport.TabIndex = 1;
            this.button_ProductReport.Text = "All product";
            this.button_ProductReport.UseVisualStyleBackColor = true;
            this.button_ProductReport.Click += new System.EventHandler(this.button_ProductReport_Click);
            // 
            // tabPage_Manage
            // 
            this.tabPage_Manage.Controls.Add(this.button_Return);
            this.tabPage_Manage.Controls.Add(this.button_Orders);
            this.tabPage_Manage.Controls.Add(this.button_Products);
            this.tabPage_Manage.Controls.Add(this.button_Client);
            this.tabPage_Manage.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Manage.Name = "tabPage_Manage";
            this.tabPage_Manage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Manage.Size = new System.Drawing.Size(757, 301);
            this.tabPage_Manage.TabIndex = 0;
            this.tabPage_Manage.Text = "Manage";
            this.tabPage_Manage.UseVisualStyleBackColor = true;
            // 
            // button_Orders
            // 
            this.button_Orders.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Orders.Location = new System.Drawing.Point(36, 30);
            this.button_Orders.Name = "button_Orders";
            this.button_Orders.Size = new System.Drawing.Size(127, 55);
            this.button_Orders.TabIndex = 3;
            this.button_Orders.Text = "Orders";
            this.button_Orders.UseVisualStyleBackColor = true;
            this.button_Orders.Click += new System.EventHandler(this.button_Orders_Click);
            // 
            // button_Products
            // 
            this.button_Products.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Products.Location = new System.Drawing.Point(36, 204);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(127, 55);
            this.button_Products.TabIndex = 2;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = true;
            this.button_Products.Click += new System.EventHandler(this.button_Products_Click);
            // 
            // button_Client
            // 
            this.button_Client.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Client.Location = new System.Drawing.Point(36, 117);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(127, 55);
            this.button_Client.TabIndex = 1;
            this.button_Client.Text = "Clients";
            this.button_Client.UseVisualStyleBackColor = true;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_Manage);
            this.tabControl_main.Controls.Add(this.tabPage_Reports);
            this.tabControl_main.Location = new System.Drawing.Point(16, 21);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(765, 327);
            this.tabControl_main.TabIndex = 0;
            // 
            // button_Return
            // 
            this.button_Return.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Return.Location = new System.Drawing.Point(222, 30);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(127, 55);
            this.button_Return.TabIndex = 4;
            this.button_Return.Text = "Return products";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // Form_MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl_main);
            this.Name = "Form_MainPage";
            this.Text = "Form_MainPage";
            this.tabPage_Reports.ResumeLayout(false);
            this.tabPage_Manage.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_Reports;
        private System.Windows.Forms.TabPage tabPage_Manage;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_ProductReport;
        private System.Windows.Forms.Button button_Orders;
        private System.Windows.Forms.Button button_Return;
    }
}