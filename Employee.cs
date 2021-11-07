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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select E_ID as ID, E_Name as [First name], E_Address as Address, E_tel_no as[Telephone no], Salary as Salary, E_job_type as[Job Type] from Employees");
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmhome fm = new Frmhome();
            fm.Show();
            this.Close();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _srch = srchBox.Text;

            loadTable.DataSource = A.getData("select * from Employees where E_ID='" + _srch + "'  ");
        }

        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void intbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _num = numBox.Text;
            string _sal = salBox.Text;
            string _jt = jtcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _name != "" && _add != "" && _num != "" && _sal != "" && _jt != "" )
            {
                A.insertData("insert into Employees (E_ID ,E_Name ,E_Address ,E_tel_no ,Salary ,E_job_type ) values ('" + _id + "', '" + _name + "' , '" + _add + "' , '" + _num + "','" + _sal + "', '" + _jt + "' )");
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
            string _name = nameBox.Text;
            string _add = addBox.Text;
            string _num = numBox.Text;
            string _sal = salBox.Text;
            string _jt = jtcomboBox.Text;

            //validate data to update into table
            if (_id != "" && _name != "" && _add != "" && _num != "" && _sal != "" && _jt != "")
            {
                A.updateData("update Employees set  E_ID='" + _id + "', E_Name='" + _name + "', E_Address='" + _add + "',E_tel_no='" + _num + "', Salary='" + _sal + "', E_job_type='" + _jt + "' where E_ID='" + _id + "' ");
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
                A.deleteData("Delete Employees where E_ID='" + _id + "' ");
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
            nameBox.Text = "";
            addBox.Text = "";
            numBox.Text = "";
            salBox.Text = "";
            jtcomboBox.Text = "";
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
                nameBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                addBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                numBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                salBox.Text = loadTable.Rows[index].Cells[4].Value.ToString();
                jtcomboBox.Text = loadTable.Rows[index].Cells[5].Value.ToString();
            }
        }
    }
}
