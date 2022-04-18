namespace hontashvili_family.UI
{
    partial class Form_ReturnItems
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Orders = new System.Windows.Forms.TabPage();
            this.groupBox_OrderDetails = new System.Windows.Forms.GroupBox();
            this.label1_ChosenClient = new System.Windows.Forms.Label();
            this.label_ChosenClient = new System.Windows.Forms.Label();
            this.label_ChosenDate = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_ChosenId = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.listBox_ProductsInOrder = new System.Windows.Forms.ListBox();
            this.listBox_ProductsInOrderCount = new System.Windows.Forms.ListBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.ProductsInOrder = new System.Windows.Forms.Label();
            this.listBox_Orders = new System.Windows.Forms.ListBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.label_FilterId = new System.Windows.Forms.Label();
            this.button_Home = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Orders.SuspendLayout();
            this.groupBox_OrderDetails.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Orders);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Orders
            // 
            this.tabPage_Orders.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Orders.Controls.Add(this.groupBox_OrderDetails);
            this.tabPage_Orders.Controls.Add(this.listBox_ProductsInOrder);
            this.tabPage_Orders.Controls.Add(this.listBox_ProductsInOrderCount);
            this.tabPage_Orders.Controls.Add(this.button_Return);
            this.tabPage_Orders.Controls.Add(this.ProductsInOrder);
            this.tabPage_Orders.Controls.Add(this.listBox_Orders);
            this.tabPage_Orders.Controls.Add(this.groupBox_Filter);
            this.tabPage_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage_Orders.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Orders.Name = "tabPage_Orders";
            this.tabPage_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Orders.Size = new System.Drawing.Size(776, 368);
            this.tabPage_Orders.TabIndex = 0;
            this.tabPage_Orders.Text = "All orders";
            // 
            // groupBox_OrderDetails
            // 
            this.groupBox_OrderDetails.Controls.Add(this.label1_ChosenClient);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenClient);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenDate);
            this.groupBox_OrderDetails.Controls.Add(this.label_Date);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenId);
            this.groupBox_OrderDetails.Controls.Add(this.label_id);
            this.groupBox_OrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_OrderDetails.Location = new System.Drawing.Point(23, 195);
            this.groupBox_OrderDetails.Name = "groupBox_OrderDetails";
            this.groupBox_OrderDetails.Size = new System.Drawing.Size(198, 145);
            this.groupBox_OrderDetails.TabIndex = 7;
            this.groupBox_OrderDetails.TabStop = false;
            this.groupBox_OrderDetails.Text = "Chosen order details";
            // 
            // label1_ChosenClient
            // 
            this.label1_ChosenClient.AutoSize = true;
            this.label1_ChosenClient.Location = new System.Drawing.Point(89, 108);
            this.label1_ChosenClient.Name = "label1_ChosenClient";
            this.label1_ChosenClient.Size = new System.Drawing.Size(0, 20);
            this.label1_ChosenClient.TabIndex = 9;
            // 
            // label_ChosenClient
            // 
            this.label_ChosenClient.AutoSize = true;
            this.label_ChosenClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ChosenClient.Location = new System.Drawing.Point(6, 108);
            this.label_ChosenClient.Name = "label_ChosenClient";
            this.label_ChosenClient.Size = new System.Drawing.Size(60, 20);
            this.label_ChosenClient.TabIndex = 8;
            this.label_ChosenClient.Text = "Client:";
            // 
            // label_ChosenDate
            // 
            this.label_ChosenDate.AutoSize = true;
            this.label_ChosenDate.Location = new System.Drawing.Point(89, 67);
            this.label_ChosenDate.Name = "label_ChosenDate";
            this.label_ChosenDate.Size = new System.Drawing.Size(0, 20);
            this.label_ChosenDate.TabIndex = 7;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Date.Location = new System.Drawing.Point(6, 67);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(53, 20);
            this.label_Date.TabIndex = 6;
            this.label_Date.Text = "Date:";
            // 
            // label_ChosenId
            // 
            this.label_ChosenId.AutoSize = true;
            this.label_ChosenId.Location = new System.Drawing.Point(89, 26);
            this.label_ChosenId.Name = "label_ChosenId";
            this.label_ChosenId.Size = new System.Drawing.Size(0, 20);
            this.label_ChosenId.TabIndex = 5;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(6, 26);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(30, 20);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "Id:";
            // 
            // listBox_ProductsInOrder
            // 
            this.listBox_ProductsInOrder.FormattingEnabled = true;
            this.listBox_ProductsInOrder.ItemHeight = 16;
            this.listBox_ProductsInOrder.Location = new System.Drawing.Point(539, 45);
            this.listBox_ProductsInOrder.Name = "listBox_ProductsInOrder";
            this.listBox_ProductsInOrder.Size = new System.Drawing.Size(198, 244);
            this.listBox_ProductsInOrder.TabIndex = 54;
            // 
            // listBox_ProductsInOrderCount
            // 
            this.listBox_ProductsInOrderCount.FormattingEnabled = true;
            this.listBox_ProductsInOrderCount.ItemHeight = 16;
            this.listBox_ProductsInOrderCount.Location = new System.Drawing.Point(737, 45);
            this.listBox_ProductsInOrderCount.Name = "listBox_ProductsInOrderCount";
            this.listBox_ProductsInOrderCount.Size = new System.Drawing.Size(25, 244);
            this.listBox_ProductsInOrderCount.TabIndex = 56;
            this.listBox_ProductsInOrderCount.Click += new System.EventHandler(this.listBox_ProductsInOrderCount_Click);
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.LightCoral;
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Return.Location = new System.Drawing.Point(651, 324);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(97, 38);
            this.button_Return.TabIndex = 57;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // ProductsInOrder
            // 
            this.ProductsInOrder.AutoSize = true;
            this.ProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductsInOrder.Location = new System.Drawing.Point(561, 22);
            this.ProductsInOrder.Name = "ProductsInOrder";
            this.ProductsInOrder.Size = new System.Drawing.Size(147, 20);
            this.ProductsInOrder.TabIndex = 55;
            this.ProductsInOrder.Text = "Products In Order:";
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 16;
            this.listBox_Orders.Location = new System.Drawing.Point(268, 23);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(231, 260);
            this.listBox_Orders.TabIndex = 3;
            this.listBox_Orders.DoubleClick += new System.EventHandler(this.ListBox_Orders_DoubleClick);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_To);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_From);
            this.groupBox_Filter.Controls.Add(this.comboBox_Client);
            this.groupBox_Filter.Controls.Add(this.textBox_Id);
            this.groupBox_Filter.Controls.Add(this.label_Client);
            this.groupBox_Filter.Controls.Add(this.label_To);
            this.groupBox_Filter.Controls.Add(this.label_From);
            this.groupBox_Filter.Controls.Add(this.label_FilterId);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(23, 23);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(239, 166);
            this.groupBox_Filter.TabIndex = 2;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Checked = false;
            this.dateTimePicker_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(76, 95);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.ShowCheckBox = true;
            this.dateTimePicker_To.Size = new System.Drawing.Size(138, 24);
            this.dateTimePicker_To.TabIndex = 9;
            this.dateTimePicker_To.ValueChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Checked = false;
            this.dateTimePicker_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(76, 57);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.ShowCheckBox = true;
            this.dateTimePicker_From.Size = new System.Drawing.Size(138, 24);
            this.dateTimePicker_From.TabIndex = 8;
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(76, 130);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(138, 28);
            this.comboBox_Client.TabIndex = 7;
            this.comboBox_Client.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(75, 16);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(139, 26);
            this.textBox_Id.TabIndex = 4;
            this.textBox_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Client.Location = new System.Drawing.Point(7, 133);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(53, 20);
            this.label_Client.TabIndex = 3;
            this.label_Client.Text = "Client:";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_To.Location = new System.Drawing.Point(7, 95);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(31, 20);
            this.label_To.TabIndex = 2;
            this.label_To.Text = "To:";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_From.Location = new System.Drawing.Point(7, 61);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(50, 20);
            this.label_From.TabIndex = 1;
            this.label_From.Text = "From:";
            // 
            // label_FilterId
            // 
            this.label_FilterId.AutoSize = true;
            this.label_FilterId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_FilterId.Location = new System.Drawing.Point(8, 22);
            this.label_FilterId.Name = "label_FilterId";
            this.label_FilterId.Size = new System.Drawing.Size(27, 20);
            this.label_FilterId.TabIndex = 0;
            this.label_FilterId.Text = "Id:";
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(783, 12);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 17;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_ReturnItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_ReturnItems";
            this.Text = "Return orders";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Orders.ResumeLayout(false);
            this.tabPage_Orders.PerformLayout();
            this.groupBox_OrderDetails.ResumeLayout(false);
            this.groupBox_OrderDetails.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Orders;
        private System.Windows.Forms.ListBox listBox_Orders;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Label label_FilterId;
        private System.Windows.Forms.ListBox listBox_ProductsInOrderCount;
        private System.Windows.Forms.Label ProductsInOrder;
        private System.Windows.Forms.ListBox listBox_ProductsInOrder;
        private System.Windows.Forms.GroupBox groupBox_OrderDetails;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_ChosenId;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1_ChosenClient;
        private System.Windows.Forms.Label label_ChosenClient;
        private System.Windows.Forms.Label label_ChosenDate;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Home;
    }
}