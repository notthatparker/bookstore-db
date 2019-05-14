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


        string CS = "datasource=127.0.0.1;port=3306;username=root;password=;database=book";

        public Orders()
        {
            InitializeComponent();
        
            MySqlConnection Con = new MySqlConnection(CS);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM books", Con);
            MySqlConnection Con1 = new MySqlConnection(CS);
            MySqlCommand SelectCommand1 = new MySqlCommand("SELECT lastname, id FROM customer", Con);
            try
            {
                Con.Open();

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
                Con1.Open();

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
            foreach (string cs in LastName)
            {
                custbox.Items.Add(cs);

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
            const string message = "Are you sure you want to cancel the Order? ";
            const string caption = "Warning";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                foreach (TextBox textBox in Controls.OfType<TextBox>())
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
                const string message = "Please enter the book Title from the list";
                const string caption = "Warning";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {
                    this.ActiveControl = bookbox;
                }
                return;
            }

            int Qnt = 0;
            try
            {
                Qnt = int.Parse(quantbox.Text);
            }
            catch (Exception exception)
            {
                const string message = "Please enter the quantity of the books";
                const string caption = "Warning";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);

                //return;
            }

            string Title = bookbox.SelectedItem.ToString();
            string ISBN = isbnbox.Text.ToString();
            double Price = double.Parse(pricebox.Text.Substring(1));
            double Total_L = Qnt * Price;


            int n = dataGridView1.Rows.Add();   //adding data in DataGridView
            dataGridView1.Rows[n].Cells[0].Value = Title;
            dataGridView1.Rows[n].Cells[1].Value = "$" + Price;
            dataGridView1.Rows[n].Cells[2].Value = Qnt.ToString();
            dataGridView1.Rows[n].Cells[3].Value = "$" + Total_L.ToString();

            for (int i = 0; i < n; i++)
            {
                string temp = (string)dataGridView1.Rows[i].Cells[3].Value;
                temp = temp.Substring(1);
                Total_L += double.Parse(temp);
            }


            subbox.Text = Total_L.ToString();

            taxbox.Text = Total_L / 10 + "";
            totalbox.Text = (Total_L / 10 + Total_L) + "";



        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count != 1)
            {
                List<string> Lines = new List<string>();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    string temp = (string)dataGridView1.Rows[i].Cells[0].Value;
                    string temp1 = (string)dataGridView1.Rows[i].Cells[1].Value;
                    string temp2 = (string)dataGridView1.Rows[i].Cells[2].Value;
                    string temp3 = (string)dataGridView1.Rows[i].Cells[3].Value;
                    MySqlConnection connect = new MySqlConnection(CS);                 //inserts values in orders
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

                MySqlConnection Con = new MySqlConnection(CS);
                MySqlCommand InserCommand = new MySqlCommand("INSERT INTO orders (sub_total, tax, total, customer_id) " +
                                                             "VALUES ('" + subbox.Text.ToString() + "','" + taxbox.Text.ToString() + "','" + totalbox.Text.ToString() + "','" + int.Parse(custbox.Text) + "') ;", Con);
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

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                bookbox.Text = "";
                pricebox.Text = "";
                authrobox.Text = "";
                isbnbox.Text = "";
                subbox.Text = "";
                taxbox.Text = "";
                totalbox.Text = "";
                quantbox.Text = "";
            }
            else
            {
                const string message = "Please Select the Book";
                const string caption = "Warning";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }
    }
}