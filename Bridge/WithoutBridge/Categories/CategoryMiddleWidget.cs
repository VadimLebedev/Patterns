using Bridge.Abstractions;
using Bridge.Entities;

namespace Bridge.WithoutBridge.Categories
{
    internal class CategoryMiddleWidget : WidgetBase
    {
        public void Run(Category category)
        {
            var data = PrepareCategoryData(category);

            ViewData(data);
        }

        private string PrepareCategoryData(Category category)
        {
            return $"This is middle widget data. {category}";
        }
    }
}
