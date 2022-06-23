using Bridge.Abstractions;

namespace Bridge.WithBridge
{
    internal class BigWidget : WidgetBase
    {
        public void Run(IWidgetData widgetData)
        {
            var data = PrepareCategoryData(widgetData);

            ViewData(data);
        }

        private string PrepareCategoryData(IWidgetData data)
        {
            return $"This is big widget data. Id: {data.GetId()}, Title: {data.GetTitle()}, Description: {data.GetDescription()}";
        }
    }
}
