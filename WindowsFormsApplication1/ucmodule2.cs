using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1
{
    public partial class ucmodule2 : UserControl
    {
        private static ucmodule2 _instance;

        public static ucmodule2 instance
        {
           get
           {
                if (_instance == null)
                    _instance = new ucmodule2();
                return _instance;
            }
        }
        public ucmodule2()
        {
            InitializeComponent();
            schedulerStorage1.Appointments.Labels.Clear();

            AppointmentLabel a = new AppointmentLabel(Color.LightPink, "Code", "Code");
            AppointmentLabel b = new AppointmentLabel(Color.Yellow, "Créneau", "Créneau");
            AppointmentLabel d = new AppointmentLabel(Color.FromArgb(92, 229, 232)," Conduite","Conduite");
            schedulerStorage1.Appointments.Labels.Add(a);
            schedulerStorage1.Appointments.Labels.Add(b);
            schedulerStorage1.Appointments.Labels.Add(d);

            schedulerStorage1.TimeZoneId = TimeZoneInfo.Local.Id;
            schedulerControl1.OptionsBehavior.ClientTimeZoneId= TimeZoneInfo.Local.Id;
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
               comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
            }

        }
        


        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void ucmodule2_Load(object sender, EventArgs e)
        {
           // clientTableAdapter2.Fill(inventoryDataSet9.Client);

            //   this.appointmentsTableAdapter.Fill(zazaDataSet.Appointments);
            this.appointmentsTableAdapter.Fill(appoint.Appointments);
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


        }

       
       

        private void dateNavigator1_Click(object sender, EventArgs e)
        {

        }

        private void toggleRecurrenceItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                    }

        private void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            clientTableAdapter2.Update(inventoryDataSet9);
            inventoryDataSet9.AcceptChanges();

            appointmentsTableAdapter.Update(appoint);
            appoint.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            clientTableAdapter2.Update(inventoryDataSet9);
            inventoryDataSet9.AcceptChanges();

            appointmentsTableAdapter.Update(appoint);
            appoint.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            clientTableAdapter2.Update(inventoryDataSet9);
            inventoryDataSet9.AcceptChanges();
            appointmentsTableAdapter.Update(appoint);
            appoint.AcceptChanges();
            appointmentsTableAdapter.Fill(appoint.Appointments);
            
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            WindowsFormsApplication1.CustomAppointmentForm form = new WindowsFormsApplication1.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            schedulerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            ComboBoxEdit comboBox = sender as ComboBoxEdit;
            string skinName = comboBox.Text;
            switch (skinName)
            {
                case "Default Skin":
                   
                    
                    schedulerControl1.LookAndFeel.SkinName = "DevExpress Style";
                    break;
                case "Default Dark Skin":
                    schedulerControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
                    break;
                default:
                    schedulerControl1.LookAndFeel.SkinName = skinName;
                    break;
            }
        }
    }
}
