using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace CES_Service_Manager
{
    /// <summary>
    /// This Class manages of controlls (pictureEdit and labelControl). Makes it visible or provides some picture or label depends on situation.
    /// </summary>
    class ManageControls
    {

        public T GetForm<T>() where T : Form
        {
            return (T)Application.OpenForms[typeof(T).Name];
        }


        public void Setting_frm_contr_initial()
        {
            var frmSS = GetForm<Form_ServerSettings>();

            frmSS.pictureEdit_Form_ServerSettings_OK.Visible = false;
            frmSS.pictureEdit_Form_ServerSettings_NOK.Visible = false;
            frmSS.pictureEdit_Form_ServerSettings_Wait.Visible = false;
            frmSS.labelControl_Form_ServerSettings_Result.Text = "Wait please...";
            frmSS.labelControl_Form_ServerSettings_Result.ForeColor = Color.Gray;
            frmSS.labelControl_Form_ServerSettings_Result.Visible = true;
            frmSS.pictureEdit_Form_ServerSettings_Wait.Visible = true;
        }

        public void Setting_frm_contr_servAvailable(string res)
        {
            var frmSS = GetForm<Form_ServerSettings>();

            frmSS.pictureEdit_Form_ServerSettings_OK.Visible = true;
            frmSS.labelControl_Form_ServerSettings_Result.Text = "Server: " + res + "is available";
            frmSS.labelControl_Form_ServerSettings_Result.ForeColor = Color.Lime;
            frmSS.pictureEdit_Form_ServerSettings_Wait.Visible = false;
        }

        public void Setting_frm_contr_servNotAvailable()
        {
            var frmSS = GetForm<Form_ServerSettings>();

            frmSS.pictureEdit_Form_ServerSettings_NOK.Visible = true;
            frmSS.labelControl_Form_ServerSettings_Result.Text = "Server is not available";
            frmSS.labelControl_Form_ServerSettings_Result.ForeColor = Color.Red;
            frmSS.pictureEdit_Form_ServerSettings_Wait.Visible = false;
        }

        public void Setting_frm_contr_IsServerAvailable(string ip, int port, string user, string key)
        {
            string result = Set_TestConnection.Check_Connection(ip, port, user, key);

            if (result != "")
            {
                Setting_frm_contr_servAvailable(result);
            }
            else
            {
                Setting_frm_contr_servNotAvailable();
            }
        }
    }
}
