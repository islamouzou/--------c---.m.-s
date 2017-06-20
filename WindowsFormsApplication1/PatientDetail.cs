using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PatientDetail : Form
    {
        int id;
        ucmodule3 a;
        public PatientDetail(ucmodule3 uc)
        {
            InitializeComponent();

            a = uc;

            gridView1.NewItemRowText = "Cliquez ici pour ajouter ";
            gridView2.NewItemRowText = "Cliquez ici pour ajouter ";

            gridView3.NewItemRowText = "Cliquez ici pour ajouter ";




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void PatientDetail_Load(object sender, EventArgs e)
        {
             id = Convert.ToInt32(a.gridView1.GetFocusedRowCellValue(a.colID_client).ToString());
            // TODO: This line of code loads data into the 'inventoryDataSet12.vaccinations' table. You can move, or remove it, as needed.
            this.vaccinationsTableAdapter.FillBy(this.inventoryDataSet12.vaccinations, id);
            // TODO: This line of code loads data into the 'inventoryDataSet12.Accident_t' table. You can move, or remove it, as needed.
            this.accident_tTableAdapter.FillBy(this.inventoryDataSet12.Accident_t, id);
            // TODO: This line of code loads data into the 'inventoryDataSet12.Carriere' table. You can move, or remove it, as needed.
            this.carriereTableAdapter.FillBy(this.inventoryDataSet12.Carriere, id);
            // TODO: This line of code loads data into the 'inventoryDataSet12.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.inventoryDataSet12.Client);
            // TODO: This line of code loads data into the 'inventoryDataSet12.Con' table. You can move, or remove it, as needed.
            pictureEdit2.EditValue = a.gridView1.GetFocusedRowCellValue(a.colphoto);
            label11.Text = a.gridView1.GetFocusedRowCellValue(a.colnom).ToString();
            label15.Text = a.gridView1.GetFocusedRowCellValue(a.colprénom).ToString();
            label12.Text = a.gridView1.GetFocusedRowCellValue(a.colsexe).ToString();
            label13.Text = a.gridView1.GetFocusedRowCellValue(a.coldate_naissance).ToString();
            label14.Text = a.gridView1.GetFocusedRowCellValue(a.collieu).ToString();
            label16.Text = a.gridView1.GetFocusedRowCellValue(a.colsituation).ToString();
            label17.Text = a.gridView1.GetFocusedRowCellValue(a.coladress).ToString();
            label18.Text = a.gridView1.GetFocusedRowCellValue(a.colwilaya).ToString();
            label19.Text = a.gridView1.GetFocusedRowCellValue(a.colgrade).ToString();
            label20.Text = a.gridView1.GetFocusedRowCellValue(a.colgroupage).ToString();
            label23.Text = a.gridView1.GetFocusedRowCellValue(a.coltaille).ToString();
            label24.Text = a.gridView1.GetFocusedRowCellValue(a.colpoids).ToString();
            // Debug.Write("hhh" + Convert.ToInt32(a.gridView1.GetFocusedRowCellValue(a.colID_client).ToString()));


        }

       

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["id_client"], id);

        }

       

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            accident_tTableAdapter.Update(inventoryDataSet12.Accident_t);
            this.accident_tTableAdapter.FillBy(this.inventoryDataSet12.Accident_t, id);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            vaccinationsTableAdapter.Update(inventoryDataSet12.vaccinations);
            this.vaccinationsTableAdapter.FillBy(this.inventoryDataSet12.vaccinations, id);
        }

        private void gridView3_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["id_client"], id);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            carriereTableAdapter.Update(inventoryDataSet12.Carriere);
            carriereTableAdapter.FillBy(inventoryDataSet12.Carriere, id);
        }
        

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["id_client"], id);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
