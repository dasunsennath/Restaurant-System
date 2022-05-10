namespace presentation1
{
    partial class change_bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btndelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnupdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btncancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.remove_Order = new Bunifu.Framework.UI.BunifuThinButton2();
            this.itemname = new System.Windows.Forms.TextBox();
            this.unitprice = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ITEM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BILL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUNATITY_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billno_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Bill No :-";
            // 
            // btnsearch
            // 
            this.btnsearch.ActiveBorderThickness = 1;
            this.btnsearch.ActiveCornerRadius = 20;
            this.btnsearch.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnsearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnsearch.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnsearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.ButtonText = "Search";
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnsearch.IdleBorderThickness = 1;
            this.btnsearch.IdleCornerRadius = 10;
            this.btnsearch.IdleFillColor = System.Drawing.Color.FloralWhite;
            this.btnsearch.IdleForecolor = System.Drawing.Color.Goldenrod;
            this.btnsearch.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btnsearch.Location = new System.Drawing.Point(599, 171);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(181, 41);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btndelete
            // 
            this.btndelete.ActiveBorderThickness = 1;
            this.btndelete.ActiveCornerRadius = 20;
            this.btndelete.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btndelete.ActiveForecolor = System.Drawing.Color.White;
            this.btndelete.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btndelete.BackColor = System.Drawing.SystemColors.Control;
            this.btndelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndelete.BackgroundImage")));
            this.btndelete.ButtonText = "Delete";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Goldenrod;
            this.btndelete.IdleBorderThickness = 1;
            this.btndelete.IdleCornerRadius = 10;
            this.btndelete.IdleFillColor = System.Drawing.Color.FloralWhite;
            this.btndelete.IdleForecolor = System.Drawing.Color.Goldenrod;
            this.btndelete.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btndelete.Location = new System.Drawing.Point(750, 574);
            this.btndelete.Margin = new System.Windows.Forms.Padding(5);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(157, 41);
            this.btndelete.TabIndex = 5;
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ActiveBorderThickness = 1;
            this.btnupdate.ActiveCornerRadius = 20;
            this.btnupdate.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btnupdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnupdate.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btnupdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnupdate.BackgroundImage")));
            this.btnupdate.ButtonText = "Update";
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnupdate.IdleBorderThickness = 1;
            this.btnupdate.IdleCornerRadius = 10;
            this.btnupdate.IdleFillColor = System.Drawing.Color.FloralWhite;
            this.btnupdate.IdleForecolor = System.Drawing.Color.Goldenrod;
            this.btnupdate.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btnupdate.Location = new System.Drawing.Point(924, 574);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(157, 41);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btncancel
            // 
            this.btncancel.ActiveBorderThickness = 1;
            this.btncancel.ActiveCornerRadius = 20;
            this.btncancel.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
            this.btncancel.ActiveForecolor = System.Drawing.Color.White;
            this.btncancel.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
            this.btncancel.BackColor = System.Drawing.SystemColors.Control;
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.ButtonText = "Cancel";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Goldenrod;
            this.btncancel.IdleBorderThickness = 1;
            this.btncancel.IdleCornerRadius = 10;
            this.btncancel.IdleFillColor = System.Drawing.Color.FloralWhite;
            this.btncancel.IdleForecolor = System.Drawing.Color.Goldenrod;
            this.btncancel.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btncancel.Location = new System.Drawing.Point(1095, 574);
            this.btncancel.Margin = new System.Windows.Forms.Padding(5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(157, 41);
            this.btncancel.TabIndex = 5;
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // remove_Order
            // 
            this.remove_Order.ActiveBorderThickness = 1;
            this.remove_Order.ActiveCornerRadius = 20;
            this.remove_Order.ActiveFillColor = System.Drawing.Color.Maroon;
            this.remove_Order.ActiveForecolor = System.Drawing.Color.White;
            this.remove_Order.ActiveLineColor = System.Drawing.Color.IndianRed;
            this.remove_Order.BackColor = System.Drawing.SystemColors.Control;
            this.remove_Order.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("remove_Order.BackgroundImage")));
            this.remove_Order.ButtonText = "Remove Order";
            this.remove_Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remove_Order.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_Order.ForeColor = System.Drawing.Color.SaddleBrown;
            this.remove_Order.IdleBorderThickness = 1;
            this.remove_Order.IdleCornerRadius = 10;
            this.remove_Order.IdleFillColor = System.Drawing.Color.FloralWhite;
            this.remove_Order.IdleForecolor = System.Drawing.Color.SaddleBrown;
            this.remove_Order.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.remove_Order.Location = new System.Drawing.Point(912, 650);
            this.remove_Order.Margin = new System.Windows.Forms.Padding(5);
            this.remove_Order.Name = "remove_Order";
            this.remove_Order.Size = new System.Drawing.Size(187, 49);
            this.remove_Order.TabIndex = 5;
            this.remove_Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remove_Order.Click += new System.EventHandler(this.remove_Order_Click);
            // 
            // itemname
            // 
            this.itemname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.ForeColor = System.Drawing.Color.Red;
            this.itemname.Location = new System.Drawing.Point(894, 301);
            this.itemname.Multiline = true;
            this.itemname.Name = "itemname";
            this.itemname.ReadOnly = true;
            this.itemname.Size = new System.Drawing.Size(339, 39);
            this.itemname.TabIndex = 7;
            this.itemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitprice
            // 
            this.unitprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitprice.ForeColor = System.Drawing.Color.DarkRed;
            this.unitprice.Location = new System.Drawing.Point(894, 391);
            this.unitprice.Multiline = true;
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            this.unitprice.Size = new System.Drawing.Size(339, 39);
            this.unitprice.TabIndex = 7;
            this.unitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantity
            // 
            this.quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantity.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.ForeColor = System.Drawing.Color.Maroon;
            this.quantity.Location = new System.Drawing.Point(894, 484);
            this.quantity.Multiline = true;
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(339, 39);
            this.quantity.TabIndex = 7;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM_NO,
            this.ITEM_NAME,
            this.UNIT_PRICE,
            this.BILL_ID,
            this.QUNATITY_C});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(36, 280);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 466);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ITEM_NO
            // 
            this.ITEM_NO.DataPropertyName = "item_no";
            this.ITEM_NO.FillWeight = 203.4567F;
            this.ITEM_NO.HeaderText = "ITEM_NO";
            this.ITEM_NO.Name = "ITEM_NO";
            this.ITEM_NO.ReadOnly = true;
            this.ITEM_NO.Visible = false;
            // 
            // ITEM_NAME
            // 
            this.ITEM_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ITEM_NAME.DataPropertyName = "item_name";
            this.ITEM_NAME.FillWeight = 65.78432F;
            this.ITEM_NAME.HeaderText = "ITEM NAME";
            this.ITEM_NAME.Name = "ITEM_NAME";
            this.ITEM_NAME.ReadOnly = true;
            // 
            // UNIT_PRICE
            // 
            this.UNIT_PRICE.DataPropertyName = "uni_price";
            this.UNIT_PRICE.FillWeight = 65.78432F;
            this.UNIT_PRICE.HeaderText = "UNIT PRICE";
            this.UNIT_PRICE.Name = "UNIT_PRICE";
            this.UNIT_PRICE.ReadOnly = true;
            this.UNIT_PRICE.Width = 150;
            // 
            // BILL_ID
            // 
            this.BILL_ID.DataPropertyName = "bill_no";
            this.BILL_ID.HeaderText = "BILL NO";
            this.BILL_ID.Name = "BILL_ID";
            this.BILL_ID.ReadOnly = true;
            this.BILL_ID.Visible = false;
            // 
            // QUNATITY_C
            // 
            this.QUNATITY_C.DataPropertyName = "quantity";
            this.QUNATITY_C.HeaderText = "QUANTITY";
            this.QUNATITY_C.Name = "QUNATITY_C";
            this.QUNATITY_C.ReadOnly = true;
            this.QUNATITY_C.Width = 150;
            // 
            // billno_text
            // 
            this.billno_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billno_text.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billno_text.ForeColor = System.Drawing.Color.Maroon;
            this.billno_text.Location = new System.Drawing.Point(489, 99);
            this.billno_text.Multiline = true;
            this.billno_text.Name = "billno_text";
            this.billno_text.Size = new System.Drawing.Size(370, 45);
            this.billno_text.TabIndex = 7;
            this.billno_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(728, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(728, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(728, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity";
            // 
            // change_bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.billno_text);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.unitprice);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.remove_Order);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Name = "change_bill";
            this.Size = new System.Drawing.Size(1306, 771);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btndelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnupdate;
        private Bunifu.Framework.UI.BunifuThinButton2 btncancel;
        private Bunifu.Framework.UI.BunifuThinButton2 remove_Order;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox unitprice;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BILL_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUNATITY_C;
        private System.Windows.Forms.TextBox billno_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
