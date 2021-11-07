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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log3 = new Login();
            log3.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmhome fm = new Frmhome();
            fm.Show();
            this.Close();
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select P_ID as ID, Pro_Type as [Product Type], P_Name as [Product Name], P_Quality as [Product Quality], P_Price as[Product Price], C_ID as [Customer ID], L_Id as[Load ID] from Product");
        }


        private void Product_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label8.BackColor = System.Drawing.Color.Transparent;
            loadCustomerComboBoxFun();
            loadLoadComboBoxFun();
        }

        // get Load 
        private void loadLoadComboBoxFun()
        {

            LIDComBox.DataSource = A.getData("select L_ID as ID, L_type as [Load type] from Loadtbl");
            LIDComBox.DisplayMember = "Load ID";
            LIDComBox.ValueMember = "ID";
        }

        // get Customer 
        private void loadCustomerComboBoxFun()
        {

            CIDComBox.DataSource = A.getData("select C_ID as ID, C_Fname as [First name], C_Lname as [Last name], C_Address as Address, Tel_no as[Telephone no], C_NIC as NIC, C_Type as[Customer Type] from Customer");
            CIDComBox.DisplayMember = "Customer ID";
            CIDComBox.ValueMember = "ID";
        }

        private void ptcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void intbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _pt = ptcomboBox.Text;
            string _name = nameBox.Text;
            string _pq = pqBox.Text;
            string _pp = ppBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _LID = LIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_id != "" && _pt != "" && _name != "" && _pq != "" && _pp != "" && _CID != "" && _LID != "")
            {
                A.insertData("insert into Product (P_ID, Pro_Type ,P_Name , P_Quality ,P_Price ,C_ID ,L_Id ) values ('" + _id + "', '" + _pt + "' , '" + _name + "' , '" + _pq + "','" + _pp + "', '" + _CID + "', '" + _LID + "' )");
                loadTableFun();
                ClearDatafun();
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
            string _pt = ptcomboBox.Text;
            string _name = nameBox.Text;
            string _pq = pqBox.Text;
            string _pp = ppBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _LID = LIDComBox.SelectedValue.ToString();

            //validate data to update into table
            if (_id != "" && _pt != "" && _name != "" && _pq != "" && _pp != "" && _CID != "" && _LID != "")
            {
                A.updateData("update Product set  P_ID='" + _id + "', Pro_Type='" + _pt + "', P_Name='" + _name + "',P_Quality='" + _pq + "', P_Price='" + _pp + "', C_ID='" + _CID + "', L_ID='" + _LID + "' ");
                loadTableFun();
                ClearDatafun();
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
                A.deleteData("Delete Product where P_ID='" + _id + "' ");
                loadTableFun();
                ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            ptcomboBox.Text = "";
            nameBox.Text = "";
            pqBox.Text = "";
            ppBox.Text = "";
            CIDComBox.SelectedValue = 0;
            LIDComBox.SelectedValue = 0;
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
                ptcomboBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                nameBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                pqBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                ppBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                CIDComBox.SelectedValue = loadTable.Rows[index].Cells[5].Value.ToString();
                LIDComBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
            }
        }
    }
}
