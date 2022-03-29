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
            this.listView_Orders = new System.Windows.Forms.ListView();
            this.columnMonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOrders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Orders
            // 
            this.listView_Orders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMonth,
            this.columnOrders});
            this.listView_Orders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Orders.HideSelection = false;
            this.listView_Orders.Location = new System.Drawing.Point(24, 60);
            this.listView_Orders.Name = "listView_Orders";
            this.listView_Orders.Size = new System.Drawing.Size(370, 332);
            this.listView_Orders.TabIndex = 0;
            this.listView_Orders.UseCompatibleStateImageBehavior = false;
            this.listView_Orders.View = System.Windows.Forms.View.Details;
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
            // Form_OrderMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_Orders);
            this.Name = "Form_OrderMonthReport";
            this.Text = "Form_OrderMonthReport";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Orders;
        private System.Windows.Forms.ColumnHeader columnMonth;
        private System.Windows.Forms.ColumnHeader columnOrders;
    }
}