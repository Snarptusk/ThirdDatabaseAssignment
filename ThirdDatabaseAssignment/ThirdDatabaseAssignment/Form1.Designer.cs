namespace ThirdDatabaseAssignment
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
            this.lblStreetAdress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNr = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreetAdress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(12, 12);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(127, 303);
            this.lstContacts.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(145, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(145, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblStreetAdress
            // 
            this.lblStreetAdress.AutoSize = true;
            this.lblStreetAdress.Location = new System.Drawing.Point(145, 69);
            this.lblStreetAdress.Name = "lblStreetAdress";
            this.lblStreetAdress.Size = new System.Drawing.Size(72, 13);
            this.lblStreetAdress.TabIndex = 3;
            this.lblStreetAdress.Text = "Street adress:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(145, 95);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 5;
            this.lblCity.Text = "City:";
            // 
            // lblPhoneNr
            // 
            this.lblPhoneNr.AutoSize = true;
            this.lblPhoneNr.Location = new System.Drawing.Point(145, 121);
            this.lblPhoneNr.Name = "lblPhoneNr";
            this.lblPhoneNr.Size = new System.Drawing.Size(55, 13);
            this.lblPhoneNr.TabIndex = 6;
            this.lblPhoneNr.Text = "Phone Nr:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(228, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtStreetAdress
            // 
            this.txtStreetAdress.Location = new System.Drawing.Point(228, 66);
            this.txtStreetAdress.Name = "txtStreetAdress";
            this.txtStreetAdress.Size = new System.Drawing.Size(175, 20);
            this.txtStreetAdress.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(228, 92);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(175, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtPhoneNr
            // 
            this.txtPhoneNr.Location = new System.Drawing.Point(228, 118);
            this.txtPhoneNr.Name = "txtPhoneNr";
            this.txtPhoneNr.Size = new System.Drawing.Size(175, 20);
            this.txtPhoneNr.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 326);
            this.Controls.Add(this.txtPhoneNr);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetAdress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhoneNr);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAdress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstContacts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreetAdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStreetAdress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNr;
    }
}

