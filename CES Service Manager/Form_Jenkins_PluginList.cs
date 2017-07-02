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

        Show_plugins_FillDatagrid inst_ShowPlugins = new Show_plugins_FillDatagrid();

        private void Form_Jenkins_PluginList_Load(object sender, EventArgs e)
        {
           
            inst_ShowPlugins.execute();
        }

        private void simpleButton1_Form_Jenkins_PluginList_Click(object sender, EventArgs e)
        {
            inst_ShowPlugins.execute();
        }
    }
}
