using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppMessanger
{
    public partial class frmRegistration : Form
    {
        string password;
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please enter your phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhoneNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFullName.Focus();
                return;
            }
            if (WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(txtPhoneNumber.Text,out password, "sms"))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    Save();
                }else
                {
                    gbRequestCode.Enabled = false;
                    gbConfirmCode.Enabled = true;
                }
            }else
            {
                MessageBox.Show("Could not generate password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Save()
        {
            this.gbRequestCode.Enabled = false;
            this.gbConfirmCode.Enabled = false;
            Properties.Settings.Default.PhoneNumber = txtPhoneNumber.Text;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.FullName = txtFullName.Text;
            Properties.Settings.Default.Save();
            if (Globals.DB.Accounts.FindByAccountID(txtPhoneNumber.Text) == null)
            {
                AppData.AccountsRow row = Globals.DB.Accounts.NewAccountsRow();
                row.AccountID = txtPhoneNumber.Text;
                row.FullName = txtFullName.Text;
                row.Password = password;
                Globals.DB.Accounts.AddAccountsRow(row);
                Globals.DB.Accounts.AcceptChanges();
                Globals.DB.Accounts.WriteXml(string.Format("{0}\\account.dat", Application.StartupPath));
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSmsCode.Text))
            {
                MessageBox.Show("Please enter your sms code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSmsCode.Focus();
                return;
            }
            password = WhatsAppApi.Register.WhatsRegisterV2.RegisterCode(txtPhoneNumber.Text, txtSmsCode.Text);
            Save();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
