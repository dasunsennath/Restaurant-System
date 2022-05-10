namespace presentation1
{
    partial class userdetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_year = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_month = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_day = new System.Windows.Forms.DateTimePicker();
            this.BILL_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEM_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUNATITY_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BILL_NO,
            this.ITEM_NAME,
            this.QUNATITY_C,
            this.UNIT_PRICE,
            this.Day,
            this.Time});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(12, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1264, 500);
            this.dataGridView1.TabIndex = 9;
            // 
            // dateTimePicker_year
            // 
            this.dateTimePicker_year.CustomFormat = "yyyy";
            this.dateTimePicker_year.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_year.Location = new System.Drawing.Point(394, 63);
            this.dateTimePicker_year.Name = "dateTimePicker_year";
            this.dateTimePicker_year.Size = new System.Drawing.Size(84, 38);
            this.dateTimePicker_year.TabIndex = 10;
            this.dateTimePicker_year.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            this.dateTimePicker_year.ValueChanged += new System.EventHandler(this.dateTimePicker_year_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(413, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yearly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(669, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "Monthly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(951, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Daily";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(204, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select One";
            // 
            // dateTimePicker_month
            // 
            this.dateTimePicker_month.CustomFormat = "yyyy-MM";
            this.dateTimePicker_month.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_month.Location = new System.Drawing.Point(656, 65);
            this.dateTimePicker_month.Name = "dateTimePicker_month";
            this.dateTimePicker_month.Size = new System.Drawing.Size(118, 38);
            this.dateTimePicker_month.TabIndex = 12;
            this.dateTimePicker_month.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            this.dateTimePicker_month.ValueChanged += new System.EventHandler(this.dateTimePicker_month_ValueChanged);
            // 
            // dateTimePicker_day
            // 
            this.dateTimePicker_day.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_day.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_day.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_day.Location = new System.Drawing.Point(919, 65);
            this.dateTimePicker_day.Name = "dateTimePicker_day";
            this.dateTimePicker_day.Size = new System.Drawing.Size(150, 38);
            this.dateTimePicker_day.TabIndex = 13;
            this.dateTimePicker_day.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            this.dateTimePicker_day.ValueChanged += new System.EventHandler(this.dateTimePicker_day_ValueChanged);
            // 
            // BILL_NO
            // 
            this.BILL_NO.DataPropertyName = "bill_no";
            this.BILL_NO.HeaderText = "BILL NO";
            this.BILL_NO.Name = "BILL_NO";
            this.BILL_NO.ReadOnly = true;
            this.BILL_NO.Width = 150;
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
            // QUNATITY_C
            // 
            this.QUNATITY_C.DataPropertyName = "quantity";
            this.QUNATITY_C.HeaderText = "QUANTITY";
            this.QUNATITY_C.Name = "QUNATITY_C";
            this.QUNATITY_C.ReadOnly = true;
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
            // Day
            // 
            this.Day.DataPropertyName = "bill_date";
            this.Day.HeaderText = "DAY";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 150;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "bill_time";
            this.Time.HeaderText = "TIME";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // userdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 724);
            this.Controls.Add(this.dateTimePicker_day);
            this.Controls.Add(this.dateTimePicker_month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_year);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userdetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_month;
        private System.Windows.Forms.DateTimePicker dateTimePicker_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn BILL_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUNATITY_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNIT_PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}
