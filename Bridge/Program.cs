using Bridge.Entities;
using Bridge.WithBridge;
using Bridge.WithoutBridge.Categories;
using Bridge.WithoutBridge.Clients;
using Bridge.WithoutBridge.Products;

var product = new Product()
{
    Id = 1,
    Name = "Apple",
    Price = 11.1m
};

var client = new Client()
{
    Id = 1,
    Name = "Bob",
    Age = 21
};

var category = new Category()
{
    Id = 1,
    Title = "Without bridge"
};


#region Without bridge
new ProductBigWidget().Run(product);
new ProductMiddleWidget().Run(product);
new ProductSmallWidget().Run(product);

new ClientBigWidget().Run(client);
new ClientMiddleWidget().Run(client);
new ClientSmallWidget().Run(client);

new CategoryBigWidget().Run(category);
new CategoryMiddleWidget().Run(category);
new CategorySmallWidget().Run(category);

#endregion

Console.WriteLine("--------------------------------------");

#region With bridge

var productWidgetData = new WidgetData<Product>(product)
.SetId(p => p.Id)
.SetTitle(p => p.Name)
.SetDescription(p => $"Product : {p.Name}, Price : {p.Price}");

var clientWidgetData = new WidgetData<Client>(client)
    .SetId(c => c.Id)
    .SetTitle(c => c.Name)
    .SetDescription(c => $"Client : {c.Name}, Age : {c.Age}");

var categoryWidgetData = new WidgetData<Category>(category)
    .SetId(c => c.Id)
    .SetTitle(c => c.Title)
    .SetDescription(c => $"Category : {c.Title}");

new BigWidget().Run(productWidgetData);
new MiddleWidget().Run(productWidgetData);
new SmallWidget().Run(productWidgetData);

new BigWidget().Run(clientWidgetData);
new MiddleWidget().Run(clientWidgetData);
new SmallWidget().Run(clientWidgetData);

new BigWidget().Run(categoryWidgetData);
new MiddleWidget().Run(categoryWidgetData);
new SmallWidget().Run(categoryWidgetData);

#endregion
