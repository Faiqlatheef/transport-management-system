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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log7 = new Login();
            log7.Show();
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
            string _num = numBox.Text;
            string _name = nameBox.Text;

            //validate data to insert into table
            if (_id != "" && _num != "" && _name != "")
            {
                A.insertData("insert into Vehicle (V_ID , V_no , V_Name )  values ('" + _id + "', '" + _num + "', '" + _name + "' )");
                loadTableFun();
                ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void uptbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _num = numBox.Text;
            string _name = nameBox.Text;

            //validate data to insert into table
            if (_id != "" && _num != "" && _name != "")
            {
                A.updateData("update Vehicle set  V_ID='" + _id + "', V_no='" + _num + "', V_Name='" + _name + "' where V_ID='" + _id + "' ");
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
                A.deleteData("Delete Vehicle where V_ID='" + _id + "' ");
                loadTableFun();
                ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select V_ID as ID, V_no as [Vehicle no], V_Name as [Vehicle name] from Vehicle");
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            numBox.Text = "";
            nameBox.Text = "";
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
                numBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                nameBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();

            }
        }
    }
}
