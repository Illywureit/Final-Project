
namespace Illy_Project.UI
{
    partial class Form_Company
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.listBox_Companies = new System.Windows.Forms.ListBox();
            this.save_button = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Location = new System.Drawing.Point(211, 284);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 27);
            this.button_delete.TabIndex = 29;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(211, 253);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(87, 27);
            this.button_clear.TabIndex = 28;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(212, 69);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(27, 20);
            this.ID.TabIndex = 27;
            this.ID.Text = "Id:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_id.Location = new System.Drawing.Point(293, 69);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(18, 20);
            this.label_id.TabIndex = 26;
            this.label_id.Text = "0";
            // 
            // listBox_Companies
            // 
            this.listBox_Companies.FormattingEnabled = true;
            this.listBox_Companies.Location = new System.Drawing.Point(12, 12);
            this.listBox_Companies.Name = "listBox_Companies";
            this.listBox_Companies.Size = new System.Drawing.Size(180, 303);
            this.listBox_Companies.TabIndex = 25;
            this.listBox_Companies.DoubleClick += new System.EventHandler(this.ListBox_Companies_DoubleClick);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.DimGray;
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.save_button.Location = new System.Drawing.Point(304, 250);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(114, 61);
            this.save_button.TabIndex = 24;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name.Location = new System.Drawing.Point(212, 108);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(55, 20);
            this.name.TabIndex = 23;
            this.name.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(297, 110);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(116, 20);
            this.textBox_Name.TabIndex = 22;
            this.textBox_Name.Leave += new System.EventHandler(this.textBox_Name_Leave);
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::Illy_Project.Properties.Resources.Back;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(362, 12);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 30;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(431, 323);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.listBox_Companies);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_Company";
            this.Text = "Company";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Company_InputLanguageChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.ListBox listBox_Companies;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Home;
    }
}