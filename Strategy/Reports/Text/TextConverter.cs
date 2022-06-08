using Strategy.Reports.Common.Interfaces;

namespace Strategy.Reports.Text
{
    internal class TextConverter : IReportDataConverter
    {
        public string ConvertDataToString(IReportData reportData)
        {
            return $"Текстовый отчет: {reportData.Title}. {reportData.Body}";
        }
    }
}
