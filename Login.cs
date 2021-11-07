using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Smartmovers
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-59OJTCM;Initial Catalog=SMSSystem;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from eLogin where e_id = '" + textBox1.Text + "' and e_password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable(); //this is creating a virtual table 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                new Frmhome().Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackColor = System.Drawing.Color.Transparent;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ClearDatafun()
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }
        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
