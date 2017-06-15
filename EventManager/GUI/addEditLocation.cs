using EventManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager.GUI
{
    public partial class addEditLocation : Form
    {
        private Location location;
        public addEditLocation(Location location)
        {
            InitializeComponent();
            this.location = location;
        }

        private void addEditLocaton_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0} Location - Manager", location.ID > 0 ? "Update" : "Add");

            txtLocation.Text = location.LocationName;
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            location.LocationName = txtLocation.Text;

            this.DialogResult = DialogResult.OK;
        }
    }
}




