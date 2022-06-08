using Strategy.Reports.Common.Interfaces;

namespace Strategy.Reports.Common
{
    internal abstract class ReportDataBase : IReportData
    {
        public string Title { get; private set; }

        public string Body { get; private set; }

        public ReportDataBase(string title, string body)
        {
            Title = title;
            Body = body;
        }
    }
}
