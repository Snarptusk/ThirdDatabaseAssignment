﻿namespace ThirdDatabaseAssignment
{
    partial class Form1
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
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNr1 = new System.Windows.Forms.TextBox();
            this.txtPhoneNr2 = new System.Windows.Forms.TextBox();
            this.txtPhoneNr3 = new System.Windows.Forms.TextBox();
            this.grbPhoneNr = new System.Windows.Forms.GroupBox();
            this.grbStreetAdress = new System.Windows.Forms.GroupBox();
            this.txtStreetAdress3 = new System.Windows.Forms.TextBox();
            this.txtStreetAdress1 = new System.Windows.Forms.TextBox();
            this.txtStreetAdress2 = new System.Windows.Forms.TextBox();
            this.cmdNew = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.grbPhoneNr.SuspendLayout();
            this.grbStreetAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(12, 12);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(127, 225);
            this.lstContacts.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(145, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(148, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(156, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(113, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(189, 86);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(113, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtPhoneNr1
            // 
            this.txtPhoneNr1.Location = new System.Drawing.Point(81, 22);
            this.txtPhoneNr1.Name = "txtPhoneNr1";
            this.txtPhoneNr1.Size = new System.Drawing.Size(113, 20);
            this.txtPhoneNr1.TabIndex = 14;
            // 
            // txtPhoneNr2
            // 
            this.txtPhoneNr2.Location = new System.Drawing.Point(81, 48);
            this.txtPhoneNr2.Name = "txtPhoneNr2";
            this.txtPhoneNr2.Size = new System.Drawing.Size(113, 20);
            this.txtPhoneNr2.TabIndex = 15;
            // 
            // txtPhoneNr3
            // 
            this.txtPhoneNr3.Location = new System.Drawing.Point(81, 74);
            this.txtPhoneNr3.Name = "txtPhoneNr3";
            this.txtPhoneNr3.Size = new System.Drawing.Size(113, 20);
            this.txtPhoneNr3.TabIndex = 16;
            // 
            // grbPhoneNr
            // 
            this.grbPhoneNr.Controls.Add(this.lblOther);
            this.grbPhoneNr.Controls.Add(this.lblCellphone);
            this.grbPhoneNr.Controls.Add(this.lblHome);
            this.grbPhoneNr.Controls.Add(this.txtPhoneNr3);
            this.grbPhoneNr.Controls.Add(this.txtPhoneNr1);
            this.grbPhoneNr.Controls.Add(this.txtPhoneNr2);
            this.grbPhoneNr.Location = new System.Drawing.Point(352, 12);
            this.grbPhoneNr.Name = "grbPhoneNr";
            this.grbPhoneNr.Size = new System.Drawing.Size(200, 114);
            this.grbPhoneNr.TabIndex = 20;
            this.grbPhoneNr.TabStop = false;
            this.grbPhoneNr.Text = "Phone Numbers";
            // 
            // grbStreetAdress
            // 
            this.grbStreetAdress.Controls.Add(this.label3);
            this.grbStreetAdress.Controls.Add(this.label2);
            this.grbStreetAdress.Controls.Add(this.label1);
            this.grbStreetAdress.Controls.Add(this.txtStreetAdress3);
            this.grbStreetAdress.Controls.Add(this.txtStreetAdress1);
            this.grbStreetAdress.Controls.Add(this.txtStreetAdress2);
            this.grbStreetAdress.Location = new System.Drawing.Point(351, 132);
            this.grbStreetAdress.Name = "grbStreetAdress";
            this.grbStreetAdress.Size = new System.Drawing.Size(200, 114);
            this.grbStreetAdress.TabIndex = 21;
            this.grbStreetAdress.TabStop = false;
            this.grbStreetAdress.Text = "Street Addresses";
            // 
            // txtStreetAdress3
            // 
            this.txtStreetAdress3.Location = new System.Drawing.Point(81, 73);
            this.txtStreetAdress3.Name = "txtStreetAdress3";
            this.txtStreetAdress3.Size = new System.Drawing.Size(113, 20);
            this.txtStreetAdress3.TabIndex = 16;
            // 
            // txtStreetAdress1
            // 
            this.txtStreetAdress1.Location = new System.Drawing.Point(81, 21);
            this.txtStreetAdress1.Name = "txtStreetAdress1";
            this.txtStreetAdress1.Size = new System.Drawing.Size(113, 20);
            this.txtStreetAdress1.TabIndex = 14;
            // 
            // txtStreetAdress2
            // 
            this.txtStreetAdress2.Location = new System.Drawing.Point(81, 47);
            this.txtStreetAdress2.Name = "txtStreetAdress2";
            this.txtStreetAdress2.Size = new System.Drawing.Size(113, 20);
            this.txtStreetAdress2.TabIndex = 15;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(145, 214);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 22;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(16, 25);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(38, 13);
            this.lblHome.TabIndex = 17;
            this.lblHome.Text = "Home:";
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(16, 51);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(57, 13);
            this.lblCellphone.TabIndex = 23;
            this.lblCellphone.Text = "Cellphone:";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(16, 77);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(36, 13);
            this.lblOther.TabIndex = 23;
            this.lblOther.Text = "Other:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Home:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Work:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Other:";
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(270, 214);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 23;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 256);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.grbStreetAdress);
            this.Controls.Add(this.grbPhoneNr);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPhoneNr.ResumeLayout(false);
            this.grbPhoneNr.PerformLayout();
            this.grbStreetAdress.ResumeLayout(false);
            this.grbStreetAdress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNr1;
        private System.Windows.Forms.TextBox txtPhoneNr2;
        private System.Windows.Forms.TextBox txtPhoneNr3;
        private System.Windows.Forms.GroupBox grbPhoneNr;
        private System.Windows.Forms.GroupBox grbStreetAdress;
        private System.Windows.Forms.TextBox txtStreetAdress3;
        private System.Windows.Forms.TextBox txtStreetAdress1;
        private System.Windows.Forms.TextBox txtStreetAdress2;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDelete;
    }
}

