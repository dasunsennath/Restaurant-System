namespace presentation1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button_ACCEPT = new System.Windows.Forms.Button();
            this.Textbox_USERNAME = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Textbox_PASSWORD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Button_CLOSE = new Bunifu.Framework.UI.BunifuImageButton();
            this.linkLabel_CREATEACCOUNT = new System.Windows.Forms.LinkLabel();
            this.labeerroe = new System.Windows.Forms.Label();
            this.error_imag = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_imag)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(478, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(100, 38);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "LOGIN";
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // button_ACCEPT
            // 
            this.button_ACCEPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_ACCEPT.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button_ACCEPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button_ACCEPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_ACCEPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ACCEPT.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ACCEPT.ForeColor = System.Drawing.Color.LightGray;
            this.button_ACCEPT.Location = new System.Drawing.Point(329, 239);
            this.button_ACCEPT.Name = "button_ACCEPT";
            this.button_ACCEPT.Size = new System.Drawing.Size(410, 40);
            this.button_ACCEPT.TabIndex = 4;
            this.button_ACCEPT.Text = "Log in";
            this.button_ACCEPT.UseVisualStyleBackColor = false;
            this.button_ACCEPT.Click += new System.EventHandler(this.button_ACCEPT_Click);
            // 
            // Textbox_USERNAME
            // 
            this.Textbox_USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_USERNAME.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_USERNAME.ForeColor = System.Drawing.Color.DimGray;
            this.Textbox_USERNAME.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_USERNAME.HintText = "";
            this.Textbox_USERNAME.isPassword = false;
            this.Textbox_USERNAME.LineFocusedColor = System.Drawing.Color.LightGray;
            this.Textbox_USERNAME.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_USERNAME.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.Textbox_USERNAME.LineThickness = 1;
            this.Textbox_USERNAME.Location = new System.Drawing.Point(329, 77);
            this.Textbox_USERNAME.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_USERNAME.Name = "Textbox_USERNAME";
            this.Textbox_USERNAME.Size = new System.Drawing.Size(410, 33);
            this.Textbox_USERNAME.TabIndex = 5;
            this.Textbox_USERNAME.Text = "USER NAME";
            this.Textbox_USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_USERNAME.Enter += new System.EventHandler(this.Textbox_USERNAME_Enter);
            this.Textbox_USERNAME.Leave += new System.EventHandler(this.Textbox_USERNAME_Leave);
            // 
            // Textbox_PASSWORD
            // 
            this.Textbox_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_PASSWORD.ForeColor = System.Drawing.Color.DimGray;
            this.Textbox_PASSWORD.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_PASSWORD.HintText = "";
            this.Textbox_PASSWORD.isPassword = false;
            this.Textbox_PASSWORD.LineFocusedColor = System.Drawing.Color.LightGray;
            this.Textbox_PASSWORD.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_PASSWORD.LineMouseHoverColor = System.Drawing.Color.LightGray;
            this.Textbox_PASSWORD.LineThickness = 1;
            this.Textbox_PASSWORD.Location = new System.Drawing.Point(329, 140);
            this.Textbox_PASSWORD.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_PASSWORD.Name = "Textbox_PASSWORD";
            this.Textbox_PASSWORD.Size = new System.Drawing.Size(410, 33);
            this.Textbox_PASSWORD.TabIndex = 6;
            this.Textbox_PASSWORD.Text = "PASSWORD";
            this.Textbox_PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_PASSWORD.Enter += new System.EventHandler(this.Textbox_PASSWORD_Enter);
            this.Textbox_PASSWORD.Leave += new System.EventHandler(this.Textbox_PASSWORD_Leave);
            // 
            // Button_CLOSE
            // 
            this.Button_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.Button_CLOSE.Image = ((System.Drawing.Image)(resources.GetObject("Button_CLOSE.Image")));
            this.Button_CLOSE.ImageActive = null;
            this.Button_CLOSE.Location = new System.Drawing.Point(738, 5);
            this.Button_CLOSE.Name = "Button_CLOSE";
            this.Button_CLOSE.Size = new System.Drawing.Size(30, 30);
            this.Button_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_CLOSE.TabIndex = 7;
            this.Button_CLOSE.TabStop = false;
            this.Button_CLOSE.Zoom = 10;
            this.Button_CLOSE.Click += new System.EventHandler(this.Button_CLOSE_Click);
            // 
            // linkLabel_CREATEACCOUNT
            // 
            this.linkLabel_CREATEACCOUNT.AutoSize = true;
            this.linkLabel_CREATEACCOUNT.LinkColor = System.Drawing.Color.Goldenrod;
            this.linkLabel_CREATEACCOUNT.Location = new System.Drawing.Point(480, 294);
            this.linkLabel_CREATEACCOUNT.Name = "linkLabel_CREATEACCOUNT";
            this.linkLabel_CREATEACCOUNT.Size = new System.Drawing.Size(134, 17);
            this.linkLabel_CREATEACCOUNT.TabIndex = 8;
            this.linkLabel_CREATEACCOUNT.TabStop = true;
            this.linkLabel_CREATEACCOUNT.Text = "CREATE ACCOUNT";
            this.linkLabel_CREATEACCOUNT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_CREATEACCOUNT_LinkClicked);
            // 
            // labeerroe
            // 
            this.labeerroe.AutoSize = true;
            this.labeerroe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeerroe.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeerroe.ForeColor = System.Drawing.Color.LightGray;
            this.labeerroe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labeerroe.Location = new System.Drawing.Point(359, 204);
            this.labeerroe.Name = "labeerroe";
            this.labeerroe.Size = new System.Drawing.Size(103, 20);
            this.labeerroe.TabIndex = 9;
            this.labeerroe.Text = "Error Massage";
            this.labeerroe.Visible = false;
            // 
            // error_imag
            // 
            this.error_imag.Image = ((System.Drawing.Image)(resources.GetObject("error_imag.Image")));
            this.error_imag.Location = new System.Drawing.Point(335, 200);
            this.error_imag.Name = "error_imag";
            this.error_imag.Size = new System.Drawing.Size(20, 20);
            this.error_imag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.error_imag.TabIndex = 10;
            this.error_imag.TabStop = false;
            this.error_imag.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.error_imag);
            this.Controls.Add(this.labeerroe);
            this.Controls.Add(this.linkLabel_CREATEACCOUNT);
            this.Controls.Add(this.Button_CLOSE);
            this.Controls.Add(this.Textbox_PASSWORD);
            this.Controls.Add(this.Textbox_USERNAME);
            this.Controls.Add(this.button_ACCEPT);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_imag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Button button_ACCEPT;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_USERNAME;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_PASSWORD;
        private Bunifu.Framework.UI.BunifuImageButton Button_CLOSE;
        private System.Windows.Forms.LinkLabel linkLabel_CREATEACCOUNT;
        private System.Windows.Forms.PictureBox error_imag;
        private System.Windows.Forms.Label labeerroe;
    }
}

