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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
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
            loadTable.DataSource = A.getData("select L_ID as ID, L_type as [Load type] from Loadtbl");
        }
        private void Load_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string _lt = ltcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _lt != "")
            {
                A.insertData("insert into Loadtbl (L_ID , L_type )  values ('" + _id + "', '" + _lt + "' )");
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
            string _lt = ltcomboBox.Text;

            //validate data to insert into table
            if (_id != "" && _lt != "")
            {
                A.updateData("update Loadtbl set  L_ID='" + _id + "', L_type='" + _lt + "' where L_ID='" + _id + "' ");
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
                A.deleteData("Delete Loadtbl where L_ID='" + _id + "' ");
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
            ltcomboBox.Text = "";
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
                ltcomboBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();

            }
        }
    }
}
