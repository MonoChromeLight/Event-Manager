using EventManager.Entities;
using System;
using System.Windows.Forms;

namespace EventManager.GUI
{
    public partial class addEditEvent : Form
    {

        private Event event1;

        public addEditEvent(Event event1)
        {
            InitializeComponent();
            this.event1 = event1;
        }

        private void FormAddEditPhone_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} Event - Manager", event1.ID > 0 ? "Update" : "Add");

           txtEvent.Text = event1.Name;
           startDate.Value = event1.Start;
           endDate.Value = event1.End;
           startTime.Value = event1.Start;
           endTime.Value = event1.End;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            event1.Name = txtEvent.Text;
            event1.Start = startDate.Value;
            event1.Start = startTime.Value;
            event1.End = endDate.Value;
            event1.End = endTime.Value;
            this.DialogResult = DialogResult.OK;
        }
    }
}
