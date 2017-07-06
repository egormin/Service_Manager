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
    public partial class Form_Jenkins_CreateProject : DevExpress.XtraEditors.XtraForm
    {
        public Form_Jenkins_CreateProject()
        {
            InitializeComponent();
        }

        private void simpleButton_Form_Jenkins_CreateProject_CreateProject_Click(object sender, EventArgs e)
        {
            textBox1.Text = Call_jenkins_createProject.Call(textEdit_Form_Jenkins_CreateProject_ProjectName.Text);           
        }
    }
}
