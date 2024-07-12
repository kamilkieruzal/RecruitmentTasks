namespace ExportReport.Models
{
    public class ExportHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string Date => Timestamp.Date.ToString("dd/MM/yyyy");
        public string Time => Timestamp.TimeOfDay.ToString(@"hh\:mm");
    }
}
