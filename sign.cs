using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace hanuman
{
    public partial class sign : Form
    {
        public sign()
        {
            InitializeComponent();
        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string userpsw = textBox2.Text;
            MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=vetapp");
            MySqlDataAdapter sda = new MySqlDataAdapter("select count(*) from userinfo where username='" + textBox1.Text + "' and userpsw = '" + textBox2.Text + "' ", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "0")
            {
                //MessageBox.Show("aferin","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("insert into userinfo(username,userpsw) values('" + textBox1.Text + "','" + textBox2.Text + "')", connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ekleme başarılı");
                connection.Close();
            }
            else
            {
                MessageBox.Show("hatalısın", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
