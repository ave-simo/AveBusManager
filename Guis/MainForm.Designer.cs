namespace AveBusManager
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.baud_var = new System.Windows.Forms.Label();
            this.parity_var = new System.Windows.Forms.Label();
            this.dataBits_var = new System.Windows.Forms.Label();
            this.stopBits_var = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startReading_btn = new System.Windows.Forms.Button();
            this.stopReading_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.light_1_statusTextBox = new System.Windows.Forms.TextBox();
            this.light_2_statusTextBox = new System.Windows.Forms.TextBox();
            this.luce_1_statusLabel = new System.Windows.Forms.Label();
            this.luce_2_statusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change light 1 status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Turn on light 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Turn off light 1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select com port";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_showItems);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baud rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data bits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stop bits:";
            // 
            // baud_var
            // 
            this.baud_var.AutoSize = true;
            this.baud_var.Location = new System.Drawing.Point(86, 25);
            this.baud_var.Name = "baud_var";
            this.baud_var.Size = new System.Drawing.Size(19, 13);
            this.baud_var.TabIndex = 4;
            this.baud_var.Text = "na";
            // 
            // parity_var
            // 
            this.parity_var.AutoSize = true;
            this.parity_var.Location = new System.Drawing.Point(86, 54);
            this.parity_var.Name = "parity_var";
            this.parity_var.Size = new System.Drawing.Size(19, 13);
            this.parity_var.TabIndex = 5;
            this.parity_var.Text = "na";
            // 
            // dataBits_var
            // 
            this.dataBits_var.AutoSize = true;
            this.dataBits_var.Location = new System.Drawing.Point(86, 83);
            this.dataBits_var.Name = "dataBits_var";
            this.dataBits_var.Size = new System.Drawing.Size(19, 13);
            this.dataBits_var.TabIndex = 6;
            this.dataBits_var.Text = "na";
            // 
            // stopBits_var
            // 
            this.stopBits_var.AutoSize = true;
            this.stopBits_var.Location = new System.Drawing.Point(86, 112);
            this.stopBits_var.Name = "stopBits_var";
            this.stopBits_var.Size = new System.Drawing.Size(19, 13);
            this.stopBits_var.TabIndex = 7;
            this.stopBits_var.Text = "na";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopBits_var);
            this.groupBox1.Controls.Add(this.dataBits_var);
            this.groupBox1.Controls.Add(this.parity_var);
            this.groupBox1.Controls.Add(this.baud_var);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(197, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Settings";
            // 
            // startReading_btn
            // 
            this.startReading_btn.Location = new System.Drawing.Point(12, 151);
            this.startReading_btn.Name = "startReading_btn";
            this.startReading_btn.Size = new System.Drawing.Size(75, 23);
            this.startReading_btn.TabIndex = 8;
            this.startReading_btn.Text = "Start reading";
            this.startReading_btn.UseVisualStyleBackColor = true;
            this.startReading_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // stopReading_btn
            // 
            this.stopReading_btn.Location = new System.Drawing.Point(91, 151);
            this.stopReading_btn.Name = "stopReading_btn";
            this.stopReading_btn.Size = new System.Drawing.Size(75, 23);
            this.stopReading_btn.TabIndex = 9;
            this.stopReading_btn.Text = "Stop reading";
            this.stopReading_btn.UseVisualStyleBackColor = true;
            this.stopReading_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(333, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(323, 242);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = " ";
            // 
            // light_1_statusTextBox
            // 
            this.light_1_statusTextBox.BackColor = System.Drawing.Color.Black;
            this.light_1_statusTextBox.Location = new System.Drawing.Point(93, 185);
            this.light_1_statusTextBox.Multiline = true;
            this.light_1_statusTextBox.Name = "light_1_statusTextBox";
            this.light_1_statusTextBox.ReadOnly = true;
            this.light_1_statusTextBox.Size = new System.Drawing.Size(73, 23);
            this.light_1_statusTextBox.TabIndex = 11;
            // 
            // light_2_statusTextBox
            // 
            this.light_2_statusTextBox.BackColor = System.Drawing.Color.Black;
            this.light_2_statusTextBox.Location = new System.Drawing.Point(93, 222);
            this.light_2_statusTextBox.Multiline = true;
            this.light_2_statusTextBox.Name = "light_2_statusTextBox";
            this.light_2_statusTextBox.ReadOnly = true;
            this.light_2_statusTextBox.Size = new System.Drawing.Size(73, 23);
            this.light_2_statusTextBox.TabIndex = 12;
            // 
            // luce_1_statusLabel
            // 
            this.luce_1_statusLabel.AutoSize = true;
            this.luce_1_statusLabel.Location = new System.Drawing.Point(14, 195);
            this.luce_1_statusLabel.Name = "luce_1_statusLabel";
            this.luce_1_statusLabel.Size = new System.Drawing.Size(73, 13);
            this.luce_1_statusLabel.TabIndex = 13;
            this.luce_1_statusLabel.Text = "Light 1 status:";
            // 
            // luce_2_statusLabel
            // 
            this.luce_2_statusLabel.AutoSize = true;
            this.luce_2_statusLabel.Location = new System.Drawing.Point(14, 232);
            this.luce_2_statusLabel.Name = "luce_2_statusLabel";
            this.luce_2_statusLabel.Size = new System.Drawing.Size(73, 13);
            this.luce_2_statusLabel.TabIndex = 14;
            this.luce_2_statusLabel.Text = "Light 2 status:";
            // 
            // groupBox2
            // 
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(197, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 65);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rent this free space";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 266);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.luce_2_statusLabel);
            this.Controls.Add(this.luce_1_statusLabel);
            this.Controls.Add(this.light_2_statusTextBox);
            this.Controls.Add(this.light_1_statusTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopReading_btn);
            this.Controls.Add(this.startReading_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "AveBusManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label baud_var;
        private System.Windows.Forms.Label parity_var;
        private System.Windows.Forms.Label dataBits_var;
        private System.Windows.Forms.Label stopBits_var;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startReading_btn;
        private System.Windows.Forms.Button stopReading_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox light_1_statusTextBox;
        private System.Windows.Forms.TextBox light_2_statusTextBox;
        private System.Windows.Forms.Label luce_1_statusLabel;
        private System.Windows.Forms.Label luce_2_statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}