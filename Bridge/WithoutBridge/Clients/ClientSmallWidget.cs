using Bridge.Abstractions;
using Bridge.Entities;

namespace Bridge.WithoutBridge.Clients
{
    internal class ClientSmallWidget : WidgetBase
    {
        public void Run(Client client)
        {
            var data = PrepareClientData(client);

            ViewData(data);
        }

        private string PrepareClientData(Client client)
        {
            return $"This is small widget data. {client}";
        }
    }
}
