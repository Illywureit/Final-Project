namespace Illy_Project.UI
{
    partial class Form_ClientReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ClientReport));
            this.button_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Home = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_FirstName_Filter = new System.Windows.Forms.TextBox();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_LastName_Filter = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.BackgroundImage = global::Illy_Project.Properties.Resources.clear_icon;
            this.button_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_clear.Location = new System.Drawing.Point(577, 72);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(32, 46);
            this.button_clear.TabIndex = 53;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Clients Report";
            // 
            // listViewClients
            // 
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFName,
            this.ColumnLName,
            this.columnPhone,
            this.columnMail,
            this.columnCity});
            this.listViewClients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 120);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(623, 295);
            this.listViewClients.TabIndex = 51;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            this.listViewClients.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Clients_ColumnClick);
            // 
            // columnFName
            // 
            this.columnFName.Text = "First Name";
            this.columnFName.Width = 123;
            // 
            // ColumnLName
            // 
            this.ColumnLName.Text = "Last Name";
            this.ColumnLName.Width = 125;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone Number";
            this.columnPhone.Width = 158;
            // 
            // columnMail
            // 
            this.columnMail.Text = "Mail";
            this.columnMail.Width = 125;
            // 
            // columnCity
            // 
            this.columnCity.Text = "City";
            this.columnCity.Width = 91;
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::Illy_Project.Properties.Resources.Back;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(656, 12);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 56;
            this.button_Home.UseVisualStyleBackColor = true;
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.SystemColors.Control;
            this.button_Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Print.BackgroundImage")));
            this.button_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Print.Location = new System.Drawing.Point(641, 345);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(73, 70);
            this.button_Print.TabIndex = 55;
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.textBox_FirstName_Filter);
            this.groupBox_Filter.Controls.Add(this.label_FirstName);
            this.groupBox_Filter.Controls.Add(this.textBox_LastName_Filter);
            this.groupBox_Filter.Controls.Add(this.label_LastName);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(79, 60);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(492, 58);
            this.groupBox_Filter.TabIndex = 57;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox_FirstName_Filter
            // 
            this.textBox_FirstName_Filter.Location = new System.Drawing.Point(110, 25);
            this.textBox_FirstName_Filter.Name = "textBox_FirstName_Filter";
            this.textBox_FirstName_Filter.Size = new System.Drawing.Size(100, 26);
            this.textBox_FirstName_Filter.TabIndex = 18;
            this.textBox_FirstName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ClientFilter_KeyUp);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_FirstName.Location = new System.Drawing.Point(13, 28);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(90, 20);
            this.label_FirstName.TabIndex = 16;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_LastName_Filter
            // 
            this.textBox_LastName_Filter.Location = new System.Drawing.Point(341, 25);
            this.textBox_LastName_Filter.Name = "textBox_LastName_Filter";
            this.textBox_LastName_Filter.Size = new System.Drawing.Size(102, 26);
            this.textBox_LastName_Filter.TabIndex = 24;
            this.textBox_LastName_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ClientFilter_KeyUp);
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_LastName.Location = new System.Drawing.Point(245, 25);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(90, 20);
            this.label_LastName.TabIndex = 23;
            this.label_LastName.Text = "Last Name:";
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
            // Form_ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewClients);
            this.Name = "Form_ClientReport";
            this.Text = "Clients Report";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ColumnHeader columnFName;
        private System.Windows.Forms.ColumnHeader ColumnLName;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnMail;
        private System.Windows.Forms.ColumnHeader columnCity;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.TextBox textBox_FirstName_Filter;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName_Filter;
        private System.Windows.Forms.Label label_LastName;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}