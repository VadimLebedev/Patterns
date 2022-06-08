using Strategy.Reports.Common;

internal class TextReportData : ReportDataBase
{
    public TextReportData(string title, string body) : base(title, body)
    {
    }

    public override string ToString()
    {
        return ConverterFactory.GetConverter(ReportType.Text).ConvertDataToString(this);
    }
}