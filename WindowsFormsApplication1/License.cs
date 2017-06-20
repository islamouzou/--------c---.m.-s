using Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class License : Form
    {
        private SQLiteConnection sql_con;
        private string md5;

        public License()
        {

            InitializeComponent();
            sql_con = new SQLiteConnection
             ("Data Source=lic.sqlite;Version=3");

            label1.Text = FingerPrint.Value();
            string hash = Reverse(FingerPrint.Value()) + "-" + "OFPP-" + "\n" + Resizee(FingerPrint.Value()) + label1.Text + "20UU";
            MD5 md5Hash = MD5.Create();

                md5 = GetMd5Hash(md5Hash,hash);


            memoEdit1.Text = md5;
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string  (charArray ) +"-UPEX-";
        }
        public static string Resizee(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Resize(ref charArray , 15);
            return new string(charArray) + "O2ED-GTH8-YIJK-V89C";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            

            if (textEdit1.Text == md5)
            {
                sql_con.Open();
                string cmd = "UPDATE  License  SET Nserie = (@nserie), Nom =(@nom) , AutoN=(@auton) where ID = '1'";

                SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);
                sql_cmd.Parameters.AddWithValue("nserie", textEdit1.Text);
                sql_cmd.Parameters.AddWithValue("nom", textEdit3.Text);
                sql_cmd.Parameters.AddWithValue("auton", textEdit2.Text);


                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
                Close();
            }
            else MessageBox.Show("Code d'activattion invalide"); 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void License_Load(object sender, EventArgs e)
        {

        }
    }
}
