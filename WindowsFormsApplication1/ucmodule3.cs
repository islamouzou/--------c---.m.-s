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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.EditForm.Helpers.Controls;
using System.Data.SQLite;
using System.IO;
using System.Collections.Specialized;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace WindowsFormsApplication1
{
    public partial class ucmodule3 : UserControl
    {
        private SQLiteConnection sql_con;

        private static ucmodule3 _instance;

        public static ucmodule3 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucmodule3();
                return _instance;
            }
        }
        public ucmodule3()
        {
            InitializeComponent();
            
            sql_con = new SQLiteConnection
               ("Data Source=inventory.sqlite;Version=3");
            gridView1.OptionsEditForm.CustomEditFormLayout = new EditForm();
           // popupContainerControl1.Dock = DockStyle.Fill;
            this.clientTableAdapter.Fill(this.inventoryDataSet12.Client);
            this.carriereTableAdapter1.Fill(this.inventoryDataSet12.Carriere);
            this.dwaTableAdapter.Fill(this.inventoryDataSet13.Dwa);
            this.conTableAdapter1.Fill(this.inventoryDataSet12.Con);
            this.con_PTableAdapter1.Fill(this.inventoryDataSet12.Con_P);
            accident_tTableAdapter.Fill(inventoryDataSet12.Accident_t);
            vaccinationsTableAdapter.Fill(inventoryDataSet12.vaccinations);
            a_PTableAdapter.Fill(inventoryDataSet12.A_P);

            tabNavigationPage5.Enabled = false;
            gridControl1.DataSource = inventoryDataSet12.Client;
            gridControl3.DataSource = inventoryDataSet12.Client;
            gridControl3.DataMember = "FK_Carriere_0_0";
           gridControl2.DataSource = inventoryDataSet12.Client;
            gridControl2.DataMember = "FK_Con_0_0";
            gridControl4.DataSource = inventoryDataSet12.Client;
            gridControl4.DataMember = "FK_Con_p_0_0";
            accidentControl5.DataSource = inventoryDataSet12.Client;
            accidentControl5.DataMember = "FK_Accident_t_0_0";
            vaccinControl6.DataSource = inventoryDataSet12.Client;
            vaccinControl6.DataMember = "FK_vaccinations_0_0";

            popupContainerControl1.Dock = DockStyle.Fill;
            popupContainerControl2.Dock = DockStyle.Fill;
            popupContainerControl3.Dock = DockStyle.Fill;
            popupContainerControl5.Dock = DockStyle.Fill;



        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void bunifuCustomDataGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            AddClient_frm add = new AddClient_frm();
            add.ShowDialog();
        }
       


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            gridView1.DeleteSelectedRows();

           ColumnView View = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.FocusedView;
            if (!(View.PostEditor() && View.UpdateCurrentRow())) return;
            try
            {
                clientTableAdapter.Update(inventoryDataSet12.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            gridView1.ShowEditForm();

        }





        private static void ChangeButtonCaption(SimpleButton btn)
        {
            var newUpdateBtnText = "Enregistrer";
            var newCancelBtnText = "Annuler";
            var btnText = btn.Text;
            switch (btnText)
            {
                case "Update":
                    btn.Text = newUpdateBtnText;
                    break;
                case "Cancel":
                    btn.Text = newCancelBtnText;
                    break;
            }
        }
        private static void ChangeButtonSize(SimpleButton btn)
        {
            btn.CalcBestSize();
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            clientTableAdapter.Update(inventoryDataSet12.Client);

        }

        private void gridView1_ShowingPopupEditForm_1(object sender, DevExpress.XtraGrid.Views.Grid.ShowingPopupEditFormEventArgs e)
        {
            foreach (Control control in e.EditForm.Controls)
            {
                if (!(control is EditFormContainer))
                {
                    continue;
                }
                foreach (Control nestedControl in control.Controls)
                {
                    if (!(nestedControl is PanelControl))
                    {
                        continue;
                    }
                    foreach (Control button in nestedControl.Controls)
                    {
                        if (button is SimpleButton)
                        {
                            var simpleButton = button as SimpleButton;
                            ChangeButtonCaption(simpleButton);
                            ChangeButtonSize(simpleButton);
                        }
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            /*AddClient_frm add = new AddClient_frm();
            add.ShowDialog();*/
            popupContainerControl1.Show();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //gridView1.ShowEditForm();
            PatientDetail patient = new PatientDetail(this);
            patient.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();

            ColumnView View = (DevExpress.XtraGrid.Views.Base.ColumnView)gridControl1.FocusedView;
            if (!(View.PostEditor() && View.UpdateCurrentRow())) return;
            try
            {
                clientTableAdapter.Update(inventoryDataSet12.Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            popupContainerControl1.Hide();
        }

        private void RessourceIDTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void add_client(string cmd)
        {
            sql_con.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);

            //   byte[] file = (byte[]) photoPictureEdit.EditValue;



            sql_cmd.Parameters.AddWithValue("nom", nomTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("prénom", prénomTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("sexe", sexeTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("datei", date_naissanceTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("lieu", lieuTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("grade", gradeTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("adress", adressTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("groupage", groupageTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("wilaya", wilayaTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("taille", textEdit1.Text);
            sql_cmd.Parameters.AddWithValue("poids", textEdit2.Text);



            /*sql_cmd.Parameters.AddWithValue("dater", date_recrutementTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("formation_s", formation_scolaireTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("formation_p", formation_professionnelleTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("act_pro", act_proTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("service", service_nationalTextEdit.Text);*/

            // SQLiteParameter param = new SQLiteParameter("@photo", System.Data.DbType.Binary);
            //  param.Value = file;
            //  sql_cmd.Parameters.Add(param);
            sql_cmd.Parameters.AddWithValue("photo", photoPictureEdit.EditValue);


            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void add_car(string cmd)
        {
            sql_con.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);

            //   byte[] file = (byte[]) photoPictureEdit.EditValue;



            sql_cmd.Parameters.AddWithValue("date_recrutement", textEdit11.Text);
            sql_cmd.Parameters.AddWithValue("formation_s", textEdit12.Text);
            sql_cmd.Parameters.AddWithValue("formation_p", textEdit13.Text);
            sql_cmd.Parameters.AddWithValue("act_pro", textEdit14.Text);
            sql_cmd.Parameters.AddWithValue("service", textEdit15.Text);
            sql_cmd.Parameters.AddWithValue("id", gridView1.GetFocusedRowCellValue(colID_client));


           /* date_recrutement, formation_s, formation_p, act_pro,service*/


            /*sql_cmd.Parameters.AddWithValue("dater", date_recrutementTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("formation_s", formation_scolaireTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("formation_p", formation_professionnelleTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("act_pro", act_proTextEdit.Text);
            sql_cmd.Parameters.AddWithValue("service", service_nationalTextEdit.Text);*/

            // SQLiteParameter param = new SQLiteParameter("@photo", System.Data.DbType.Binary);
            //  param.Value = file;
            //  sql_cmd.Parameters.Add(param);
            sql_cmd.Parameters.AddWithValue("photo", photoPictureEdit.EditValue);

            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void ucmodule3_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {

            popupContainerControl2.Show();
            popupContainerControl1.Hide();

            //  bool isValid = dxValidationProvider1.Validate();

            string cmd = "INSERT INTO Client (nom,prénom,sexe,date_naissance,lieu,grade,adress,groupage,wilaya,photo,taille,poids) VALUES (@nom, @prénom, @sexe, @datei, @lieu, @grade, @adress, @groupage, @wilaya, @photo, @taille, @poids )";

            /*            string cmd = "INSERT INTO Client (nom, prénom, adress, date_inscription, date_naissance, paiement, id_cours, Id_examen, papier1, papier2, papier3, photo) VALUES ('52','1','2','3','5','6','7','8','9','10','11','12')";
*/

            //  if (isValid)
            // {
            add_client(cmd);
            //   ucmodule3.instance.clientTableAdapter.Fill(ucmodule3.instance.inventoryDataSet12.Client);
            clientTableAdapter.Fill(inventoryDataSet12.Client);
            gridView1.MoveLast();
            popupContainerControl1.Hide();

            // }

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {

            carriereTableAdapter1.Update(inventoryDataSet12.Carriere);
            string cmd = "INSERT INTO Crrière_a (id_client, date_recrutement, formation_s, formation_p, act_pro,service ) VALUES (@id, @date_recrutement, @formation_s, @formation_p, @act_pro, @service ) ";
            add_car(cmd);
            crrière_aTableAdapter1.Update(inventoryDataSet12.Crrière_a);
            tabNavigationPage5.Enabled = true;
            tabPane2.SelectedPage = tabNavigationPage5;
            tabNavigationPage4.Enabled = false;
 
        } 

        private void simpleButton6_Click_1(object sender, EventArgs e)
        {
           
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            label8.Text = gridView1.GetFocusedRowCellValue(coltaille).ToString();
            label9.Text = gridView1.GetFocusedRowCellValue(colpoids).ToString();
            if (gridView1.GetFocusedRowCellValue(coltaille).ToString() != "")
            {
                double taille = Convert.ToDouble(gridView1.GetFocusedRowCellValue(coltaille).ToString());
                double poids = Convert.ToDouble(gridView1.GetFocusedRowCellValue(colpoids).ToString());
                double imc = poids / (taille * taille);
                double pideal = 22 * (taille * taille); 
                if (imc < 16.5) label10.Text = "Dénutrition";
                else if (imc > 16.5 && imc < 18.5) label10.Text = "État de maigreur";
                else if (imc > 18.5 && imc < 25) label10.Text = "Corpulence normale";
                else if (imc > 25 && imc < 30) label10.Text = "Surpoids";
                else if (imc > 30 && imc < 35) label10.Text = "Obèsité modérée";
                else if (imc > 35 && imc < 40) label10.Text = "Obèsité sévère";
                else if (imc > 40 ) label10.Text = "Obèsité morbide";
                label11.Text = Convert.ToString(pideal);

            }
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
                
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            vaccinationsTableAdapter.Update(inventoryDataSet12.vaccinations);
            accident_tTableAdapter.Update(inventoryDataSet12.Accident_t);
            string cmd = "INSERT INTO A_P (id_client, ac, mg, ic, acc, int, mp, mcp, af ) VALUES (@id_client, @ac, @mg, @ic, @acc, @int, @mp, @mcp, @af ) ";
            add_Ap(cmd);
            a_PTableAdapter.Update(inventoryDataSet12.A_P);
            popupContainerControl2.Hide();
            tabNavigationPage5.Enabled = false;
            tabPane2.SelectedPage = tabNavigationPage5;
            tabNavigationPage4.Enabled = true;
        }

        private void add_Ap(string cmd)
        {
            sql_con.Open();
            SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);

            sql_cmd.Parameters.AddWithValue("id_client", gridView1.GetFocusedRowCellValue(colID_client));
            sql_cmd.Parameters.AddWithValue("ac", textBox1.Text);
            sql_cmd.Parameters.AddWithValue("mg", textBox2.Text);
            sql_cmd.Parameters.AddWithValue("ic", textBox3.Text);
            sql_cmd.Parameters.AddWithValue("acc", textBox4.Text);
            sql_cmd.Parameters.AddWithValue("int", textBox5.Text);
            sql_cmd.Parameters.AddWithValue("mp", textBox6.Text);
            sql_cmd.Parameters.AddWithValue("mcp", textBox7.Text);
            sql_cmd.Parameters.AddWithValue("af", textBox8.Text);

            sql_cmd.Parameters.AddWithValue("photo", photoPictureEdit.EditValue);

            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            popupContainerControl3.Show();
            filesTableAdapter.Fill(inventoryDataSet12.files);
            List<string> lines = new List<string>();
            var source = new StringCollection();
            // 2
            // Use using StreamReader for disposing.
            using (var r = new StringReader(WindowsFormsApplication1.Properties.Resources.maladi))
            {

                // 3
                // Use while != null pattern for loop
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    // 4
                    // Insert logic here.
                    // ...
                    // "line" is a line in the file. Add it to our List.
                    lines.Add(line + "." + "\n");



                }
                autocompleteMenu1.SetAutocompleteItems(lines);
            }
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            sql_con.Open();
            var id = (long)gridView1.GetFocusedRowCellValue(colID_client);
            conTableAdapter1.Insert(id , dateEdit1.Text,richTextBox1.Text,richTextBox5.Text,richTextBox4.Text,richTextBox3.Text,richTextBox2.Text,"");
            conTableAdapter1.Update(inventoryDataSet12.Con);
            conTableAdapter1.Fill(inventoryDataSet12.Con);
            gridView2.MoveLast();
            string cmd = "INSERT INTO Tratement (id_con, medic, dose, temp, durée ) VALUES (@id_con, @medic, @dose, @temp, @durée ) ";
           
            add_con(cmd);
            popupContainerControl3.Hide();
           
        }
         
        private void add_con(string cmd)
        {
          
            SQLiteCommand sql_cmd = new SQLiteCommand(cmd, sql_con);

            if (lookUpEdit1.Text != "Veuillez choisir un médicament")
            {
               

                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit1.Text);
                sql_cmd.Parameters.AddWithValue("dose", a1.Text);
                sql_cmd.Parameters.AddWithValue("temp", b1.Text);
                sql_cmd.Parameters.AddWithValue("durée", c1.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            if (lookUpEdit2.Text != "Veuillez choisir un médicament") {
                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_con.Open();
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit2.Text);
                sql_cmd.Parameters.AddWithValue("dose", a2.Text);
                sql_cmd.Parameters.AddWithValue("temp", b2.Text);
                sql_cmd.Parameters.AddWithValue("durée", c2.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            if (lookUpEdit3.Text != "Veuillez choisir un médicament")
            {
                sql_con.Open();
                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit3.Text);
                sql_cmd.Parameters.AddWithValue("dose", a3.Text);
                sql_cmd.Parameters.AddWithValue("temp", b3.Text);
                sql_cmd.Parameters.AddWithValue("durée", c3.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            if (lookUpEdit4.Text != "Veuillez choisir un médicament")
            {
                sql_con.Open();
                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit4.Text);
                sql_cmd.Parameters.AddWithValue("dose", a4.Text);
                sql_cmd.Parameters.AddWithValue("temp", b4.Text);
                sql_cmd.Parameters.AddWithValue("durée", c4.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            if (lookUpEdit5.Text != "Veuillez choisir un médicament")
            {
                sql_con.Open();
                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit5.Text);
                sql_cmd.Parameters.AddWithValue("dose", a5.Text);
                sql_cmd.Parameters.AddWithValue("temp", b5.Text);
                sql_cmd.Parameters.AddWithValue("durée", c5.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
            if (lookUpEdit6.Text != "Veuillez choisir un médicament")
            {
                sql_con.Open();
                sql_cmd.Parameters.AddWithValue("id_con", gridView2.GetFocusedRowCellValue(colid));
                sql_cmd.Parameters.AddWithValue("medic", lookUpEdit6.Text);
                sql_cmd.Parameters.AddWithValue("dose", a6.Text);
                sql_cmd.Parameters.AddWithValue("temp", b6.Text);
                sql_cmd.Parameters.AddWithValue("durée", c6.Text);

                sql_cmd.ExecuteNonQuery();
                sql_con.Close();
            }
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            XtraReport1 report = new XtraReport1();
            /*  report.xrLabel5.Text=
              report.xrLabel6.Text =
              report.xrLabel7.Text =
              report.xrLabel8.Text =
              report.xrLabel9.Text =
              report.xrLabel10.Text =*/
            List<string> str = new List<string>();
            SQLiteConnection con = new SQLiteConnection(@"Data source=C:\Users\Zou\OneDrive - Association Cesi Viacesi mail\Projects\CMS\Auto - Copie\WindowsFormsApplication1\bin\Debug\inventory.sqlite;Version=3");
            SQLiteCommand com = new SQLiteCommand("SELECT  * from Tratement where id_con = @id", con);
            com.Parameters.AddWithValue("id", gridView2.GetFocusedRowCellValue(colid));
            SQLiteDataAdapter sda = new SQLiteDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            foreach (DataRow dr in dt.Rows)
            {
                str.Add(dr["medic"].ToString() + "  "+dr["dose"].ToString() + "  "+dr["temp"].ToString() + dr["durée"].ToString());
         
            }
            for (int i =0; i<str.Count;i++)
            {
                report.xrLabel5.Text += str[i] +"\n\n\n\n";
            }
           
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            popupContainerControl5.Show();
            memoEdit1.Text = gridView2.GetFocusedRowCellValue(colmotif).ToString();
            memoEdit2.Text = gridView2.GetFocusedRowCellValue(colex_clinique).ToString();
            memoEdit3.Text = gridView2.GetFocusedRowCellValue(colex_paraclinique).ToString();
            memoEdit4.Text = gridView2.GetFocusedRowCellValue(coldiagnostic).ToString();


        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            popupContainerControl5.Show();
            memoEdit1.Text = gridView2.GetFocusedRowCellValue(colmotif).ToString();
            memoEdit2.Text = gridView2.GetFocusedRowCellValue(colex_clinique).ToString();
            memoEdit3.Text = gridView2.GetFocusedRowCellValue(colex_paraclinique).ToString();
            memoEdit4.Text = gridView2.GetFocusedRowCellValue(coldiagnostic).ToString();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            popupContainerControl5.Hide();
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            Consultation_P con_p = new Consultation_P(this);
            con_p.ShowDialog();
        }
    }
}
