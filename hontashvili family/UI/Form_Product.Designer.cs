
namespace hontashvili_family.UI
{
    partial class Form_Product
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
            this.button_AddCompany = new System.Windows.Forms.Button();
            this.company = new System.Windows.Forms.Label();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.textBox_Name_Filter = new System.Windows.Forms.TextBox();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_AddCategory = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.label_Filter_Category = new System.Windows.Forms.Label();
            this.comboBox_Filter_Category = new System.Windows.Forms.ComboBox();
            this.label_Filter_Company = new System.Windows.Forms.Label();
            this.comboBox_Filter_Company = new System.Windows.Forms.ComboBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label_filterCount = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_Count = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddCompany
            // 
            this.button_AddCompany.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_AddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddCompany.Location = new System.Drawing.Point(761, 109);
            this.button_AddCompany.Name = "button_AddCompany";
            this.button_AddCompany.Size = new System.Drawing.Size(25, 28);
            this.button_AddCompany.TabIndex = 3;
            this.button_AddCompany.Text = "+";
            this.button_AddCompany.UseVisualStyleBackColor = false;
            this.button_AddCompany.Click += new System.EventHandler(this.button_AddCompany_Click);
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.company.Location = new System.Drawing.Point(527, 114);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(80, 20);
            this.company.TabIndex = 34;
            this.company.Text = "Company:";
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Company.DisplayMember = "city";
            this.comboBox_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(634, 111);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Company.TabIndex = 2;
            this.comboBox_Company.ValueMember = "city";
            // 
            // textBox_Name_Filter
            // 
            this.textBox_Name_Filter.Location = new System.Drawing.Point(97, 42);
            this.textBox_Name_Filter.Name = "textBox_Name_Filter";
            this.textBox_Name_Filter.Size = new System.Drawing.Size(100, 29);
            this.textBox_Name_Filter.TabIndex = 32;
            this.textBox_Name_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_Name_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
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
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(651, 252);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 27);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(527, 33);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 26;
            this.ID.Text = "ID";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(670, 33);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 25;
            this.label_id.Text = "0";
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DimGray;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_button.Location = new System.Drawing.Point(531, 252);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(114, 61);
            this.save_button.TabIndex = 6;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name.Location = new System.Drawing.Point(527, 72);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 22;
            this.name.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(634, 72);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(143, 20);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_Name.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // button_AddCategory
            // 
            this.button_AddCategory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_AddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddCategory.Location = new System.Drawing.Point(761, 159);
            this.button_AddCategory.Name = "button_AddCategory";
            this.button_AddCategory.Size = new System.Drawing.Size(25, 28);
            this.button_AddCategory.TabIndex = 5;
            this.button_AddCategory.Text = "+";
            this.button_AddCategory.UseVisualStyleBackColor = false;
            this.button_AddCategory.Click += new System.EventHandler(this.button_AddCategory_Click);
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.category.Location = new System.Drawing.Point(527, 167);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(77, 20);
            this.category.TabIndex = 38;
            this.category.Text = "Category:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Category.DisplayMember = "city";
            this.comboBox_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(634, 162);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Category.TabIndex = 4;
            this.comboBox_Category.ValueMember = "city";
            // 
            // listBox_Products
            // 
            this.listBox_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 16;
            this.listBox_Products.Location = new System.Drawing.Point(247, 20);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(264, 292);
            this.listBox_Products.TabIndex = 36;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.ListBox_Products_DoubleClick);
            // 
            // label_Filter_Category
            // 
            this.label_Filter_Category.AutoSize = true;
            this.label_Filter_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Category.Location = new System.Drawing.Point(14, 127);
            this.label_Filter_Category.Name = "label_Filter_Category";
            this.label_Filter_Category.Size = new System.Drawing.Size(77, 20);
            this.label_Filter_Category.TabIndex = 44;
            this.label_Filter_Category.Text = "Category:";
            // 
            // comboBox_Filter_Category
            // 
            this.comboBox_Filter_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Filter_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Filter_Category.DisplayMember = "city";
            this.comboBox_Filter_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_Filter_Category.FormattingEnabled = true;
            this.comboBox_Filter_Category.Location = new System.Drawing.Point(97, 126);
            this.comboBox_Filter_Category.Name = "comboBox_Filter_Category";
            this.comboBox_Filter_Category.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Filter_Category.TabIndex = 43;
            this.comboBox_Filter_Category.ValueMember = "city";
            this.comboBox_Filter_Category.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // label_Filter_Company
            // 
            this.label_Filter_Company.AutoSize = true;
            this.label_Filter_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Company.Location = new System.Drawing.Point(14, 85);
            this.label_Filter_Company.Name = "label_Filter_Company";
            this.label_Filter_Company.Size = new System.Drawing.Size(80, 20);
            this.label_Filter_Company.TabIndex = 42;
            this.label_Filter_Company.Text = "Company:";
            // 
            // comboBox_Filter_Company
            // 
            this.comboBox_Filter_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Filter_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Filter_Company.DisplayMember = "city";
            this.comboBox_Filter_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_Filter_Company.FormattingEnabled = true;
            this.comboBox_Filter_Company.Location = new System.Drawing.Point(98, 84);
            this.comboBox_Filter_Company.Name = "comboBox_Filter_Company";
            this.comboBox_Filter_Company.Size = new System.Drawing.Size(99, 28);
            this.comboBox_Filter_Company.TabIndex = 41;
            this.comboBox_Filter_Company.ValueMember = "city";
            this.comboBox_Filter_Company.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.label_filterCount);
            this.groupBox_Filter.Controls.Add(this.numericUpDown2);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Category);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Category);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Company);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Company);
            this.groupBox_Filter.Controls.Add(this.textBox_Name_Filter);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Name);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 20);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(229, 237);
            this.groupBox_Filter.TabIndex = 45;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // label_filterCount
            // 
            this.label_filterCount.AutoSize = true;
            this.label_filterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_filterCount.Location = new System.Drawing.Point(14, 166);
            this.label_filterCount.Name = "label_filterCount";
            this.label_filterCount.Size = new System.Drawing.Size(102, 20);
            this.label_filterCount.TabIndex = 48;
            this.label_filterCount.Text = "Max quantity:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown2.Location = new System.Drawing.Point(134, 164);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown2.TabIndex = 48;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown1.Location = new System.Drawing.Point(634, 209);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 26);
            this.numericUpDown1.TabIndex = 46;
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Count.Location = new System.Drawing.Point(527, 209);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(78, 20);
            this.label_Count.TabIndex = 47;
            this.label_Count.Text = "Inventory:";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Location = new System.Drawing.Point(651, 286);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 27);
            this.button_delete.TabIndex = 48;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(774, 2);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 49;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.button_AddCategory);
            this.Controls.Add(this.category);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.button_AddCompany);
            this.Controls.Add(this.company);
            this.Controls.Add(this.comboBox_Company);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_Product";
            this.Text = "Product";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Product_InputLanguageChanged);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddCompany;
        private System.Windows.Forms.Label company;
        private System.Windows.Forms.ComboBox comboBox_Company;
        private System.Windows.Forms.TextBox textBox_Name_Filter;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_AddCategory;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Label label_Filter_Category;
        private System.Windows.Forms.ComboBox comboBox_Filter_Category;
        private System.Windows.Forms.Label label_Filter_Company;
        private System.Windows.Forms.ComboBox comboBox_Filter_Company;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.Label label_filterCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_Home;
    }
}