namespace Strategy.Reports.Common.Interfaces
{
    internal interface IReportDataConverter
    {
        string ConvertDataToString(IReportData reportData);
    }
}