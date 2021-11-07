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
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log4 = new Login();
            log4.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frmhome fm = new Frmhome();
            fm.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //this object is created for get common code for this application
        CommonClass A = new CommonClass();
        private void intbtn_Click(object sender, EventArgs e)
        {
            //get insert values from text box into variable
            string _id = idBox.Text;
            string _jd = jddateTime.Text;
            string _sl = slBox.Text;
            string _el = elBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _TUID = TUIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_id != "" && _jd != "" && _sl != "" && _el != "" && _CID != "" && _PID != "" && _DID != "" && _TUID != "")
            {
                A.insertData("insert into Job (J_id ,J_Date ,Start_loc ,end_loc ,CID , P_ID, D_ID, TU_ID ) values ('" + _id + "', '" + _jd + "' , '" + _sl + "' , '" + _el + "','" + _CID + "', '" + _PID + "','" + _DID + "', '" + _TUID + "'  )");
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
            string _jd = jddateTime.Text;
            string _sl = slBox.Text;
            string _el = elBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();
            string _DID = DIDComBox.SelectedValue.ToString();
            string _TUID = TUIDComBox.SelectedValue.ToString();

            //validate data to update into table
            if (_id != "" && _jd != "" && _sl != "" && _el != "" && _CID != "" && _PID != "" && _DID != "" && _TUID != "")
            {
                A.updateData("update Job set  J_id='" + _id + "', J_Date='" + _jd + "', Start_loc='" + _sl + "',end_loc='" + _el + "', CID='" + _CID + "', P_ID='" + _PID + "', D_ID='" + _DID + "', TU_ID='" + _TUID + "' where J_id='" + _id + "' ");
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
                A.deleteData("Delete Job where J_id='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select J_id as ID, J_Date as [Job Date], Start_loc as [Start location], end_loc as [End location], CID as[Customer ID], P_ID as [Product ID], D_ID as[Depot ID], TU_ID as[TransportUnit ID] from Job");
        }

        private void Job_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label9.BackColor = System.Drawing.Color.Transparent;
            loadCustomerComboBoxFun();
            loadProductComboBoxFun();
            loadDepotComboBoxFun();
            loadTransportUnitComboBoxFun();
        }

        // get Transport Unit 
        private void loadTransportUnitComboBoxFun()
        {

            TUIDComBox.DataSource = A.getData("select TU_ID as ID, V_ID as [Vehicle ID], E_ID as [Employee] from Transport_unit");
            TUIDComBox.DisplayMember = "TU ID";
            TUIDComBox.ValueMember = "ID";
        }

        // get Depot 
        private void loadDepotComboBoxFun()
        {

            DIDComBox.DataSource = A.getData("select D_ID as ID, D_Place as [Depot Place], TU_ID as [TranportUnit ID], Con_ID as [Container ID], V_ID as[Vehicle ID], T_ID as [Trailer ID], L_ID as[Load ID] from Depot");
            DIDComBox.DisplayMember = "Depot ID";
            DIDComBox.ValueMember = "ID";
        }

        // get Product 
        private void loadProductComboBoxFun()
        {

            PIDComBox.DataSource = A.getData("select P_ID as ID, Pro_Type as [Product Type], P_Name as [Product Name], P_Quality as [Product Quality], P_Price as[Product Price], C_ID as [Customer ID], L_Id as[Load ID] from Product");
            PIDComBox.DisplayMember = "Product ID";
            PIDComBox.ValueMember = "ID";
        }

        // get Customer 
        private void loadCustomerComboBoxFun()
        {

            CIDComBox.DataSource = A.getData("select C_ID as ID, C_Fname as [First name], C_Lname as [Last name], C_Address as Address, Tel_no as[Telephone no], C_NIC as NIC, C_Type as[Customer Type] from Customer");
            CIDComBox.DisplayMember = "Customer ID";
            CIDComBox.ValueMember = "ID";
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            jddateTime.Text = "";
            slBox.Text = "";
            elBox.Text = "";
            CIDComBox.SelectedValue = 0;
            PIDComBox.SelectedValue = 0;
            DIDComBox.SelectedValue = 0;
            TUIDComBox.SelectedValue = 0;
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
                jddateTime.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                slBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                elBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                CIDComBox.SelectedValue = loadTable.Rows[index].Cells[4].Value.ToString();
                PIDComBox.SelectedValue = loadTable.Rows[index].Cells[5].Value.ToString();
                DIDComBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
                TUIDComBox.SelectedValue = loadTable.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void changeDateformat()
        {
            A.convertDateTimeFormate(jddateTime);
        }
    }
}
