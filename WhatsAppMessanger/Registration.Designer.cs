namespace WhatsAppMessanger
{
    partial class frmRegistration
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
            this.btnRequest = new System.Windows.Forms.Button();
            this.gbRequestCode = new System.Windows.Forms.GroupBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbConfirmCode = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtSmsCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRequestCode.SuspendLayout();
            this.gbConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(220, 81);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // gbRequestCode
            // 
            this.gbRequestCode.Controls.Add(this.txtFullName);
            this.gbRequestCode.Controls.Add(this.btnRequest);
            this.gbRequestCode.Controls.Add(this.label1);
            this.gbRequestCode.Controls.Add(this.txtPhoneNumber);
            this.gbRequestCode.Controls.Add(this.lblPhoneNumber);
            this.gbRequestCode.Location = new System.Drawing.Point(12, 21);
            this.gbRequestCode.Name = "gbRequestCode";
            this.gbRequestCode.Size = new System.Drawing.Size(308, 122);
            this.gbRequestCode.TabIndex = 1;
            this.gbRequestCode.TabStop = false;
            this.gbRequestCode.Text = "Step 1: Request code";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 30);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(113, 27);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 20);
            this.txtPhoneNumber.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(113, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(182, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // gbConfirmCode
            // 
            this.gbConfirmCode.Controls.Add(this.btnConfirm);
            this.gbConfirmCode.Controls.Add(this.txtSmsCode);
            this.gbConfirmCode.Controls.Add(this.label3);
            this.gbConfirmCode.Enabled = false;
            this.gbConfirmCode.Location = new System.Drawing.Point(12, 164);
            this.gbConfirmCode.Name = "gbConfirmCode";
            this.gbConfirmCode.Size = new System.Drawing.Size(308, 96);
            this.gbConfirmCode.TabIndex = 1;
            this.gbConfirmCode.TabStop = false;
            this.gbConfirmCode.Text = "Step 2: Confirm code";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(220, 53);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtSmsCode
            // 
            this.txtSmsCode.Location = new System.Drawing.Point(113, 27);
            this.txtSmsCode.MaxLength = 6;
            this.txtSmsCode.Name = "txtSmsCode";
            this.txtSmsCode.Size = new System.Drawing.Size(182, 20);
            this.txtSmsCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sms code:";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 282);
            this.Controls.Add(this.gbConfirmCode);
            this.Controls.Add(this.gbRequestCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.gbRequestCode.ResumeLayout(false);
            this.gbRequestCode.PerformLayout();
            this.gbConfirmCode.ResumeLayout(false);
            this.gbConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox gbRequestCode;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.GroupBox gbConfirmCode;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtSmsCode;
        private System.Windows.Forms.Label label3;
    }
}