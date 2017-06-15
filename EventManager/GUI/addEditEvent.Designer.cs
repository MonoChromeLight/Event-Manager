namespace EventManager.GUI
{
    partial class addEditEvent
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
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.AllowDrop = true;
            this.startDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.CustomFormat = "dd-mm- yyyy";
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(135, 66);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(171, 26);
            this.startDate.TabIndex = 0;
            // 
            // startTime
            // 
            this.startTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTime.CustomFormat = "Time";
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startTime.Location = new System.Drawing.Point(324, 66);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(111, 26);
            this.startTime.TabIndex = 1;
            this.startTime.Value = new System.DateTime(2017, 6, 13, 11, 37, 0, 0);
            // 
            // endDate
            // 
            this.endDate.AllowDrop = true;
            this.endDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.CustomFormat = "dd-mm- yyyy";
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(135, 99);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(171, 26);
            this.endDate.TabIndex = 2;
            // 
            // endTime
            // 
            this.endTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTime.CustomFormat = "Time";
            this.endTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.endTime.Location = new System.Drawing.Point(324, 99);
            this.endTime.Name = "endTime";
            this.endTime.ShowUpDown = true;
            this.endTime.Size = new System.Drawing.Size(111, 26);
            this.endTime.TabIndex = 3;
            this.endTime.Value = new System.DateTime(2017, 6, 13, 11, 37, 0, 0);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(21, 69);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(109, 20);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "Start of event:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnd.Location = new System.Drawing.Point(26, 102);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(103, 20);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "End of event:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(26, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Event name:";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(135, 31);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(160, 20);
            this.txtEvent.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(242, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(367, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // addEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 264);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startDate);
            this.Name = "addEditEvent";
            this.Text = "Event Manager";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}

