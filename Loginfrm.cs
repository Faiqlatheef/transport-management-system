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
    public partial class Loginfrm : Form
    {
        public Loginfrm()
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
            string _pas = pasBox.Text;

            //validate data to insert into table
            if (_id != "" && _pas != "")
            {
                A.insertData("insert into eLogin (e_id , e_password )  values ('" + _id + "', '" + _pas + "' )");
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
            string _pas = pasBox.Text;

            //validate data to insert into table
            if (_id != "" && _pas != "")
            {
                A.updateData("update eLogin set  e_id='" + _id + "', e_password='" + _pas + "' where e_id='" + _id + "' ");
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
                A.deleteData("Delete eLogin where e_id='" + _id + "' ");
                loadTableFun();
                ClearDatafun();
            }
            else
            {
                MessageBox.Show(A.message_emptyBox());
            }
        }

        private void loadTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
            // this function for load table
        private void loadTableFun()
        {
            loadTable.DataSource = A.getData("select e_id as ID, e_password as password from eLogin");
        
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            loadTableFun();
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void ClearDatafun()
        {
            idBox.Text = "";
            pasBox.Text = "";
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
                pasBox.Text = loadTable.Rows[index].Cells[1].Value.ToString();

            }
        }
    }
}
