namespace Bridge.WithBridge
{
    internal class WidgetData<T> : IWidgetData where T : class
    {
        private readonly T instance;
        private int _id;
        private string _title;
        private string _description;

        public WidgetData(T instance) => this.instance = instance;

        public WidgetData<T> SetId(Func<T, int> func)
        {
            _id = func(instance);

            return this;
        }

        public WidgetData<T> SetTitle(Func<T, string> func)
        {
            _title = func(instance);

            return this;
        }

        public WidgetData<T> SetDescription(Func<T, string> func)
        {
            _description = func(instance);

            return this;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetDescription()
        {
            return _description;
        }
    }
}
