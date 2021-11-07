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
    public partial class Transportunit : Form
    {
        public Transportunit()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmhome fm = new Frmhome();
            fm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log5 = new Login();
            log5.Show();
            this.Close();
        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void intbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _VID = VIDComBox.SelectedValue.ToString();
            string _EID = EIDComBox.SelectedValue.ToString();
            
            //validate data to insert into table
            if (_id != "" && _VID != "" && _EID != "")
            {
                A.insertData("insert into Transport_unit (TU_ID , V_ID, E_ID )  values ('" + _id + "', '" + _VID + "', '" + _EID + "' )");
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
            string _VID = VIDComBox.SelectedValue.ToString();
            string _EID = EIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_id != "" && _VID != "" && _EID != "")
            {
                A.updateData("update Transport_unit set  TU_ID='" + _id + "', V_ID='" + _VID + "', E_ID='" + _EID + "' where TU_ID='" + _id + "' ");
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
                A.deleteData("Delete Transport_unit where TU_ID='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select TU_ID as ID, V_ID as [Vehicle ID], E_ID as [Employee] from Transport_unit");
        }
        
        private void Transportunit_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label4.BackColor = System.Drawing.Color.Transparent;
            loadVehicleComboBoxFun();
            loadEmployeesComboBoxFun();
        }

        // get Employees 
        private void loadEmployeesComboBoxFun()
        {

            VIDComBox.DataSource = A.getData("select E_ID as ID, E_Name as [First name], E_Address as Address, E_tel_no as[Telephone no], Salary as Salary, E_job_type as[Job Type] from Employees");
            VIDComBox.DisplayMember = "Employee ID";
            VIDComBox.ValueMember = "ID";
        }

        // get Vehicle 
        private void loadVehicleComboBoxFun()
        {

            VIDComBox.DataSource = A.getData("select V_ID as ID, V_no as [Vehicle no], V_Name as [Vehicle name] from Vehicle");
            VIDComBox.DisplayMember = "Vehicle ID";
            VIDComBox.ValueMember = "ID";
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            VIDComBox.SelectedValue = 0;
            EIDComBox.SelectedValue = 0;
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
                VIDComBox.SelectedValue = loadTable.Rows[index].Cells[1].Value.ToString();
                EIDComBox.SelectedValue = loadTable.Rows[index].Cells[2].Value.ToString();

            }
        }
    }
}
