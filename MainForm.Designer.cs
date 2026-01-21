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
            this.label1 = new System.Windows.Forms.Label();
            this.lightStatus_var = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.stopBits_var = new System.Windows.Forms.Label();
            this.dataBits_var = new System.Windows.Forms.Label();
            this.baud_var = new System.Windows.Forms.Label();
            this.parity_var = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Turn off light 1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "abc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Light 1 Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lightStatus_var
            // 
            this.lightStatus_var.AutoSize = true;
            this.lightStatus_var.Location = new System.Drawing.Point(240, 205);
            this.lightStatus_var.Name = "lightStatus_var";
            this.lightStatus_var.Size = new System.Drawing.Size(25, 13);
            this.lightStatus_var.TabIndex = 5;
            this.lightStatus_var.Text = "abc";
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
            this.groupBox1.Location = new System.Drawing.Point(197, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Settings";
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "not implemented";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // stopBits_var
            // 
            this.stopBits_var.AutoSize = true;
            this.stopBits_var.Location = new System.Drawing.Point(86, 112);
            this.stopBits_var.Name = "stopBits_var";
            this.stopBits_var.Size = new System.Drawing.Size(25, 13);
            this.stopBits_var.TabIndex = 7;
            this.stopBits_var.Text = "abc";
            this.stopBits_var.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataBits_var
            // 
            this.dataBits_var.AutoSize = true;
            this.dataBits_var.Location = new System.Drawing.Point(86, 83);
            this.dataBits_var.Name = "dataBits_var";
            this.dataBits_var.Size = new System.Drawing.Size(25, 13);
            this.dataBits_var.TabIndex = 6;
            this.dataBits_var.Text = "abc";
            this.dataBits_var.Click += new System.EventHandler(this.label8_Click);
            // 
            // baud_var
            // 
            this.baud_var.AutoSize = true;
            this.baud_var.Location = new System.Drawing.Point(86, 25);
            this.baud_var.Name = "baud_var";
            this.baud_var.Size = new System.Drawing.Size(25, 13);
            this.baud_var.TabIndex = 4;
            this.baud_var.Text = "abc";
            this.baud_var.Click += new System.EventHandler(this.label10_Click);
            // 
            // parity_var
            // 
            this.parity_var.AutoSize = true;
            this.parity_var.Location = new System.Drawing.Point(86, 54);
            this.parity_var.Name = "parity_var";
            this.parity_var.Size = new System.Drawing.Size(25, 13);
            this.parity_var.TabIndex = 5;
            this.parity_var.Text = "abc";
            this.parity_var.Click += new System.EventHandler(this.label9_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 243);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lightStatus_var);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "AveBusManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lightStatus_var;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label stopBits_var;
        private System.Windows.Forms.Label dataBits_var;
        private System.Windows.Forms.Label parity_var;
        private System.Windows.Forms.Label baud_var;
    }
}