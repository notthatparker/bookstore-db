using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Orders : Form
    {
        List<Book> BookShop = new List<Book>();
        ArrayList LastName = new ArrayList();
        ArrayList customer_id_list = new ArrayList();


        string datara = "datasource=127.0.0.1;port=3306;username=root;password=;database=book";

        public Orders()
        {
            InitializeComponent();
        
            MySqlConnection network = new MySqlConnection(datara);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM books", network);
            MySqlConnection dataaris = new MySqlConnection(datara);
            MySqlCommand SelectCommand1 = new MySqlCommand("SELECT lastname, id FROM customer", network);
            try
            {
                network.Open();

                using (MySqlDataReader myReader = SelectCommand.ExecuteReader())
                {

                    while (myReader.Read())
                    {

                        BookShop.Add(new Book(int.Parse(myReader.GetString("id")), myReader.GetString("author"), myReader.GetString("isbn"), myReader.GetString("price"), myReader.GetString("title")));


                    }
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                dataaris.Open();

                using (MySqlDataReader myReader1 = SelectCommand1.ExecuteReader())
                {

                    while (myReader1.Read())
                    {
                        LastName.Add(myReader1.GetString("lastname"));
                        customer_id_list.Add(myReader1.GetString("id"));


                    }
                }



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



            foreach (Book bk in BookShop)
            {
                bookbox.Items.Add(bk.Title);
                //addimg titles to combobox
            }
            foreach (string da_ta in LastName)
            {
                custbox.Items.Add(da_ta);

                //addimg titles to combobox
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void backbtn_1_Click(object sender, EventArgs e)
        {
            //goes back to the menu form 
            this.Hide();
            formMenu menush = new formMenu();

            menush.Show();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            const string caption = "STOP STOP";
            const string message = "Hey are u really sure? ";
          
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {  foreach (TextBox textBox in Controls.OfType<TextBox>())
               textBox.Text = "";
            }
            return;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void custbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookbox_SelectedIndexChanged(object sender, EventArgs e)
        {


            for (int i = 0; i < BookShop.Count; i++)
            {
                if (bookbox.SelectedIndex == i)
                {


                    isbnbox.Text = BookShop[i].ISBN.ToString();
                    authrobox.Text = BookShop[i].Author.ToString();
                    pricebox.Text = BookShop[i].Price.ToString();
                    custbox.Text = customer_id_list[i].ToString();
                    bookbox.Text = BookShop[i].id.ToString();

                }
            }
        }

        public class Book
        {
            public string Author;
            public string ISBN;
            public string Price;
            public string Title;
            public int id;



            public Book(int id, string Author, string ISBN, string Price, string Title)
            {
                this.id = id;
                this.Author = Author;
                this.ISBN = ISBN;
                this.Price = Price;
                this.Title = Title;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (bookbox.SelectedItem == null)
            {
                const string message = "Enter The title from the combobox please";
                const string caption = "Stop Alert Warning ";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    this.ActiveControl = bookbox;
                }
                return;
            }

            int raodenobara = 0;
            try
            {
                raodenobara = int.Parse(quantbox.Text);
            }
            catch (Exception exception)
            {
                const string caption = "Alert ";

                const string message = "Dont forget the quantity please";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);

                //return;
            }

            string saxeli = bookbox.SelectedItem.ToString();
            string wignicodi = isbnbox.Text.ToString();
            double fasi = double.Parse(pricebox.Text.Substring(1));
            double linetotal = raodenobara * fasi;


            int count = listcol.Rows.Add();   
            listcol.Rows[count].Cells[0].Value = saxeli;
            listcol.Rows[count].Cells[1].Value = "$" + fasi;
            listcol.Rows[count].Cells[2].Value = raodenobara.ToString();
            listcol.Rows[count].Cells[3].Value = "$" + linetotal.ToString();
            //so we added some data 
            for (int i = 0; i < count; i++)
            {
                string temp = (string)listcol.Rows[i].Cells[3].Value;
                temp = temp.Substring(1);
                linetotal += double.Parse(temp);
            }


            subtotalbx.Text = linetotal.ToString();

            taxbox.Text = linetotal / 10 + "";
            totalbox.Text = (linetotal / 10 + linetotal) + "";



        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {

            if (listcol.Rows.Count != 1)
            {
                List<string> lister = new List<string>();
                for (int i = 0; i < listcol.Rows.Count - 1; i++)
                {
                    string temp = (string)listcol.Rows[i].Cells[0].Value;
                    string temp1 = (string)listcol.Rows[i].Cells[1].Value;
                    string temp2 = (string)listcol.Rows[i].Cells[2].Value;
                    string temp3 = (string)listcol.Rows[i].Cells[3].Value;
                    MySqlConnection connect = new MySqlConnection(datara);                 //inserts values in orders
                    MySqlCommand command = new MySqlCommand("insert into orderdetails(order_id, book_id, quantity_of_books, lines_total) VALUES ((Select (Max(order_id)+1) as Max from orders),'" + int.Parse(book_id.Text) + "' ,'" + temp2.ToString() + "','" + temp3.ToString() + "' );", connect);
                    MySqlDataReader Reader;
                    try
                    {
                        connect.Open();
                        Reader = command.ExecuteReader();
                        while (Reader.Read()) { }


                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    connect.Close();
                }

                MySqlConnection Con = new MySqlConnection(datara);
                MySqlCommand InserCommand = new MySqlCommand("INSERT INTO orders (sub_total, tax, total, customer_id) " +
                                                             "VALUES ('" + subtotalbx.Text.ToString() + "','" + taxbox.Text.ToString() + "','" + totalbox.Text.ToString() + "','" + int.Parse(custbox.Text) + "') ;", Con);
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

                const string message = "Your Order has been confirmed";
                const string caption = "Warning";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                listcol.Rows.Clear();
                listcol.Refresh();
                bookbox.Text = "";
                pricebox.Text = "";
                authrobox.Text = "";
                isbnbox.Text = "";
                subtotalbx.Text = "";
                taxbox.Text = "";
                totalbox.Text = "";
                quantbox.Text = "";
            }
            else
            {
                const string caption = "Alert";
                const string message = "Choosea  book";
               
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
            }
        }
    }
}