namespace EventManager.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripLocations = new System.Windows.Forms.ToolStrip();
            this.btnAddNewLocation = new System.Windows.Forms.ToolStripButton();
            this.btnEditLocation = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteLocation = new System.Windows.Forms.ToolStripButton();
            this.bindingSourceEvents = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceLocations = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewLocations = new System.Windows.Forms.DataGridView();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.toolStripEvents = new System.Windows.Forms.ToolStrip();
            this.btnAddNewEvent = new System.Windows.Forms.ToolStripButton();
            this.btnEditEvent = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEvent = new System.Windows.Forms.ToolStripButton();
            this.toolStripLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            this.toolStripEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLocations
            // 
            this.toolStripLocations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewLocation,
            this.btnEditLocation,
            this.btnDeleteLocation});
            this.toolStripLocations.Location = new System.Drawing.Point(0, 0);
            this.toolStripLocations.Name = "toolStripLocations";
            this.toolStripLocations.Size = new System.Drawing.Size(677, 25);
            this.toolStripLocations.TabIndex = 0;
            this.toolStripLocations.Text = "toolStrip1";
            // 
            // btnAddNewLocation
            // 
            this.btnAddNewLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddNewLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewLocation.Image")));
            this.btnAddNewLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewLocation.Name = "btnAddNewLocation";
            this.btnAddNewLocation.Size = new System.Drawing.Size(33, 22);
            this.btnAddNewLocation.Text = "Add";
            this.btnAddNewLocation.Click += new System.EventHandler(this.btnAddNewLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnEditLocation.Image")));
            this.btnEditLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(31, 22);
            this.btnEditLocation.Text = "Edit";
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLocation.Image")));
            this.btnDeleteLocation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(44, 22);
            this.btnDeleteLocation.Text = "Delete";
            this.btnDeleteLocation.ToolTipText = "toolStripButton1";
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // bindingSourceLocations
            // 
            this.bindingSourceLocations.CurrentChanged += new System.EventHandler(this.bindingSourceLocations_CurrentChanged);
            // 
            // dataGridViewLocations
            // 
            this.dataGridViewLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewLocations.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewLocations.Name = "dataGridViewLocations";
            this.dataGridViewLocations.Size = new System.Drawing.Size(677, 125);
            this.dataGridViewLocations.TabIndex = 1;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEvents.Location = new System.Drawing.Point(0, 178);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.Size = new System.Drawing.Size(677, 132);
            this.dataGridViewEvents.TabIndex = 2;
            // 
            // toolStripEvents
            // 
            this.toolStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddNewEvent,
            this.btnEditEvent,
            this.btnDeleteEvent});
            this.toolStripEvents.Location = new System.Drawing.Point(0, 150);
            this.toolStripEvents.Name = "toolStripEvents";
            this.toolStripEvents.Size = new System.Drawing.Size(677, 25);
            this.toolStripEvents.TabIndex = 4;
            this.toolStripEvents.Text = "toolStrip2";
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAddNewEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewEvent.Image")));
            this.btnAddNewEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(33, 22);
            this.btnAddNewEvent.Text = "Add";
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEditEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnEditEvent.Image")));
            this.btnEditEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(31, 22);
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeleteEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEvent.Image")));
            this.btnDeleteEvent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(44, 22);
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.ToolTipText = "toolStripButton1";
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 310);
            this.Controls.Add(this.toolStripEvents);
            this.Controls.Add(this.dataGridViewEvents);
            this.Controls.Add(this.dataGridViewLocations);
            this.Controls.Add(this.toolStripLocations);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.toolStripLocations.ResumeLayout(false);
            this.toolStripLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            this.toolStripEvents.ResumeLayout(false);
            this.toolStripEvents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripLocations;
        private System.Windows.Forms.ToolStripButton btnAddNewLocation;
        private System.Windows.Forms.BindingSource bindingSourceEvents;
        private System.Windows.Forms.BindingSource bindingSourceLocations;
        private System.Windows.Forms.ToolStripButton btnEditLocation;
        private System.Windows.Forms.ToolStripButton btnDeleteLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocations;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.ToolStrip toolStripEvents;
        private System.Windows.Forms.ToolStripButton btnAddNewEvent;
        private System.Windows.Forms.ToolStripButton btnEditEvent;
        private System.Windows.Forms.ToolStripButton btnDeleteEvent;
    }
}