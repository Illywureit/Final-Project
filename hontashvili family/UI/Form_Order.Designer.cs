
namespace hontashvili_family.UI
{
    partial class Form_Order
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
            this.Order_details = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ChosenClient = new System.Windows.Forms.Label();
            this.label_client1 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.label_Comment = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.lablel_Id = new System.Windows.Forms.Label();
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
            this.Order_client = new System.Windows.Forms.TabPage();
            this.groupBox_details = new System.Windows.Forms.GroupBox();
            this.label_chosenCity = new System.Windows.Forms.Label();
            this.label_chosenMail = new System.Windows.Forms.Label();
            this.label_City = new System.Windows.Forms.Label();
            this.label_chosenPhone = new System.Windows.Forms.Label();
            this.lable_mail = new System.Windows.Forms.Label();
            this.label_phoneNumber = new System.Windows.Forms.Label();
            this.label_chosenFirst = new System.Windows.Forms.Label();
            this.label_first = new System.Windows.Forms.Label();
            this.label_ChosenLast = new System.Windows.Forms.Label();
            this.label_last = new System.Windows.Forms.Label();
            this.groupBox_clientFilter = new System.Windows.Forms.GroupBox();
            this.textBox_FirstName_Filter = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_LastName_Filter = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.Order_items = new System.Windows.Forms.TabPage();
            this.groupBox_chosenProduct = new System.Windows.Forms.GroupBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.pCategory = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.pCompany = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Label();
            this.ProductsInOrder = new System.Windows.Forms.Label();
            this.PotentialsProducts = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Filter_Category = new System.Windows.Forms.Label();
            this.comboBox_Filter_Category = new System.Windows.Forms.ComboBox();
            this.label_Filter_Company = new System.Windows.Forms.Label();
            this.comboBox_Filter_Company = new System.Windows.Forms.ComboBox();
            this.textBox_Name_Filter = new System.Windows.Forms.TextBox();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.listBox_ProductsInOrder = new System.Windows.Forms.ListBox();
            this.listBox_PotentialsProducts = new System.Windows.Forms.ListBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Order_details.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.Order_client.SuspendLayout();
            this.groupBox_details.SuspendLayout();
            this.groupBox_clientFilter.SuspendLayout();
            this.Order_items.SuspendLayout();
            this.groupBox_chosenProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Order_details);
            this.tabControl1.Controls.Add(this.Order_client);
            this.tabControl1.Controls.Add(this.Order_items);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 358);
            this.tabControl1.TabIndex = 0;
            // 
            // Order_details
            // 
            this.Order_details.BackColor = System.Drawing.Color.LightCyan;
            this.Order_details.Controls.Add(this.label2);
            this.Order_details.Controls.Add(this.label1);
            this.Order_details.Controls.Add(this.label_ChosenClient);
            this.Order_details.Controls.Add(this.label_client1);
            this.Order_details.Controls.Add(this.textBox_Comment);
            this.Order_details.Controls.Add(this.dateTimePicker_Date);
            this.Order_details.Controls.Add(this.label_Comment);
            this.Order_details.Controls.Add(this.label_Date);
            this.Order_details.Controls.Add(this.label_Id);
            this.Order_details.Controls.Add(this.lablel_Id);
            this.Order_details.Controls.Add(this.listBox_Orders);
            this.Order_details.Controls.Add(this.groupBox_Filter);
            this.Order_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Order_details.Location = new System.Drawing.Point(4, 25);
            this.Order_details.Name = "Order_details";
            this.Order_details.Padding = new System.Windows.Forms.Padding(3);
            this.Order_details.Size = new System.Drawing.Size(761, 329);
            this.Order_details.TabIndex = 0;
            this.Order_details.Text = "Order details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "*";
            // 
            // label_ChosenClient
            // 
            this.label_ChosenClient.AutoSize = true;
            this.label_ChosenClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_ChosenClient.Location = new System.Drawing.Point(73, 211);
            this.label_ChosenClient.Name = "label_ChosenClient";
            this.label_ChosenClient.Size = new System.Drawing.Size(103, 20);
            this.label_ChosenClient.TabIndex = 12;
            this.label_ChosenClient.Text = "None chosen";
            // 
            // label_client1
            // 
            this.label_client1.AutoSize = true;
            this.label_client1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_client1.Location = new System.Drawing.Point(14, 211);
            this.label_client1.Name = "label_client1";
            this.label_client1.Size = new System.Drawing.Size(53, 20);
            this.label_client1.TabIndex = 11;
            this.label_client1.Text = "Client:";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(72, 117);
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(133, 67);
            this.textBox_Comment.TabIndex = 10;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker_Date.CalendarTitleForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dateTimePicker_Date.Checked = false;
            this.dateTimePicker_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(72, 68);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.ShowCheckBox = true;
            this.dateTimePicker_Date.Size = new System.Drawing.Size(133, 24);
            this.dateTimePicker_Date.TabIndex = 9;
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Comment.Location = new System.Drawing.Point(14, 113);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(47, 20);
            this.label_Comment.TabIndex = 5;
            this.label_Comment.Text = "Note:";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Date.Location = new System.Drawing.Point(14, 67);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(48, 20);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Id.Location = new System.Drawing.Point(68, 34);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(18, 20);
            this.label_Id.TabIndex = 3;
            this.label_Id.Text = "0";
            // 
            // lablel_Id
            // 
            this.lablel_Id.AutoSize = true;
            this.lablel_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lablel_Id.Location = new System.Drawing.Point(14, 34);
            this.lablel_Id.Name = "lablel_Id";
            this.lablel_Id.Size = new System.Drawing.Size(25, 20);
            this.lablel_Id.TabIndex = 2;
            this.lablel_Id.Text = "ld:";
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 16;
            this.listBox_Orders.Location = new System.Drawing.Point(233, 18);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(231, 260);
            this.listBox_Orders.TabIndex = 1;
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
            this.groupBox_Filter.Location = new System.Drawing.Point(486, 18);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(239, 166);
            this.groupBox_Filter.TabIndex = 0;
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
            // Order_client
            // 
            this.Order_client.BackColor = System.Drawing.Color.LightCyan;
            this.Order_client.Controls.Add(this.groupBox_details);
            this.Order_client.Controls.Add(this.groupBox_clientFilter);
            this.Order_client.Controls.Add(this.listBox_Clients);
            this.Order_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Order_client.Location = new System.Drawing.Point(4, 25);
            this.Order_client.Name = "Order_client";
            this.Order_client.Padding = new System.Windows.Forms.Padding(3);
            this.Order_client.Size = new System.Drawing.Size(761, 329);
            this.Order_client.TabIndex = 1;
            this.Order_client.Text = "Order client";
            // 
            // groupBox_details
            // 
            this.groupBox_details.Controls.Add(this.label_chosenCity);
            this.groupBox_details.Controls.Add(this.label_chosenMail);
            this.groupBox_details.Controls.Add(this.label_City);
            this.groupBox_details.Controls.Add(this.label_chosenPhone);
            this.groupBox_details.Controls.Add(this.lable_mail);
            this.groupBox_details.Controls.Add(this.label_phoneNumber);
            this.groupBox_details.Controls.Add(this.label_chosenFirst);
            this.groupBox_details.Controls.Add(this.label_first);
            this.groupBox_details.Controls.Add(this.label_ChosenLast);
            this.groupBox_details.Controls.Add(this.label_last);
            this.groupBox_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_details.Location = new System.Drawing.Point(478, 21);
            this.groupBox_details.Name = "groupBox_details";
            this.groupBox_details.Size = new System.Drawing.Size(277, 197);
            this.groupBox_details.TabIndex = 30;
            this.groupBox_details.TabStop = false;
            this.groupBox_details.Text = "Chosen client details";
            // 
            // label_chosenCity
            // 
            this.label_chosenCity.AutoSize = true;
            this.label_chosenCity.Location = new System.Drawing.Point(134, 158);
            this.label_chosenCity.Name = "label_chosenCity";
            this.label_chosenCity.Size = new System.Drawing.Size(0, 18);
            this.label_chosenCity.TabIndex = 34;
            // 
            // label_chosenMail
            // 
            this.label_chosenMail.AutoSize = true;
            this.label_chosenMail.Location = new System.Drawing.Point(134, 123);
            this.label_chosenMail.Name = "label_chosenMail";
            this.label_chosenMail.Size = new System.Drawing.Size(0, 18);
            this.label_chosenMail.TabIndex = 33;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_City.Location = new System.Drawing.Point(9, 158);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(42, 18);
            this.label_City.TabIndex = 32;
            this.label_City.Text = "City:";
            // 
            // label_chosenPhone
            // 
            this.label_chosenPhone.AutoSize = true;
            this.label_chosenPhone.Location = new System.Drawing.Point(134, 95);
            this.label_chosenPhone.Name = "label_chosenPhone";
            this.label_chosenPhone.Size = new System.Drawing.Size(0, 18);
            this.label_chosenPhone.TabIndex = 5;
            // 
            // lable_mail
            // 
            this.lable_mail.AutoSize = true;
            this.lable_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lable_mail.Location = new System.Drawing.Point(7, 126);
            this.lable_mail.Name = "lable_mail";
            this.lable_mail.Size = new System.Drawing.Size(44, 18);
            this.lable_mail.TabIndex = 31;
            this.lable_mail.Text = "Mail:";
            // 
            // label_phoneNumber
            // 
            this.label_phoneNumber.AutoSize = true;
            this.label_phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_phoneNumber.Location = new System.Drawing.Point(6, 95);
            this.label_phoneNumber.Name = "label_phoneNumber";
            this.label_phoneNumber.Size = new System.Drawing.Size(122, 18);
            this.label_phoneNumber.TabIndex = 4;
            this.label_phoneNumber.Text = "Phone number:";
            // 
            // label_chosenFirst
            // 
            this.label_chosenFirst.AutoSize = true;
            this.label_chosenFirst.Location = new System.Drawing.Point(134, 63);
            this.label_chosenFirst.Name = "label_chosenFirst";
            this.label_chosenFirst.Size = new System.Drawing.Size(0, 18);
            this.label_chosenFirst.TabIndex = 3;
            // 
            // label_first
            // 
            this.label_first.AutoSize = true;
            this.label_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_first.Location = new System.Drawing.Point(6, 63);
            this.label_first.Name = "label_first";
            this.label_first.Size = new System.Drawing.Size(93, 18);
            this.label_first.TabIndex = 2;
            this.label_first.Text = "First name:";
            // 
            // label_ChosenLast
            // 
            this.label_ChosenLast.AutoSize = true;
            this.label_ChosenLast.Location = new System.Drawing.Point(134, 32);
            this.label_ChosenLast.Name = "label_ChosenLast";
            this.label_ChosenLast.Size = new System.Drawing.Size(0, 18);
            this.label_ChosenLast.TabIndex = 1;
            // 
            // label_last
            // 
            this.label_last.AutoSize = true;
            this.label_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_last.Location = new System.Drawing.Point(8, 32);
            this.label_last.Name = "label_last";
            this.label_last.Size = new System.Drawing.Size(91, 18);
            this.label_last.TabIndex = 0;
            this.label_last.Text = "Last name:";
            // 
            // groupBox_clientFilter
            // 
            this.groupBox_clientFilter.Controls.Add(this.textBox_FirstName_Filter);
            this.groupBox_clientFilter.Controls.Add(this.label_FirstName);
            this.groupBox_clientFilter.Controls.Add(this.textBox_LastName_Filter);
            this.groupBox_clientFilter.Controls.Add(this.label_LastName);
            this.groupBox_clientFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_clientFilter.Location = new System.Drawing.Point(6, 21);
            this.groupBox_clientFilter.Name = "groupBox_clientFilter";
            this.groupBox_clientFilter.Size = new System.Drawing.Size(253, 141);
            this.groupBox_clientFilter.TabIndex = 29;
            this.groupBox_clientFilter.TabStop = false;
            this.groupBox_clientFilter.Text = "Filter";
            // 
            // textBox_FirstName_Filter
            // 
            this.textBox_FirstName_Filter.Location = new System.Drawing.Point(131, 77);
            this.textBox_FirstName_Filter.Name = "textBox_FirstName_Filter";
            this.textBox_FirstName_Filter.Size = new System.Drawing.Size(116, 26);
            this.textBox_FirstName_Filter.TabIndex = 30;
            this.textBox_FirstName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Client_filter_KeyUp);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_FirstName.Location = new System.Drawing.Point(6, 77);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(90, 20);
            this.label_FirstName.TabIndex = 29;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_LastName_Filter
            // 
            this.textBox_LastName_Filter.Location = new System.Drawing.Point(131, 41);
            this.textBox_LastName_Filter.Name = "textBox_LastName_Filter";
            this.textBox_LastName_Filter.Size = new System.Drawing.Size(116, 26);
            this.textBox_LastName_Filter.TabIndex = 28;
            this.textBox_LastName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_Client_filter_KeyUp);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_LastName.Location = new System.Drawing.Point(6, 43);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(90, 20);
            this.label_LastName.TabIndex = 27;
            this.label_LastName.Text = "Last Name:";
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 16;
            this.listBox_Clients.Location = new System.Drawing.Point(277, 20);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(181, 260);
            this.listBox_Clients.TabIndex = 26;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // Order_items
            // 
            this.Order_items.BackColor = System.Drawing.Color.LightCyan;
            this.Order_items.Controls.Add(this.groupBox_chosenProduct);
            this.Order_items.Controls.Add(this.ProductsInOrder);
            this.Order_items.Controls.Add(this.PotentialsProducts);
            this.Order_items.Controls.Add(this.groupBox1);
            this.Order_items.Controls.Add(this.listBox_ProductsInOrder);
            this.Order_items.Controls.Add(this.listBox_PotentialsProducts);
            this.Order_items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Order_items.Location = new System.Drawing.Point(4, 25);
            this.Order_items.Name = "Order_items";
            this.Order_items.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Order_items.Size = new System.Drawing.Size(761, 329);
            this.Order_items.TabIndex = 2;
            this.Order_items.Text = "Order items";
            // 
            // groupBox_chosenProduct
            // 
            this.groupBox_chosenProduct.Controls.Add(this.labelCat);
            this.groupBox_chosenProduct.Controls.Add(this.pCategory);
            this.groupBox_chosenProduct.Controls.Add(this.labelCom);
            this.groupBox_chosenProduct.Controls.Add(this.pCompany);
            this.groupBox_chosenProduct.Controls.Add(this.labelN);
            this.groupBox_chosenProduct.Controls.Add(this.pName);
            this.groupBox_chosenProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_chosenProduct.Location = new System.Drawing.Point(8, 201);
            this.groupBox_chosenProduct.Name = "groupBox_chosenProduct";
            this.groupBox_chosenProduct.Size = new System.Drawing.Size(241, 117);
            this.groupBox_chosenProduct.TabIndex = 49;
            this.groupBox_chosenProduct.TabStop = false;
            this.groupBox_chosenProduct.Text = "Chosen product details";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(134, 95);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(0, 18);
            this.labelCat.TabIndex = 5;
            // 
            // pCategory
            // 
            this.pCategory.AutoSize = true;
            this.pCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pCategory.Location = new System.Drawing.Point(6, 95);
            this.pCategory.Name = "pCategory";
            this.pCategory.Size = new System.Drawing.Size(81, 18);
            this.pCategory.TabIndex = 4;
            this.pCategory.Text = "Category:";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(134, 63);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(0, 18);
            this.labelCom.TabIndex = 3;
            // 
            // pCompany
            // 
            this.pCompany.AutoSize = true;
            this.pCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pCompany.Location = new System.Drawing.Point(6, 63);
            this.pCompany.Name = "pCompany";
            this.pCompany.Size = new System.Drawing.Size(84, 18);
            this.pCompany.TabIndex = 2;
            this.pCompany.Text = "Company:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(134, 32);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(0, 18);
            this.labelN.TabIndex = 1;
            // 
            // pName
            // 
            this.pName.AutoSize = true;
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pName.Location = new System.Drawing.Point(8, 32);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(57, 18);
            this.pName.TabIndex = 0;
            this.pName.Text = "Name:";
            // 
            // ProductsInOrder
            // 
            this.ProductsInOrder.AutoSize = true;
            this.ProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductsInOrder.Location = new System.Drawing.Point(545, 25);
            this.ProductsInOrder.Name = "ProductsInOrder";
            this.ProductsInOrder.Size = new System.Drawing.Size(147, 20);
            this.ProductsInOrder.TabIndex = 48;
            this.ProductsInOrder.Text = "Products In Order:";
            // 
            // PotentialsProducts
            // 
            this.PotentialsProducts.AutoSize = true;
            this.PotentialsProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.PotentialsProducts.Location = new System.Drawing.Point(287, 25);
            this.PotentialsProducts.Name = "PotentialsProducts";
            this.PotentialsProducts.Size = new System.Drawing.Size(160, 20);
            this.PotentialsProducts.TabIndex = 47;
            this.PotentialsProducts.Text = "Potentials Products:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Filter_Category);
            this.groupBox1.Controls.Add(this.comboBox_Filter_Category);
            this.groupBox1.Controls.Add(this.label_Filter_Company);
            this.groupBox1.Controls.Add(this.comboBox_Filter_Company);
            this.groupBox1.Controls.Add(this.textBox_Name_Filter);
            this.groupBox1.Controls.Add(this.label_Filter_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(8, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 170);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label_Filter_Category
            // 
            this.label_Filter_Category.AutoSize = true;
            this.label_Filter_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Category.Location = new System.Drawing.Point(14, 127);
            this.label_Filter_Category.Name = "label_Filter_Category";
            this.label_Filter_Category.Size = new System.Drawing.Size(73, 20);
            this.label_Filter_Category.TabIndex = 44;
            this.label_Filter_Category.Text = "Category";
            // 
            // comboBox_Filter_Category
            // 
            this.comboBox_Filter_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Filter_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Filter_Category.DisplayMember = "city";
            this.comboBox_Filter_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_Filter_Category.FormattingEnabled = true;
            this.comboBox_Filter_Category.Location = new System.Drawing.Point(97, 126);
            this.comboBox_Filter_Category.Name = "comboBox_Filter_Category";
            this.comboBox_Filter_Category.Size = new System.Drawing.Size(144, 26);
            this.comboBox_Filter_Category.TabIndex = 43;
            this.comboBox_Filter_Category.ValueMember = "city";
            this.comboBox_Filter_Category.TextChanged += new System.EventHandler(this.comboBoxProductFilter_TextChanged);
            // 
            // label_Filter_Company
            // 
            this.label_Filter_Company.AutoSize = true;
            this.label_Filter_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Company.Location = new System.Drawing.Point(14, 85);
            this.label_Filter_Company.Name = "label_Filter_Company";
            this.label_Filter_Company.Size = new System.Drawing.Size(76, 20);
            this.label_Filter_Company.TabIndex = 42;
            this.label_Filter_Company.Text = "Company";
            // 
            // comboBox_Filter_Company
            // 
            this.comboBox_Filter_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Filter_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Filter_Company.DisplayMember = "city";
            this.comboBox_Filter_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Filter_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_Filter_Company.FormattingEnabled = true;
            this.comboBox_Filter_Company.Location = new System.Drawing.Point(98, 84);
            this.comboBox_Filter_Company.Name = "comboBox_Filter_Company";
            this.comboBox_Filter_Company.Size = new System.Drawing.Size(143, 26);
            this.comboBox_Filter_Company.TabIndex = 41;
            this.comboBox_Filter_Company.ValueMember = "city";
            this.comboBox_Filter_Company.TextChanged += new System.EventHandler(this.comboBoxProductFilter_TextChanged);
            // 
            // textBox_Name_Filter
            // 
            this.textBox_Name_Filter.Location = new System.Drawing.Point(97, 42);
            this.textBox_Name_Filter.Name = "textBox_Name_Filter";
            this.textBox_Name_Filter.Size = new System.Drawing.Size(144, 26);
            this.textBox_Name_Filter.TabIndex = 32;
            this.textBox_Name_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ProductFilter_KeyUp);
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Name.Location = new System.Drawing.Point(14, 40);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Filter_Name.TabIndex = 30;
            this.label_Filter_Name.Text = "Name:";
            // 
            // listBox_ProductsInOrder
            // 
            this.listBox_ProductsInOrder.FormattingEnabled = true;
            this.listBox_ProductsInOrder.ItemHeight = 16;
            this.listBox_ProductsInOrder.Location = new System.Drawing.Point(523, 48);
            this.listBox_ProductsInOrder.Name = "listBox_ProductsInOrder";
            this.listBox_ProductsInOrder.Size = new System.Drawing.Size(198, 244);
            this.listBox_ProductsInOrder.TabIndex = 1;
            this.listBox_ProductsInOrder.DoubleClick += new System.EventHandler(this.listBox_ProductsInOrder_DoubleClick);
            // 
            // listBox_PotentialsProducts
            // 
            this.listBox_PotentialsProducts.FormattingEnabled = true;
            this.listBox_PotentialsProducts.ItemHeight = 16;
            this.listBox_PotentialsProducts.Location = new System.Drawing.Point(276, 52);
            this.listBox_PotentialsProducts.Name = "listBox_PotentialsProducts";
            this.listBox_PotentialsProducts.Size = new System.Drawing.Size(192, 244);
            this.listBox_PotentialsProducts.TabIndex = 0;
            this.listBox_PotentialsProducts.Click += new System.EventHandler(this.ListBox_Products_Click);
            this.listBox_PotentialsProducts.DoubleClick += new System.EventHandler(this.listBox_PotentialsProducts_DoubleClick);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_clear.Location = new System.Drawing.Point(654, 364);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 37);
            this.button_clear.TabIndex = 14;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DimGray;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_button.Location = new System.Drawing.Point(553, 361);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(95, 41);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.save_button);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Order_InputLanguageChanged);
            this.tabControl1.ResumeLayout(false);
            this.Order_details.ResumeLayout(false);
            this.Order_details.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.Order_client.ResumeLayout(false);
            this.groupBox_details.ResumeLayout(false);
            this.groupBox_details.PerformLayout();
            this.groupBox_clientFilter.ResumeLayout(false);
            this.groupBox_clientFilter.PerformLayout();
            this.Order_items.ResumeLayout(false);
            this.Order_items.PerformLayout();
            this.groupBox_chosenProduct.ResumeLayout(false);
            this.groupBox_chosenProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Order_details;
        private System.Windows.Forms.TabPage Order_client;
        private System.Windows.Forms.TabPage Order_items;
        private System.Windows.Forms.Label label_ChosenClient;
        private System.Windows.Forms.Label label_client1;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label label_Comment;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label lablel_Id;
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
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox groupBox_clientFilter;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName_Filter;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.TextBox textBox_FirstName_Filter;
        private System.Windows.Forms.GroupBox groupBox_details;
        private System.Windows.Forms.Label label_chosenPhone;
        private System.Windows.Forms.Label label_phoneNumber;
        private System.Windows.Forms.Label label_chosenFirst;
        private System.Windows.Forms.Label label_first;
        private System.Windows.Forms.Label label_ChosenLast;
        private System.Windows.Forms.Label label_last;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.Label lable_mail;
        private System.Windows.Forms.Label label_chosenCity;
        private System.Windows.Forms.Label label_chosenMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_ProductsInOrder;
        private System.Windows.Forms.ListBox listBox_PotentialsProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Filter_Category;
        private System.Windows.Forms.ComboBox comboBox_Filter_Category;
        private System.Windows.Forms.Label label_Filter_Company;
        private System.Windows.Forms.ComboBox comboBox_Filter_Company;
        private System.Windows.Forms.TextBox textBox_Name_Filter;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Windows.Forms.Label PotentialsProducts;
        private System.Windows.Forms.Label ProductsInOrder;
        private System.Windows.Forms.GroupBox groupBox_chosenProduct;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label pCategory;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label pCompany;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label pName;
    }
}