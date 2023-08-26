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
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(68, 81);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(143, 55);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "add user";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::capstoneproject.Properties.Resources._99425148_2402006923430298_415144967531397120_n;
            this.ClientSize = new System.Drawing.Size(860, 400);
            this.Controls.Add(this.addbtn);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
    }
}