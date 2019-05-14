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
        ArrayList satauri = new ArrayList();
        ArrayList avtori = new ArrayList();
        ArrayList codiwign = new ArrayList();
        ArrayList fasi = new ArrayList();
        ArrayList id = new ArrayList();

        int save = 0;
        string library = "datasource=127.0.0.1;port=3306;username=root;password=;database=book";

        public Bookform()
        {
            InitializeComponent();
            MySqlConnection Con = new MySqlConnection(library);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM books", Con);
            idthing.Visible = false;

            try
            {
                Con.Open();

                using (MySqlDataReader myReader = SelectCommand.ExecuteReader())
                {

                    while (myReader.Read())
                    {
                        Author.Add(myReader.GetString("author"));
                        codiwign.Add(myReader.GetString("isbn"));
                        fasi.Add(myReader.GetString("price"));
                        satauri.Add(myReader.GetString("title"));
                        id.Add(myReader.GetString("id"));
                        comboBox1.Items.Add(myReader.GetString("title"));

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
            sataurisbbox.Text = null;
            box1.Text = null;
            Author_box.Text = null;
            pricebox.Text = null;
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
                int id = int.Parse(idthing.Text) - 1;

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

                    sataurisbbox.Text = satauri[i].ToString();
                    box1.Text = codiwign[i].ToString();
                    Author_box.Text = avtori[i].ToString();
                    pricebox.Text = fasi[i].ToString();
                    idthing.Text = id[i].ToString();
                }
            }

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (save == 1)
            {

                if ((Author_box.Text == "") ||( sataurisbbox.Text == "") || (box1.Text == "") ||( pricebox.Text == ""))
                    MessageBox.Show("Dear sadly u havent inputed anything *_*");
                else
                {    string title = sataurisbbox.Text;
                    string author = Author_box.Text;
                    string isbn = box1.Text;
                    //string Id = invinsibletb.Text;
                    string price = pricebox.Text;
                    MySqlConnection Con = new MySqlConnection(library);
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
                    avtori.Add(author);
                    satauri.Add(title);
                    codiwign.Add(isbn);
                    fasi.Add(price);
                    sataurisbbox.Text = null;
                    Author_box.Text = null;
                    box1.Text = null;
                    pricebox.Text = null;
                }
            }
            else
            {   int ind = int.Parse(idthing.Text) - 1;
                if (Author_box.Text == avtori[ind].ToString() && sataurisbbox.Text == satauri[ind].ToString() && box1.Text == codiwign[ind].ToString() && pricebox.Text == fasi[ind].ToString()) MessageBox.Show("not updated");
                else
                {
                    MySqlConnection network = new MySqlConnection(library);
                    MySqlCommand change = new MySqlCommand("UPDATE books SET title = '" + titletb.Text.ToString() + "', author = '" + authortb.Text.ToString() + "', isbn = '" + isbntb.Text.ToString() + "', price = '" + pricetb.Text.ToString() + "' where id = '" + idthing.Text + "' ; ", network);
                    MySqlDataReader waverider;
                    try
                    {  network.Open();
                        waverider = change.ExecuteReader();
                    

                        MessageBox.Show("Dear user it was a success");
                        while (waverider.Read())
                        {

                        }


                        satauri[ind] = sataurisbbox.Text;
                        avtori[ind] = Author_box.Text;
                        codiwign[ind] = box1.Text;
                        fasi[ind] = pricebox.Text;
                        sataurisbbox.Text = null;
                        Author_box.Text = null;
                        box1.Text = null;
                        pricebox.Text = null;
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }



                }
            }
        }
    }
}
