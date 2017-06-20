using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Data.SQLite;
using Security;
using System.Diagnostics;
using System.Security.Cryptography;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection sql_con;
        private Login login;
        static int usr = 0;
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(ucmodule3.instance);
            panel1.Controls.Add(ucmodule2.instance);

            ucmodule3.instance.Dock = DockStyle.Fill;
          
            ucmodule2.instance.Dock = DockStyle.Fill;

            sql_con = new SQLiteConnection
            ("Data Source=lic.sqlite;Version=3");

             login = new Login(this);
            
           if (!panel1.Controls.Contains(ucmodule1.instance))
            {
                panel1.Controls.Add(ucmodule1.instance);
                ucmodule1.instance.Dock = DockStyle.Fill;
                ucmodule1.instance.BringToFront();
            }
            else ucmodule1.instance.BringToFront();
           
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pan_btn_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width==47)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 198;
                panel_anim.ShowSync(sidemenu);
                logoanime.ShowSync(logo);
            }
            else
            {
                logoanime.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 47;
                panel_anim.ShowSync(sidemenu);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
                if (!panel1.Controls.Contains(ucmodule1.instance))
                {
                    panel1.Controls.Add(ucmodule1.instance);
                    ucmodule1.instance.Dock = DockStyle.Fill;
                    ucmodule1.instance.BringToFront();
                }
                else ucmodule1.instance.BringToFront();

                ucmodule1.instance.clientTableAdapter.Fill(ucmodule1.instance.ucmodule1Set.Client);
            
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
           
                if (!panel1.Controls.Contains(ucmodule5.instance))
                {
                    panel1.Controls.Add(ucmodule5.instance);
                    ucmodule5.instance.Dock = DockStyle.Fill;
                    ucmodule5.instance.BringToFront();
                    ucmodule5.instance.Show();
                }
                else ucmodule5.instance.BringToFront();
                ucmodule5.instance.Show();
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            
                if (!panel1.Controls.Contains(ucmodule3.instance))
                {
                    panel1.Controls.Add(ucmodule3.instance);
                    ucmodule3.instance.Dock = DockStyle.Fill;
                    ucmodule3.instance.BringToFront();
                    ucmodule3.instance.Show();

                }
                else ucmodule3.instance.BringToFront();
                ucmodule3.instance.Show();
            
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
                if (!panel1.Controls.Contains(ucmodule2.instance))
                {
                    panel1.Controls.Add(ucmodule2.instance);
                    ucmodule2.instance.Dock = DockStyle.Fill;
                    ucmodule2.instance.BringToFront();
                    ucmodule2.instance.Show();
                }
                else ucmodule2.instance.BringToFront();
                ucmodule2.instance.Show();

                //ucmodule2.instance.clientTableAdapter2.Fill(ucmodule2.instance.inventoryDataSet9.Client);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                if (!panel1.Controls.Contains(ucmodule2.instance))
                {
                    panel1.Controls.Add(ucmodule2.instance);
                    ucmodule2.instance.Dock = DockStyle.Fill;
                    ucmodule2.instance.BringToFront();
                }
                else ucmodule2.instance.BringToFront();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                if (!panel1.Controls.Contains(ucmodule1.instance))
                {
                    panel1.Controls.Add(ucmodule1.instance);
                    ucmodule1.instance.Dock = DockStyle.Fill;
                    ucmodule1.instance.BringToFront();
                }
                else ucmodule1.instance.BringToFront();
            
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        { 
            
                if (!panel1.Controls.Contains(ucmodule4.instance))
                {
                    panel1.Controls.Add(ucmodule4.instance);
                    ucmodule4.instance.Dock = DockStyle.Fill;
                    ucmodule4.instance.BringToFront();
                    ucmodule4.instance.Show();
                }
                else ucmodule4.instance.BringToFront();
                ucmodule4.instance.Show();
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCalendar1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCalendar1_onValueChanged_1(object sender, EventArgs e)
        {
           

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            License license = new License();
          

            sql_con.Open();
            string cmd = "SELECT Nserie FROM License WHERE ID = '1' ";
            string cmd1 = "SELECT AutoN FROM License WHERE ID = '1' ";

            SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);
            SQLiteCommand sql_cmd1 = new SQLiteCommand(cmd1, sql_con);

            string a = sql_cmd.ExecuteScalar().ToString();
            string b = sql_cmd1.ExecuteScalar().ToString();
            sql_con.Close();
            label1.Text = "Licensed to :" + b;
            string hash = Reverse(FingerPrint.Value()) + "-" + "OFPP-" + "\n" + Resizee(FingerPrint.Value()) + FingerPrint.Value() + "20UU";
            MD5 md5Hash = MD5.Create();

            string md5 = GetMd5Hash(md5Hash, hash);

            Debug.WriteLine("aaaa" + a);
            if (a != md5)
            {
                license.ShowDialog();

            }
            
            else login.ShowDialog();



        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray) + "-UPEX-";
        }
        public static string Resizee(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Resize(ref charArray, 15);
            return new string(charArray) + "O2ED-GTH8-YIJK-V89C";
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           /* if (textEdit1.Text == "Admin" && textEdit2.Text == "admin" || textEdit1.Text == "Docteur" && textEdit2.Text == "docteur123")
            {
                ucmodule3.instance.simpleButton9.Enabled = true;
                ucmodule3.instance.simpleButton8.Enabled = true;
                ucmodule3.instance.simpleButton5.Enabled = true;
                popupContainerControl1.Hide();
                usr = 1;
            }

            else if (textEdit1.Text == "sec" && textEdit2.Text == "sec123")
            {
                ucmodule3.instance.simpleButton9.Enabled = false;
                ucmodule3.instance.simpleButton8.Enabled = false;
                ucmodule3.instance.simpleButton5.Enabled = false;
                popupContainerControl1.Hide();
                usr = 1;

            }
            else MessageBox.Show("Wrong");*/
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            animator1.HideSync(label2);
            hyperlinkLabelControl1.Hide();
            login.ShowDialog();
        }

        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            ChangePass change = new ChangePass();
            change.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create a report instance.
            XtraReport1 report = new XtraReport1();

          
            // and show the report's print preview.
            ReportPrintTool pt = new ReportPrintTool(report);
            pt.AutoShowParametersPanel = true;
            pt.ShowPreviewDialog();
        }
    }
}
