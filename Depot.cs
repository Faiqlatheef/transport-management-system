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
    public partial class Depot : Form
    {
        public Depot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log6 = new Login();
            log6.Show();
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
            string _dp = dpBox.Text;
            string _TUID = TUIDComBox.SelectedValue.ToString();
            string _ConID = ConIDComBox.SelectedValue.ToString();
            string _VID = VIDComBox.SelectedValue.ToString();
            string _TrID = TrIDComBox.SelectedValue.ToString();
            string _LID = LIDComBox.SelectedValue.ToString();

            //validate data to insert into table
            if (_id != "" && _dp != "" && _TUID != "" && _ConID != "" && _VID != "" && _TrID != "" && _LID != "")
            {
                A.insertData("insert into Depot (D_ID, D_Place  ,TU_ID , Con_ID ,V_ID ,T_ID ,L_ID ) values ('" + _id + "', '" + _dp + "' , '" + _TUID + "' , '" + _ConID + "','" + _VID + "', '" + _TrID + "', '" + _LID + "' )");
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
            string _dp = dpBox.Text;
            string _TUID = TUIDComBox.SelectedValue.ToString();
            string _ConID = ConIDComBox.SelectedValue.ToString();
            string _VID = VIDComBox.SelectedValue.ToString();
            string _TrID = TrIDComBox.SelectedValue.ToString();
            string _LID = LIDComBox.SelectedValue.ToString();

            //validate data to update into table
            if (_id != "" && _dp != "" && _TUID != "" && _ConID != "" && _VID != "" && _TrID != "" && _LID != "")
            {
                A.updateData("update Depot set  D_ID='" + _id + "', D_Place='" + _dp + "', TU_ID='" + _TUID + "',Con_ID='" + _ConID + "', V_ID='" + _VID + "', T_ID='" + _TrID + "', L_ID='" + _LID + "' where D_ID='" + _id + "' ");
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
                A.deleteData("Delete Depot where D_ID='" + _id + "' ");
                loadTableFun();
                ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            ClearDatafun();
        }

        // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select D_ID as ID, D_Place as [Depot Place], TU_ID as [TranportUnit ID], Con_ID as [Container ID], V_ID as[Vehicle ID], T_ID as [Trailer ID], L_ID as[Load ID] from Depot");
        }

        private void Depot_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label8.BackColor = System.Drawing.Color.Transparent;
            loadTransportUnitComboBoxFun();
            loadContainerComboBoxFun();
            loadVehicleComboBoxFun();
            loadTrailerComboBoxFun();
            loadLoadComboBoxFun();
        }

        // get Load 
        private void loadLoadComboBoxFun()
        {

            LIDComBox.DataSource = A.getData("select L_ID as ID, L_type as [Load type] from Loadtbl");
            LIDComBox.DisplayMember = "Load ID";
            LIDComBox.ValueMember = "ID";
        }

        // get Trailer 
        private void loadTrailerComboBoxFun()
        {

            TrIDComBox.DataSource = A.getData("select T_ID as ID, T_Capacity as [Trailer Capacity] from Trailer");
            TrIDComBox.DisplayMember = "Trailer ID";
            TrIDComBox.ValueMember = "ID";
        }

        // get Vehicle 
        private void loadVehicleComboBoxFun()
        {

            VIDComBox.DataSource = A.getData("select V_ID as ID, V_no as [Vehicle no], V_Name as [Vehicle name] from Vehicle");
            VIDComBox.DisplayMember = "Vehicle ID";
            VIDComBox.ValueMember = "ID";
        }

        // get Container 
        private void loadContainerComboBoxFun()
        {

            ConIDComBox.DataSource = A.getData("select Con_ID as ID, Con_type as [Con type] from Container");
            ConIDComBox.DisplayMember = "Container ID";
            ConIDComBox.ValueMember = "ID";
        }

        // get Transport Unit 
        private void loadTransportUnitComboBoxFun()
        {

            TUIDComBox.DataSource = A.getData("select TU_ID as ID, V_ID as [Vehicle ID], E_ID as [Employee] from Transport_unit");
            TUIDComBox.DisplayMember = "TU ID";
            TUIDComBox.ValueMember = "ID";
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            dpBox.Text = "";
            TUIDComBox.SelectedValue = 0;
            ConIDComBox.SelectedValue = 0;
            VIDComBox.SelectedValue = 0;
            TrIDComBox.SelectedValue = 0;
            LIDComBox.SelectedValue = 0;
        }


        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                idBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                dpBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
                TUIDComBox.SelectedValue = loadTable.Rows[index].Cells[2].Value.ToString();
                ConIDComBox.SelectedValue = loadTable.Rows[index].Cells[3].Value.ToString();
                VIDComBox.SelectedValue = loadTable.Rows[index].Cells[4].Value.ToString();
                TrIDComBox.SelectedValue = loadTable.Rows[index].Cells[5].Value.ToString();
                LIDComBox.SelectedValue = loadTable.Rows[index].Cells[6].Value.ToString();
            }
        }

    }
}
