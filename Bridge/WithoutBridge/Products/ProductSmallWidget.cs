using Bridge.Abstractions;
using Bridge.Entities;

namespace Bridge.WithoutBridge.Products
{
    internal class ProductSmallWidget : WidgetBase
    {
        public void Run(Product product)
        {
            var data = PrepareProductData(product);

            ViewData(data);
        }

        private string PrepareProductData(Product product)
        {
            return $"This is small widget data. {product}";
        }
    }
}
