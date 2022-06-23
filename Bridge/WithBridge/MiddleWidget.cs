using Bridge.Abstractions;

namespace Bridge.WithBridge
{
    internal class MiddleWidget : WidgetBase
    {
        public void Run(IWidgetData widgetData)
        {
            var data = PrepareCategoryData(widgetData);

            ViewData(data);
        }

        private string PrepareCategoryData(IWidgetData data)
        {
            return $"This is middle widget data. Id: {data.GetId()}, Title: {data.GetTitle()}";
        }
    }
}
