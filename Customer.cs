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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log2 = new Login();
            log2.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmhome fm = new Frmhome();
            fm.Show();
            this.Close();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void intbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _fn = fnBox.Text;
            string _ln = lnBox.Text;
            string _add = addBox.Text;
            string _num = numBox.Text;
            string _nic = nicBox.Text;
            string _ct = ctcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _fn != "" && _ln != "" && _add != "" && _num != "" && _nic != "" && _ct != "" )
            {
                A.insertData("insert into Customer  (C_ID, C_Fname  ,C_Lname , C_Address  ,Tel_no ,C_NIC  ,C_Type ) values ('" + _id + "', '" + _fn + "' , '" + _ln + "','" + _add + "', '" + _num + "' , '" + _nic + "', '" + _ct + "' )");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _fn = fnBox.Text;
            string _ln = lnBox.Text;
            string _add = addBox.Text;
            string _num = numBox.Text;
            string _nic = nicBox.Text;
            string _ct = ctcomboBox.Text;

            //validate data to update into table
            if (_id != "" && _fn != "" && _ln != "" && _add != "" && _num != "" && _nic != "" && _ct != "")
            {
                A.updateData("update Customer set  C_ID='" + _id + "', C_Fname='" + _fn + "', C_Lname='" + _ln + "',C_Address='" + _add + "', Tel_no='" + _num + "', C_NIC='" + _nic + "', C_Type='" + _ct + "' where C_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void dltbtn_Click(object sender, EventArgs e)
        {
            string _id = idBox.Text;

            //validate data to delete into table
            if (_id != "")
            {
                A.deleteData("Delete Customer where C_ID='" + _id + "' ");
                loadTableFun();
                this.ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select C_ID as ID, C_Fname as [First name], C_Lname as [Last name], C_Address as Address, Tel_no as[Telephone no], C_NIC as NIC, C_Type as[Customer Type] from Customer");
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label8.BackColor = System.Drawing.Color.Transparent;
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            fnBox.Text = "";
            lnBox.Text = "";
            addBox.Text = "";
            numBox.Text = "";
            nicBox.Text = "";
            ctcomboBox.Text = "";
        }


        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearDatafun();
        }

        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                fnBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                lnBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                addBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                numBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                nicBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
                ctcomboBox.Text = loadTable.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void srchbtn_Click(object sender, EventArgs e)
        {
             string _srch = srchBox.Text;

             loadTable.DataSource = A.getData("select * from Customer where C_ID='" + _srch + "'  ");
        }
    }
}
