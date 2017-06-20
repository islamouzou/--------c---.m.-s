using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SQLite;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Tile;

namespace WindowsFormsApplication1
{
    public partial class ucmodule4 : UserControl
    {
        private SQLiteConnection sql_con;

        private static ucmodule4 _instance;

        public static ucmodule4 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucmodule4();
                return _instance;
            }
        }
        public ucmodule4()
        {
            InitializeComponent();




        }

        private void ucmodule4_Load(object sender, EventArgs e)
        {

        }
    }
}