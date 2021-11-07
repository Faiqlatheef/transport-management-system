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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login log5 = new Login();
            log5.Show();
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
            string _bd = billdateTime.Text;
            string _pm = pmBox.Text;
            string _bc = bcBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _JID = JIDComBox.SelectedValue.ToString();
            string _TUID = TUIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();
            
            //validate data to insert into table
            if (_id != "" && _bd != "" && _pm != "" && _bc != "" && _CID != "" && _JID != "" && _TUID != "" && _PID != "")
            {
                A.insertData("insert into Bill (B_ID, B_Date ,Payment_Method, Bill_cash ,C_ID,J_ID ,TU_ID  ,P_ID ) values ('" + _id + "', '" + _bd + "' , '" + _pm + "','" + _bc + "', '" + _CID + "' , '" + _JID + "', '" + _TUID + "' , '" + _PID + "')");
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
            string _bd = billdateTime.Text;
            string _pm = pmBox.Text;
            string _bc = bcBox.Text;
            string _CID = CIDComBox.SelectedValue.ToString();
            string _JID = JIDComBox.SelectedValue.ToString();
            string _TUID = TUIDComBox.SelectedValue.ToString();
            string _PID = PIDComBox.SelectedValue.ToString();

            //validate data to update into table
            if (_id != "" && _bd != "" && _pm != "" && _bc != "" && _CID != "" && _JID != "" && _TUID != "" && _PID != "")
            {
                A.updateData("update Bill set  B_ID='" + _id + "', B_Date='" + _bd + "', Payment_Method='" + _pm + "',Bill_cash='" + _bc + "', C_ID='" + _CID + "', J_ID='" + _JID + "', TU_ID='" + _TUID + "', P_ID='" + _PID + "' where B_ID='" + _id + "' ");
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
                A.deleteData("Delete Bill where B_ID='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select B_ID as ID, B_Date as Date, Payment_Method as [Payment Method], Bill_cash as Cash, C_ID as[Customer ID], J_ID as [Job ID], TU_ID as[Transport Unit], P_ID as [Product ID] from Bill");
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label9.BackColor = System.Drawing.Color.Transparent;
            loadCustomerComboBoxFun();
            loadJobComboBoxFun();
            loadTransportUnitComboBoxFun();
            loadProductComboBoxFun();
            
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            billdateTime.Text = "";
            pmBox.Text = "";
            bcBox.Text = "";
            CIDComBox.SelectedValue = 0;
            JIDComBox.SelectedValue = 0;
            TUIDComBox.SelectedValue = 0;
            PIDComBox.SelectedValue = 0;
        }


        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
            
        }

        // get Product 
        private void loadProductComboBoxFun()
        {

            PIDComBox.DataSource = A.getData("select P_ID as ID, Pro_Type as [Product Type], P_Name as [Product Name], P_Quality as [Product Quality], P_Price as[Product Price], C_ID as [Customer ID], L_Id as[Load ID] from Product");
            PIDComBox.DisplayMember = "Product ID";
            PIDComBox.ValueMember = "ID";
        }

        // get Transport Unit 
        private void loadTransportUnitComboBoxFun()
        {

            TUIDComBox.DataSource = A.getData("select TU_ID as ID, V_ID as [Vehicle ID], E_ID as [Employee] from Transport_unit");
            TUIDComBox.DisplayMember = "TU ID";
            TUIDComBox.ValueMember = "ID";
        }

        // get Job 
        private void loadJobComboBoxFun()
        {

            JIDComBox.DataSource = A.getData("select J_id as ID, J_Date as [Job Date], Start_loc as [Start location], end_loc as [End location], CID as[Customer ID], P_ID as [Product ID], D_ID as[Depot ID], TU_ID as[TransportUnit ID] from Job");
            JIDComBox.DisplayMember = "Job ID";
            JIDComBox.ValueMember = "ID";
        }

        // get Customer 
        private void loadCustomerComboBoxFun()
        {

            CIDComBox.DataSource = A.getData("select C_ID as ID, C_Fname as [First name], C_Lname as [Last name], C_Address as Address, Tel_no as[Telephone no], C_NIC as NIC, C_Type as[Customer Type] from Customer");
            CIDComBox.DisplayMember = "Customer ID";
            CIDComBox.ValueMember = "ID";
        }

        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                billdateTime.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                pmBox.Text = loadTable.Rows[index].Cells[2].Value.ToString();
                bcBox.Text = loadTable.Rows[index].Cells[3].Value.ToString();
                CIDComBox.SelectedValue = loadTable.Rows[index].Cells[4].Value.ToString();
                JIDComBox.SelectedValue = loadTable.Rows[index].Cells[5].Value.ToString();
                TUIDComBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
                PIDComBox.SelectedValue = loadTable.Rows[index].Cells[7].Value.ToString();
            }
        }


        private void prntbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString( idBox.Text ,new Font("Arial",12,FontStyle.Bold), Brushes.Black, new Point(10,100) );
            e.Graphics.DrawString(billdateTime.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString(pmBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString(bcBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 130));
            e.Graphics.DrawString(CIDComBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString(JIDComBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString(TUIDComBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString(PIDComBox.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(10, 170));
        }

        private void changeDateformat()
        {
            A.convertDateTimeFormate(billdateTime);
        }

    }
}
