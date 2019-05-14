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
   

    public partial class Customers : Form
    {
        ArrayList LastName = new ArrayList();
        ArrayList FirstName = new ArrayList();
        ArrayList Address = new ArrayList();
        ArrayList City = new ArrayList();
        ArrayList States = new ArrayList();
        ArrayList Zip = new ArrayList();
        ArrayList Phone = new ArrayList();
        ArrayList Email = new ArrayList();
        ArrayList Id = new ArrayList();
        int save = 0;
        string CS = "datasource=127.0.0.1;port=3306;username=root;password=;database=book";

        public Customers()
        {
            InitializeComponent();

            Reset_increment();
            MySqlConnection Con = new MySqlConnection(CS);
            MySqlCommand SelectCommand = new MySqlCommand("SELECT * FROM customer", Con);
            idthing.Visible = false;
            try
            {
                Con.Open();

                using (MySqlDataReader myReader = SelectCommand.ExecuteReader())
                {

                    while (myReader.Read())
                    {

                        LastName.Add(myReader.GetString("lastname"));
                        FirstName.Add(myReader.GetString("firstname"));
                        Address.Add(myReader.GetString("address"));
                        City.Add(myReader.GetString("city"));
                        States.Add(myReader.GetString("states"));
                        Zip.Add(myReader.GetString("zip"));
                        Phone.Add(myReader.GetString("phone"));
                        Email.Add(myReader.GetString("email"));
                        Id.Add(myReader.GetString("id"));
                        comboBox1.Items.Add(myReader.GetString("lastname"));

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }



        private void Reset_increment()
        {
            string sql1 = "ALTER TABLE `customer` AUTO_INCREMENT = 1";
            MySqlConnection Conn = new MySqlConnection(CS);
            MySqlCommand Data = new MySqlCommand(sql1, Conn);
            MySqlDataReader myReader5;
            try
            {
                Conn.Open();
                myReader5 = Data.ExecuteReader();                                                 //in case the row is deleted, this piece of code resets auto increment, so the index is calculated correctly later



                while (myReader5.Read())
                {
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            Conn.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Id.Count; i++)
            {
                if (comboBox1.SelectedIndex == i)
                {

                    first_namebox.Text = FirstName[i].ToString();
                    last_namebox.Text = LastName[i].ToString();
                    address_box.Text = Address[i].ToString();
                    city_box.Text = City[i].ToString();
                    state_box.Text = States[i].ToString();
                    zip_box.Text = Zip[i].ToString();
                    phone_box.Text = Phone[i].ToString();
                    email_box.Text = Email[i].ToString();

                }


            }

        }

        private void isbnLab_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {   //goes back to the menu form 
            this.Hide();
            formMenu menush = new formMenu();

            menush.Show();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {


            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";


            const string alerttext = "done";//because nothing was ever found 
            const string titler = "iTS DONE ITS DESTROYED";

            var messageboxer = MessageBox.Show(titler, alerttext, MessageBoxButtons.OKCancel);





        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void NewCust_btn_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            last_namebox.Text = null;
            first_namebox.Text = null;
            address_box.Text = null;
            city_box.Text = null;
            state_box.Text = null;
            zip_box.Text = null;
            phone_box.Text = null;
            email_box.Text = null;

            save = 1;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (save == 1)
            {
                Reset_increment();
                if (last_namebox.Text == null || first_namebox.Text == null || address_box.Text == null
                    || city_box.Text == null || state_box.Text == null || zip_box.Text == null || phone_box.Text == null
                    || email_box.Text == null
                    )
                    MessageBox.Show("Fill the text boxes!");


                else
                {
                    string lastname = last_namebox.Text;
                    string firstname = first_namebox.Text;
                    string address = address_box.Text;
                    string city = city_box.Text;
                    string states = state_box.Text;
                    string zip = zip_box.Text;
                    string phone = phone_box.Text;
                    string mail = email_box.Text;
                  //  string id = invinsibletb.Text;

                    MySqlConnection Con = new MySqlConnection(CS);
                    MySqlCommand InserCommand = new MySqlCommand("INSERT INTO customer (lastname, firstname, address,city, states, zip, phone, email ) VALUES ('" + lastname + "','" + firstname + "','" + address + "','" + city + "','" + states + "','" + zip + "','" + phone + "','" + mail + "');", Con);
                    MySqlDataReader parser;
                    try
                    {
                        Con.Open();
                        parser = InserCommand.ExecuteReader();
                        while (parser.Read())
                        {
                        }
                        MessageBox.Show("You action has been saved!");


                        LastName.Add(lastname);
                        FirstName.Add(firstname);
                        Address.Add(address);
                        City.Add(city);
                        States.Add(states);
                        Zip.Add(zip);
                        Phone.Add(phone);
                        Email.Add(mail);
                        Id.Add(id);
                        last_namebox.Text = null;
                        first_namebox.Text = null;
                        address_box.Text = null;
                        city_box.Text = null;
                        state_box.Text = null;
                        phone_box.Text = null;
                        zip_box.Text = null;
                        email_box.Text = null;
                        DialogResult dialogResult = MessageBox.Show("Hey Are u totally sure about this ?", "KEEP", MessageBoxButtons.YesNoCancel);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("SO ITS SAFE AND SOUND ^_^");

                        }

                        else if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
                        {
                            return;
                        }
                        while (parser.Read())
                        {
                        }





                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }


                }
            }
            else
            {

                int ind = int.Parse(idthing.Text) - 1;
                MessageBox.Show(ind.ToString());
                if (
                    first_namebox.Text == FirstName[int.Parse(idthing.Text)].ToString()
                     && last_namebox.Text == FirstName[int.Parse(idthing.Text)].ToString()
                     && address_box.Text == Address[int.Parse(idthing.Text)].ToString()
                     && city_box.Text == City[int.Parse(idthing.Text)].ToString()
                     && state_box.Text == States[int.Parse(idthing.Text)].ToString()
                     && zip_box.Text == Zip[int.Parse(idthing.Text)].ToString()
                     && phone_box.Text == Phone[int.Parse(idthing.Text)].ToString()
                     && email_box.Text == Email[int.Parse(idthing.Text)].ToString()
                   )

                    MessageBox.Show("Let Me Check ...Yea no update sorry");

                else
                {
                    MySqlConnection Con = new MySqlConnection(CS);


                    MySqlCommand UpdateCommand = new MySqlCommand("UPDATE customer SET firstname='" + firstnametb.Text.ToString() + "', lastname='" + lastnametb.Text.ToString() + "', address='" + addresstb.Text.ToString() + "', city='" + citytb.Text.ToString() + "', states ='" + statestb.Text.ToString() + "', zip='" + ziptb.Text.ToString() + "', phone ='" + phonetb.Text.ToString() + "', email='" + mailtb.Text.ToString() + "' where id= '" + idthing.Text + "' ;", Con);
                    MySqlDataReader myReader;
                    try
                    {
                        Con.Open();
                        myReader = UpdateCommand.ExecuteReader();


                        MessageBox.Show("ITs SAfe IN SOUND");
                        while (myReader.Read())
                        {


                        }



                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    Con.Close();
                    FirstName[ind] = first_namebox.Text;
                    LastName[ind] = last_namebox.Text;
                    Address[ind] = address_box.Text;
                    City[ind] = city_box.Text;
                    States[ind] = state_box.Text;
                    Zip[ind] = zip_box.Text;
                    Phone[ind] = phone_box.Text;
                    Email[ind] = email_box.Text;
                    last_namebox.Text = null;
                    first_namebox.Text = null;
                    address_box.Text = null;
                    city_box.Text = null;
                    state_box.Text = null;
                    phone_box.Text = null;
                    zip_box.Text = null;
                    email_box.Text = null;
                }
            }
        }
    }
}
