namespace WindowsFormsApp3
{
    partial class Orders
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
            this.backbtn_1 = new System.Windows.Forms.Button();
            this.subbox = new System.Windows.Forms.TextBox();
            this.taxbox = new System.Windows.Forms.TextBox();
            this.totalbox = new System.Windows.Forms.TextBox();
            this.custbox = new System.Windows.Forms.ComboBox();
            this.bookbox = new System.Windows.Forms.ComboBox();
            this.authrobox = new System.Windows.Forms.TextBox();
            this.isbnbox = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.quantbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn_1
            // 
            this.backbtn_1.Location = new System.Drawing.Point(668, 26);
            this.backbtn_1.Name = "backbtn_1";
            this.backbtn_1.Size = new System.Drawing.Size(120, 48);
            this.backbtn_1.TabIndex = 0;
            this.backbtn_1.Text = "BACK";
            this.backbtn_1.UseVisualStyleBackColor = true;
            this.backbtn_1.Click += new System.EventHandler(this.backbtn_1_Click);
            // 
            // subbox
            // 
            this.subbox.Location = new System.Drawing.Point(261, 352);
            this.subbox.Name = "subbox";
            this.subbox.Size = new System.Drawing.Size(131, 22);
            this.subbox.TabIndex = 5;
            this.subbox.Text = "sub total";
            // 
            // taxbox
            // 
            this.taxbox.Location = new System.Drawing.Point(431, 352);
            this.taxbox.Name = "taxbox";
            this.taxbox.Size = new System.Drawing.Size(140, 22);
            this.taxbox.TabIndex = 6;
            this.taxbox.Text = "tax";
            // 
            // totalbox
            // 
            this.totalbox.Location = new System.Drawing.Point(600, 352);
            this.totalbox.Name = "totalbox";
            this.totalbox.Size = new System.Drawing.Size(131, 22);
            this.totalbox.TabIndex = 7;
            this.totalbox.Text = "Total";
            // 
            // custbox
            // 
            this.custbox.FormattingEnabled = true;
            this.custbox.Location = new System.Drawing.Point(12, 39);
            this.custbox.Name = "custbox";
            this.custbox.Size = new System.Drawing.Size(226, 24);
            this.custbox.TabIndex = 8;
            this.custbox.Text = "Customer ID";
            this.custbox.SelectedIndexChanged += new System.EventHandler(this.custbox_SelectedIndexChanged);
            // 
            // bookbox
            // 
            this.bookbox.FormattingEnabled = true;
            this.bookbox.Location = new System.Drawing.Point(12, 90);
            this.bookbox.Name = "bookbox";
            this.bookbox.Size = new System.Drawing.Size(226, 24);
            this.bookbox.TabIndex = 9;
            this.bookbox.Text = "Book";
            this.bookbox.SelectedIndexChanged += new System.EventHandler(this.bookbox_SelectedIndexChanged);
            // 
            // authrobox
            // 
            this.authrobox.Enabled = false;
            this.authrobox.Location = new System.Drawing.Point(12, 136);
            this.authrobox.Name = "authrobox";
            this.authrobox.Size = new System.Drawing.Size(226, 22);
            this.authrobox.TabIndex = 10;
            this.authrobox.Text = "Author";
            // 
            // isbnbox
            // 
            this.isbnbox.Enabled = false;
            this.isbnbox.Location = new System.Drawing.Point(12, 182);
            this.isbnbox.Name = "isbnbox";
            this.isbnbox.Size = new System.Drawing.Size(226, 22);
            this.isbnbox.TabIndex = 11;
            this.isbnbox.Text = "ISBN";
            // 
            // pricebox
            // 
            this.pricebox.Enabled = false;
            this.pricebox.Location = new System.Drawing.Point(12, 224);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(226, 22);
            this.pricebox.TabIndex = 12;
            this.pricebox.Text = "Price";
            // 
            // quantbox
            // 
            this.quantbox.Location = new System.Drawing.Point(12, 269);
            this.quantbox.Name = "quantbox";
            this.quantbox.Size = new System.Drawing.Size(226, 22);
            this.quantbox.TabIndex = 13;
            this.quantbox.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.QTY,
            this.LineTotal});
            this.dataGridView1.Location = new System.Drawing.Point(261, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(443, 242);
            this.dataGridView1.TabIndex = 14;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            // 
            // LineTotal
            // 
            this.LineTotal.HeaderText = "Line Total";
            this.LineTotal.Name = "LineTotal";
            // 
            // confirmbutton
            // 
            this.confirmbutton.BackColor = System.Drawing.Color.Chartreuse;
            this.confirmbutton.Location = new System.Drawing.Point(261, 396);
            this.confirmbutton.Name = "confirmbutton";
            this.confirmbutton.Size = new System.Drawing.Size(142, 28);
            this.confirmbutton.TabIndex = 15;
            this.confirmbutton.Text = "Confirm";
            this.confirmbutton.UseVisualStyleBackColor = false;
            this.confirmbutton.Click += new System.EventHandler(this.confirmbutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.DarkRed;
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(429, 396);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(142, 28);
            this.cancelbutton.TabIndex = 16;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 309);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(226, 23);
            this.add.TabIndex = 18;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.isbnbox);
            this.Controls.Add(this.authrobox);
            this.Controls.Add(this.bookbox);
            this.Controls.Add(this.custbox);
            this.Controls.Add(this.totalbox);
            this.Controls.Add(this.taxbox);
            this.Controls.Add(this.subbox);
            this.Controls.Add(this.backbtn_1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn_1;
        private System.Windows.Forms.TextBox subbox;
        private System.Windows.Forms.TextBox taxbox;
        private System.Windows.Forms.TextBox totalbox;
        private System.Windows.Forms.ComboBox custbox;
        private System.Windows.Forms.ComboBox bookbox;
        private System.Windows.Forms.TextBox authrobox;
        private System.Windows.Forms.TextBox isbnbox;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.TextBox quantbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add;
    }
}