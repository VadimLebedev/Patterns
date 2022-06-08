using Strategy.Reports.Common.Interfaces;

namespace Strategy.Reports.Common
{
    internal class DataHandler : IDataHandler
    {
        public T Handle<T>(string message) where T : ReportDataBase
        {
            var title = message[..11];
            var body = message[12..];

            var constrInfo = typeof(T).GetConstructor(new[] { typeof(string), typeof(string) });

            if (constrInfo == null)
                throw new NotSupportedException();

            T instance = (T)constrInfo.Invoke(new[] { title, body });

            return instance;

        }
    }
}
