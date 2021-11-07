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
    public partial class trailer : Form
    {
        public trailer()
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
            string _trc = trcBox.Text;

            //validate data to insert into table
            if (_id != "" && _trc != "")
            {
                A.insertData("insert into Trailer (T_ID , T_Capacity )  values ('" + _id + "', '" + _trc + "' )");
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
            string _trc = trcBox.Text;

            //validate data to insert into table
            if (_id != "" && _trc != "")
            {
                A.updateData("update Trailer set  T_ID='" + _id + "', T_Capacity='" + _trc + "' where T_ID='" + _id + "' ");
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
                A.deleteData("Delete Trailer where T_ID='" + _id + "' ");
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
            loadTable.DataSource = A.getData("select T_ID as ID, T_Capacity as [Trailer Capacity] from Trailer");
        }
        private void trailer_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            trcBox.Text = "";
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
                trcBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();

            }
        }
    }
}
