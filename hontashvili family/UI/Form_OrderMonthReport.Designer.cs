namespace hontashvili_family.UI
{
    partial class Form_OrderMonthReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OrderMonthReport));
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.columnMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_head = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button_Print = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMonth,
            this.columnOrders});
            this.listViewOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(49, 106);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(370, 332);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnMonth
            // 
            this.columnMonth.Text = "Month";
            this.columnMonth.Width = 138;
            // 
            // columnOrders
            // 
            this.columnOrders.Text = "Amont of orders";
            this.columnOrders.Width = 199;
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.Location = new System.Drawing.Point(45, 27);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(462, 20);
            this.label_head.TabIndex = 52;
            this.label_head.Text = "Number of orders each month - annual report";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown1.Location = new System.Drawing.Point(196, 64);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 29);
            this.numericUpDown1.TabIndex = 53;
            this.numericUpDown1.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 54;
            this.label1.Text = "Year:";
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
            this.button_Print.Location = new System.Drawing.Point(573, 188);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(91, 88);
            this.button_Print.TabIndex = 55;
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(730, 5);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 56;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // Form_OrderMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_Print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label_head);
            this.Controls.Add(this.listViewOrders);
            this.Name = "Form_OrderMonthReport";
            this.Text = "Form_OrderMonthReport";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.ColumnHeader columnMonth;
        private System.Windows.Forms.ColumnHeader columnOrders;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button_Home;
    }
}