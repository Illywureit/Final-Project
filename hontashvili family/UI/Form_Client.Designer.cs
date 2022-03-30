namespace hontashvili_family.UI
{
    partial class Form_Client
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_id = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_FirstName_Filter = new System.Windows.Forms.TextBox();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_AddCity = new System.Windows.Forms.Button();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.textBox_LastName_Filter = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(638, 62);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(143, 21);
            this.textBox_FirstName.TabIndex = 1;
            this.textBox_FirstName.TextChanged += new System.EventHandler(this.textBox_Name_Leave);
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.firstName.Location = new System.Drawing.Point(490, 59);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(90, 20);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First Name:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lastName.Location = new System.Drawing.Point(491, 97);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(90, 20);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name:";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mail.Location = new System.Drawing.Point(489, 173);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(41, 20);
            this.mail.TabIndex = 5;
            this.mail.Text = "Mail:";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.phone.Location = new System.Drawing.Point(489, 137);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(119, 20);
            this.phone.TabIndex = 6;
            this.phone.Text = "Phone Number:";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(637, 136);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(143, 21);
            this.textBox_Phone.TabIndex = 3;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_Leave);
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DimGray;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_button.Location = new System.Drawing.Point(493, 279);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(114, 61);
            this.save_button.TabIndex = 7;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 16;
            this.listBox_Clients.Location = new System.Drawing.Point(244, 19);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(214, 292);
            this.listBox_Clients.TabIndex = 9;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.ListBox_Clients_DoubleClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(633, 20);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 10;
            this.label_id.Text = "0";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(490, 20);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 20);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID";
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(612, 279);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 27);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Location = new System.Drawing.Point(613, 314);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 27);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_FirstName.Location = new System.Drawing.Point(13, 47);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(90, 20);
            this.label_FirstName.TabIndex = 16;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_FirstName_Filter
            // 
            this.textBox_FirstName_Filter.Location = new System.Drawing.Point(110, 44);
            this.textBox_FirstName_Filter.Name = "textBox_FirstName_Filter";
            this.textBox_FirstName_Filter.Size = new System.Drawing.Size(100, 29);
            this.textBox_FirstName_Filter.TabIndex = 18;
            this.textBox_FirstName_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_FirstName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_filter_KeyUp);
            // 
            // comboBox_City
            // 
            this.comboBox_City.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_City.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_City.DisplayMember = "city";
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(638, 210);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(121, 23);
            this.comboBox_City.TabIndex = 5;
            this.comboBox_City.ValueMember = "city";
            this.comboBox_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(491, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "City:";
            // 
            // button_AddCity
            // 
            this.button_AddCity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_AddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_AddCity.Location = new System.Drawing.Point(769, 207);
            this.button_AddCity.Name = "button_AddCity";
            this.button_AddCity.Size = new System.Drawing.Size(25, 28);
            this.button_AddCity.TabIndex = 6;
            this.button_AddCity.Text = "+";
            this.button_AddCity.UseVisualStyleBackColor = false;
            this.button_AddCity.Click += new System.EventHandler(this.button_AddCity_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(637, 96);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(143, 21);
            this.textBox_LastName.TabIndex = 2;
            this.textBox_LastName.TextChanged += new System.EventHandler(this.textBox_Name_Leave);
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_LastName.Location = new System.Drawing.Point(12, 88);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(90, 20);
            this.label_LastName.TabIndex = 23;
            this.label_LastName.Text = "Last Name:";
            // 
            // textBox_LastName_Filter
            // 
            this.textBox_LastName_Filter.Location = new System.Drawing.Point(108, 88);
            this.textBox_LastName_Filter.Name = "textBox_LastName_Filter";
            this.textBox_LastName_Filter.Size = new System.Drawing.Size(102, 29);
            this.textBox_LastName_Filter.TabIndex = 24;
            this.textBox_LastName_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_LastName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_filter_KeyUp);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(638, 172);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(143, 21);
            this.textBox_Mail.TabIndex = 4;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.textBox_FirstName_Filter);
            this.groupBox_Filter.Controls.Add(this.label_FirstName);
            this.groupBox_Filter.Controls.Add(this.textBox_LastName_Filter);
            this.groupBox_Filter.Controls.Add(this.label_LastName);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 23);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(226, 137);
            this.groupBox_Filter.TabIndex = 25;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(813, 8);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 26;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(880, 407);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.button_AddCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.textBox_FirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "Form_Client";
            this.Text = "Client";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Client_InputLanguageChanged);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_FirstName_Filter;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_AddCity;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox textBox_LastName_Filter;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Button button_Home;
    }
}

