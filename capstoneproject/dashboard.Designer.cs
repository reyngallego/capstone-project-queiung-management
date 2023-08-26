namespace capstoneproject
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            this.usersbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tblloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginformDataSet = new capstoneproject.loginformDataSet();
            this.queuebtn = new System.Windows.Forms.Button();
            this.purposebtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.tbl_loginTableAdapter = new capstoneproject.loginformDataSetTableAdapters.tbl_loginTableAdapter();
            this.lblshow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersbtn
            // 
            this.usersbtn.Location = new System.Drawing.Point(276, 101);
            this.usersbtn.Name = "usersbtn";
            this.usersbtn.Size = new System.Drawing.Size(82, 27);
            this.usersbtn.TabIndex = 0;
            this.usersbtn.Text = "USERS";
            this.usersbtn.UseVisualStyleBackColor = true;
            this.usersbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(364, 101);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(82, 27);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.Text = "LOG OUT";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblloginBindingSource, "image", true));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tblloginBindingSource
            // 
            this.tblloginBindingSource.DataMember = "tbl_login";
            this.tblloginBindingSource.DataSource = this.loginformDataSet;
            // 
            // loginformDataSet
            // 
            this.loginformDataSet.DataSetName = "loginformDataSet";
            this.loginformDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queuebtn
            // 
            this.queuebtn.Location = new System.Drawing.Point(12, 101);
            this.queuebtn.Name = "queuebtn";
            this.queuebtn.Size = new System.Drawing.Size(82, 27);
            this.queuebtn.TabIndex = 4;
            this.queuebtn.Text = "QUEUEING";
            this.queuebtn.UseVisualStyleBackColor = true;
            this.queuebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // purposebtn
            // 
            this.purposebtn.Location = new System.Drawing.Point(112, 101);
            this.purposebtn.Name = "purposebtn";
            this.purposebtn.Size = new System.Drawing.Size(82, 27);
            this.purposebtn.TabIndex = 5;
            this.purposebtn.Text = "PURPOSE";
            this.purposebtn.UseVisualStyleBackColor = true;
            this.purposebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // reportbtn
            // 
            this.reportbtn.Location = new System.Drawing.Point(188, 101);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(82, 27);
            this.reportbtn.TabIndex = 6;
            this.reportbtn.Text = "REPORT";
            this.reportbtn.UseVisualStyleBackColor = true;
            this.reportbtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(587, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(0, 4);
            this.listBox1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 423);
            this.dataGridView1.TabIndex = 8;
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(736, 9);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(178, 40);
            this.lbltime.TabIndex = 10;
            this.lbltime.Text = "time";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(683, 49);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(231, 29);
            this.lbldate.TabIndex = 11;
            this.lbldate.Text = "date";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblusername
            // 
            this.lblusername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblloginBindingSource, "username", true));
            this.lblusername.Location = new System.Drawing.Point(109, 25);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(140, 13);
            this.lblusername.TabIndex = 12;
            this.lblusername.Text = "username";
            // 
            // tbl_loginTableAdapter
            // 
            this.tbl_loginTableAdapter.ClearBeforeFill = true;
            // 
            // lblshow
            // 
            this.lblshow.Location = new System.Drawing.Point(12, 75);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(100, 23);
            this.lblshow.TabIndex = 13;
            this.lblshow.Text = "show";
            this.lblshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capstoneproject.Properties.Resources._99425148_2402006923430298_415144967531397120_n;
            this.ClientSize = new System.Drawing.Size(956, 572);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.purposebtn);
            this.Controls.Add(this.queuebtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.usersbtn);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load_1);
            this.Shown += new System.EventHandler(this.dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginformDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button usersbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button queuebtn;
        private System.Windows.Forms.Button purposebtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblusername;
        private loginformDataSet loginformDataSet;
        private System.Windows.Forms.BindingSource tblloginBindingSource;
        private loginformDataSetTableAdapters.tbl_loginTableAdapter tbl_loginTableAdapter;
        private System.Windows.Forms.Label lblshow;
    }
}