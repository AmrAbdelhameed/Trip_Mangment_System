namespace TMS
{
    partial class Form2
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
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(12, 76);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(109, 30);
            this.fname.TabIndex = 1;
            this.fname.Text = "First Name";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(12, 137);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(106, 30);
            this.lname.TabIndex = 2;
            this.lname.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nationality";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 30);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 137);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(260, 30);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 205);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(260, 30);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 261);
            this.textBox4.MaxLength = 14;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(260, 30);
            this.textBox4.TabIndex = 10;
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 342);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(260, 30);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 389);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(260, 30);
            this.textBox6.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password should contain at least five characters\r\n and not contain  ! , @ # $ % ^" +
    " & * .";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "Age";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(151, 430);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(260, 30);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 18F);
            this.button1.ForeColor = System.Drawing.Color.GhostWhite;
            this.button1.Location = new System.Drawing.Point(132, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.CausesValidation = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(314, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(423, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "TMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}