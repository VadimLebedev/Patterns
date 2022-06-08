using Strategy.Reports.Common.Interfaces;
using Strategy.Reports.Email;
using Strategy.Reports.Text;

namespace Strategy.Reports.Common
{
    internal class ConverterFactory
    {
        internal static IReportDataConverter GetConverter(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.Email:
                    return new EmailConverter();
                case ReportType.Text:
                    return new TextConverter();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}