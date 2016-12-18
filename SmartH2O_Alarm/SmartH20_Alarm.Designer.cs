namespace SmartH2O_Alarm
{
    partial class SmartH20_Alarm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxActivate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBT = new System.Windows.Forms.CheckBox();
            this.checkBoxGr = new System.Windows.Forms.CheckBox();
            this.checkBoxLs = new System.Windows.Forms.CheckBox();
            this.checkBoxEq = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxBTMax = new System.Windows.Forms.TextBox();
            this.textBoxBTMin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxValueLS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValue2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxValueGR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxValueEQ = new System.Windows.Forms.TextBox();
            this.labelEqValue = new System.Windows.Forms.Label();
            this.listBoxSensors = new System.Windows.Forms.ListBox();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sensor selected:";
            // 
            // checkBoxActivate
            // 
            this.checkBoxActivate.AutoSize = true;
            this.checkBoxActivate.Enabled = false;
            this.checkBoxActivate.Location = new System.Drawing.Point(413, 25);
            this.checkBoxActivate.Name = "checkBoxActivate";
            this.checkBoxActivate.Size = new System.Drawing.Size(62, 17);
            this.checkBoxActivate.TabIndex = 5;
            this.checkBoxActivate.Text = "Active?";
            this.checkBoxActivate.UseVisualStyleBackColor = true;
            this.checkBoxActivate.CheckedChanged += new System.EventHandler(this.checkBoxActivate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(514, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBT);
            this.groupBox1.Controls.Add(this.checkBoxGr);
            this.groupBox1.Controls.Add(this.checkBoxLs);
            this.groupBox1.Controls.Add(this.checkBoxEq);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.labelValue2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(138, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 253);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triggers";
            // 
            // checkBoxBT
            // 
            this.checkBoxBT.AutoSize = true;
            this.checkBoxBT.Location = new System.Drawing.Point(389, 214);
            this.checkBoxBT.Name = "checkBoxBT";
            this.checkBoxBT.Size = new System.Drawing.Size(62, 17);
            this.checkBoxBT.TabIndex = 17;
            this.checkBoxBT.Text = "Active?";
            this.checkBoxBT.UseVisualStyleBackColor = true;
            this.checkBoxBT.CheckedChanged += new System.EventHandler(this.checkBoxBT_CheckedChanged);
            // 
            // checkBoxGr
            // 
            this.checkBoxGr.AutoSize = true;
            this.checkBoxGr.Location = new System.Drawing.Point(389, 52);
            this.checkBoxGr.Name = "checkBoxGr";
            this.checkBoxGr.Size = new System.Drawing.Size(62, 17);
            this.checkBoxGr.TabIndex = 15;
            this.checkBoxGr.Text = "Active?";
            this.checkBoxGr.UseVisualStyleBackColor = true;
            this.checkBoxGr.CheckedChanged += new System.EventHandler(this.checkBoxGr_CheckedChanged);
            // 
            // checkBoxLs
            // 
            this.checkBoxLs.AutoSize = true;
            this.checkBoxLs.Location = new System.Drawing.Point(389, 160);
            this.checkBoxLs.Name = "checkBoxLs";
            this.checkBoxLs.Size = new System.Drawing.Size(62, 17);
            this.checkBoxLs.TabIndex = 15;
            this.checkBoxLs.Text = "Active?";
            this.checkBoxLs.UseVisualStyleBackColor = true;
            this.checkBoxLs.CheckedChanged += new System.EventHandler(this.checkBoxLs_CheckedChanged);
            // 
            // checkBoxEq
            // 
            this.checkBoxEq.AutoSize = true;
            this.checkBoxEq.Location = new System.Drawing.Point(389, 102);
            this.checkBoxEq.Name = "checkBoxEq";
            this.checkBoxEq.Size = new System.Drawing.Size(62, 17);
            this.checkBoxEq.TabIndex = 12;
            this.checkBoxEq.Text = "Active?";
            this.checkBoxEq.UseVisualStyleBackColor = true;
            this.checkBoxEq.CheckedChanged += new System.EventHandler(this.checkBoxEq_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Status";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxBTMax);
            this.groupBox5.Controls.Add(this.textBoxBTMin);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(28, 192);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 48);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Between";
            // 
            // textBoxBTMax
            // 
            this.textBoxBTMax.Location = new System.Drawing.Point(234, 19);
            this.textBoxBTMax.Name = "textBoxBTMax";
            this.textBoxBTMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxBTMax.TabIndex = 11;
            // 
            // textBoxBTMin
            // 
            this.textBoxBTMin.Location = new System.Drawing.Point(63, 19);
            this.textBoxBTMin.Name = "textBoxBTMin";
            this.textBoxBTMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxBTMin.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Value Max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Value Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxValueLS);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(28, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 48);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Less";
            // 
            // textBoxValueLS
            // 
            this.textBoxValueLS.Location = new System.Drawing.Point(83, 20);
            this.textBoxValueLS.Name = "textBoxValueLS";
            this.textBoxValueLS.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueLS.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Value:";
            // 
            // labelValue2
            // 
            this.labelValue2.AutoSize = true;
            this.labelValue2.Location = new System.Drawing.Point(339, 103);
            this.labelValue2.Name = "labelValue2";
            this.labelValue2.Size = new System.Drawing.Size(37, 13);
            this.labelValue2.TabIndex = 12;
            this.labelValue2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxValueGR);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(28, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 48);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Greater";
            // 
            // textBoxValueGR
            // 
            this.textBoxValueGR.Location = new System.Drawing.Point(83, 20);
            this.textBoxValueGR.Name = "textBoxValueGR";
            this.textBoxValueGR.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueGR.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Value:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxValueEQ);
            this.groupBox2.Controls.Add(this.labelEqValue);
            this.groupBox2.Location = new System.Drawing.Point(28, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equal";
            // 
            // textBoxValueEQ
            // 
            this.textBoxValueEQ.Location = new System.Drawing.Point(83, 19);
            this.textBoxValueEQ.Name = "textBoxValueEQ";
            this.textBoxValueEQ.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueEQ.TabIndex = 11;
            // 
            // labelEqValue
            // 
            this.labelEqValue.AutoSize = true;
            this.labelEqValue.Location = new System.Drawing.Point(22, 22);
            this.labelEqValue.Name = "labelEqValue";
            this.labelEqValue.Size = new System.Drawing.Size(37, 13);
            this.labelEqValue.TabIndex = 10;
            this.labelEqValue.Text = "Value:";
            // 
            // listBoxSensors
            // 
            this.listBoxSensors.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSensors.FormattingEnabled = true;
            this.listBoxSensors.ItemHeight = 16;
            this.listBoxSensors.Location = new System.Drawing.Point(12, 53);
            this.listBoxSensors.Name = "listBoxSensors";
            this.listBoxSensors.Size = new System.Drawing.Size(120, 244);
            this.listBoxSensors.TabIndex = 12;
            this.listBoxSensors.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensors_SelectedIndexChanged);
            // 
            // labelSensorName
            // 
            this.labelSensorName.AutoSize = true;
            this.labelSensorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensorName.Location = new System.Drawing.Point(295, 24);
            this.labelSensorName.Name = "labelSensorName";
            this.labelSensorName.Size = new System.Drawing.Size(45, 16);
            this.labelSensorName.TabIndex = 13;
            this.labelSensorName.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sensors Availables";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMessage.Location = new System.Drawing.Point(22, 314);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 16);
            this.labelMessage.TabIndex = 15;
            // 
            // SmartH20_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 345);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelSensorName);
            this.Controls.Add(this.listBoxSensors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxActivate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SmartH20_Alarm";
            this.Text = "SmartH2O";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxActivate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxBT;
        private System.Windows.Forms.TextBox textBoxBTMax;
        private System.Windows.Forms.TextBox textBoxBTMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxLs;
        private System.Windows.Forms.TextBox textBoxValueLS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxGr;
        private System.Windows.Forms.TextBox textBoxValueGR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxEq;
        private System.Windows.Forms.TextBox textBoxValueEQ;
        private System.Windows.Forms.Label labelEqValue;
        private System.Windows.Forms.Label labelValue2;
        private System.Windows.Forms.ListBox listBoxSensors;
        private System.Windows.Forms.Label labelSensorName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelMessage;
    }
}

