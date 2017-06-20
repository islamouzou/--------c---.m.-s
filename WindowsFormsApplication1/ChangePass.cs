using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data source=C:\Users\Zou\OneDrive - Association Cesi Viacesi mail\Projects\CMS\Auto - Copie\WindowsFormsApplication1\bin\Debug\inventory.sqlite;Version=3");

            SQLiteCommand com = new SQLiteCommand("update Login set Password= @pass where Username= @user", con);
            com.Parameters.AddWithValue("user", comboBoxEdit1.Text);
            com.Parameters.AddWithValue("pass", comboBoxEdit2.Text);
            com.ExecuteScalar();
            /*SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);*/
        }
    }
}
