namespace Smartmovers
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.intbtn = new System.Windows.Forms.Button();
            this.srchbtn = new System.Windows.Forms.Button();
            this.srchBox = new System.Windows.Forms.TextBox();
            this.nicBox = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.TextBox();
            this.fnBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.ctcomboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lnBox = new System.Windows.Forms.TextBox();
            this.addBox = new System.Windows.Forms.TextBox();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(553, 94);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(718, 406);
            this.loadTable.TabIndex = 24;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(553, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 35);
            this.button5.TabIndex = 23;
            this.button5.Text = "Menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dltbtn.Location = new System.Drawing.Point(215, 527);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(78, 31);
            this.dltbtn.TabIndex = 22;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updbtn.Location = new System.Drawing.Point(119, 527);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(78, 31);
            this.updbtn.TabIndex = 21;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // intbtn
            // 
            this.intbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.intbtn.Location = new System.Drawing.Point(15, 527);
            this.intbtn.Name = "intbtn";
            this.intbtn.Size = new System.Drawing.Size(78, 31);
            this.intbtn.TabIndex = 20;
            this.intbtn.Text = "Insert";
            this.intbtn.UseVisualStyleBackColor = false;
            this.intbtn.Click += new System.EventHandler(this.intbtn_Click);
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.srchbtn.Location = new System.Drawing.Point(765, 58);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(80, 32);
            this.srchbtn.TabIndex = 19;
            this.srchbtn.Text = "Search";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // srchBox
            // 
            this.srchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchBox.Location = new System.Drawing.Point(553, 61);
            this.srchBox.Name = "srchBox";
            this.srchBox.Size = new System.Drawing.Size(206, 27);
            this.srchBox.TabIndex = 18;
            // 
            // nicBox
            // 
            this.nicBox.Location = new System.Drawing.Point(213, 388);
            this.nicBox.Name = "nicBox";
            this.nicBox.Size = new System.Drawing.Size(315, 22);
            this.nicBox.TabIndex = 16;
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(214, 334);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(315, 22);
            this.numBox.TabIndex = 15;
            // 
            // fnBox
            // 
            this.fnBox.Location = new System.Drawing.Point(213, 158);
            this.fnBox.Name = "fnBox";
            this.fnBox.Size = new System.Drawing.Size(315, 22);
            this.fnBox.TabIndex = 13;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(213, 113);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(315, 22);
            this.idBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Customer Tel no :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer NIC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Customer Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID :";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1175, 523);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 37);
            this.button6.TabIndex = 25;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // ctcomboBox
            // 
            this.ctcomboBox.FormattingEnabled = true;
            this.ctcomboBox.Items.AddRange(new object[] {
            "Cat_1",
            "Cat_2",
            "Cat_3"});
            this.ctcomboBox.Location = new System.Drawing.Point(215, 441);
            this.ctcomboBox.Name = "ctcomboBox";
            this.ctcomboBox.Size = new System.Drawing.Size(315, 24);
            this.ctcomboBox.TabIndex = 79;
            this.ctcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1025, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Last Name :";
            // 
            // lnBox
            // 
            this.lnBox.Location = new System.Drawing.Point(215, 210);
            this.lnBox.Name = "lnBox";
            this.lnBox.Size = new System.Drawing.Size(315, 22);
            this.lnBox.TabIndex = 13;
            // 
            // addBox
            // 
            this.addBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBox.Location = new System.Drawing.Point(214, 270);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(315, 38);
            this.addBox.TabIndex = 14;
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clrbtn.Location = new System.Drawing.Point(310, 527);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(75, 31);
            this.clrbtn.TabIndex = 81;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(207, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 32);
            this.label8.TabIndex = 82;
            this.label8.Text = "Customer";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1283, 570);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctcomboBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.intbtn);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.srchBox);
            this.Controls.Add(this.nicBox);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.lnBox);
            this.Controls.Add(this.fnBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button intbtn;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.TextBox srchBox;
        private System.Windows.Forms.TextBox nicBox;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.TextBox fnBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox ctcomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lnBox;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Label label8;
    }
}