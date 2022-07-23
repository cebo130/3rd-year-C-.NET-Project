namespace Thembelihle
{
    partial class MakeBooking
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
            this.number_of_guest_combobox = new System.Windows.Forms.ComboBox();
            this.parking_combobox = new System.Windows.Forms.ComboBox();
            this.breakfast_checkbox = new System.Windows.Forms.CheckBox();
            this.sum_price_label = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.cards_combobox = new System.Windows.Forms.ComboBox();
            this.add_card_btn = new System.Windows.Forms.Button();
            this.room_name_label = new System.Windows.Forms.Label();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.food_quantity_label = new System.Windows.Forms.Label();
            this.avaliable_paking_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number_of_guest_combobox
            // 
            this.number_of_guest_combobox.FormattingEnabled = true;
            this.number_of_guest_combobox.Location = new System.Drawing.Point(27, 128);
            this.number_of_guest_combobox.Name = "number_of_guest_combobox";
            this.number_of_guest_combobox.Size = new System.Drawing.Size(160, 21);
            this.number_of_guest_combobox.TabIndex = 0;
            this.number_of_guest_combobox.TextChanged += new System.EventHandler(this.number_of_guest_combobox_TextChanged);
            // 
            // parking_combobox
            // 
            this.parking_combobox.FormattingEnabled = true;
            this.parking_combobox.Location = new System.Drawing.Point(27, 217);
            this.parking_combobox.Name = "parking_combobox";
            this.parking_combobox.Size = new System.Drawing.Size(160, 21);
            this.parking_combobox.TabIndex = 1;
            this.parking_combobox.TextChanged += new System.EventHandler(this.parking_combobox_TextChanged);
            // 
            // breakfast_checkbox
            // 
            this.breakfast_checkbox.AutoSize = true;
            this.breakfast_checkbox.Location = new System.Drawing.Point(27, 165);
            this.breakfast_checkbox.Name = "breakfast_checkbox";
            this.breakfast_checkbox.Size = new System.Drawing.Size(77, 17);
            this.breakfast_checkbox.TabIndex = 3;
            this.breakfast_checkbox.Text = "Breakfeast";
            this.breakfast_checkbox.UseVisualStyleBackColor = true;
            this.breakfast_checkbox.CheckedChanged += new System.EventHandler(this.breakfast_checkbox_CheckedChanged);
            // 
            // sum_price_label
            // 
            this.sum_price_label.Location = new System.Drawing.Point(2, 326);
            this.sum_price_label.Name = "sum_price_label";
            this.sum_price_label.Size = new System.Drawing.Size(422, 31);
            this.sum_price_label.TabIndex = 4;
            this.sum_price_label.Text = "price";
            this.sum_price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(179, 375);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(75, 23);
            this.pay_btn.TabIndex = 5;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // cards_combobox
            // 
            this.cards_combobox.FormattingEnabled = true;
            this.cards_combobox.Location = new System.Drawing.Point(27, 283);
            this.cards_combobox.Name = "cards_combobox";
            this.cards_combobox.Size = new System.Drawing.Size(160, 21);
            this.cards_combobox.TabIndex = 6;
            // 
            // add_card_btn
            // 
            this.add_card_btn.Location = new System.Drawing.Point(207, 283);
            this.add_card_btn.Name = "add_card_btn";
            this.add_card_btn.Size = new System.Drawing.Size(75, 23);
            this.add_card_btn.TabIndex = 7;
            this.add_card_btn.Text = "Add Card";
            this.add_card_btn.UseVisualStyleBackColor = true;
            this.add_card_btn.Click += new System.EventHandler(this.add_card_Click);
            // 
            // room_name_label
            // 
            this.room_name_label.AutoSize = true;
            this.room_name_label.Location = new System.Drawing.Point(29, 69);
            this.room_name_label.Name = "room_name_label";
            this.room_name_label.Size = new System.Drawing.Size(62, 13);
            this.room_name_label.TabIndex = 8;
            this.room_name_label.Text = "room_name";
            // 
            // customer_name_label
            // 
            this.customer_name_label.AutoSize = true;
            this.customer_name_label.Location = new System.Drawing.Point(29, 26);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.Size = new System.Drawing.Size(79, 13);
            this.customer_name_label.TabIndex = 9;
            this.customer_name_label.Text = "customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Number of Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Parking Slots";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Card";
            // 
            // food_quantity_label
            // 
            this.food_quantity_label.AutoSize = true;
            this.food_quantity_label.Location = new System.Drawing.Point(236, 169);
            this.food_quantity_label.Name = "food_quantity_label";
            this.food_quantity_label.Size = new System.Drawing.Size(0, 13);
            this.food_quantity_label.TabIndex = 13;
            // 
            // avaliable_paking_label
            // 
            this.avaliable_paking_label.AutoSize = true;
            this.avaliable_paking_label.Location = new System.Drawing.Point(236, 220);
            this.avaliable_paking_label.Name = "avaliable_paking_label";
            this.avaliable_paking_label.Size = new System.Drawing.Size(0, 13);
            this.avaliable_paking_label.TabIndex = 14;
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 426);
            this.Controls.Add(this.avaliable_paking_label);
            this.Controls.Add(this.food_quantity_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_name_label);
            this.Controls.Add(this.room_name_label);
            this.Controls.Add(this.add_card_btn);
            this.Controls.Add(this.cards_combobox);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.sum_price_label);
            this.Controls.Add(this.breakfast_checkbox);
            this.Controls.Add(this.parking_combobox);
            this.Controls.Add(this.number_of_guest_combobox);
            this.Name = "MakeBooking";
            this.Text = "MakeBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox number_of_guest_combobox;
        private System.Windows.Forms.ComboBox parking_combobox;
        private System.Windows.Forms.CheckBox breakfast_checkbox;
        private System.Windows.Forms.Label sum_price_label;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.ComboBox cards_combobox;
        private System.Windows.Forms.Button add_card_btn;
        private System.Windows.Forms.Label room_name_label;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label food_quantity_label;
        private System.Windows.Forms.Label avaliable_paking_label;
    }
}