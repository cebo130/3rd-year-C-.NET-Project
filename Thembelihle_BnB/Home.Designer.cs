namespace Thembelihle
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.night_label = new System.Windows.Forms.Label();
            this.to_time = new System.Windows.Forms.DateTimePicker();
            this.to_label = new System.Windows.Forms.Label();
            this.from_time = new System.Windows.Forms.DateTimePicker();
            this.from_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.twin_book_btn = new System.Windows.Forms.Button();
            this.twin_price = new System.Windows.Forms.Label();
            this.twin_quantity = new System.Windows.Forms.Label();
            this.twin_discription = new System.Windows.Forms.Label();
            this.twin_name = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.family_book_btn = new System.Windows.Forms.Button();
            this.family_price = new System.Windows.Forms.Label();
            this.family_quantity = new System.Windows.Forms.Label();
            this.family_discription = new System.Windows.Forms.Label();
            this.family_name = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.standard_book_btn = new System.Windows.Forms.Button();
            this.standard_price = new System.Windows.Forms.Label();
            this.standard_quantity = new System.Windows.Forms.Label();
            this.standard_discription = new System.Windows.Forms.Label();
            this.standard_name = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.night_label);
            this.panel1.Controls.Add(this.to_time);
            this.panel1.Controls.Add(this.to_label);
            this.panel1.Controls.Add(this.from_time);
            this.panel1.Controls.Add(this.from_label);
            this.panel1.Location = new System.Drawing.Point(15, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 60);
            this.panel1.TabIndex = 0;
            // 
            // night_label
            // 
            this.night_label.AutoSize = true;
            this.night_label.Location = new System.Drawing.Point(585, 25);
            this.night_label.Name = "night_label";
            this.night_label.Size = new System.Drawing.Size(30, 13);
            this.night_label.TabIndex = 5;
            this.night_label.Text = "night";
            // 
            // to_time
            // 
            this.to_time.Location = new System.Drawing.Point(327, 21);
            this.to_time.Name = "to_time";
            this.to_time.Size = new System.Drawing.Size(200, 20);
            this.to_time.TabIndex = 3;
            this.to_time.ValueChanged += new System.EventHandler(this.to_time_ValueChanged);
            // 
            // to_label
            // 
            this.to_label.AutoSize = true;
            this.to_label.Location = new System.Drawing.Point(289, 25);
            this.to_label.Name = "to_label";
            this.to_label.Size = new System.Drawing.Size(26, 13);
            this.to_label.TabIndex = 2;
            this.to_label.Text = "To: ";
            // 
            // from_time
            // 
            this.from_time.Location = new System.Drawing.Point(65, 22);
            this.from_time.Name = "from_time";
            this.from_time.Size = new System.Drawing.Size(200, 20);
            this.from_time.TabIndex = 1;
            this.from_time.ValueChanged += new System.EventHandler(this.from_time_ValueChanged);
            // 
            // from_label
            // 
            this.from_label.AutoSize = true;
            this.from_label.Location = new System.Drawing.Point(24, 26);
            this.from_label.Name = "from_label";
            this.from_label.Size = new System.Drawing.Size(36, 13);
            this.from_label.TabIndex = 0;
            this.from_label.Text = "From: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(15, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 529);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.twin_book_btn);
            this.panel5.Controls.Add(this.twin_price);
            this.panel5.Controls.Add(this.twin_quantity);
            this.panel5.Controls.Add(this.twin_discription);
            this.panel5.Controls.Add(this.twin_name);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(3, 354);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(943, 170);
            this.panel5.TabIndex = 6;
            // 
            // twin_book_btn
            // 
            this.twin_book_btn.Location = new System.Drawing.Point(852, 117);
            this.twin_book_btn.Name = "twin_book_btn";
            this.twin_book_btn.Size = new System.Drawing.Size(75, 45);
            this.twin_book_btn.TabIndex = 5;
            this.twin_book_btn.Text = "BOOK NOW";
            this.twin_book_btn.UseVisualStyleBackColor = true;
            this.twin_book_btn.Click += new System.EventHandler(this.twin_book_btn_Click);
            // 
            // twin_price
            // 
            this.twin_price.Location = new System.Drawing.Point(852, 62);
            this.twin_price.Name = "twin_price";
            this.twin_price.Size = new System.Drawing.Size(75, 45);
            this.twin_price.TabIndex = 4;
            this.twin_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twin_quantity
            // 
            this.twin_quantity.Location = new System.Drawing.Point(852, 7);
            this.twin_quantity.Name = "twin_quantity";
            this.twin_quantity.Size = new System.Drawing.Size(75, 45);
            this.twin_quantity.TabIndex = 3;
            this.twin_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twin_discription
            // 
            this.twin_discription.Location = new System.Drawing.Point(223, 76);
            this.twin_discription.Name = "twin_discription";
            this.twin_discription.Size = new System.Drawing.Size(551, 82);
            this.twin_discription.TabIndex = 2;
            // 
            // twin_name
            // 
            this.twin_name.Location = new System.Drawing.Point(222, 9);
            this.twin_name.Name = "twin_name";
            this.twin_name.Size = new System.Drawing.Size(437, 45);
            this.twin_name.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.family_book_btn);
            this.panel4.Controls.Add(this.family_price);
            this.panel4.Controls.Add(this.family_quantity);
            this.panel4.Controls.Add(this.family_discription);
            this.panel4.Controls.Add(this.family_name);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(3, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(943, 170);
            this.panel4.TabIndex = 6;
            // 
            // family_book_btn
            // 
            this.family_book_btn.Location = new System.Drawing.Point(852, 117);
            this.family_book_btn.Name = "family_book_btn";
            this.family_book_btn.Size = new System.Drawing.Size(75, 45);
            this.family_book_btn.TabIndex = 5;
            this.family_book_btn.Text = "BOOK NOW";
            this.family_book_btn.UseVisualStyleBackColor = true;
            this.family_book_btn.Click += new System.EventHandler(this.family_book_btn_Click);
            // 
            // family_price
            // 
            this.family_price.Location = new System.Drawing.Point(852, 62);
            this.family_price.Name = "family_price";
            this.family_price.Size = new System.Drawing.Size(75, 45);
            this.family_price.TabIndex = 4;
            this.family_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // family_quantity
            // 
            this.family_quantity.Location = new System.Drawing.Point(852, 7);
            this.family_quantity.Name = "family_quantity";
            this.family_quantity.Size = new System.Drawing.Size(75, 45);
            this.family_quantity.TabIndex = 3;
            this.family_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // family_discription
            // 
            this.family_discription.Location = new System.Drawing.Point(223, 76);
            this.family_discription.Name = "family_discription";
            this.family_discription.Size = new System.Drawing.Size(551, 82);
            this.family_discription.TabIndex = 2;
            // 
            // family_name
            // 
            this.family_name.Location = new System.Drawing.Point(222, 9);
            this.family_name.Name = "family_name";
            this.family_name.Size = new System.Drawing.Size(437, 45);
            this.family_name.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.standard_book_btn);
            this.panel3.Controls.Add(this.standard_price);
            this.panel3.Controls.Add(this.standard_quantity);
            this.panel3.Controls.Add(this.standard_discription);
            this.panel3.Controls.Add(this.standard_name);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(943, 170);
            this.panel3.TabIndex = 0;
            // 
            // standard_book_btn
            // 
            this.standard_book_btn.Location = new System.Drawing.Point(852, 117);
            this.standard_book_btn.Name = "standard_book_btn";
            this.standard_book_btn.Size = new System.Drawing.Size(75, 45);
            this.standard_book_btn.TabIndex = 5;
            this.standard_book_btn.Text = "BOOK NOW";
            this.standard_book_btn.UseVisualStyleBackColor = true;
            this.standard_book_btn.Click += new System.EventHandler(this.standard_book_btn_Click);
            // 
            // standard_price
            // 
            this.standard_price.Location = new System.Drawing.Point(852, 62);
            this.standard_price.Name = "standard_price";
            this.standard_price.Size = new System.Drawing.Size(75, 45);
            this.standard_price.TabIndex = 4;
            this.standard_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standard_quantity
            // 
            this.standard_quantity.Location = new System.Drawing.Point(852, 7);
            this.standard_quantity.Name = "standard_quantity";
            this.standard_quantity.Size = new System.Drawing.Size(75, 45);
            this.standard_quantity.TabIndex = 3;
            this.standard_quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // standard_discription
            // 
            this.standard_discription.Location = new System.Drawing.Point(223, 76);
            this.standard_discription.Name = "standard_discription";
            this.standard_discription.Size = new System.Drawing.Size(551, 82);
            this.standard_discription.TabIndex = 2;
            // 
            // standard_name
            // 
            this.standard_name.Location = new System.Drawing.Point(222, 9);
            this.standard_name.Name = "standard_name";
            this.standard_name.Size = new System.Drawing.Size(437, 45);
            this.standard_name.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::Thembelihle.Properties.Resources.Twin_Room_1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Thembelihle.Properties.Resources.Triple_Family_Room_Self_Cater_1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 170);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Thembelihle.Properties.Resources.Standard_Room_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker to_time;
        private System.Windows.Forms.Label to_label;
        private System.Windows.Forms.DateTimePicker from_time;
        private System.Windows.Forms.Label from_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button standard_book_btn;
        private System.Windows.Forms.Label standard_price;
        private System.Windows.Forms.Label standard_quantity;
        private System.Windows.Forms.Label standard_discription;
        private System.Windows.Forms.Label standard_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button twin_book_btn;
        private System.Windows.Forms.Label twin_price;
        private System.Windows.Forms.Label twin_quantity;
        private System.Windows.Forms.Label twin_discription;
        private System.Windows.Forms.Label twin_name;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button family_book_btn;
        private System.Windows.Forms.Label family_price;
        private System.Windows.Forms.Label family_quantity;
        private System.Windows.Forms.Label family_discription;
        private System.Windows.Forms.Label family_name;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label night_label;
    }
}