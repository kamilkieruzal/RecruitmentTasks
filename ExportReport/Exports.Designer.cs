namespace ExportReport
{
    partial class Exports
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ExportName = new DevExpress.XtraGrid.Columns.GridColumn();
            Date = new DevExpress.XtraGrid.Columns.GridColumn();
            Time = new DevExpress.XtraGrid.Columns.GridColumn();
            UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            Location = new DevExpress.XtraGrid.Columns.GridColumn();
            dateFromEdit = new DevExpress.XtraEditors.DateEdit();
            dateToEdit = new DevExpress.XtraEditors.DateEdit();
            locationLabel = new DevExpress.XtraEditors.LabelControl();
            dateFromLabel = new DevExpress.XtraEditors.LabelControl();
            dateToLabel = new DevExpress.XtraEditors.LabelControl();
            confirm = new DevExpress.XtraEditors.SimpleButton();
            back = new DevExpress.XtraEditors.SimpleButton();
            next = new DevExpress.XtraEditors.SimpleButton();
            locationCb = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFromEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateToEdit.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationCb.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Location = new Point(232, 12);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(756, 576);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ExportName, Date, Time, UserName, Location });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ExportName
            // 
            ExportName.Caption = "Nazwa";
            ExportName.FieldName = "Name";
            ExportName.Name = "ExportName";
            ExportName.Visible = true;
            ExportName.VisibleIndex = 0;
            ExportName.Width = 108;
            // 
            // Date
            // 
            Date.Caption = "Data";
            Date.FieldName = "Date";
            Date.Name = "Date";
            Date.Visible = true;
            Date.VisibleIndex = 1;
            Date.Width = 102;
            // 
            // Time
            // 
            Time.Caption = "Godzina";
            Time.FieldName = "Time";
            Time.Name = "Time";
            Time.Visible = true;
            Time.VisibleIndex = 2;
            Time.Width = 102;
            // 
            // UserName
            // 
            UserName.Caption = "Użytkownik";
            UserName.FieldName = "UserName";
            UserName.Name = "UserName";
            UserName.Visible = true;
            UserName.VisibleIndex = 3;
            UserName.Width = 102;
            // 
            // Location
            // 
            Location.Caption = "Lokal";
            Location.FieldName = "Location";
            Location.Name = "Location";
            Location.Visible = true;
            Location.VisibleIndex = 4;
            Location.Width = 117;
            // 
            // dateFromEdit
            // 
            dateFromEdit.EditValue = null;
            dateFromEdit.Location = new Point(12, 123);
            dateFromEdit.Name = "dateFromEdit";
            dateFromEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFromEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFromEdit.Size = new Size(214, 20);
            dateFromEdit.TabIndex = 3;
            // 
            // dateToEdit
            // 
            dateToEdit.EditValue = null;
            dateToEdit.Location = new Point(12, 179);
            dateToEdit.Name = "dateToEdit";
            dateToEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateToEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateToEdit.Size = new Size(214, 20);
            dateToEdit.TabIndex = 4;
            // 
            // locationLabel
            // 
            locationLabel.Location = new Point(12, 40);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(24, 13);
            locationLabel.TabIndex = 13;
            locationLabel.Text = "Lokal";
            // 
            // dateFromLabel
            // 
            dateFromLabel.Location = new Point(12, 104);
            dateFromLabel.Name = "dateFromLabel";
            dateFromLabel.Size = new Size(14, 13);
            dateFromLabel.TabIndex = 5;
            dateFromLabel.Text = "Od";
            // 
            // dateToLabel
            // 
            dateToLabel.Location = new Point(12, 160);
            dateToLabel.Name = "dateToLabel";
            dateToLabel.Size = new Size(13, 13);
            dateToLabel.TabIndex = 6;
            dateToLabel.Text = "Do";
            // 
            // confirm
            // 
            confirm.Location = new Point(12, 525);
            confirm.Name = "confirm";
            confirm.Size = new Size(214, 23);
            confirm.TabIndex = 7;
            confirm.Text = "Zatwierdź";
            confirm.Click += confirm_Click;
            // 
            // back
            // 
            back.Location = new Point(12, 565);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 8;
            back.Text = "Wstecz";
            back.Click += back_Click;
            // 
            // next
            // 
            next.Location = new Point(151, 565);
            next.Name = "next";
            next.Size = new Size(75, 23);
            next.TabIndex = 9;
            next.Text = "Dalej";
            next.Click += next_Click;
            // 
            // locationCb
            // 
            locationCb.Location = new Point(12, 59);
            locationCb.Name = "locationCb";
            locationCb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            locationCb.Size = new Size(214, 20);
            locationCb.TabIndex = 12;
            // 
            // Exports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(locationCb);
            Controls.Add(next);
            Controls.Add(back);
            Controls.Add(confirm);
            Controls.Add(dateToLabel);
            Controls.Add(dateFromLabel);
            Controls.Add(dateToEdit);
            Controls.Add(dateFromEdit);
            Controls.Add(locationLabel);
            Controls.Add(gridControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Exports";
            Text = "Exports";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFromEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToEdit.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateToEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationCb.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ExportName;
        private DevExpress.XtraGrid.Columns.GridColumn Date;
        private DevExpress.XtraGrid.Columns.GridColumn Time;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn Location;
        private DevExpress.XtraEditors.LabelControl locationLabel;
        private DevExpress.XtraEditors.ComboBoxEdit locationCb;
        private DevExpress.XtraEditors.DateEdit dateFromEdit;
        private DevExpress.XtraEditors.DateEdit dateToEdit;
        private DevExpress.XtraEditors.LabelControl dateFromLabel;
        private DevExpress.XtraEditors.LabelControl dateToLabel;
        private DevExpress.XtraEditors.SimpleButton confirm;
        private DevExpress.XtraEditors.SimpleButton back;
        private DevExpress.XtraEditors.SimpleButton next;
    }
}
