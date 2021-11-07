namespace Smartmovers
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            this.bcBox = new System.Windows.Forms.TextBox();
            this.pmBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.intbtn = new System.Windows.Forms.Button();
            this.billdateTime = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.CIDComBox = new System.Windows.Forms.ComboBox();
            this.JIDComBox = new System.Windows.Forms.ComboBox();
            this.TUIDComBox = new System.Windows.Forms.ComboBox();
            this.PIDComBox = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.prntbtn = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bcBox
            // 
            this.bcBox.Location = new System.Drawing.Point(162, 250);
            this.bcBox.Name = "bcBox";
            this.bcBox.Size = new System.Drawing.Size(366, 22);
            this.bcBox.TabIndex = 8;
            // 
            // pmBox
            // 
            this.pmBox.Location = new System.Drawing.Point(162, 204);
            this.pmBox.Name = "pmBox";
            this.pmBox.Size = new System.Drawing.Size(366, 22);
            this.pmBox.TabIndex = 9;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(162, 112);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(366, 22);
            this.idBox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Payment method :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Customer ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bill cash :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bill Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bill ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Job ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Trans Unit ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Product ID :";
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(591, 100);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(681, 353);
            this.loadTable.TabIndex = 25;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1179, 491);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(93, 37);
            this.button6.TabIndex = 30;
            this.button6.Text = "Logout";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(591, 488);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 37);
            this.button5.TabIndex = 29;
            this.button5.Text = "Menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dltbtn.Location = new System.Drawing.Point(205, 494);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(78, 31);
            this.dltbtn.TabIndex = 28;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updbtn.Location = new System.Drawing.Point(109, 494);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(78, 31);
            this.updbtn.TabIndex = 27;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // intbtn
            // 
            this.intbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.intbtn.Location = new System.Drawing.Point(5, 494);
            this.intbtn.Name = "intbtn";
            this.intbtn.Size = new System.Drawing.Size(78, 31);
            this.intbtn.TabIndex = 26;
            this.intbtn.Text = "Insert";
            this.intbtn.UseVisualStyleBackColor = false;
            this.intbtn.Click += new System.EventHandler(this.intbtn_Click);
            // 
            // billdateTime
            // 
            this.billdateTime.Enabled = false;
            this.billdateTime.Location = new System.Drawing.Point(162, 157);
            this.billdateTime.Name = "billdateTime";
            this.billdateTime.Size = new System.Drawing.Size(366, 22);
            this.billdateTime.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1044, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clrbtn.Location = new System.Drawing.Point(300, 494);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(75, 31);
            this.clrbtn.TabIndex = 80;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 32);
            this.label9.TabIndex = 81;
            this.label9.Text = "Bill";
            // 
            // CIDComBox
            // 
            this.CIDComBox.FormattingEnabled = true;
            this.CIDComBox.Location = new System.Drawing.Point(162, 296);
            this.CIDComBox.Name = "CIDComBox";
            this.CIDComBox.Size = new System.Drawing.Size(366, 24);
            this.CIDComBox.TabIndex = 82;
            // 
            // JIDComBox
            // 
            this.JIDComBox.FormattingEnabled = true;
            this.JIDComBox.Location = new System.Drawing.Point(162, 338);
            this.JIDComBox.Name = "JIDComBox";
            this.JIDComBox.Size = new System.Drawing.Size(366, 24);
            this.JIDComBox.TabIndex = 82;
            // 
            // TUIDComBox
            // 
            this.TUIDComBox.FormattingEnabled = true;
            this.TUIDComBox.Location = new System.Drawing.Point(162, 383);
            this.TUIDComBox.Name = "TUIDComBox";
            this.TUIDComBox.Size = new System.Drawing.Size(366, 24);
            this.TUIDComBox.TabIndex = 82;
            // 
            // PIDComBox
            // 
            this.PIDComBox.FormattingEnabled = true;
            this.PIDComBox.Location = new System.Drawing.Point(162, 429);
            this.PIDComBox.Name = "PIDComBox";
            this.PIDComBox.Size = new System.Drawing.Size(366, 24);
            this.PIDComBox.TabIndex = 82;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // prntbtn
            // 
            this.prntbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prntbtn.Location = new System.Drawing.Point(434, 494);
            this.prntbtn.Name = "prntbtn";
            this.prntbtn.Size = new System.Drawing.Size(85, 31);
            this.prntbtn.TabIndex = 83;
            this.prntbtn.Text = "Print";
            this.prntbtn.UseVisualStyleBackColor = false;
            this.prntbtn.Click += new System.EventHandler(this.prntbtn_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 531);
            this.Controls.Add(this.prntbtn);
            this.Controls.Add(this.PIDComBox);
            this.Controls.Add(this.TUIDComBox);
            this.Controls.Add(this.JIDComBox);
            this.Controls.Add(this.CIDComBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.billdateTime);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.intbtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.bcBox);
            this.Controls.Add(this.pmBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bcBox;
        private System.Windows.Forms.TextBox pmBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button intbtn;
        private System.Windows.Forms.DateTimePicker billdateTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CIDComBox;
        private System.Windows.Forms.ComboBox JIDComBox;
        private System.Windows.Forms.ComboBox TUIDComBox;
        private System.Windows.Forms.ComboBox PIDComBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button prntbtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}