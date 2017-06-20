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
    public partial class Login : Form
    {
        Form1 form1;
        public Login(Form1 form11)
        {
            InitializeComponent();
            this.CenterToScreen();
           this.form1 = form11;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"Data source=C:\Users\Zou\OneDrive - Association Cesi Viacesi mail\Projects\CMS\Auto - Copie\WindowsFormsApplication1\bin\Debug\inventory.sqlite;Version=3");
            SQLiteCommand com = new SQLiteCommand("SELECT COUNT (*) from Login where Username= @user and Password= @pass", con);
            com.Parameters.AddWithValue("user", textEdit1.Text);
            com.Parameters.AddWithValue("pass", textEdit2.Text);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && textEdit1.Text=="Sec" )
            {
                Hide();
                ucmodule3.instance.simpleButton5.Enabled = false;
                ucmodule3.instance.simpleButton8.Enabled = false;
                ucmodule3.instance.simpleButton9.Enabled = false;
                form1.label2.Text = "Bonjour " + textEdit1.Text;
                form1.animator1.ShowSync(form1.label2);
                form1.hyperlinkLabelControl1.Show();

            }
            else if (dt.Rows[0][0].ToString() == "1" && textEdit1.Text!="Sec")
            {
                form1.label2.Text = "Bonjour " + textEdit1.Text;
                form1.animator1.ShowSync(form1.label2);
                form1.hyperlinkLabelControl1.Show();
                Hide();
            }
            
           

            textEdit1.Text = "";
            textEdit2.Text = "";
            
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
