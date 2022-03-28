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
            this.button_Return = new System.Windows.Forms.Button();
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
            this.groupBox_chosenProduct = new System.Windows.Forms.GroupBox();
            this.labelCat = new System.Windows.Forms.Label();
            this.pCategory = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.pCompany = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.pName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_filterCount = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label_Filter_Category = new System.Windows.Forms.Label();
            this.comboBox_Filter_Category = new System.Windows.Forms.ComboBox();
            this.label_Filter_Company = new System.Windows.Forms.Label();
            this.comboBox_Filter_Company = new System.Windows.Forms.ComboBox();
            this.textBox_Name_Filter = new System.Windows.Forms.TextBox();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.listBox_ProductsInOrderCount = new System.Windows.Forms.ListBox();
            this.ProductsInOrder = new System.Windows.Forms.Label();
            this.listBox_ProductsInOrder = new System.Windows.Forms.ListBox();
            this.label_ChosenQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_Orders.SuspendLayout();
            this.groupBox_OrderDetails.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.tabPage_Return.SuspendLayout();
            this.groupBox_chosenProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(788, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Orders
            // 
            this.tabPage_Orders.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Orders.Controls.Add(this.groupBox_OrderDetails);
            this.tabPage_Orders.Controls.Add(this.button_Return);
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
            // groupBox_OrderDetails
            // 
            this.groupBox_OrderDetails.Controls.Add(this.label1_ChosenClient);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenClient);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenDate);
            this.groupBox_OrderDetails.Controls.Add(this.label_Date);
            this.groupBox_OrderDetails.Controls.Add(this.label_ChosenId);
            this.groupBox_OrderDetails.Controls.Add(this.label_id);
            this.groupBox_OrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_OrderDetails.Location = new System.Drawing.Point(526, 43);
            this.groupBox_OrderDetails.Name = "groupBox_OrderDetails";
            this.groupBox_OrderDetails.Size = new System.Drawing.Size(198, 193);
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
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.LightCoral;
            this.button_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Return.Location = new System.Drawing.Point(536, 275);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(97, 38);
            this.button_Return.TabIndex = 57;
            this.button_Return.Text = "Return";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 16;
            this.listBox_Orders.Location = new System.Drawing.Point(268, 53);
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
            // tabPage_Return
            // 
            this.tabPage_Return.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_Return.Controls.Add(this.groupBox_chosenProduct);
            this.tabPage_Return.Controls.Add(this.groupBox1);
            this.tabPage_Return.Controls.Add(this.listBox_ProductsInOrderCount);
            this.tabPage_Return.Controls.Add(this.ProductsInOrder);
            this.tabPage_Return.Controls.Add(this.listBox_ProductsInOrder);
            this.tabPage_Return.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Return.Name = "tabPage_Return";
            this.tabPage_Return.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Return.Size = new System.Drawing.Size(780, 368);
            this.tabPage_Return.TabIndex = 1;
            this.tabPage_Return.Text = "Return products";
            // 
            // groupBox_chosenProduct
            // 
            this.groupBox_chosenProduct.Controls.Add(this.label_ChosenQuantity);
            this.groupBox_chosenProduct.Controls.Add(this.label3);
            this.groupBox_chosenProduct.Controls.Add(this.labelCat);
            this.groupBox_chosenProduct.Controls.Add(this.pCategory);
            this.groupBox_chosenProduct.Controls.Add(this.labelCom);
            this.groupBox_chosenProduct.Controls.Add(this.pCompany);
            this.groupBox_chosenProduct.Controls.Add(this.labelN);
            this.groupBox_chosenProduct.Controls.Add(this.pName);
            this.groupBox_chosenProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_chosenProduct.Location = new System.Drawing.Point(8, 210);
            this.groupBox_chosenProduct.Name = "groupBox_chosenProduct";
            this.groupBox_chosenProduct.Size = new System.Drawing.Size(241, 152);
            this.groupBox_chosenProduct.TabIndex = 59;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_filterCount);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.label_Filter_Category);
            this.groupBox1.Controls.Add(this.comboBox_Filter_Category);
            this.groupBox1.Controls.Add(this.label_Filter_Company);
            this.groupBox1.Controls.Add(this.comboBox_Filter_Company);
            this.groupBox1.Controls.Add(this.textBox_Name_Filter);
            this.groupBox1.Controls.Add(this.label_Filter_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 201);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label_filterCount
            // 
            this.label_filterCount.AutoSize = true;
            this.label_filterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_filterCount.Location = new System.Drawing.Point(14, 169);
            this.label_filterCount.Name = "label_filterCount";
            this.label_filterCount.Size = new System.Drawing.Size(98, 20);
            this.label_filterCount.TabIndex = 49;
            this.label_filterCount.Text = "Min quantity:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown2.Location = new System.Drawing.Point(129, 169);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(89, 26);
            this.numericUpDown2.TabIndex = 50;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
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
            // listBox_ProductsInOrderCount
            // 
            this.listBox_ProductsInOrderCount.FormattingEnabled = true;
            this.listBox_ProductsInOrderCount.ItemHeight = 16;
            this.listBox_ProductsInOrderCount.Location = new System.Drawing.Point(536, 31);
            this.listBox_ProductsInOrderCount.Name = "listBox_ProductsInOrderCount";
            this.listBox_ProductsInOrderCount.Size = new System.Drawing.Size(25, 244);
            this.listBox_ProductsInOrderCount.TabIndex = 56;
            this.listBox_ProductsInOrderCount.Click += new System.EventHandler(this.listBox_ProductsInOrderCount_Click);
            // 
            // ProductsInOrder
            // 
            this.ProductsInOrder.AutoSize = true;
            this.ProductsInOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ProductsInOrder.Location = new System.Drawing.Point(360, 8);
            this.ProductsInOrder.Name = "ProductsInOrder";
            this.ProductsInOrder.Size = new System.Drawing.Size(147, 20);
            this.ProductsInOrder.TabIndex = 55;
            this.ProductsInOrder.Text = "Products In Order:";
            // 
            // listBox_ProductsInOrder
            // 
            this.listBox_ProductsInOrder.FormattingEnabled = true;
            this.listBox_ProductsInOrder.ItemHeight = 16;
            this.listBox_ProductsInOrder.Location = new System.Drawing.Point(338, 31);
            this.listBox_ProductsInOrder.Name = "listBox_ProductsInOrder";
            this.listBox_ProductsInOrder.Size = new System.Drawing.Size(198, 244);
            this.listBox_ProductsInOrder.TabIndex = 54;
            this.listBox_ProductsInOrder.Click += new System.EventHandler(this.listBox_ProductsInOrder_Click);
            // 
            // label_ChosenQuantity
            // 
            this.label_ChosenQuantity.AutoSize = true;
            this.label_ChosenQuantity.Location = new System.Drawing.Point(134, 127);
            this.label_ChosenQuantity.Name = "label_ChosenQuantity";
            this.label_ChosenQuantity.Size = new System.Drawing.Size(0, 18);
            this.label_ChosenQuantity.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity:";
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
            this.groupBox_OrderDetails.ResumeLayout(false);
            this.groupBox_OrderDetails.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.tabPage_Return.ResumeLayout(false);
            this.tabPage_Return.PerformLayout();
            this.groupBox_chosenProduct.ResumeLayout(false);
            this.groupBox_chosenProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox_chosenProduct;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label pCategory;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Label pCompany;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label pName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_filterCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_Filter_Category;
        private System.Windows.Forms.ComboBox comboBox_Filter_Category;
        private System.Windows.Forms.Label label_Filter_Company;
        private System.Windows.Forms.ComboBox comboBox_Filter_Company;
        private System.Windows.Forms.TextBox textBox_Name_Filter;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Windows.Forms.Label label_ChosenQuantity;
        private System.Windows.Forms.Label label3;
    }
}