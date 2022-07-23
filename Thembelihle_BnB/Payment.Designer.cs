namespace Thembelihle
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            this.add_card_btn = new System.Windows.Forms.Button();
            this.delete_seleted_btn = new System.Windows.Forms.Button();
            this.expirey_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_holder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cards_list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cards_list)).BeginInit();
            this.SuspendLayout();
            // 
            // add_card_btn
            // 
            this.add_card_btn.Location = new System.Drawing.Point(23, 12);
            this.add_card_btn.Name = "add_card_btn";
            this.add_card_btn.Size = new System.Drawing.Size(75, 23);
            this.add_card_btn.TabIndex = 0;
            this.add_card_btn.Text = "Add Card";
            this.add_card_btn.UseVisualStyleBackColor = true;
            this.add_card_btn.Click += new System.EventHandler(this.add_card_btn_Click);
            // 
            // delete_seleted_btn
            // 
            this.delete_seleted_btn.Location = new System.Drawing.Point(456, 569);
            this.delete_seleted_btn.Name = "delete_seleted_btn";
            this.delete_seleted_btn.Size = new System.Drawing.Size(139, 37);
            this.delete_seleted_btn.TabIndex = 2;
            this.delete_seleted_btn.Text = "Remove Selected Card";
            this.delete_seleted_btn.UseVisualStyleBackColor = true;
            this.delete_seleted_btn.Click += new System.EventHandler(this.delete_seleted_btn_Click);
            // 
            // groupPmb7DataSet
            // 
            // paymentTableAdapter
            // 
            // tableAdapterManager
            // 

            // 
            // expirey_date
            // 
            this.expirey_date.HeaderText = "Expirey Date";
            this.expirey_date.MinimumWidth = 302;
            this.expirey_date.Name = "expirey_date";
            this.expirey_date.ReadOnly = true;
            this.expirey_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.expirey_date.Width = 302;
            // 
            // card_number
            // 
            this.card_number.HeaderText = "Card Number";
            this.card_number.MinimumWidth = 302;
            this.card_number.Name = "card_number";
            this.card_number.ReadOnly = true;
            this.card_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.card_number.Width = 302;
            // 
            // card_holder
            // 
            this.card_holder.FillWeight = 200F;
            this.card_holder.HeaderText = "Card Holder";
            this.card_holder.MinimumWidth = 302;
            this.card_holder.Name = "card_holder";
            this.card_holder.ReadOnly = true;
            this.card_holder.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.card_holder.Width = 302;
            // 
            // cards_list
            // 
            this.cards_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.cards_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.card_holder,
            this.card_number,
            this.expirey_date});
            this.cards_list.Location = new System.Drawing.Point(23, 54);
            this.cards_list.MultiSelect = false;
            this.cards_list.Name = "cards_list";
            this.cards_list.ReadOnly = true;
            this.cards_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cards_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cards_list.Size = new System.Drawing.Size(949, 507);
            this.cards_list.TabIndex = 3;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 626);
            this.Controls.Add(this.cards_list);
            this.Controls.Add(this.delete_seleted_btn);
            this.Controls.Add(this.add_card_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payment";
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.cards_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_card_btn;
        private System.Windows.Forms.Button delete_seleted_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirey_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_holder;
        private System.Windows.Forms.DataGridView cards_list;
    }
}