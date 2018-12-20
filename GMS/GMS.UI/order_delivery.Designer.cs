namespace GMS.UI
{
    partial class order_delivey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_delivey));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Item = new MetroFramework.Controls.MetroComboBox();
            this.Quan = new MetroFramework.Controls.MetroTextBox();
            this.Dept = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Assign = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Comp_name = new MetroFramework.Controls.MetroTextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(180, 37);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(280, 30);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Order And Delivery Section";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(594, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Item Type";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(602, 167);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Quantity";
            //this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // Item
            // 
            this.Item.FormattingEnabled = true;
            this.Item.ItemHeight = 23;
            this.Item.Location = new System.Drawing.Point(702, 97);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(121, 29);
            this.Item.TabIndex = 5;
            this.Item.UseSelectable = true;
            this.Item.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // Quan
            // 
            // 
            // 
            // 
            this.Quan.CustomButton.Image = null;
            this.Quan.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Quan.CustomButton.Name = "";
            this.Quan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Quan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Quan.CustomButton.TabIndex = 1;
            this.Quan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Quan.CustomButton.UseSelectable = true;
            this.Quan.CustomButton.Visible = false;
            this.Quan.Lines = new string[0];
            this.Quan.Location = new System.Drawing.Point(708, 167);
            this.Quan.MaxLength = 32767;
            this.Quan.Name = "Quan";
            this.Quan.PasswordChar = '\0';
            this.Quan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Quan.SelectedText = "";
            this.Quan.SelectionLength = 0;
            this.Quan.SelectionStart = 0;
            this.Quan.ShortcutsEnabled = true;
            this.Quan.Size = new System.Drawing.Size(121, 23);
            this.Quan.TabIndex = 6;
            this.Quan.UseSelectable = true;
            this.Quan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Quan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Dept
            // 
            this.Dept.FormattingEnabled = true;
            this.Dept.ItemHeight = 23;
            this.Dept.Location = new System.Drawing.Point(708, 227);
            this.Dept.Name = "Dept";
            this.Dept.Size = new System.Drawing.Size(121, 29);
            this.Dept.TabIndex = 7;
            this.Dept.UseSelectable = true;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(594, 227);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 17);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Department";
            // 
            // Assign
            // 
            this.Assign.ActiveBorderThickness = 1;
            this.Assign.ActiveCornerRadius = 20;
            this.Assign.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Assign.ActiveForecolor = System.Drawing.Color.White;
            this.Assign.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Assign.BackColor = System.Drawing.Color.Transparent;
            this.Assign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Assign.BackgroundImage")));
            this.Assign.ButtonText = "Assign";
            this.Assign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Assign.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assign.ForeColor = System.Drawing.Color.SeaGreen;
            this.Assign.IdleBorderThickness = 1;
            this.Assign.IdleCornerRadius = 20;
            this.Assign.IdleFillColor = System.Drawing.Color.White;
            this.Assign.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Assign.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Assign.Location = new System.Drawing.Point(605, 450);
            this.Assign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Assign.Name = "Assign";
            this.Assign.Size = new System.Drawing.Size(141, 46);
            this.Assign.TabIndex = 9;
            this.Assign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Assign.Click += new System.EventHandler(this.Assign_Click);
            // 
            // Cancel
            // 
            this.Cancel.ActiveBorderThickness = 1;
            this.Cancel.ActiveCornerRadius = 20;
            this.Cancel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Cancel.ActiveForecolor = System.Drawing.Color.Transparent;
            this.Cancel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancel.BackgroundImage")));
            this.Cancel.ButtonText = "Cancel";
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.SeaGreen;
            this.Cancel.IdleBorderThickness = 1;
            this.Cancel.IdleCornerRadius = 20;
            this.Cancel.IdleFillColor = System.Drawing.Color.White;
            this.Cancel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Cancel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Cancel.Location = new System.Drawing.Point(40, 455);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(171, 41);
            this.Cancel.TabIndex = 10;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Delivered";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(345, 455);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(144, 41);
            this.bunifuThinButton22.TabIndex = 11;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(581, 301);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(106, 17);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Company Name";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(594, 370);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(85, 17);
            this.bunifuCustomLabel6.TabIndex = 13;
            this.bunifuCustomLabel6.Text = "Choose Date";
            // 
            // Comp_name
            // 
            // 
            // 
            // 
            this.Comp_name.CustomButton.Image = null;
            this.Comp_name.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.Comp_name.CustomButton.Name = "";
            this.Comp_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Comp_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Comp_name.CustomButton.TabIndex = 1;
            this.Comp_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Comp_name.CustomButton.UseSelectable = true;
            this.Comp_name.CustomButton.Visible = false;
            this.Comp_name.Lines = new string[0];
            this.Comp_name.Location = new System.Drawing.Point(711, 301);
            this.Comp_name.MaxLength = 32767;
            this.Comp_name.Name = "Comp_name";
            this.Comp_name.PasswordChar = '\0';
            this.Comp_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Comp_name.SelectedText = "";
            this.Comp_name.SelectionLength = 0;
            this.Comp_name.SelectionStart = 0;
            this.Comp_name.ShortcutsEnabled = true;
            this.Comp_name.Size = new System.Drawing.Size(118, 23);
            this.Comp_name.TabIndex = 14;
            this.Comp_name.UseSelectable = true;
            this.Comp_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Comp_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Exit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(679, 511);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(150, 38);
            this.bunifuThinButton21.TabIndex = 17;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dataGridView1);
            this.bunifuGradientPanel1.Controls.Add(this.DateTime1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton21);
            this.bunifuGradientPanel1.Controls.Add(this.Comp_name);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel6);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel5);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuThinButton22);
            this.bunifuGradientPanel1.Controls.Add(this.Cancel);
            this.bunifuGradientPanel1.Controls.Add(this.Assign);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.Dept);
            this.bunifuGradientPanel1.Controls.Add(this.Quan);
            this.bunifuGradientPanel1.Controls.Add(this.Item);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LavenderBlush;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(3, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(845, 557);
            this.bunifuGradientPanel1.TabIndex = 0;
           // this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 341);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateTime1
            // 
            this.DateTime1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DateTime1.CustomFormat = "dd-MM-yyyy";
            this.DateTime1.Location = new System.Drawing.Point(711, 363);
            this.DateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime1.Name = "DateTime1";
            this.DateTime1.Size = new System.Drawing.Size(121, 29);
            this.DateTime1.TabIndex = 18;
            this.DateTime1.Value = new System.DateTime(2017, 9, 2, 0, 0, 0, 0);
            // 
            // order_delivey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "order_delivey";
            this.Size = new System.Drawing.Size(851, 560);
            this.Load += new System.EventHandler(this.order_delivey_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private MetroFramework.Controls.MetroComboBox Item;
        private MetroFramework.Controls.MetroTextBox Quan;
        private MetroFramework.Controls.MetroComboBox Dept;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuThinButton2 Assign;
        private Bunifu.Framework.UI.BunifuThinButton2 Cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private MetroFramework.Controls.MetroTextBox Comp_name;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private MetroFramework.Controls.MetroDateTime DateTime1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
