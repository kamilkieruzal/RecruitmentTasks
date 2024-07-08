namespace ExportReport.Models
{
    public class Export
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
    }
}
