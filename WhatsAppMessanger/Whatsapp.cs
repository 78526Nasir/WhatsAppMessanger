using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WhatsAppMessanger
{
    public partial class Whatsapp : Form
    {
        WhatsApp wa;

        public Whatsapp()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void cbRemember_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = cbRemember.Checked;
            Properties.Settings.Default.PhoneNumber = txtPhoneNumber.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void linkNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(frmRegistration frm=new frmRegistration())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                    txtPassword.Text = Properties.Settings.Default.Password;
                }
            }
        }

        private void Whatsapp_Load(object sender, EventArgs e)
        {
            signOutToolStripMenuItem.Visible = false;
            panel1.BringToFront();
            if (Properties.Settings.Default.Remember)
            {
                txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
                txtPassword.Text = Properties.Settings.Default.Password;
                cbRemember.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
