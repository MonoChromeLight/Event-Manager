using EventManager.Entities;
using EventManager.Repositories;
using System;
using System.Windows.Forms;

namespace EventManager.GUI
{
    public partial class MainForm : Form
    {
        private EventRepository eventRepository;
        private LocationRepository locationRepository;

        public MainForm(EventRepository eventRepository, LocationRepository locationRepository)
        {
            InitializeComponent();
            this.eventRepository = eventRepository;
            this.locationRepository = locationRepository;

            RefreshLocations();
            LayoutEditEvent();
        }

        private void LayoutEditEvent()
        {
            dataGridViewEvents.Columns[0].Visible = false;
            dataGridViewEvents.Columns[4].Visible = false;
            dataGridViewEvents.Columns[5].Visible = false;
            dataGridViewEvents.Columns[1].HeaderText = "Event Name";
            dataGridViewEvents.Columns[2].HeaderText = "Starts";
            dataGridViewEvents.Columns[3].HeaderText = "Ends";
        }

        private void RefreshLocations()
        {
            bindingSourceLocations.DataSource = locationRepository.GetAll();
            dataGridViewLocations.DataSource = bindingSourceLocations;
        }

        private void RefreshEvents()
        {
            Location location = (Location)bindingSourceLocations.Current;
            if (location==null)
            {
                return;
            }
            bindingSourceEvents.DataSource = eventRepository.GetAll(p => p.LocationID == location.ID);
            dataGridViewEvents.DataSource = bindingSourceEvents;
        }

        private void btnAddNewLocation_Click(object sender, EventArgs e)
        {
            Location location = new Location();
            addEditLocation form = new addEditLocation(location);

            if (form.ShowDialog()==DialogResult.OK)
            {
                locationRepository.Insert(location);
                RefreshLocations();
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            Location location = (Location)bindingSourceLocations.Current;
            if (location==null)
            {
                return;
            }

            addEditLocation form = new addEditLocation(location);
            if (form.ShowDialog()==DialogResult.OK)
            {
                locationRepository.Update(location);
                RefreshLocations();
            }
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            Location location = (Location)bindingSourceLocations.Current;
            if (location == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this location?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                locationRepository.Delete(location);
                RefreshLocations();
            }
        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            Location location = (Location)bindingSourceLocations.Current;
            if (location==null)
            {
                return;
            }

            Event event1 = new Event();
            event1.LocationID = location.ID;

            addEditEvent form = new addEditEvent(event1);
            if (form.ShowDialog()==DialogResult.OK)
            {
                eventRepository.Insert(event1);
                RefreshEvents();
            }
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            Event event1 = (Event)bindingSourceEvents.Current;
            if (event1==null)
            {
                return;
            }

            addEditEvent form = new addEditEvent(event1);
            if (form.ShowDialog()==DialogResult.OK)
            {
                eventRepository.Update(event1);
                RefreshEvents();
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            Event event1 = (Event)bindingSourceEvents.Current;
            if (event1==null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
               "Are you sure you want to delete this event?",
               "Confirmation",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2
               );

            if (result == DialogResult.Yes)
            {
                eventRepository.Delete(event1);
                RefreshEvents();
            }
        }

        private void bindingSourceLocations_CurrentChanged(object sender, EventArgs e)
        {
            RefreshEvents();
        }
    }
}
