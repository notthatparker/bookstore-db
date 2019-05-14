namespace WindowsFormsApp3
{
    partial class Bookform
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
            this.Back_btn = new System.Windows.Forms.Button();
            this.titleLab = new System.Windows.Forms.Label();
            this.Title_box = new System.Windows.Forms.TextBox();
            this.Author_box = new System.Windows.Forms.TextBox();
            this.NewBook_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.isbnLab = new System.Windows.Forms.Label();
            this.priceLab = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.authr = new System.Windows.Forms.Label();
            this.idthing = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Back_btn.Location = new System.Drawing.Point(580, 27);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(127, 29);
            this.Back_btn.TabIndex = 0;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Location = new System.Drawing.Point(6, 68);
            this.titleLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(27, 13);
            this.titleLab.TabIndex = 1;
            this.titleLab.Text = "Title";
            this.titleLab.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title_box
            // 
            this.Title_box.Location = new System.Drawing.Point(65, 68);
            this.Title_box.Margin = new System.Windows.Forms.Padding(2);
            this.Title_box.Name = "Title_box";
            this.Title_box.Size = new System.Drawing.Size(486, 20);
            this.Title_box.TabIndex = 3;
            this.Title_box.TextChanged += new System.EventHandler(this.Title_box_TextChanged);
            // 
            // Author_box
            // 
            this.Author_box.Location = new System.Drawing.Point(65, 102);
            this.Author_box.Margin = new System.Windows.Forms.Padding(2);
            this.Author_box.Name = "Author_box";
            this.Author_box.Size = new System.Drawing.Size(356, 20);
            this.Author_box.TabIndex = 4;
            // 
            // NewBook_btn
            // 
            this.NewBook_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewBook_btn.Location = new System.Drawing.Point(580, 63);
            this.NewBook_btn.Margin = new System.Windows.Forms.Padding(2);
            this.NewBook_btn.Name = "NewBook_btn";
            this.NewBook_btn.Size = new System.Drawing.Size(127, 29);
            this.NewBook_btn.TabIndex = 5;
            this.NewBook_btn.Text = "New Book";
            this.NewBook_btn.UseVisualStyleBackColor = false;
            this.NewBook_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save_btn.Location = new System.Drawing.Point(580, 97);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(127, 29);
            this.save_btn.TabIndex = 6;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel_btn.Location = new System.Drawing.Point(580, 131);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(127, 29);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 8;
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(65, 179);
            this.pricebox.Margin = new System.Windows.Forms.Padding(2);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(254, 20);
            this.pricebox.TabIndex = 9;
            // 
            // isbnLab
            // 
            this.isbnLab.AutoSize = true;
            this.isbnLab.Location = new System.Drawing.Point(6, 139);
            this.isbnLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbnLab.Name = "isbnLab";
            this.isbnLab.Size = new System.Drawing.Size(32, 13);
            this.isbnLab.TabIndex = 10;
            this.isbnLab.Text = "ISBN";
            // 
            // priceLab
            // 
            this.priceLab.AutoSize = true;
            this.priceLab.Location = new System.Drawing.Point(6, 181);
            this.priceLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceLab.Name = "priceLab";
            this.priceLab.Size = new System.Drawing.Size(31, 13);
            this.priceLab.TabIndex = 11;
            this.priceLab.Text = "Price";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(228, -23);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1, 4);
            this.listBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(65, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Text = "Edit an Existing Book";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // authr
            // 
            this.authr.AutoSize = true;
            this.authr.Location = new System.Drawing.Point(9, 108);
            this.authr.Name = "authr";
            this.authr.Size = new System.Drawing.Size(38, 13);
            this.authr.TabIndex = 15;
            this.authr.Text = "Author";
            // 
            // idthing
            // 
            this.idthing.Location = new System.Drawing.Point(607, 330);
            this.idthing.Name = "idthing";
            this.idthing.Size = new System.Drawing.Size(100, 20);
            this.idthing.TabIndex = 16;
            this.idthing.Visible = false;
            // 
            // Bookform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(716, 362);
            this.Controls.Add(this.idthing);
            this.Controls.Add(this.authr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.priceLab);
            this.Controls.Add(this.isbnLab);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.NewBook_btn);
            this.Controls.Add(this.Author_box);
            this.Controls.Add(this.Title_box);
            this.Controls.Add(this.titleLab);
            this.Controls.Add(this.Back_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bookform";
            this.Text = "Book keeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label titleLab;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox Title_box;
        private System.Windows.Forms.TextBox Author_box;
        private System.Windows.Forms.Button NewBook_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox pricebox;
        private System.Windows.Forms.Label isbnLab;
        private System.Windows.Forms.Label priceLab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label authr;
        private System.Windows.Forms.TextBox idthing;
    }
}

