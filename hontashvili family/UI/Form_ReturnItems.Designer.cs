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
            this.tabPage_Return = new System.Windows.Forms.TabPage();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.listBox_ProductsInOrderCount = new System.Windows.Forms.ListBox();
            this.ProductsInOrder = new System.Windows.Forms.Label();
            this.listBox_ProductsInOrder = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_Orders.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.tabPage_Return.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Orders);
            this.tabControl1.Controls.Add(this.tabPage_Return);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Orders
            // 
            this.tabPage_Orders.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Orders.Controls.Add(this.listBox_Orders);
            this.tabPage_Orders.Controls.Add(this.groupBox_Filter);
            this.tabPage_Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabPage_Orders.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Orders.Name = "tabPage_Orders";
            this.tabPage_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Orders.Size = new System.Drawing.Size(780, 343);
            this.tabPage_Orders.TabIndex = 0;
            this.tabPage_Orders.Text = "All orders";
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 16;
            this.listBox_Orders.Location = new System.Drawing.Point(268, 53);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(231, 260);
            this.listBox_Orders.TabIndex = 3;
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
            this.groupBox_Filter.Location = new System.Drawing.Point(23, 53);
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
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(76, 130);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(138, 28);
            this.comboBox_Client.TabIndex = 7;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(75, 16);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(139, 26);
            this.textBox_Id.TabIndex = 4;
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
            // tabPage_Return
            // 
            this.tabPage_Return.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Return.Controls.Add(this.button_Plus);
            this.tabPage_Return.Controls.Add(this.button_Minus);
            this.tabPage_Return.Controls.Add(this.listBox_ProductsInOrderCount);
            this.tabPage_Return.Controls.Add(this.ProductsInOrder);
            this.tabPage_Return.Controls.Add(this.listBox_ProductsInOrder);
            this.tabPage_Return.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Return.Name = "tabPage_Return";
            this.tabPage_Return.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Return.Size = new System.Drawing.Size(780, 343);
            this.tabPage_Return.TabIndex = 1;
            this.tabPage_Return.Text = "Return products";
            // 
            // button_Plus
            // 
            this.button_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Plus.Location = new System.Drawing.Point(270, 31);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(32, 31);
            this.button_Plus.TabIndex = 58;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            // 
            // button_Minus
            // 
            this.button_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Minus.Location = new System.Drawing.Point(270, 67);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(32, 31);
            this.button_Minus.TabIndex = 57;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            // 
            // listBox_ProductsInOrderCount
            // 
            this.listBox_ProductsInOrderCount.FormattingEnabled = true;
            this.listBox_ProductsInOrderCount.ItemHeight = 16;
            this.listBox_ProductsInOrderCount.Location = new System.Drawing.Point(239, 31);
            this.listBox_ProductsInOrderCount.Name = "listBox_ProductsInOrderCount";
            this.listBox_ProductsInOrderCount.Size = new System.Drawing.Size(25, 244);
            this.listBox_ProductsInOrderCount.TabIndex = 56;
            // 
            // ProductsInOrder
            // 
            this.ProductsInOrder.AutoSize = true;
            this.ProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductsInOrder.Location = new System.Drawing.Point(63, 8);
            this.ProductsInOrder.Name = "ProductsInOrder";
            this.ProductsInOrder.Size = new System.Drawing.Size(147, 20);
            this.ProductsInOrder.TabIndex = 55;
            this.ProductsInOrder.Text = "Products In Order:";
            // 
            // listBox_ProductsInOrder
            // 
            this.listBox_ProductsInOrder.FormattingEnabled = true;
            this.listBox_ProductsInOrder.ItemHeight = 16;
            this.listBox_ProductsInOrder.Location = new System.Drawing.Point(41, 31);
            this.listBox_ProductsInOrder.Name = "listBox_ProductsInOrder";
            this.listBox_ProductsInOrder.Size = new System.Drawing.Size(198, 244);
            this.listBox_ProductsInOrder.TabIndex = 54;
            // 
            // Form_ReturnItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_ReturnItems";
            this.Text = "Form_ReturnItems";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Orders.ResumeLayout(false);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.tabPage_Return.ResumeLayout(false);
            this.tabPage_Return.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Orders;
        private System.Windows.Forms.TabPage tabPage_Return;
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
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.ListBox listBox_ProductsInOrderCount;
        private System.Windows.Forms.Label ProductsInOrder;
        private System.Windows.Forms.ListBox listBox_ProductsInOrder;
    }
}