namespace graficos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabCharts = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAveragePh = new System.Windows.Forms.Label();
            this.labelMaxPh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMinPh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAvgNH3 = new System.Windows.Forms.Label();
            this.labelMaxNH3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelMinNH3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nh3Chart1 = new LiveCharts.WinForms.CartesianChart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMaxCI2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMinCI2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ciChart2 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.timePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panelTime = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelDate = new System.Windows.Forms.Panel();
            this.panelDate2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.listViewAlarms = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAlarms = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxAlarmsInfo = new System.Windows.Forms.GroupBox();
            this.panelDateAlarm2 = new System.Windows.Forms.Panel();
            this.datePickerAlarm2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.panelDateAlarm1 = new System.Windows.Forms.Panel();
            this.datePickerAlarm1 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panelTimeAlarm = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.timePickerAlarm1 = new System.Windows.Forms.DateTimePicker();
            this.buttonUpdateAlarmInfo = new System.Windows.Forms.Button();
            this.comboBoxAlarms = new System.Windows.Forms.ComboBox();
            this.tabCharts.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelDate2.SuspendLayout();
            this.groupBoxAlarms.SuspendLayout();
            this.groupBoxAlarmsInfo.SuspendLayout();
            this.panelDateAlarm2.SuspendLayout();
            this.panelDateAlarm1.SuspendLayout();
            this.panelTimeAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCharts
            // 
            this.tabCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCharts.Controls.Add(this.tabPage1);
            this.tabCharts.Controls.Add(this.tabPage2);
            this.tabCharts.Controls.Add(this.tabPage3);
            this.tabCharts.Location = new System.Drawing.Point(-1, 60);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.SelectedIndex = 0;
            this.tabCharts.Size = new System.Drawing.Size(1105, 560);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.SelectedIndexChanged += new System.EventHandler(this.tab1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxDate);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.phChart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PH Chart";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.panelDate2);
            this.groupBoxDate.Controls.Add(this.panelDate);
            this.groupBoxDate.Controls.Add(this.panelTime);
            this.groupBoxDate.Controls.Add(this.buttonUpdate);
            this.groupBoxDate.Location = new System.Drawing.Point(864, 90);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(219, 437);
            this.groupBoxDate.TabIndex = 7;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Information By Date and Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelAveragePh);
            this.groupBox1.Controls.Add(this.labelMaxPh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelMinPh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(864, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 78);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information:";
            // 
            // labelAveragePh
            // 
            this.labelAveragePh.AutoSize = true;
            this.labelAveragePh.Location = new System.Drawing.Point(78, 54);
            this.labelAveragePh.Name = "labelAveragePh";
            this.labelAveragePh.Size = new System.Drawing.Size(13, 13);
            this.labelAveragePh.TabIndex = 5;
            this.labelAveragePh.Text = "0";
            // 
            // labelMaxPh
            // 
            this.labelMaxPh.AutoSize = true;
            this.labelMaxPh.Location = new System.Drawing.Point(78, 37);
            this.labelMaxPh.Name = "labelMaxPh";
            this.labelMaxPh.Size = new System.Drawing.Size(13, 13);
            this.labelMaxPh.TabIndex = 4;
            this.labelMaxPh.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max: ";
            // 
            // labelMinPh
            // 
            this.labelMinPh.AutoSize = true;
            this.labelMinPh.Location = new System.Drawing.Point(78, 20);
            this.labelMinPh.Name = "labelMinPh";
            this.labelMinPh.Size = new System.Drawing.Size(13, 13);
            this.labelMinPh.TabIndex = 1;
            this.labelMinPh.Text = "0";
            this.labelMinPh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Min: ";
            // 
            // phChart1
            // 
            this.phChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phChart1.Location = new System.Drawing.Point(3, 4);
            this.phChart1.Name = "phChart1";
            this.phChart1.Size = new System.Drawing.Size(855, 531);
            this.phChart1.TabIndex = 0;
            this.phChart1.Text = "PH CHART";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.nh3Chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NH3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelAvgNH3);
            this.groupBox2.Controls.Add(this.labelMaxNH3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelMinNH3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(864, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 78);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information:";
            // 
            // labelAvgNH3
            // 
            this.labelAvgNH3.AutoSize = true;
            this.labelAvgNH3.Location = new System.Drawing.Point(78, 54);
            this.labelAvgNH3.Name = "labelAvgNH3";
            this.labelAvgNH3.Size = new System.Drawing.Size(13, 13);
            this.labelAvgNH3.TabIndex = 5;
            this.labelAvgNH3.Text = "0";
            // 
            // labelMaxNH3
            // 
            this.labelMaxNH3.AutoSize = true;
            this.labelMaxNH3.Location = new System.Drawing.Point(78, 37);
            this.labelMaxNH3.Name = "labelMaxNH3";
            this.labelMaxNH3.Size = new System.Drawing.Size(13, 13);
            this.labelMaxNH3.TabIndex = 4;
            this.labelMaxNH3.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Average: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Max: ";
            // 
            // labelMinNH3
            // 
            this.labelMinNH3.AutoSize = true;
            this.labelMinNH3.Location = new System.Drawing.Point(78, 20);
            this.labelMinNH3.Name = "labelMinNH3";
            this.labelMinNH3.Size = new System.Drawing.Size(13, 13);
            this.labelMinNH3.TabIndex = 1;
            this.labelMinNH3.Text = "0";
            this.labelMinNH3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Min: ";
            // 
            // nh3Chart1
            // 
            this.nh3Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nh3Chart1.Location = new System.Drawing.Point(0, 0);
            this.nh3Chart1.Name = "nh3Chart1";
            this.nh3Chart1.Size = new System.Drawing.Size(858, 531);
            this.nh3Chart1.TabIndex = 0;
            this.nh3Chart1.Text = "NH3 Chart";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.ciChart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1097, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CI2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.labelMaxCI2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.labelMinCI2);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(864, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 78);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "0";
            // 
            // labelMaxCI2
            // 
            this.labelMaxCI2.AutoSize = true;
            this.labelMaxCI2.Location = new System.Drawing.Point(78, 37);
            this.labelMaxCI2.Name = "labelMaxCI2";
            this.labelMaxCI2.Size = new System.Drawing.Size(13, 13);
            this.labelMaxCI2.TabIndex = 4;
            this.labelMaxCI2.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Average: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Max: ";
            // 
            // labelMinCI2
            // 
            this.labelMinCI2.AutoSize = true;
            this.labelMinCI2.Location = new System.Drawing.Point(78, 20);
            this.labelMinCI2.Name = "labelMinCI2";
            this.labelMinCI2.Size = new System.Drawing.Size(13, 13);
            this.labelMinCI2.TabIndex = 1;
            this.labelMinCI2.Text = "0";
            this.labelMinCI2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Min: ";
            // 
            // ciChart2
            // 
            this.ciChart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ciChart2.Location = new System.Drawing.Point(0, 0);
            this.ciChart2.Name = "ciChart2";
            this.ciChart2.Size = new System.Drawing.Size(858, 531);
            this.ciChart2.TabIndex = 0;
            this.ciChart2.Text = "CI2 Chart";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(113, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alarms";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Charts";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Information",
            "Information By Date/Hour",
            "Information By Date",
            "Information Between dates"});
            this.comboBox1.Location = new System.Drawing.Point(878, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "All Information";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(6, 220);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(196, 21);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // timePicker1
            // 
            this.timePicker1.CustomFormat = "hh:mm:ss";
            this.timePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker1.Location = new System.Drawing.Point(7, 22);
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.ShowUpDown = true;
            this.timePicker1.Size = new System.Drawing.Size(186, 20);
            this.timePicker1.TabIndex = 6;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.label6);
            this.panelTime.Controls.Add(this.timePicker1);
            this.panelTime.Location = new System.Drawing.Point(6, 19);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(200, 55);
            this.panelTime.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time:";
            // 
            // panelDate
            // 
            this.panelDate.Controls.Add(this.datePicker1);
            this.panelDate.Controls.Add(this.label1);
            this.panelDate.Location = new System.Drawing.Point(6, 80);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(203, 51);
            this.panelDate.TabIndex = 8;
            // 
            // panelDate2
            // 
            this.panelDate2.Controls.Add(this.datePicker2);
            this.panelDate2.Controls.Add(this.label12);
            this.panelDate2.Location = new System.Drawing.Point(6, 137);
            this.panelDate2.Name = "panelDate2";
            this.panelDate2.Size = new System.Drawing.Size(203, 51);
            this.panelDate2.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Second date:";
            // 
            // datePicker1
            // 
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker1.Location = new System.Drawing.Point(0, 18);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(200, 20);
            this.datePicker1.TabIndex = 10;
            // 
            // datePicker2
            // 
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker2.Location = new System.Drawing.Point(0, 18);
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Size = new System.Drawing.Size(200, 20);
            this.datePicker2.TabIndex = 11;
            // 
            // listViewAlarms
            // 
            this.listViewAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAlarms.Location = new System.Drawing.Point(4, 11);
            this.listViewAlarms.Name = "listViewAlarms";
            this.listViewAlarms.Size = new System.Drawing.Size(862, 549);
            this.listViewAlarms.TabIndex = 5;
            this.listViewAlarms.UseCompatibleStateImageBehavior = false;
            this.listViewAlarms.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Time";
            this.columnHeader5.Width = 150;
            // 
            // groupBoxAlarms
            // 
            this.groupBoxAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlarms.Controls.Add(this.groupBoxAlarmsInfo);
            this.groupBoxAlarms.Controls.Add(this.listViewAlarms);
            this.groupBoxAlarms.Location = new System.Drawing.Point(3, 60);
            this.groupBoxAlarms.Name = "groupBoxAlarms";
            this.groupBoxAlarms.Size = new System.Drawing.Size(1101, 560);
            this.groupBoxAlarms.TabIndex = 11;
            this.groupBoxAlarms.TabStop = false;
            this.groupBoxAlarms.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Alarm";
            this.columnHeader6.Width = 190;
            // 
            // groupBoxAlarmsInfo
            // 
            this.groupBoxAlarmsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlarmsInfo.Controls.Add(this.comboBoxAlarms);
            this.groupBoxAlarmsInfo.Controls.Add(this.panelDateAlarm2);
            this.groupBoxAlarmsInfo.Controls.Add(this.panelDateAlarm1);
            this.groupBoxAlarmsInfo.Controls.Add(this.panelTimeAlarm);
            this.groupBoxAlarmsInfo.Controls.Add(this.buttonUpdateAlarmInfo);
            this.groupBoxAlarmsInfo.Location = new System.Drawing.Point(878, 47);
            this.groupBoxAlarmsInfo.Name = "groupBoxAlarmsInfo";
            this.groupBoxAlarmsInfo.Size = new System.Drawing.Size(219, 502);
            this.groupBoxAlarmsInfo.TabIndex = 8;
            this.groupBoxAlarmsInfo.TabStop = false;
            this.groupBoxAlarmsInfo.Text = "Information By Date and Time";
            // 
            // panelDateAlarm2
            // 
            this.panelDateAlarm2.Controls.Add(this.datePickerAlarm2);
            this.panelDateAlarm2.Controls.Add(this.label14);
            this.panelDateAlarm2.Location = new System.Drawing.Point(6, 185);
            this.panelDateAlarm2.Name = "panelDateAlarm2";
            this.panelDateAlarm2.Size = new System.Drawing.Size(203, 51);
            this.panelDateAlarm2.TabIndex = 9;
            // 
            // datePickerAlarm2
            // 
            this.datePickerAlarm2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAlarm2.Location = new System.Drawing.Point(0, 18);
            this.datePickerAlarm2.Name = "datePickerAlarm2";
            this.datePickerAlarm2.Size = new System.Drawing.Size(200, 20);
            this.datePickerAlarm2.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Second date:";
            // 
            // panelDateAlarm1
            // 
            this.panelDateAlarm1.Controls.Add(this.datePickerAlarm1);
            this.panelDateAlarm1.Controls.Add(this.label15);
            this.panelDateAlarm1.Location = new System.Drawing.Point(6, 123);
            this.panelDateAlarm1.Name = "panelDateAlarm1";
            this.panelDateAlarm1.Size = new System.Drawing.Size(203, 51);
            this.panelDateAlarm1.TabIndex = 8;
            // 
            // datePickerAlarm1
            // 
            this.datePickerAlarm1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAlarm1.Location = new System.Drawing.Point(0, 18);
            this.datePickerAlarm1.Name = "datePickerAlarm1";
            this.datePickerAlarm1.Size = new System.Drawing.Size(200, 20);
            this.datePickerAlarm1.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Date:";
            // 
            // panelTimeAlarm
            // 
            this.panelTimeAlarm.Controls.Add(this.label16);
            this.panelTimeAlarm.Controls.Add(this.timePickerAlarm1);
            this.panelTimeAlarm.Location = new System.Drawing.Point(6, 59);
            this.panelTimeAlarm.Name = "panelTimeAlarm";
            this.panelTimeAlarm.Size = new System.Drawing.Size(200, 55);
            this.panelTimeAlarm.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Time:";
            // 
            // timePickerAlarm1
            // 
            this.timePickerAlarm1.CustomFormat = "hh:mm:ss";
            this.timePickerAlarm1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePickerAlarm1.Location = new System.Drawing.Point(7, 22);
            this.timePickerAlarm1.Name = "timePickerAlarm1";
            this.timePickerAlarm1.ShowUpDown = true;
            this.timePickerAlarm1.Size = new System.Drawing.Size(186, 20);
            this.timePickerAlarm1.TabIndex = 6;
            // 
            // buttonUpdateAlarmInfo
            // 
            this.buttonUpdateAlarmInfo.Location = new System.Drawing.Point(9, 251);
            this.buttonUpdateAlarmInfo.Name = "buttonUpdateAlarmInfo";
            this.buttonUpdateAlarmInfo.Size = new System.Drawing.Size(196, 21);
            this.buttonUpdateAlarmInfo.TabIndex = 6;
            this.buttonUpdateAlarmInfo.Text = "Update";
            this.buttonUpdateAlarmInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateAlarmInfo.Click += new System.EventHandler(this.buttonUpdateAlarmInfo_Click);
            // 
            // comboBoxAlarms
            // 
            this.comboBoxAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAlarms.FormattingEnabled = true;
            this.comboBoxAlarms.Items.AddRange(new object[] {
            "All Information",
            "Information By Date/Hour",
            "Information By Date",
            "Information Between dates"});
            this.comboBoxAlarms.Location = new System.Drawing.Point(9, 19);
            this.comboBoxAlarms.Name = "comboBoxAlarms";
            this.comboBoxAlarms.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAlarms.TabIndex = 12;
            this.comboBoxAlarms.Text = "All Information";
            this.comboBoxAlarms.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlarms_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 621);
            this.Controls.Add(this.groupBoxAlarms);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabCharts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SmartH2O_SeeAPP";
            this.tabCharts.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelDate2.ResumeLayout(false);
            this.panelDate2.PerformLayout();
            this.groupBoxAlarms.ResumeLayout(false);
            this.groupBoxAlarmsInfo.ResumeLayout(false);
            this.panelDateAlarm2.ResumeLayout(false);
            this.panelDateAlarm2.PerformLayout();
            this.panelDateAlarm1.ResumeLayout(false);
            this.panelDateAlarm1.PerformLayout();
            this.panelTimeAlarm.ResumeLayout(false);
            this.panelTimeAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart phChart1;
        private System.Windows.Forms.TabControl tabCharts;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart nh3Chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private LiveCharts.WinForms.CartesianChart ciChart2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMinPh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAveragePh;
        private System.Windows.Forms.Label labelMaxPh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAvgNH3;
        private System.Windows.Forms.Label labelMaxNH3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMinNH3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMaxCI2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMinCI2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker timePicker1;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Panel panelDate2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.ListView listViewAlarms;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBoxAlarms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBoxAlarmsInfo;
        private System.Windows.Forms.Panel panelDateAlarm2;
        private System.Windows.Forms.DateTimePicker datePickerAlarm2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelDateAlarm1;
        private System.Windows.Forms.DateTimePicker datePickerAlarm1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelTimeAlarm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker timePickerAlarm1;
        private System.Windows.Forms.Button buttonUpdateAlarmInfo;
        private System.Windows.Forms.ComboBox comboBoxAlarms;
    }
}

