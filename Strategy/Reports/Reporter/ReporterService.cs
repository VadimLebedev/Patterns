using Strategy.Reports.Common.Interfaces;
using Strategy.Reports.Email;
using System.Collections.ObjectModel;

namespace Strategy.Reports.Reporter
{
    internal class ReporterService
    {
        private readonly ReadOnlyDictionary<Type, Action<IReportData>> reporters;

        public ReporterService()
        {
            reporters = new(new Dictionary<Type, Action<IReportData>>
                {
                    { typeof(EmailReportData), ReportToEmail},
                    { typeof(TextReportData), ReportToText}
                });
        }

        public void Report(IReportData reportData)
        {
            var method = reporters.GetValueOrDefault(reportData.GetType());

            if (method == null)
                throw new NotSupportedException();

            method.Invoke(reportData);
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
