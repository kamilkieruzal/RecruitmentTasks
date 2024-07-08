using Bogus;
using ExportReport.Models;

namespace ExportReport.DAL
{
    public class FakeDataHelper
    {
        public IList<ExportHistory> GetFakeExports()
        {
            var exportHistoryId = 1;
            var fakeDataProvider = new Faker<ExportHistory>()
                .RuleFor(e => e.Id, f => exportHistoryId++)
                .RuleFor(e => e.Name, f => new Faker().Lorem.Sentence(1))
                .RuleFor(e => e.Timestamp, f => new Faker().Date.Recent())
                .RuleFor(e => e.UserName, (f, e) => f.Name.FirstName())
                .RuleFor(e => e.Location, (f, e) => f.Address.City());

            var result = fakeDataProvider.Generate(1000);

            return result;
        }
    }
}
