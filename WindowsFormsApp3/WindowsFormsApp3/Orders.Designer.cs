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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // backbtn_1
            // 
            this.backbtn_1.Location = new System.Drawing.Point(644, 26);
            this.backbtn_1.Name = "backbtn_1";
            this.backbtn_1.Size = new System.Drawing.Size(120, 48);
            this.backbtn_1.TabIndex = 0;
            this.backbtn_1.Text = "BACK";
            this.backbtn_1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(644, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(43, 52);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(255, 22);
            this.idbox.TabIndex = 3;
            this.idbox.Text = "Enter Customer id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "order id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 22);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "sub total";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(255, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "tax";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "tax";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.backbtn_1);
            this.Name = "Orders";
            this.Text = "v ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbtn_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
    }
}