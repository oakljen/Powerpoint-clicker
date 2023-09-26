namespace Powerpoint_clicker
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
            this.status = new System.Windows.Forms.Label();
            this.iplable = new System.Windows.Forms.Label();
            this.portlable = new System.Windows.Forms.Label();
            this.webaddress = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serverLogsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customports = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(110, 288);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(119, 25);
            this.status.TabIndex = 1;
            this.status.Text = "Not Running";
            // 
            // iplable
            // 
            this.iplable.AutoSize = true;
            this.iplable.Location = new System.Drawing.Point(49, 322);
            this.iplable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.iplable.Name = "iplable";
            this.iplable.Size = new System.Drawing.Size(34, 25);
            this.iplable.TabIndex = 2;
            this.iplable.Text = "Ip:";
            // 
            // portlable
            // 
            this.portlable.AutoSize = true;
            this.portlable.Location = new System.Drawing.Point(30, 347);
            this.portlable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.portlable.Name = "portlable";
            this.portlable.Size = new System.Drawing.Size(53, 25);
            this.portlable.TabIndex = 3;
            this.portlable.Text = "Port:";
            // 
            // webaddress
            // 
            this.webaddress.AutoSize = true;
            this.webaddress.Location = new System.Drawing.Point(150, 555);
            this.webaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.webaddress.Name = "webaddress";
            this.webaddress.Size = new System.Drawing.Size(45, 25);
            this.webaddress.TabIndex = 4;
            this.webaddress.TabStop = true;
            this.webaddress.Text = "Null";
            this.webaddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webaddress_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 555);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Web address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 38);
            this.label5.TabIndex = 6;
            this.label5.Text = "Slide Clicker";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Custom Port:";
            // 
            // serverLogsText
            // 
            this.serverLogsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLogsText.Location = new System.Drawing.Point(367, 79);
            this.serverLogsText.Margin = new System.Windows.Forms.Padding(4);
            this.serverLogsText.Multiline = true;
            this.serverLogsText.Name = "serverLogsText";
            this.serverLogsText.ReadOnly = true;
            this.serverLogsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverLogsText.Size = new System.Drawing.Size(457, 436);
            this.serverLogsText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Server Logs";
            // 
            // customports
            // 
            this.customports.Location = new System.Drawing.Point(167, 108);
            this.customports.Margin = new System.Windows.Forms.Padding(2);
            this.customports.MaxLength = 5;
            this.customports.Name = "customports";
            this.customports.Size = new System.Drawing.Size(70, 29);
            this.customports.TabIndex = 8;
            this.customports.TextChanged += new System.EventHandler(this.customports_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverLogsText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customports);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.webaddress);
            this.Controls.Add(this.portlable);
            this.Controls.Add(this.iplable);
            this.Controls.Add(this.status);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label iplable;
        private System.Windows.Forms.Label portlable;
        private System.Windows.Forms.LinkLabel webaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverLogsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customports;
        private System.Windows.Forms.Button button1;
    }
}

