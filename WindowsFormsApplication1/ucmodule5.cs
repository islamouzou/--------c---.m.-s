using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ucmodule5 : UserControl
    {

        private static ucmodule5 _instance;

        public static ucmodule5 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucmodule5();
                return _instance;
            }
        }

        public ucmodule5()
        {
            InitializeComponent();
            pictureEdit1.Properties.ContextMenuStrip = new ContextMenuStrip();

            
            clientTableAdapter.Fill(inventoryDataSet11.Client);
            examenTableAdapter.Fill(inventoryDataSet11.Examen);

            gridControl1.DataSource = inventoryDataSet11.Client;
            gridControl2.DataSource = inventoryDataSet11.Client;
            gridControl2.DataMember = "FK_Examen_0_0";

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            label1.Text = gridView1.GetFocusedRowCellValue(colnom).ToString() + " " + gridView1.GetFocusedRowCellValue(colprénom).ToString();
            label3.Text = gridView1.GetFocusedRowCellValue(coladress).ToString();
            label4.Text = gridView1.GetFocusedRowCellValue(coldate_naissance).ToString();
            pictureEdit1.EditValue = gridView1.GetFocusedRowCellValue(colphoto);
            popupContainerControl1.Show();





        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            popupContainerControl1.Hide();
        }
    }
}
