using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CES_Service_Manager
{
    public partial class Form_Settings : DevExpress.XtraEditors.XtraForm
    {
        public Form_Settings()
        {
            InitializeComponent();
        }

        string publicKeyPass;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Public Key(*.pub)|*.pub";
            dialog.Title = "Choose your public key";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               publicKeyPass = dialog.FileName;
            }
        }

        private void simpleButton_Settings_TestConnection_Click(object sender, EventArgs e)
        {
           string res =  Set_TestConnection.Check_Connection(textEdit_Settings_IP.Text, publicKeyPass);

            if (res=="OK")
            {pictureEdit_Settings_OK.Visible = true;} else { pictureEdit_Settings_NOK.Visible = true; }
        }
    }
}
