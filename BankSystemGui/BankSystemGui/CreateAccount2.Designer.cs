﻿namespace BankSystemGui
{
    partial class CreateAccount2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStateCreate = new System.Windows.Forms.TextBox();
            this.txtCityCreate = new System.Windows.Forms.TextBox();
            this.txtZipCreate = new System.Windows.Forms.TextBox();
            this.txtAddressCreate = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "State:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // txtStateCreate
            // 
            this.txtStateCreate.Location = new System.Drawing.Point(111, 21);
            this.txtStateCreate.Name = "txtStateCreate";
            this.txtStateCreate.Size = new System.Drawing.Size(100, 20);
            this.txtStateCreate.TabIndex = 4;
            this.txtStateCreate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCityCreate
            // 
            this.txtCityCreate.Location = new System.Drawing.Point(111, 53);
            this.txtCityCreate.Name = "txtCityCreate";
            this.txtCityCreate.Size = new System.Drawing.Size(100, 20);
            this.txtCityCreate.TabIndex = 5;
            // 
            // txtZipCreate
            // 
            this.txtZipCreate.Location = new System.Drawing.Point(111, 88);
            this.txtZipCreate.Name = "txtZipCreate";
            this.txtZipCreate.Size = new System.Drawing.Size(100, 20);
            this.txtZipCreate.TabIndex = 6;
            // 
            // txtAddressCreate
            // 
            this.txtAddressCreate.Location = new System.Drawing.Point(111, 117);
            this.txtAddressCreate.Name = "txtAddressCreate";
            this.txtAddressCreate.Size = new System.Drawing.Size(100, 20);
            this.txtAddressCreate.TabIndex = 7;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(214, 235);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(163, 57);
            this.btnCreateAccount.TabIndex = 8;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // CreateAccount2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtAddressCreate);
            this.Controls.Add(this.txtZipCreate);
            this.Controls.Add(this.txtCityCreate);
            this.Controls.Add(this.txtStateCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStateCreate;
        private System.Windows.Forms.TextBox txtCityCreate;
        private System.Windows.Forms.TextBox txtZipCreate;
        private System.Windows.Forms.TextBox txtAddressCreate;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}