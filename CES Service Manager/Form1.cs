using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CES_Service_Manager
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Jenkins_Clicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panel5.Visible = true;
        }
    }
}
