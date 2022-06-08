using Strategy.Reports.Common.Interfaces;
using Strategy.Reports.Email;

namespace Strategy.Reports.Reporter
{
    internal class ReporterService
    {
        public void Report(IReportData reportData)
        {
            if (reportData.GetType() == typeof(EmailReportData))
                ReportToEmail(reportData);
            else if (reportData.GetType() == typeof(TextReportData))
                ReportToText(reportData);
            else
                throw new NotSupportedException();
        }

        private void ReportToText(IReportData reportData)
        {
            Console.WriteLine("Сохраняем отчет в текстовом файле....");
            Console.WriteLine(reportData.ToString());
        }

        private void ReportToEmail(IReportData reportData)
        {
            Console.WriteLine("Отправляем письмо по Email....");
            Console.WriteLine(reportData.ToString());
        }
    }
}
