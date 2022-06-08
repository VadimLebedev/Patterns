using Strategy.Reports.Common;

namespace Strategy.Reports.Email
{
    internal class EmailReportData : ReportDataBase
    {
        public EmailReportData(string title, string body) : base(title, body)
        {
        }

        public override string ToString()
        {
            return ConverterFactory.GetConverter(ReportType.Email).ConvertDataToString(this);
        }
    }
}
