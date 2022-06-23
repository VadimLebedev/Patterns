using Bridge.Abstractions;
using Bridge.Entities;

namespace Bridge.WithoutBridge.Clients
{
    internal class ClientMiddleWidget : WidgetBase
    {
        public void Run(Client client)
        {
            var data = PrepareClientData(client);

            ViewData(data);
        }

        private string PrepareClientData(Client client)
        {
            return $"This is middle widget data. {client}";
        }
    }
}
