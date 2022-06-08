using Strategy.Reports.Common.Interfaces;

namespace Strategy.Reports.Email
{
    internal class EmailConverter : IReportDataConverter
    {
        public string ConvertDataToString(IReportData reportData)
        {
            return $"Письмо {reportData.Title}. Сообщение: {reportData.Body}";
        }
    }
}
