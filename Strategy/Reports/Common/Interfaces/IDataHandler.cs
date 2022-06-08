namespace Strategy.Reports.Common.Interfaces
{
    internal interface IDataHandler
    {
        T Handle<T>(string message) where T : ReportDataBase;
    }
}