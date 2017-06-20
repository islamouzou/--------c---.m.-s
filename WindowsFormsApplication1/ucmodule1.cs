using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Timers;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;

namespace WindowsFormsApplication1
{
    public partial class ucmodule1 : UserControl
    {
        private static int adel =1 ;
        private static int adel1 = 0;
        static int ab = 1;
        private static ucmodule1 _instance;
        int lockTimerCounter = 0;

        public static ucmodule1 instance 
        {
            
            get
           {
                if (_instance == null)
                    _instance = new ucmodule1();
                return _instance;
                
            }
            
        }

        public ucmodule1()
        {
            InitializeComponent();

           // clientTableAdapter.Fill(this.ucmodule1Set.Client);
            timer1.Start();
            timer2.Start();
           


        }
        void OnTimerTick(object sender, EventArgs e)
        {
            if (lockTimerCounter == 0)
            {
                lockTimerCounter++;
                UpdateTime();
                lockTimerCounter--;
            }
        }
        int GetStringLength(string str)
        {
            int counter = 0;
            int pos = 0;
            while (pos < str.Length)
            {
                if (str[pos] != ':')
                    counter++;
                pos++;
            }
            return counter;
        }
        void UpdateTime()
        {
            string time = DateTime.Now.ToLongTimeString();
            if (GetStringLength(time) > digitalGauge1.DigitCount)
                digitalGauge1.DigitCount = GetStringLength(time);
            digitalGauge1.Text = time;
        }


        private void tabPane1_Click(object sender, EventArgs e)
        {
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {
            
        }

        private void tileView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowindex = e.ListSourceRowIndex;
            int label = Convert.ToInt16(tileView2.GetListSourceRowCellValue(rowindex, "Label"));
            if (e.Column.FieldName != "tileViewColumn1") return;
            if (e.IsGetData)  {

                if (label == 1)
                {
                    e.Value = "Créneau";
                }
                if (label == 0)
                {
                    e.Value = "Code";
                }
                if (label == 2)
                {
                    e.Value = "Conduite";
                }
            }
        }

        private void tileView2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            OnTimerTick(null, null);
        }


        void OnTimerTick1(object sender, EventArgs e)
        {

            adel1 = tileView2.Position;
           
           

            if (ab < 0) { 
                tileView2.Position -= 1;
            }
            if (ab > 0)
            {
                tileView2.Position += 1;
            }
            

            adel = tileView2.Position;

            if (adel == adel1)
            {
                ab *= (-1);
            }
            Debug.WriteLine("adel  " + adel);
            Debug.WriteLine("adel1   " + adel1);
        }
        

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            OnTimerTick1(null, null);
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value == true)
            {
                timer2.Start();
            }
            else timer2.Stop();
        }

        private void ucmodule1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
