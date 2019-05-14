namespace WindowsFormsApp3
{
    partial class Customers
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.priceLab = new System.Windows.Forms.Label();
            this.isbnLab = new System.Windows.Forms.Label();
            this.zip_box = new System.Windows.Forms.TextBox();
            this.state_box = new System.Windows.Forms.TextBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.NewCust_btn = new System.Windows.Forms.Button();
            this.city_box = new System.Windows.Forms.TextBox();
            this.first_namebox = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.FnameLab = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.last_namebox = new System.Windows.Forms.TextBox();
            this.LnameLab = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.addressLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.idthing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "Edit an Existing Customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(31, 234);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(28, 17);
            this.priceLab.TabIndex = 25;
            this.priceLab.Text = "Zip";
            // 
            // isbnLab
            // 
            this.isbnLab.AutoSize = true;
            this.isbnLab.Location = new System.Drawing.Point(31, 182);
            this.isbnLab.Name = "isbnLab";
            this.isbnLab.Size = new System.Drawing.Size(41, 17);
            this.isbnLab.TabIndex = 24;
            this.isbnLab.Text = "State";
            this.isbnLab.Click += new System.EventHandler(this.isbnLab_Click);
            // 
            // zip_box
            // 
            this.zip_box.Location = new System.Drawing.Point(110, 231);
            this.zip_box.Name = "zip_box";
            this.zip_box.Size = new System.Drawing.Size(338, 22);
            this.zip_box.TabIndex = 23;
            // 
            // state_box
            // 
            this.state_box.Location = new System.Drawing.Point(110, 179);
            this.state_box.Name = "state_box";
            this.state_box.Size = new System.Drawing.Size(473, 22);
            this.state_box.TabIndex = 22;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_btn.Location = new System.Drawing.Point(798, 137);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(169, 36);
            this.Cancel_btn.TabIndex = 21;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save_btn.Location = new System.Drawing.Point(798, 95);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(169, 36);
            this.save_btn.TabIndex = 20;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // NewCust_btn
            // 
            this.NewCust_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewCust_btn.Location = new System.Drawing.Point(798, 53);
            this.NewCust_btn.Name = "NewCust_btn";
            this.NewCust_btn.Size = new System.Drawing.Size(169, 36);
            this.NewCust_btn.TabIndex = 19;
            this.NewCust_btn.Text = "New Customer";
            this.NewCust_btn.UseVisualStyleBackColor = false;
            this.NewCust_btn.Click += new System.EventHandler(this.NewCust_btn_Click);
            // 
            // city_box
            // 
            this.city_box.Location = new System.Drawing.Point(110, 137);
            this.city_box.Name = "city_box";
            this.city_box.Size = new System.Drawing.Size(473, 22);
            this.city_box.TabIndex = 18;
            // 
            // first_namebox
            // 
            this.first_namebox.Location = new System.Drawing.Point(110, 53);
            this.first_namebox.Name = "first_namebox";
            this.first_namebox.Size = new System.Drawing.Size(174, 22);
            this.first_namebox.TabIndex = 17;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(31, 140);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(35, 17);
            this.Author.TabIndex = 16;
            this.Author.Text = "City:";
            // 
            // FnameLab
            // 
            this.FnameLab.AutoSize = true;
            this.FnameLab.Location = new System.Drawing.Point(31, 53);
            this.FnameLab.Name = "FnameLab";
            this.FnameLab.Size = new System.Drawing.Size(76, 17);
            this.FnameLab.TabIndex = 15;
            this.FnameLab.Text = "First Name";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Back_btn.Location = new System.Drawing.Point(798, 9);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(169, 36);
            this.Back_btn.TabIndex = 14;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // last_namebox
            // 
            this.last_namebox.Location = new System.Drawing.Point(409, 53);
            this.last_namebox.Name = "last_namebox";
            this.last_namebox.Size = new System.Drawing.Size(174, 22);
            this.last_namebox.TabIndex = 28;
            // 
            // LnameLab
            // 
            this.LnameLab.AutoSize = true;
            this.LnameLab.Location = new System.Drawing.Point(330, 53);
            this.LnameLab.Name = "LnameLab";
            this.LnameLab.Size = new System.Drawing.Size(76, 17);
            this.LnameLab.TabIndex = 27;
            this.LnameLab.Text = "Last Name";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(110, 95);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(473, 22);
            this.address_box.TabIndex = 30;
            // 
            // addressLab
            // 
            this.addressLab.AutoSize = true;
            this.addressLab.Location = new System.Drawing.Point(31, 98);
            this.addressLab.Name = "addressLab";
            this.addressLab.Size = new System.Drawing.Size(64, 17);
            this.addressLab.TabIndex = 29;
            this.addressLab.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Home phone";
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(110, 275);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(338, 22);
            this.phone_box.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(110, 313);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(338, 22);
            this.email_box.TabIndex = 33;
            // 
            // invinsibletb
            // 
            this.idthing.Enabled = false;
            this.idthing.Location = new System.Drawing.Point(798, 176);
            this.idthing.Name = "invinsibletb";
            this.idthing.Size = new System.Drawing.Size(100, 22);
            this.idthing.TabIndex = 35;
            this.idthing.Visible = false;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 365);
            this.Controls.Add(this.idthing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.addressLab);
            this.Controls.Add(this.last_namebox);
            this.Controls.Add(this.LnameLab);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priceLab);
            this.Controls.Add(this.isbnLab);
            this.Controls.Add(this.zip_box);
            this.Controls.Add(this.state_box);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.NewCust_btn);
            this.Controls.Add(this.city_box);
            this.Controls.Add(this.first_namebox);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.FnameLab);
            this.Controls.Add(this.Back_btn);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label priceLab;
        private System.Windows.Forms.Label isbnLab;
        private System.Windows.Forms.TextBox zip_box;
        private System.Windows.Forms.TextBox state_box;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button NewCust_btn;
        private System.Windows.Forms.TextBox city_box;
        private System.Windows.Forms.TextBox first_namebox;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label FnameLab;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.TextBox last_namebox;
        private System.Windows.Forms.Label LnameLab;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label addressLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox idthing;
    }
}