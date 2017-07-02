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
    public partial class Form_Jenkins_PluginList : DevExpress.XtraEditors.XtraForm
    {
        public Form_Jenkins_PluginList()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("s");
        }

        private void Form_Jenkins_PluginList_Load(object sender, EventArgs e)
        {
            Show_plugins_FillDatagrid fdr_P = new Show_plugins_FillDatagrid();
            fdr_P.execut();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
