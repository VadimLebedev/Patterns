using Bridge.Abstractions;

namespace Bridge.WithBridge
{
    internal class SmallWidget : WidgetBase
    {
        public void Run(IWidgetData widgetData)
        {
            var data = PrepareCategoryData(widgetData);

            ViewData(data);
        }

        private string PrepareCategoryData(IWidgetData data)
        {
            return $"This is small widget data. Id: {data.GetId()}";
        }
    }
}
