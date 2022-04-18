namespace hontashvili_family.UI
{
    partial class Form_ProductsInOrdersReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_clear = new System.Windows.Forms.Button();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label_filterCount = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label_Filter_Category = new System.Windows.Forms.Label();
            this.comboBox_Filter_Category = new System.Windows.Forms.ComboBox();
            this.label_Filter_Company = new System.Windows.Forms.Label();
            this.comboBox_Filter_Company = new System.Windows.Forms.ComboBox();
            this.textBox_Name_Filter = new System.Windows.Forms.TextBox();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.button_Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 325);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_clear.Location = new System.Drawing.Point(651, 70);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 37);
            this.button_clear.TabIndex = 49;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
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
            this.groupBox_Filter.Location = new System.Drawing.Point(3, 53);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(642, 63);
            this.groupBox_Filter.TabIndex = 48;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // label_filterCount
            // 
            this.label_filterCount.AutoSize = true;
            this.label_filterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_filterCount.Location = new System.Drawing.Point(483, 25);
            this.label_filterCount.Name = "label_filterCount";
            this.label_filterCount.Size = new System.Drawing.Size(84, 16);
            this.label_filterCount.TabIndex = 48;
            this.label_filterCount.Text = "Max quantity:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown2.Location = new System.Drawing.Point(573, 21);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(63, 26);
            this.numericUpDown2.TabIndex = 48;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.comboBoxProductFilter_TextChanged);
            // 
            // label_Filter_Category
            // 
            this.label_Filter_Category.AutoSize = true;
            this.label_Filter_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Category.Location = new System.Drawing.Point(306, 25);
            this.label_Filter_Category.Name = "label_Filter_Category";
            this.label_Filter_Category.Size = new System.Drawing.Size(65, 16);
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
            this.comboBox_Filter_Category.Location = new System.Drawing.Point(377, 19);
            this.comboBox_Filter_Category.Name = "comboBox_Filter_Category";
            this.comboBox_Filter_Category.Size = new System.Drawing.Size(100, 28);
            this.comboBox_Filter_Category.TabIndex = 43;
            this.comboBox_Filter_Category.ValueMember = "city";
            this.comboBox_Filter_Category.TextChanged += new System.EventHandler(this.comboBoxProductFilter_TextChanged);
            // 
            // label_Filter_Company
            // 
            this.label_Filter_Company.AutoSize = true;
            this.label_Filter_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Company.Location = new System.Drawing.Point(143, 27);
            this.label_Filter_Company.Name = "label_Filter_Company";
            this.label_Filter_Company.Size = new System.Drawing.Size(68, 16);
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
            this.comboBox_Filter_Company.Location = new System.Drawing.Point(217, 19);
            this.comboBox_Filter_Company.Name = "comboBox_Filter_Company";
            this.comboBox_Filter_Company.Size = new System.Drawing.Size(83, 28);
            this.comboBox_Filter_Company.TabIndex = 41;
            this.comboBox_Filter_Company.ValueMember = "city";
            this.comboBox_Filter_Company.TextChanged += new System.EventHandler(this.comboBoxProductFilter_TextChanged);
            // 
            // textBox_Name_Filter
            // 
            this.textBox_Name_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox_Name_Filter.Location = new System.Drawing.Point(67, 21);
            this.textBox_Name_Filter.Name = "textBox_Name_Filter";
            this.textBox_Name_Filter.Size = new System.Drawing.Size(70, 26);
            this.textBox_Name_Filter.TabIndex = 32;
            this.textBox_Name_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_ProductFilter_KeyUp);
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_Filter_Name.Location = new System.Drawing.Point(14, 26);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(47, 16);
            this.label_Filter_Name.TabIndex = 30;
            this.label_Filter_Name.Text = "Name:";
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::hontashvili_family.Properties.Resources.חזרה;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(740, 18);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 51;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Products In orders Report";
            // 
            // Form_ProductsInOrdersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.chart1);
            this.Name = "Form_ProductsInOrdersReport";
            this.Text = "Form_ProductsInOrdersReport";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_filterCount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label_Filter_Category;
        private System.Windows.Forms.ComboBox comboBox_Filter_Category;
        private System.Windows.Forms.Label label_Filter_Company;
        private System.Windows.Forms.ComboBox comboBox_Filter_Company;
        private System.Windows.Forms.TextBox textBox_Name_Filter;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Label label1;
    }
}