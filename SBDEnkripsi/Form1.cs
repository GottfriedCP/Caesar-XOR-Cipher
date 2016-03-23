using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBDEnkripsi
{
    public partial class Form1 : Form
    {
        string NoFileOpened = "Click BROWSE.";
        string FileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OpenTxt = new OpenFileDialog();
                OpenTxt.Title = "Choose File";
                OpenTxt.Filter = "Text Files(*.txt )| *.txt;";

                if (OpenTxt.ShowDialog() == DialogResult.OK)
                {
                    FileName = OpenTxt.FileName;
                    lblFileName.Text = FileName;
                    txtMain.Text = System.IO.File.ReadAllText(OpenTxt.FileName);

                    if (txtKeyString.Text == "") lblStatus.Text = "Please enter key string.";
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdBtnEnc.Checked = true;
            lblStatus.Text = NoFileOpened;
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileName == "" || txtKeyString.Text == "")
                {
                    MessageBox.Show("Please check source file and key", caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
                else if (rdBtnEnc.Checked == true && rdBtnDec.Checked == false)
                {
                    // ENCRYPTING
                    txtMain.Text = CaesarXorCrypto.Encrypt(txtMain.Text, txtKeyString.Text);

                    lblStatus.Text = "1 Operation complete.";
                    MessageBox.Show("Encryption successful", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
                else if (rdBtnDec.Checked == true && rdBtnEnc.Checked == false)
                {
                    // DECRYPTING
                    txtMain.Text = CaesarXorCrypto.Decrypt(txtMain.Text, txtKeyString.Text);

                    lblStatus.Text = "1 Operation complete.";
                    MessageBox.Show("Decryption successful", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void rdBtnEnc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveTxt = new SaveFileDialog();
                SaveTxt.Title = "Save As";
                SaveTxt.Filter = "Text File|*.txt";

                if (SaveTxt.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(SaveTxt.FileName, txtMain.Text);
                    lblStatus.Text = "Saved.";
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, caption: "ERROR", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
