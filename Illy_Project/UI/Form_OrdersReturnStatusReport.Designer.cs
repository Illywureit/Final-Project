namespace Illy_Project.UI
{
    partial class Form_OrdersReturnStatusReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_Home = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_head = new System.Windows.Forms.Label();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.label_To = new System.Windows.Forms.Label();
            this.label_From = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(4, 103);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(668, 347);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_Home
            // 
            this.button_Home.BackgroundImage = global::Illy_Project.Properties.Resources.Back;
            this.button_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_Home.Location = new System.Drawing.Point(730, 12);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(58, 42);
            this.button_Home.TabIndex = 61;
            this.button_Home.UseVisualStyleBackColor = true;
            this.button_Home.Click += new System.EventHandler(this.button_Home_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button_clear.Location = new System.Drawing.Point(568, 45);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(89, 37);
            this.button_clear.TabIndex = 59;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_head
            // 
            this.label_head.AutoSize = true;
            this.label_head.Font = new System.Drawing.Font("Aharoni", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_head.Location = new System.Drawing.Point(233, 9);
            this.label_head.Name = "label_head";
            this.label_head.Size = new System.Drawing.Size(232, 20);
            this.label_head.TabIndex = 60;
            this.label_head.Text = "Retun Status of Orders";
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_To);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_From);
            this.groupBox_Filter.Controls.Add(this.comboBox_Client);
            this.groupBox_Filter.Controls.Add(this.label_Client);
            this.groupBox_Filter.Controls.Add(this.label_To);
            this.groupBox_Filter.Controls.Add(this.label_From);
            this.groupBox_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox_Filter.Location = new System.Drawing.Point(4, 32);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(535, 65);
            this.groupBox_Filter.TabIndex = 58;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
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
            // Form_OrdersReturnStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Home);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.label_head);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.chart1);
            this.Name = "Form_OrdersReturnStatusReport";
            this.Text = "Return Status of Orders Report";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_head;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.Label label_From;
    }
}