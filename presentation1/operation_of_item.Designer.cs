namespace presentation1
{
    partial class operation_of_item
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(operation_of_item));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.product_no_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_name_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_price_text = new System.Windows.Forms.TextBox();
            this.btn_add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.product_no_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_update = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ITEM_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CATEGORY_NO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(20, 132);
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
            this.dataGridView1.Size = new System.Drawing.Size(693, 623);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // product_no_text
            // 
            this.product_no_text.BackColor = System.Drawing.Color.White;
            this.product_no_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_no_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_no_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.product_no_text.Location = new System.Drawing.Point(949, 177);
            this.product_no_text.Name = "product_no_text";
            this.product_no_text.Size = new System.Drawing.Size(330, 27);
            this.product_no_text.TabIndex = 5;
            this.product_no_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(767, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product No";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(767, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name";
            // 
            // product_name_text
            // 
            this.product_name_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.product_name_text.BackColor = System.Drawing.Color.White;
            this.product_name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_name_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.product_name_text.Location = new System.Drawing.Point(949, 274);
            this.product_name_text.Name = "product_name_text";
            this.product_name_text.Size = new System.Drawing.Size(330, 27);
            this.product_name_text.TabIndex = 7;
            this.product_name_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(767, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Price";
            // 
            // product_price_text
            // 
            this.product_price_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.product_price_text.BackColor = System.Drawing.Color.White;
            this.product_price_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_price_text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.product_price_text.Location = new System.Drawing.Point(949, 355);
            this.product_price_text.Name = "product_price_text";
            this.product_price_text.Size = new System.Drawing.Size(330, 27);
            this.product_price_text.TabIndex = 9;
            this.product_price_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_add
            // 
            this.btn_add.ActiveBorderThickness = 2;
            this.btn_add.ActiveCornerRadius = 20;
            this.btn_add.ActiveFillColor = System.Drawing.Color.White;
            this.btn_add.ActiveForecolor = System.Drawing.Color.Maroon;
            this.btn_add.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_add.BackColor = System.Drawing.SystemColors.Control;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.ButtonText = "ADD";
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_add.IdleBorderThickness = 1;
            this.btn_add.IdleCornerRadius = 20;
            this.btn_add.IdleFillColor = System.Drawing.Color.White;
            this.btn_add.IdleForecolor = System.Drawing.Color.Maroon;
            this.btn_add.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btn_add.Location = new System.Drawing.Point(892, 587);
            this.btn_add.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(117, 58);
            this.btn_add.TabIndex = 11;
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(767, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product Category";
            // 
            // product_no_combo
            // 
            this.product_no_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.product_no_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_no_combo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.product_no_combo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_no_combo.Items.AddRange(new object[] {
            "BEEF",
            "BEVERAGES",
            "BREAKFAST",
            "CHICKEN",
            "DESSERTS",
            "MCCAFE",
            "MEALS",
            "SALADS",
            "SIDES",
            "VEGETARIAN",
            "WRAPS"});
            this.product_no_combo.Location = new System.Drawing.Point(949, 461);
            this.product_no_combo.Name = "product_no_combo";
            this.product_no_combo.Size = new System.Drawing.Size(330, 31);
            this.product_no_combo.Sorted = true;
            this.product_no_combo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(901, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Product Description";
            // 
            // btn_update
            // 
            this.btn_update.ActiveBorderThickness = 2;
            this.btn_update.ActiveCornerRadius = 20;
            this.btn_update.ActiveFillColor = System.Drawing.Color.White;
            this.btn_update.ActiveForecolor = System.Drawing.Color.Maroon;
            this.btn_update.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_update.BackColor = System.Drawing.SystemColors.Control;
            this.btn_update.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_update.BackgroundImage")));
            this.btn_update.ButtonText = "UPDATE";
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_update.IdleBorderThickness = 1;
            this.btn_update.IdleCornerRadius = 20;
            this.btn_update.IdleFillColor = System.Drawing.Color.White;
            this.btn_update.IdleForecolor = System.Drawing.Color.Maroon;
            this.btn_update.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btn_update.Location = new System.Drawing.Point(1019, 587);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(117, 58);
            this.btn_update.TabIndex = 15;
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ActiveBorderThickness = 2;
            this.btn_delete.ActiveCornerRadius = 20;
            this.btn_delete.ActiveFillColor = System.Drawing.Color.White;
            this.btn_delete.ActiveForecolor = System.Drawing.Color.Maroon;
            this.btn_delete.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.ButtonText = "DELETE";
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_delete.IdleBorderThickness = 1;
            this.btn_delete.IdleCornerRadius = 20;
            this.btn_delete.IdleFillColor = System.Drawing.Color.White;
            this.btn_delete.IdleForecolor = System.Drawing.Color.Maroon;
            this.btn_delete.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.btn_delete.Location = new System.Drawing.Point(1146, 587);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 58);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "RESET";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Maroon;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.bunifuThinButton21.Location = new System.Drawing.Point(764, 587);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(117, 58);
            this.bunifuThinButton21.TabIndex = 17;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchTextbox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Goldenrod;
            this.SearchTextbox.Location = new System.Drawing.Point(137, 66);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.Size = new System.Drawing.Size(174, 34);
            this.SearchTextbox.TabIndex = 18;
            this.SearchTextbox.Text = "Search.....";
            this.SearchTextbox.Enter += new System.EventHandler(this.SearchTextbox_Enter);
            this.SearchTextbox.Leave += new System.EventHandler(this.SearchTextbox_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(340, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ITEM_NO
            // 
            this.ITEM_NO.DataPropertyName = "item_id";
            this.ITEM_NO.FillWeight = 203.4567F;
            this.ITEM_NO.HeaderText = "ITEM NO";
            this.ITEM_NO.Name = "ITEM_NO";
            this.ITEM_NO.ReadOnly = true;
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
            this.UNIT_PRICE.Width = 75;
            // 
            // CATEGORY_NO
            // 
            this.CATEGORY_NO.DataPropertyName = "category_name";
            this.CATEGORY_NO.FillWeight = 64.97462F;
            this.CATEGORY_NO.HeaderText = "CATEGORY NAME";
            this.CATEGORY_NO.Name = "CATEGORY_NO";
            this.CATEGORY_NO.ReadOnly = true;
            // 
            // operation_of_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchTextbox);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.product_no_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product_price_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_no_text);
            this.Controls.Add(this.dataGridView1);
            this.Name = "operation_of_item";
            this.Size = new System.Drawing.Size(1306, 771);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox product_no_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox product_name_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox product_price_text;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox product_no_combo;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_update;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_delete;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TextBox SearchTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY_NO;

    }
}
