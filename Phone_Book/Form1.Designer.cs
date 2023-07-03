namespace Phone_Book
{
    partial class First_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_Page));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.phone_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.search_logo = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.options_cmbo = new System.Windows.Forms.ComboBox();
            this.Selection_lbl = new System.Windows.Forms.Label();
            this.name_txtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.no_txtbx = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.add_contact_btn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.DIsplay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 89);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(122, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 378);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(679, 41);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // phone_list
            // 
            this.phone_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_list.BackColor = System.Drawing.Color.RoyalBlue;
            this.phone_list.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phone_list.FormattingEnabled = true;
            this.phone_list.ItemHeight = 32;
            this.phone_list.Location = new System.Drawing.Point(10, 174);
            this.phone_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phone_list.Name = "phone_list";
            this.phone_list.Size = new System.Drawing.Size(674, 228);
            this.phone_list.TabIndex = 0;
            this.phone_list.SelectedIndexChanged += new System.EventHandler(this.phone_list_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.792208F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.20779F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.Controls.Add(this.search_logo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SearchBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.add_btn, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 98);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(674, 52);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // search_logo
            // 
            this.search_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_logo.AutoSize = true;
            this.search_logo.Image = ((System.Drawing.Image)(resources.GetObject("search_logo.Image")));
            this.search_logo.Location = new System.Drawing.Point(3, 0);
            this.search_logo.Name = "search_logo";
            this.search_logo.Size = new System.Drawing.Size(38, 52);
            this.search_logo.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.SearchBox.Location = new System.Drawing.Point(47, 6);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(521, 39);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.AutoSize = true;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.Location = new System.Drawing.Point(591, 2);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(62, 48);
            this.add_btn.TabIndex = 2;
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78377F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.21622F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.options_cmbo, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Selection_lbl, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.name_txtbx, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.no_txtbx, 1, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(7, 424);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(660, 127);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number:";
            // 
            // options_cmbo
            // 
            this.options_cmbo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.options_cmbo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.options_cmbo.FormattingEnabled = true;
            this.options_cmbo.Items.AddRange(new object[] {
            "Landline",
            "Cell"});
            this.options_cmbo.Location = new System.Drawing.Point(95, 9);
            this.options_cmbo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.options_cmbo.Name = "options_cmbo";
            this.options_cmbo.Size = new System.Drawing.Size(540, 29);
            this.options_cmbo.TabIndex = 4;
            // 
            // Selection_lbl
            // 
            this.Selection_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Selection_lbl.AutoSize = true;
            this.Selection_lbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Selection_lbl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Selection_lbl.Location = new System.Drawing.Point(7, 10);
            this.Selection_lbl.Name = "Selection_lbl";
            this.Selection_lbl.Size = new System.Drawing.Size(57, 28);
            this.Selection_lbl.TabIndex = 5;
            this.Selection_lbl.Text = "Type:";
            // 
            // name_txtbx
            // 
            this.name_txtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_txtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_txtbx.Location = new System.Drawing.Point(99, 57);
            this.name_txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txtbx.Name = "name_txtbx";
            this.name_txtbx.Size = new System.Drawing.Size(532, 29);
            this.name_txtbx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // no_txtbx
            // 
            this.no_txtbx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.no_txtbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.no_txtbx.Location = new System.Drawing.Point(102, 98);
            this.no_txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_txtbx.Name = "no_txtbx";
            this.no_txtbx.Size = new System.Drawing.Size(526, 29);
            this.no_txtbx.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.45098F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.54902F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel5.Controls.Add(this.Clear_btn, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Clear_btn.AutoSize = true;
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_btn.Location = new System.Drawing.Point(3, 30);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clear_btn.Size = new System.Drawing.Size(1, 40);
            this.Clear_btn.TabIndex = 2;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit_btn.AutoSize = true;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.Location = new System.Drawing.Point(-13, 30);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(1, 40);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Cancel";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // add_contact_btn
            // 
            this.add_contact_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_contact_btn.AutoSize = true;
            this.add_contact_btn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_contact_btn.Location = new System.Drawing.Point(31, 2);
            this.add_contact_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_contact_btn.Name = "add_contact_btn";
            this.add_contact_btn.Size = new System.Drawing.Size(56, 28);
            this.add_contact_btn.TabIndex = 0;
            this.add_contact_btn.Text = "Add";
            this.add_contact_btn.UseVisualStyleBackColor = true;
            this.add_contact_btn.Click += new System.EventHandler(this.add_contact_btn_Click);
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(153, 2);
            this.clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear.Name = "clear";
            this.clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clear.Size = new System.Drawing.Size(64, 28);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.95259F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.04741F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel6.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.clear, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.add_contact_btn, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.DIsplay, 3, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 555);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(502, 32);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(282, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DIsplay
            // 
            this.DIsplay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DIsplay.AutoSize = true;
            this.DIsplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DIsplay.Location = new System.Drawing.Point(397, 2);
            this.DIsplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DIsplay.Name = "DIsplay";
            this.DIsplay.Size = new System.Drawing.Size(96, 28);
            this.DIsplay.TabIndex = 4;
            this.DIsplay.Text = "Display";
            this.DIsplay.UseVisualStyleBackColor = true;
            this.DIsplay.Click += new System.EventHandler(this.DIsplay_Click);
            // 
            // First_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(700, 587);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.phone_list);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "First_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.First_Page_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ListBox phone_list;
        private Label search_logo;
        private TextBox SearchBox;
        private Button add_btn;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox options_cmbo;
        private Label Selection_lbl;
        private TextBox name_txtbx;
        private Label label2;
        private TextBox no_txtbx;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel5;
        private Button Clear_btn;
        private Button exit_btn;
        private Button add_contact_btn;
        private Button clear;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button1;
        private Button DIsplay;
    }
}