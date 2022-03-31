namespace hontashvili_family.UI
{
    partial class Form_OrdersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OrdersReport));
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.comboBox_Returned = new System.Windows.Forms.ComboBox();
            this.label_Returned = new System.Windows.Forms.Label();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_head = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnClient,
            this.columnDate,
            this.columnReturned});
            this.listViewOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(36, 109);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(562, 329);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            this.listViewOrders.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Products_ColumnClick);
            // 
            // columnClient
            // 
            this.columnClient.Text = "Client";
            this.columnClient.Width = 175;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 181;
            // 
            // columnReturned
            // 
            this.columnReturned.Text = "Return status";
            this.columnReturned.Width = 137;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.comboBox_Returned);
            this.groupBox_Filter.Controls.Add(this.label_Returned);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_To);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_From);
            this.groupBox_Filter.Controls.Add(this.comboBox_Client);
            this.groupBox_Filter.Controls.Add(this.label_Client);
            this.groupBox_Filter.Controls.Add(this.label_To);
            this.groupBox_Filter.Controls.Add(this.label_From);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(1, 38);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(696, 65);
            this.groupBox_Filter.TabIndex = 1;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // comboBox_Returned
            // 
            this.comboBox_Returned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Returned.FormattingEnabled = true;
            this.comboBox_Returned.Items.AddRange(new object[] {
            "All",
            "True",
            "False"});
            this.comboBox_Returned.Location = new System.Drawing.Point(592, 25);
            this.comboBox_Returned.Name = "comboBox_Returned";
            this.comboBox_Returned.Size = new System.Drawing.Size(91, 24);
            this.comboBox_Returned.TabIndex = 11;
            this.comboBox_Returned.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label_Returned
            // 
            this.label_Returned.AutoSize = true;
            this.label_Returned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Returned.Location = new System.Drawing.Point(521, 30);
            this.label_Returned.Name = "label_Returned";
            this.label_Returned.Size = new System.Drawing.Size(65, 16);
            this.label_Returned.TabIndex = 10;
            this.label_Returned.Text = "Returned:";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Checked = false;
            this.dateTimePicker_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(377, 25);
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
            this.dateTimePicker_From.Location = new System.Drawing.Point(210, 25);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.ShowCheckBox = true;
            this.dateTimePicker_From.Size = new System.Drawing.Size(139, 24);
            this.dateTimePicker_From.TabIndex = 8;
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(55, 26);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(109, 24);
            this.comboBox_Client.TabIndex = 7;
            this.comboBox_Client.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Client.Location = new System.Drawing.Point(6, 29);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(43, 16);
            this.label_Client.TabIndex = 3;
            this.label_Client.Text = "Client:";
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_To.Location = new System.Drawing.Point(353, 30);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(27, 16);
            this.label_To.TabIndex = 2;
            this.label_To.Text = "To:";
            // 
            // label_From
            // 
            this.label_From.AutoSize = true;
            this.label_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_From.Location = new System.Drawing.Point(172, 29);
            this.label_From.Name = "label_From";
            this.label_From.Size = new System.Drawing.Size(41, 16);
            this.label_From.TabIndex = 1;
            this.label_From.Text = "From:";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_clear.Location = new System.Drawing.Point(640, 211);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 37);
            this.button_clear.TabIndex = 50;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.Location = new System.Drawing.Point(236, 15);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(151, 20);
            this.label_head.TabIndex = 51;
            this.label_head.Text = "Orders Report";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.SystemColors.Control;
            this.button_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Print.BackgroundImage")));
            this.button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Print.Location = new System.Drawing.Point(650, 254);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(73, 70);
            this.button_Print.TabIndex = 52;
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(740, 2);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 57;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_OrdersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.label_head);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.listViewOrders);
            this.Name = "Form_OrdersReport";
            this.Text = "Form_OrdersReport";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnClient;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnReturned;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.ComboBox comboBox_Returned;
        private System.Windows.Forms.Label label_Returned;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Label label_head;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button_Home;
    }
}