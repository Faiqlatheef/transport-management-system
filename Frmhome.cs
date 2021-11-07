using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smartmovers
{
    public partial class Frmhome : Form
    {
        public Frmhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Depot dep = new Depot();
            dep.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Job job = new Job();
            job.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vehicle veh = new Vehicle();
            veh.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log8 = new Login();
            log8.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Container cont = new Container();
            cont.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Load lo = new Load();
            lo.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            trailer tr = new trailer();
            tr.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Transportunit tu = new Transportunit();
            tu.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Loginfrm lf = new Loginfrm();
            lf.Show();
            this.Hide();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            cus.Show();
            this.Hide();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Show();
            this.Hide();
        }
    }
}
