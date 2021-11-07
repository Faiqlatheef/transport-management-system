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
    public partial class Container : Form
    {
        public Container()
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
            string _id = IDBox.Text;
            string _ct = ctcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _ct != "")
            {
                A.insertData("insert into Container (Con_ID , Con_type )  values ('" + _id + "', '" + _ct + "' )");
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
            string _id = IDBox.Text;
            string _ct = ctcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _ct != "")
            {
                A.updateData("update Container set  Con_ID='" + _id + "', Con_type='" + _ct + "' where Con_ID='" + _id + "' ");
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

            string _id = IDBox.Text;

            //validate data to delete into table
            if (_id != "")
            {
                A.deleteData("Delete Container where Con_ID='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select Con_ID as ID, Con_type as [Con type] from Container");
            
        }

        private void Container_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }
        private void ClearDatafun()
        {
            IDBox.Text = "";
            ctcomboBox.Text = "";
            
        }
        

        private void clrbtn_Click(object sender, EventArgs e)
        {
            this.ClearDatafun();
        }

        private void loadTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                IDBox.Text = loadTable.Rows[index].Cells[0].Value.ToString();
                ctcomboBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();
            }
        }
    }
}
