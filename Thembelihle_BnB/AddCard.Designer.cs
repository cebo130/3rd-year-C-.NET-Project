namespace Thembelihle
{
    partial class AddCard
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
            this.card_holder_textbox = new System.Windows.Forms.TextBox();
            this.card_number_textbox = new System.Windows.Forms.TextBox();
            this.expirey_date_textbox = new System.Windows.Forms.TextBox();
            this.cvv_textbox = new System.Windows.Forms.TextBox();
            this.card_holder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.card_number = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // card_holder_textbox
            // 
            this.card_holder_textbox.Location = new System.Drawing.Point(27, 78);
            this.card_holder_textbox.Name = "card_holder_textbox";
            this.card_holder_textbox.Size = new System.Drawing.Size(204, 20);
            this.card_holder_textbox.TabIndex = 0;
            // 
            // card_number_textbox
            // 
            this.card_number_textbox.Location = new System.Drawing.Point(27, 172);
            this.card_number_textbox.Name = "card_number_textbox";
            this.card_number_textbox.Size = new System.Drawing.Size(204, 20);
            this.card_number_textbox.TabIndex = 1;
            // 
            // expirey_date_textbox
            // 
            this.expirey_date_textbox.Location = new System.Drawing.Point(27, 270);
            this.expirey_date_textbox.Name = "expirey_date_textbox";
            this.expirey_date_textbox.Size = new System.Drawing.Size(204, 20);
            this.expirey_date_textbox.TabIndex = 2;
            // 
            // cvv_textbox
            // 
            this.cvv_textbox.Location = new System.Drawing.Point(27, 342);
            this.cvv_textbox.Name = "cvv_textbox";
            this.cvv_textbox.Size = new System.Drawing.Size(100, 20);
            this.cvv_textbox.TabIndex = 3;
            // 
            // card_holder
            // 
            this.card_holder.AutoSize = true;
            this.card_holder.Location = new System.Drawing.Point(24, 48);
            this.card_holder.Name = "card_holder";
            this.card_holder.Size = new System.Drawing.Size(94, 13);
            this.card_holder.TabIndex = 4;
            this.card_holder.Text = "Card Holder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Expirey Date";
            // 
            // card_number
            // 
            this.card_number.AutoSize = true;
            this.card_number.Location = new System.Drawing.Point(24, 143);
            this.card_number.Name = "card_number";
            this.card_number.Size = new System.Drawing.Size(69, 13);
            this.card_number.TabIndex = 7;
            this.card_number.Text = "Card Number";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(103, 395);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 444);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.card_number);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.card_holder);
            this.Controls.Add(this.cvv_textbox);
            this.Controls.Add(this.expirey_date_textbox);
            this.Controls.Add(this.card_number_textbox);
            this.Controls.Add(this.card_holder_textbox);
            this.Name = "AddCard";
            this.Text = "AddCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox card_holder_textbox;
        private System.Windows.Forms.TextBox card_number_textbox;
        private System.Windows.Forms.TextBox expirey_date_textbox;
        private System.Windows.Forms.TextBox cvv_textbox;
        private System.Windows.Forms.Label card_holder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label card_number;
        private System.Windows.Forms.Button submit_btn;
    }
}