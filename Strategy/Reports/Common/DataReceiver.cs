using System.Text;

namespace Strategy.Reports.Common
{
    internal class DataReceiver
    {
        public string ReceiveData(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }
    }
}
