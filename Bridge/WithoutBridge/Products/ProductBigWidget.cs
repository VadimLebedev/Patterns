using Bridge.Abstractions;
using Bridge.Entities;

namespace Bridge.WithoutBridge.Products
{
    internal class ProductBigWidget : WidgetBase
    {
        public void Run(Product product)
        {
            var data = PrepareProductData(product);

            ViewData(data);
        }

        private string PrepareProductData(Product product)
        {
            return $"This is big widget data. {product}";
        }
    }
}
