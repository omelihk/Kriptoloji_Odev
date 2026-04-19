using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdev1
{
    public partial class MailForm : Form
    {
        // Dışarıya açılan özellikler — Form1 bunları okuyacak
        public string Gonderen => gonderenComboBox.GetItemText(gonderenComboBox.SelectedItem);
        public string AppSifre => sifreTextBox.Text;
        public string Alici => aliciComboBox.GetItemText(aliciComboBox.SelectedItem);

        public MailForm()
        {
            InitializeComponent();
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Gonderen) ||
                string.IsNullOrEmpty(AppSifre) ||
                string.IsNullOrEmpty(Alici))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.",
                    "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void appPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://myaccount.google.com/apppasswords",
                UseShellExecute = true
            });
        }
    }
}