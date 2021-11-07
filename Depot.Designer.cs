namespace Smartmovers
{
    partial class Depot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depot));
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpBox = new System.Windows.Forms.TextBox();
            this.loadTable = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dltbtn = new System.Windows.Forms.Button();
            this.updbtn = new System.Windows.Forms.Button();
            this.intbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clrbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TUIDComBox = new System.Windows.Forms.ComboBox();
            this.ConIDComBox = new System.Windows.Forms.ComboBox();
            this.VIDComBox = new System.Windows.Forms.ComboBox();
            this.LIDComBox = new System.Windows.Forms.ComboBox();
            this.TrIDComBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(177, 109);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(318, 22);
            this.idBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Trans Unit ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Trailer ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Load ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vehicle ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Depot place :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Depot ID :";
            // 
            // dpBox
            // 
            this.dpBox.Location = new System.Drawing.Point(177, 164);
            this.dpBox.Name = "dpBox";
            this.dpBox.Size = new System.Drawing.Size(318, 22);
            this.dpBox.TabIndex = 26;
            // 
            // loadTable
            // 
            this.loadTable.AllowUserToAddRows = false;
            this.loadTable.AllowUserToDeleteRows = false;
            this.loadTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loadTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.loadTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadTable.Location = new System.Drawing.Point(584, 94);
            this.loadTable.Name = "loadTable";
            this.loadTable.ReadOnly = true;
            this.loadTable.RowTemplate.Height = 24;
            this.loadTable.Size = new System.Drawing.Size(698, 357);
            this.loadTable.TabIndex = 37;
            this.loadTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadTable_CellClick_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1189, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 50;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Location = new System.Drawing.Point(584, 481);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 37);
            this.button5.TabIndex = 49;
            this.button5.Text = "Menu";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dltbtn
            // 
            this.dltbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dltbtn.Location = new System.Drawing.Point(224, 481);
            this.dltbtn.Name = "dltbtn";
            this.dltbtn.Size = new System.Drawing.Size(78, 31);
            this.dltbtn.TabIndex = 48;
            this.dltbtn.Text = "Delete";
            this.dltbtn.UseVisualStyleBackColor = false;
            this.dltbtn.Click += new System.EventHandler(this.dltbtn_Click);
            // 
            // updbtn
            // 
            this.updbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.updbtn.Location = new System.Drawing.Point(112, 481);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(78, 31);
            this.updbtn.TabIndex = 47;
            this.updbtn.Text = "Update";
            this.updbtn.UseVisualStyleBackColor = false;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // intbtn
            // 
            this.intbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.intbtn.Location = new System.Drawing.Point(8, 481);
            this.intbtn.Name = "intbtn";
            this.intbtn.Size = new System.Drawing.Size(78, 31);
            this.intbtn.TabIndex = 46;
            this.intbtn.Text = "Insert";
            this.intbtn.UseVisualStyleBackColor = false;
            this.intbtn.Click += new System.EventHandler(this.intbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1052, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "Container ID :";
            // 
            // clrbtn
            // 
            this.clrbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clrbtn.Location = new System.Drawing.Point(323, 481);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(75, 31);
            this.clrbtn.TabIndex = 82;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = false;
            this.clrbtn.Click += new System.EventHandler(this.clrbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 32);
            this.label8.TabIndex = 83;
            this.label8.Text = "Depot";
            // 
            // TUIDComBox
            // 
            this.TUIDComBox.FormattingEnabled = true;
            this.TUIDComBox.Location = new System.Drawing.Point(177, 209);
            this.TUIDComBox.Name = "TUIDComBox";
            this.TUIDComBox.Size = new System.Drawing.Size(318, 24);
            this.TUIDComBox.TabIndex = 84;
            // 
            // ConIDComBox
            // 
            this.ConIDComBox.FormattingEnabled = true;
            this.ConIDComBox.Location = new System.Drawing.Point(177, 263);
            this.ConIDComBox.Name = "ConIDComBox";
            this.ConIDComBox.Size = new System.Drawing.Size(318, 24);
            this.ConIDComBox.TabIndex = 84;
            // 
            // VIDComBox
            // 
            this.VIDComBox.FormattingEnabled = true;
            this.VIDComBox.Location = new System.Drawing.Point(177, 311);
            this.VIDComBox.Name = "VIDComBox";
            this.VIDComBox.Size = new System.Drawing.Size(318, 24);
            this.VIDComBox.TabIndex = 84;
            // 
            // LIDComBox
            // 
            this.LIDComBox.FormattingEnabled = true;
            this.LIDComBox.Location = new System.Drawing.Point(177, 359);
            this.LIDComBox.Name = "LIDComBox";
            this.LIDComBox.Size = new System.Drawing.Size(318, 24);
            this.LIDComBox.TabIndex = 84;
            // 
            // TrIDComBox
            // 
            this.TrIDComBox.FormattingEnabled = true;
            this.TrIDComBox.Location = new System.Drawing.Point(177, 408);
            this.TrIDComBox.Name = "TrIDComBox";
            this.TrIDComBox.Size = new System.Drawing.Size(318, 24);
            this.TrIDComBox.TabIndex = 84;
            // 
            // Depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 524);
            this.Controls.Add(this.TrIDComBox);
            this.Controls.Add(this.LIDComBox);
            this.Controls.Add(this.VIDComBox);
            this.Controls.Add(this.ConIDComBox);
            this.Controls.Add(this.TUIDComBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dltbtn);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.intbtn);
            this.Controls.Add(this.loadTable);
            this.Controls.Add(this.dpBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Depot";
            this.Text = "Depot";
            this.Load += new System.EventHandler(this.Depot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dpBox;
        private System.Windows.Forms.DataGridView loadTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button dltbtn;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.Button intbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clrbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox TUIDComBox;
        private System.Windows.Forms.ComboBox ConIDComBox;
        private System.Windows.Forms.ComboBox VIDComBox;
        private System.Windows.Forms.ComboBox LIDComBox;
        private System.Windows.Forms.ComboBox TrIDComBox;
    }
}