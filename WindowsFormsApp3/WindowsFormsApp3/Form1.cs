using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp3
{
    public partial class Bookform : Form
    {
        ArrayList Title = new ArrayList();
        ArrayList Author = new ArrayList();
        ArrayList ISBN = new ArrayList();
        ArrayList Price = new ArrayList();
        ArrayList id = new ArrayList();

        int save = 0;
        string CS = "datasource=127.0.0.1;port=3306;username=root;password=;database=book";

        public Bookform()
        {
            InitializeComponent();
            MySqlConnection Con = new MySqlConnection(CS);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM books", Con);
            invinsibletb.Visible = false;

            try
            {
                Con.Open();

                using (MySqlDataReader myReader = SelectCommand.ExecuteReader())
                {

                    while (myReader.Read())
                    {
                        Author.Add(myReader.GetString("author"));
                        ISBN.Add(myReader.GetString("isbn"));
                        Price.Add(myReader.GetString("price"));
                        Title.Add(myReader.GetString("title"));
                        id.Add(myReader.GetString("id"));
                        drop2.Items.Add(myReader.GetString("title"));

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            Title_box.Text = null;
            textBox1.Text = null;
            Author_box.Text = null;
            textBox2.Text = null;
            save = 1;
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            //goes back to the menu form 
            this.Hide();
            formMenu menush = new formMenu();

            menush.Show();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult Check = MessageBox.Show("Can you confirm your cancelation?", "Cancelation", MessageBoxButtons.YesNo);
            if (Check == DialogResult.Yes)
            {
                int id = int.Parse(invinsibletb.Text) - 1;

                foreach (TextBox textBox in Controls.OfType<TextBox>())
                    textBox.Text = "";

            }

            else if (Check == DialogResult.No)
            {
                return;
            }

            const string alertmessage = "Good Luck";//because nothing was ever found 
                const string titletext = "Hello We canceled it";

                var messageboxer = MessageBox.Show(titletext, alertmessage, MessageBoxButtons.OKCancel);


         

        }

        private void Title_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < id.Count; i++)
            {
                if (comboBox1.SelectedIndex == i)
                {

                    Title_box.Text = Title[i].ToString();
                    textBox1.Text = ISBN[i].ToString();
                    Author_box.Text = Author[i].ToString();
                    textBox2.Text = Price[i].ToString();
                    invinsibletb.Text = id[i].ToString();
                }
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (save == 1)
            {

                if (Author_box.Text == "" || Title_box.Text == "" || textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("incorrect input");
                else
                {

                    string title = Title_box.Text;
                    string author = Author_box.Text;
                    string isbn = textBox1.Text;
                    //string Id = invinsibletb.Text;
                    string price = pricetb.Text;
                    MySqlConnection Con = new MySqlConnection(CS);
                    MySqlCommand InserCommand = new MySqlCommand("INSERT INTO books (title, author, isbn, price) VALUES ('" + title + "','" + author + "','" + isbn + "','" + price + "');", Con);
                    MySqlDataReader MyReader;
                    try
                    {
                        Con.Open();
                        MyReader = InserCommand.ExecuteReader();
                        while (MyReader.Read())
                        {
                        }
                        MessageBox.Show("You action has been saved!");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    Author.Add(author);
                    Title.Add(title);
                    ISBN.Add(isbn);
                    Price.Add(price);
                    Title_box.Text = null;
                    Author_box.Text = null;
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
            }
            else
            {

                int ind = int.Parse(invinsibletb.Text) - 1;


                if (Author_box.Text == Author[ind].ToString() && Title_box.Text == Title[ind].ToString() && textBox1.Text == ISBN[ind].ToString() && textBox2.Text == Price[ind].ToString()) MessageBox.Show("not updated");




                else
                {
                    MySqlConnection Con = new MySqlConnection(CS);


                    MySqlCommand UpdateCommand = new MySqlCommand("UPDATE books SET title = '" + titletb.Text.ToString() + "', author = '" + authortb.Text.ToString() + "', isbn = '" + isbntb.Text.ToString() + "', price = '" + pricetb.Text.ToString() + "' where id = '" + invinsibletb.Text + "' ; ", Con);
                    MySqlDataReader myReader;

                    try
                    {
                        Con.Open();
                        myReader = UpdateCommand.ExecuteReader();


                        MessageBox.Show("Your actions have been saved!");
                        while (myReader.Read())
                        {

                        }


                        Title[ind] = Title_box.Text;
                        Author[ind] = Author_box.Text;
                        ISBN[ind] = textBox1.Text;
                        Price[ind] = textBox2.Text;
                        Title_box.Text = null;
                        Author_box.Text = null;
                        textBox1.Text = null;
                        textBox2.Text = null;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }



                }
            }
        }
    }
}
