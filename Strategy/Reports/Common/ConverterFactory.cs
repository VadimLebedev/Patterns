using Strategy.Reports.Common.Interfaces;
using Strategy.Reports.Email;
using Strategy.Reports.Text;
using System.Collections.ObjectModel;

namespace Strategy.Reports.Common
{
    internal class ConverterFactory
    {
        private static readonly ReadOnlyDictionary<ReportType, IReportDataConverter> converters = new (
                new Dictionary<ReportType, IReportDataConverter> 
                { 
                    { ReportType.Email, new EmailConverter()},
                    { ReportType.Text, new TextConverter()}
                }
            );

        internal static IReportDataConverter GetConverter(ReportType reportType)
        {
            var converter = converters.GetValueOrDefault(reportType);

            if (converter == null)
                throw new NotSupportedException();

            return converter;
        }
    }
}