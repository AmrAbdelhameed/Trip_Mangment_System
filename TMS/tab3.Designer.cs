namespace TMS
{
    partial class tab3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tab3));
            this.search = new System.Windows.Forms.Button();
            this.city = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.AutoEllipsis = true;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Comic Sans MS", 16.2F);
            this.search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search.Location = new System.Drawing.Point(608, 268);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(226, 53);
            this.search.TabIndex = 12;
            this.search.Text = "Find Resturant";
            this.search.UseVisualStyleBackColor = true;
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.HintForeColor = System.Drawing.Color.Empty;
            this.city.HintText = "";
            this.city.isPassword = false;
            this.city.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.city.LineIdleColor = System.Drawing.Color.Gray;
            this.city.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(64)))), ((int)(((byte)(78)))));
            this.city.LineThickness = 3;
            this.city.Location = new System.Drawing.Point(245, 244);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(370, 57);
            this.city.TabIndex = 11;
            this.city.Text = "City Name";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.city.Enter += new System.EventHandler(this.city_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(997, 227);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // tab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.city);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tab3";
            this.Size = new System.Drawing.Size(997, 357);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button search;
        private Bunifu.Framework.UI.BunifuMaterialTextbox city;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
