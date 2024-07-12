using ExportReport.DAL;
using ExportReport.Models;
using ExportReport.Utils;
using System.ComponentModel;

namespace ExportReport
{
    public partial class Exports : Form
    {
        private ExportsDbContext db;
        private int currentPageNumber = 0;
        private const int pageSize = 100;
        private const string dateFormat = "dd/MM/yyyy";
        private BindingList<ExportHistory> exportHistories = new BindingList<ExportHistory>();

        public Exports()
        {
            db = new ExportsDbContext();
            InitializeComponent();
            var locations = db.ExportHistory.Select(x => x.Location).Distinct().ToList();
            locationCb.Properties.Items.AddRange(locations);

            gridControl1.BindingContext = new BindingContext();
            gridControl1.DataSource = exportHistories;
            back.Enabled = false;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (dateToEdit.DateTime < dateFromEdit.DateTime)
            {
                MessageBox.Show("Data \"od\" nie może być późniejsza niż data \"do\".");
                return;
            }

            currentPageNumber = 0;
            FilterExportHistories();
        }

        private void next_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            currentPageNumber++;
            FilterExportHistories();
        }

        private void back_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            if (currentPageNumber == 1)
                back.Enabled = false;

            currentPageNumber--;
            FilterExportHistories();
        }

        private void FilterExportHistories()
        {
            var query = db.ExportHistory.AsQueryable();

            if (!string.IsNullOrEmpty(locationCb.SelectedItem.ToString()))
                query = query.Where(x => x.Location == locationCb.Text);

            if (!string.IsNullOrEmpty(dateFromEdit.Text))
                query = query.Where(x => x.Timestamp >= dateFromEdit.DateTime);

            if (!string.IsNullOrEmpty(dateToEdit.Text))
                query = query.Where(x => x.Timestamp <= dateFromEdit.DateTime.AddDays(1).AddMilliseconds(-1000));

            var exportHistoriesResult = query.Skip(currentPageNumber * pageSize).Take(pageSize).ToList();

            if (exportHistoriesResult.Any())
            {
                exportHistories.Clear();
                exportHistories.AddRange(exportHistoriesResult);
            }
            else
            {
                next.Enabled = false;
                currentPageNumber--;
            }
        }
    }
}
