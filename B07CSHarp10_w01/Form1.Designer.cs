namespace B07CSHarp10_w01
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
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtc3 = new System.Windows.Forms.TextBox();
            this.btncounter1 = new System.Windows.Forms.Button();
            this.btnCnt2 = new System.Windows.Forms.Button();
            this.btnctn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtc1
            // 
            this.txtc1.Enabled = false;
            this.txtc1.Location = new System.Drawing.Point(88, 35);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(113, 20);
            this.txtc1.TabIndex = 0;
            // 
            // txtc2
            // 
            this.txtc2.Enabled = false;
            this.txtc2.Location = new System.Drawing.Point(249, 35);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(165, 20);
            this.txtc2.TabIndex = 1;
            // 
            // txtc3
            // 
            this.txtc3.Enabled = false;
            this.txtc3.Location = new System.Drawing.Point(440, 35);
            this.txtc3.Name = "txtc3";
            this.txtc3.Size = new System.Drawing.Size(192, 20);
            this.txtc3.TabIndex = 2;
            this.txtc3.TextChanged += new System.EventHandler(this.txtc3_TextChanged);
            // 
            // btncounter1
            // 
            this.btncounter1.Location = new System.Drawing.Point(97, 85);
            this.btncounter1.Name = "btncounter1";
            this.btncounter1.Size = new System.Drawing.Size(75, 23);
            this.btncounter1.TabIndex = 3;
            this.btncounter1.Text = "Counter 1";
            this.btncounter1.UseVisualStyleBackColor = true;
            this.btncounter1.Click += new System.EventHandler(this.btncounter1_Click);
            // 
            // btnCnt2
            // 
            this.btnCnt2.Location = new System.Drawing.Point(283, 85);
            this.btnCnt2.Name = "btnCnt2";
            this.btnCnt2.Size = new System.Drawing.Size(75, 23);
            this.btnCnt2.TabIndex = 4;
            this.btnCnt2.Text = "Counter 2";
            this.btnCnt2.UseVisualStyleBackColor = true;
            this.btnCnt2.Click += new System.EventHandler(this.btnCnt2_Click);
            // 
            // btnctn3
            // 
            this.btnctn3.Location = new System.Drawing.Point(458, 85);
            this.btnctn3.Name = "btnctn3";
            this.btnctn3.Size = new System.Drawing.Size(75, 23);
            this.btnctn3.TabIndex = 5;
            this.btnctn3.Text = "Counter 3";
            this.btnctn3.UseVisualStyleBackColor = true;
            this.btnctn3.Click += new System.EventHandler(this.btnctn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Waiting client list for Service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(128, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(345, 186);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnctn3);
            this.Controls.Add(this.btnCnt2);
            this.Controls.Add(this.btncounter1);
            this.Controls.Add(this.txtc3);
            this.Controls.Add(this.txtc2);
            this.Controls.Add(this.txtc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtc3;
        private System.Windows.Forms.Button btncounter1;
        private System.Windows.Forms.Button btnCnt2;
        private System.Windows.Forms.Button btnctn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblmsg;
    }
}

